using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System;
//using Microsoft.VisualBasic;
namespace CarAccelerometer
{
    public partial class Setup : Form
    {

        private Main myOwner;

        private ArrayList _checkPoints;

        private double _drag;

        private double _gallonsOfGas;

        private double _frontalArea;

        private double _weightOfCar;

        private double _weightOfPassengers;

        private double _stopTime;

        private double _totalWeight;

        public Setup()
        {
            InitializeComponent();
            //  rx8 + me + gas for the default starting curb weight:
            this.txtWeightOfCar.Text = "3229.0";
        }

        public Setup(Main parentFormRef)
            : this()
        {
            myOwner = parentFormRef;
            myOwner.SetAllLabelsBackColorToTransparent(((System.Windows.Forms.Control.ControlCollection)(this.Controls)));
            myOwner.IsSetupComplete = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            myOwner.PaintBackround(Color.OrangeRed, Color.Black, e);
            e.Dispose();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if ((myOwner.KinematicsCalculator == null))
            {
                myOwner.KinematicsCalculator = new CarCalculator(_totalWeight);
            }
            else
            {
                myOwner.KinematicsCalculator.Weight = _totalWeight;
            }
            if (!(_checkPoints == null))
            {
                myOwner.KinematicsCalculator.Checkpoints = _checkPoints;
            }
            myOwner.KinematicsCalculator.DragCoefficient = _drag;
            myOwner.KinematicsCalculator.FrontalArea = _frontalArea;
            myOwner.OutputGridResultsToFile = chkOutputResultsToFile.Checked;
            myOwner.OutputTraceToFile = chkOutputTraceToCSV.Checked;
            myOwner.StopTime = _stopTime;
            this.DialogResult = DialogResult.OK;
            btnGO.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _weightOfPassengers = (_weightOfPassengers + double.Parse(this.txtWeightOfPass.Text));
            this.txtWeightOfPass.Text = "0";
            _gallonsOfGas = (_gallonsOfGas + double.Parse(this.txtGallonsOfGas.Text));
            this.txtGallonsOfGas.Text = "0";
            _weightOfCar = double.Parse(this.txtWeightOfCar.Text);
            _totalWeight = (_weightOfCar
                        + (_weightOfPassengers
                        + (_gallonsOfGas * CarCalculator.POUNDS_PER_GALLON_OF_GAS)));
            if ((_totalWeight <= CarCalculator.POUNDS_PER_KG))
            {
                MessageBox.Show("You must enter valid weight values and then click 'go' for the accelerometer to run.");
                myOwner.IsSetupComplete = false;
            }
            else
            {
                _gallonsOfGas = 0;
                _weightOfPassengers = 0;
                this.txtWeightOfCar.Text = _totalWeight.ToString();
                //  a source of dynamic acceleration is when the accelerometer picks up vibrations 
                //  users testing cars with high levels of NVH will most likely need to change this
                double dynamicAccelerationThreshold = 0;
                if (((txtTriggerValue.Text.Trim().Length == 0)
                            || (!double.TryParse(txtTriggerValue.Text.Trim(),out dynamicAccelerationThreshold)
                            || (dynamicAccelerationThreshold <= 0))))
                {
                    this.btnGO.Enabled = false;
                    myOwner.IsSetupComplete = false;
                    MessageBox.Show("You must enter a valid number in the acceleration trigger input box. The default value is '.02'");
                    txtTriggerValue.Select();
                    return;
                }
                else
                {
                    myOwner.AccelerationRequiredToStartTiming = dynamicAccelerationThreshold;
                }
                if (((txtFrontalArea.Text.Trim().Length == 0)
                            || (!double.TryParse(txtFrontalArea.Text.Trim(), out _frontalArea)
                            || (_frontalArea <= 0))))
                {
                    this.btnGO.Enabled = false;
                    myOwner.IsSetupComplete = false;
                    MessageBox.Show("You must enter a valid number in the vehicle frontal area input box. The default value is '2.4276'");
                    txtFrontalArea.Select();
                    return;
                }
                if (((txtDrag.Text.Trim().Length == 0)
                            || (!double.TryParse(txtDrag.Text.Trim(), out _drag)
                            || (_drag <= 0))))
                {
                    this.btnGO.Enabled = false;
                    myOwner.IsSetupComplete = false;
                    MessageBox.Show("You must enter a valid number in the vehicle drag coefficient input box. The default value is '.30'");
                    txtDrag.Select();
                    return;
                }
                if (((txtStopTime.Text.Trim().Length == 0)
                            || (!double.TryParse(txtStopTime.Text.Trim(),out _stopTime)
                            || (_stopTime < 0))))
                {
                    this.btnGO.Enabled = false;
                    myOwner.IsSetupComplete = false;
                    MessageBox.Show("You must enter a valid number in the stop time input box. The default value is '0'(sec.) Entering '0'" +
                        " will cause the accelerometer to run until it is manually stopped.");
                    txtStopTime.Text = "0";
                    _stopTime = 0;
                    txtStopTime.Select();
                    return;
                }
                this.btnGO.Enabled = true;
                myOwner.IsSetupComplete = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult =DialogResult.Abort;
            this.Close();
            // caller needs to take care of terminating the app 
        }

        private void btnAddCheckpoint_Click(object sender, EventArgs e)
        {
            double checkPoint = 0;
            if (((txtCheckpoint.Text.Trim().Length != 0)
                        && (double.TryParse(txtCheckpoint.Text.Trim(),out  checkPoint)
                        && (checkPoint > 0))))
            {
                if ((_checkPoints == null))
                {
                    _checkPoints = new ArrayList();
                }
                _checkPoints.Add(checkPoint);
                _checkPoints.Sort();
                lstCheckpoints.DataSource = null;
                lstCheckpoints.DataSource = _checkPoints;
            }
            txtCheckpoint.Text = String.Empty;
        }

        private void txtCheckpoint_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar == ((char)(Keys.Enter))))
            {
                btnAddCheckpoint_Click(sender, null);
            }
        }

        private void Setup_Load(object sender, System.EventArgs e)
        {
            if ((myOwner.IsSetupComplete == true))
            {
                btnGO.Enabled = true;
                btnAdd.Text = "apply";
            }
        }

    }
}