using Phidgets.Events;
using Phidgets;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace CarAccelerometer
{
   public partial class Main : Form
    {
        private TimeSpan _currentTime;

        private StreamWriter _gridDataFileWriter;

        private TimeSpan _previousTime;

        private CarCalculator _statCalculator;

        private Setup _setupForm;

        private Stopwatch _stopWatch;

        private StreamWriter _traceDataFileWriter;

        private Phidgets.Accelerometer _vehicleTimer;

        private double _accelerationStartThreshold = 0.02;//  default this (can be changed in setup)
                
        private double _currentAcc;

        private string _currentAcceleration;

        private string _currentSpeed;

        private string _distanceTraveled;

        private string _horsepower;

        private bool _isNewRun = true;

        private bool _isSetup = false;

        private double _lastScreenUpdateInSeconds;

        private double _firstAccel;

        private bool _reverseAccelerationFlag = false;

        private double _stopTime;

        private string _totalTime;

        private bool _vehicleStartedMoving = false;

        private bool _writeGridResultsToFile = false;

        private bool _writeTraceOutputToFile = false;

        public Main()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetAllLabelsBackColorToTransparent(((System.Windows.Forms.Control.ControlCollection)(this.Controls)));
        }

        public CarCalculator KinematicsCalculator
        {
            get
            {
                return _statCalculator;
            }
            set
            {
                _statCalculator = value;
            }
        }

        public bool IsSetupComplete
        {
            get
            {
                return _isSetup;
            }
            set
            {
                _isSetup = value;
            }
        }

        public double AccelerationRequiredToStartTiming
        {
            get
            {
                return _accelerationStartThreshold;
            }
            set
            {
                _accelerationStartThreshold = value;
            }
        }

        public bool OutputGridResultsToFile
        {
            get
            {
                return _writeGridResultsToFile;
            }
            set
            {
                _writeGridResultsToFile = value;
            }
        }

        public bool OutputTraceToFile
        {
            get
            {
                return _writeTraceOutputToFile;
            }
            set
            {
                _writeTraceOutputToFile = value;
            }
        }

        public double StopTime
        {
            get
            {
                return _stopTime;
            }
            set
            {
                _stopTime = value;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                _setupForm = new Setup(this);
                if (RunSetup())
                {
                    KinematicsCalculator.SpeedReachedCheckpoint += new CarCalculator.SpeedReachedCheckpointHandler(this.Calculator_SpeedReachedCheckpointEvent);
                    this.Text = "Please come to a complete stop (on a flat surface) and click 'start'.";
                    _vehicleTimer = new Phidgets.Accelerometer();
                    _stopWatch = new Stopwatch();
                    resetState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error occured during load. Details are: {0} The application will now terminate, as this is an invalid" +
                        " state.", ex.Message));
                Application.Exit();
            }
        }

        private void Calculator_SpeedReachedCheckpointEvent(double seconds, double speed)
        {
            double diff = 0;
            if ((gridCheckpoints.Rows.Count > 0))
            {
                diff = ((double)(gridCheckpoints[1, (gridCheckpoints.Rows.Count - 1)].Value));
            }
            gridCheckpoints.Rows.Add(speed, seconds, (seconds - diff));
            gridCheckpoints.FirstDisplayedScrollingRowIndex = (gridCheckpoints.Rows.Count - 1);
        }

        private void accel_AccelerationChange(object sender, AccelerationChangeEventArgs e)
        {
            try
            {
                //  _vehicleTimer.axes[1].Sensitivity = .005;
                double changeInAccel = 0;
                if (!_vehicleStartedMoving)
                {
                    if (_isNewRun)
                    {
                        _firstAccel = _vehicleTimer.axes[1].Acceleration;        // first read  
                        _isNewRun = false;
                    }
                    this.Text = string.Format("cur. long. accel: {0} g. - cur. lat. accel: {1} g. -- Waiting for launch.", _vehicleTimer.axes[1].Acceleration.ToString("F4"), _vehicleTimer.axes[0].Acceleration.ToString("F3"));
                }
                _currentAcc = _vehicleTimer.axes[1].Acceleration;
                changeInAccel = (_currentAcc - _firstAccel);// _firstAccel only gets set once
                
                if (((Math.Abs(changeInAccel) <= AccelerationRequiredToStartTiming)
                            && !_vehicleStartedMoving))
                {
                    return;
                }
                if (_reverseAccelerationFlag)
                {
                    // will be false until after 1st calculation
                    if ((changeInAccel <= 0))
                    {
                        // actually increasing here...
                        changeInAccel = Math.Abs(changeInAccel);
                    }
                    else
                    {
                        // actually decreasing here...
                        changeInAccel = (changeInAccel * -1);
                    }
                }
                if (!_vehicleStartedMoving)
                {
                    if ((changeInAccel < 0))
                    {
                        // we started to move backwards first time through
                        _reverseAccelerationFlag = true;
                        changeInAccel = Math.Abs(changeInAccel);
                    }
                    this.Text = "Accelerometer running. Click 'stop timing' to end timing.";
                    _vehicleStartedMoving = true;
                    _stopWatch.Start();
                }
                //  keep the following line as close to the SetKinematicsProperties method as possible
                _currentTime = _stopWatch.Elapsed;
                this.KinematicsCalculator.SetKinematicsProperties(changeInAccel, (_currentTime - _previousTime).TotalSeconds);
                _previousTime = _currentTime;
                _currentAcceleration = changeInAccel.ToString("F4");
                _currentSpeed = this.KinematicsCalculator.CurrentSpeed.ToString("F2");
                _distanceTraveled = this.KinematicsCalculator.DistanceTraveled.ToString("F4");
                _horsepower = this.KinematicsCalculator.Horsepower.ToString("F2");
                _totalTime = this.KinematicsCalculator.TotalTime.ToString("F3");
                if (((this.KinematicsCalculator.TotalTime - _lastScreenUpdateInSeconds)
                            >= 0.25))//  only need to update display every 1/4 second
                {
                    this.Text = string.Format("Current longitudinal (fow/rev) accel: {0} - Current latitudinal (cornering) accel: {1}", _currentAcceleration, _vehicleTimer.axes[0].Acceleration.ToString("F3"));
                    RefreshGridData();
                    _lastScreenUpdateInSeconds = this.KinematicsCalculator.TotalTime;
                }
                if ((this.OutputTraceToFile
                            && !(_traceDataFileWriter == null)))
                {
                    _traceDataFileWriter.WriteLine((_totalTime.ToString() + (","
                                    + (_horsepower + (","
                                    + (_currentSpeed + (","
                                    + (_distanceTraveled + (","
                                    + (_vehicleTimer.axes[0].Acceleration.ToString("F4") + ("," + _currentAcceleration)))))))))));
                }
                if (((this.StopTime > 0)
                            && (_previousTime.TotalSeconds >= this.StopTime)))
                {
                    //  we want to end at a stopping point that the user chose
                    string msg = ("Peak horsepower: "
                                + (this.KinematicsCalculator.PeakHorsepower.ToString("F4") + ("\r\n" + ("Average horsepower: " + this.KinematicsCalculator.AverageHorsepower.ToString("F4")))));
                    resetState();
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error occured. Details are: {0}", ex.Message));
                resetState();
            }
        }

        private void RefreshGridData()
        {
            try
            {
                if (((_currentSpeed.Trim()
                            + (_totalTime.Trim() + _distanceTraveled.Trim()))
                            != String.Empty))
                {
                    gridResults.Rows.Add(_totalTime, _horsepower, _currentSpeed, _distanceTraveled, _currentAcceleration);
                    gridResults.FirstDisplayedScrollingRowIndex = (gridResults.Rows.Count - 1);
                    gridResults.Invalidate();
                    if ((this.OutputGridResultsToFile
                                && !(_gridDataFileWriter == null)))
                    {
                        _gridDataFileWriter.WriteLine(("Time: "
                                        + (_totalTime + ('\t' + ("Current HP: "
                                        + (_horsepower + ('\t' + ("MPH: "
                                        + (_currentSpeed + ('\t' + ("Distance (miles): "
                                        + (_distanceTraveled + ('\t' + ("Current Accel (g): " + _currentAcceleration))))))))))))));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error occured. Details are: {0}", ex.Message));
                resetState();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintBackround(Color.OrangeRed, Color.Black, e);
            e.Dispose();
        }

        private void btnChangeTimerStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!_vehicleStartedMoving
                            && (btnChangeTimerStatus.Text == "&start")))
                {
                    // start the accelerometer
                    btnChangeTimerStatus.Text = "&stop";
                    gridCheckpoints.Rows.Clear();
                    gridResults.Rows.Clear();
                    if (OutputGridResultsToFile)
                    {
                        _gridDataFileWriter = new StreamWriter((Application.StartupPath + "\\accelerometerData.txt"), true);
                        _gridDataFileWriter.Write("This run was created on: ");
                        _gridDataFileWriter.WriteLine((DateTime.Now + ("\r\n" + "*********************************************")));
                    }
                    if (OutputTraceToFile)
                    {
                        _traceDataFileWriter = new StreamWriter((Application.StartupPath + "\\accelerometerTraceData.csv"), false);
                        _traceDataFileWriter.WriteLine("Time,Current HP,MPH,Distance (miles),Current lat. accel (g),Current long. accel (g)");
                    }
                    if (!(_vehicleTimer == null))
                    {
                        _vehicleTimer.open();
                        _vehicleTimer.AccelerationChange += new AccelerationChangeEventHandler(this.accel_AccelerationChange);
                    }
                }
                else
                {
                    string msg = ("Peak horsepower: "
                                + (this.KinematicsCalculator.PeakHorsepower.ToString("F4") + ("\r\n" + ("Average horsepower: " + this.KinematicsCalculator.AverageHorsepower.ToString("F4")))));
                    resetState();
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error occured. Details are: {0}", ex.Message));
                resetState();
            }
        }

        private void resetState()
        {
            if (!(_vehicleTimer == null))
            {
                _vehicleTimer.AccelerationChange -= accel_AccelerationChange;
            }
            if ((this.OutputGridResultsToFile
                        && !(_gridDataFileWriter == null)))
            {
                MessageBox.Show(("Output file has been successfully saved in the following location: \r\n" + 
                                 (Application.StartupPath + @"\accelerometerData.txt")), Application.ProductName, MessageBoxButtons.OK);
                _gridDataFileWriter.Flush();
                _gridDataFileWriter.Close();
                _gridDataFileWriter = null;
            }
            if ((this.OutputTraceToFile
                        && !(_traceDataFileWriter == null)))
            {
                MessageBox.Show(("CSV file has been successfully saved in the following location: \r\n" + 
                                (Application.StartupPath + @"\accelerometerTraceData.csv")), Application.ProductName, MessageBoxButtons.OK);
                _traceDataFileWriter.Flush();
                _traceDataFileWriter.Close();
                _traceDataFileWriter = null;
            }
            btnChangeTimerStatus.Text = "&start";
            _currentAcc = 0;
            _currentAcceleration = null;
            _currentSpeed = null;
            _currentTime = TimeSpan.Zero;
            _distanceTraveled = null;
            _firstAccel = 0;
            _horsepower = null;
            _isNewRun = true;
            _lastScreenUpdateInSeconds = 0;
            _previousTime = TimeSpan.Zero;
            _reverseAccelerationFlag = false;
            _stopWatch.Reset();
            _totalTime = null;
            _vehicleStartedMoving = false;
            this.KinematicsCalculator.reset();
            this.Text = "Please come to a complete stop (on a flat surface) and click 'start'.";
        }

        public void PaintBackround(Color leftColor, Color rightColor, PaintEventArgs e)
        {
            LinearGradientBrush linGradientBrush = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), leftColor, rightColor, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(linGradientBrush, new Rectangle(0, 0, this.Width, this.Height));
        }

        private void btnSetup_Click(object sender, System.EventArgs e)
        {
            RunSetup();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            resetState();
            Application.Exit();
        }

        private bool RunSetup()
        {
            try
            {
                DialogResult dResult = _setupForm.ShowDialog(this);
                while (((dResult != DialogResult.OK)
                            || !IsSetupComplete))
                {
                    if ((dResult == DialogResult.Abort))
                    {
                        this.Close();
                        Application.Exit();
                        return false;
                    }
                    MessageBox.Show("You must enter values and click 'go' in the setup window for the accelerometer to run. Please fix this error to continue.");
                    dResult = _setupForm.ShowDialog(this);
                }
                lblWeight.Text = ("Loaded vehicle weight: "
                            + (this.KinematicsCalculator.WeightInPounds.ToString() + " lbs"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
       public void SetAllLabelsBackColorToTransparent(System.Windows.Forms.Control.ControlCollection controlCollection)
       {
           if (!(controlCollection == null))
           {
               foreach (Control ctl in controlCollection)
               {
                   if ((!(ctl == null)
                               && (ctl.Controls.Count > 0)))
                   {
                       SetAllLabelsBackColorToTransparent(((System.Windows.Forms.Control.ControlCollection)(ctl.Controls)));
                   }
                   if (ctl is Label || ctl is CheckBox)
                   {
                       ctl.BackColor = Color.Transparent;
                       ctl.ForeColor = Color.Black;
                   }
               }
           }
       }


    }

}

