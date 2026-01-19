namespace CarAccelerometer
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStopTime = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFrontalArea = new System.Windows.Forms.TextBox();
            this.txtDrag = new System.Windows.Forms.TextBox();
            this.chkOutputTraceToCSV = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.chkOutputResultsToFile = new System.Windows.Forms.CheckBox();
            this.txtCheckpoint = new System.Windows.Forms.TextBox();
            this.btnAddCheckpoint = new System.Windows.Forms.Button();
            this.lstCheckpoints = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTriggerValue = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtGallonsOfGas = new System.Windows.Forms.TextBox();
            this.txtWeightOfPass = new System.Windows.Forms.TextBox();
            this.txtWeightOfCar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStopTime
            // 
            this.txtStopTime.Location = new System.Drawing.Point(370, 40);
            this.txtStopTime.Name = "txtStopTime";
            this.txtStopTime.Size = new System.Drawing.Size(45, 20);
            this.txtStopTime.TabIndex = 47;
            this.txtStopTime.Text = "0";
            this.txtStopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label3.Location = new System.Drawing.Point(258, 44);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(106, 13);
            this.Label3.TabIndex = 63;
            this.Label3.Text = "Stop timing after (s):  ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(14, 111);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 62;
            this.Label1.Text = "Drag coefficient: ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(14, 135);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 13);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Frontal area of car (m^2): ";
            // 
            // txtFrontalArea
            // 
            this.txtFrontalArea.Location = new System.Drawing.Point(147, 131);
            this.txtFrontalArea.Name = "txtFrontalArea";
            this.txtFrontalArea.Size = new System.Drawing.Size(100, 20);
            this.txtFrontalArea.TabIndex = 46;
            this.txtFrontalArea.Text = "2.4276";
            // 
            // txtDrag
            // 
            this.txtDrag.Location = new System.Drawing.Point(147, 107);
            this.txtDrag.Name = "txtDrag";
            this.txtDrag.Size = new System.Drawing.Size(100, 20);
            this.txtDrag.TabIndex = 45;
            this.txtDrag.Text = ".30";
            // 
            // chkOutputTraceToCSV
            // 
            this.chkOutputTraceToCSV.AutoSize = true;
            this.chkOutputTraceToCSV.BackColor = System.Drawing.Color.Black;
            this.chkOutputTraceToCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkOutputTraceToCSV.Location = new System.Drawing.Point(277, 204);
            this.chkOutputTraceToCSV.Name = "chkOutputTraceToCSV";
            this.chkOutputTraceToCSV.Size = new System.Drawing.Size(150, 17);
            this.chkOutputTraceToCSV.TabIndex = 60;
            this.chkOutputTraceToCSV.Text = "create trace (spreadsheet)";
            this.chkOutputTraceToCSV.UseVisualStyleBackColor = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label7.Location = new System.Drawing.Point(14, 20);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(74, 13);
            this.Label7.TabIndex = 59;
            this.Label7.Text = "Weight of car:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label6.Location = new System.Drawing.Point(14, 44);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(113, 13);
            this.Label6.TabIndex = 58;
            this.Label6.Text = "Weight of passengers:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label5.Location = new System.Drawing.Point(14, 71);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 13);
            this.Label5.TabIndex = 57;
            this.Label5.Text = "Gallons of gas:";
            // 
            // chkOutputResultsToFile
            // 
            this.chkOutputResultsToFile.AutoSize = true;
            this.chkOutputResultsToFile.BackColor = System.Drawing.Color.Black;
            this.chkOutputResultsToFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkOutputResultsToFile.Location = new System.Drawing.Point(277, 186);
            this.chkOutputResultsToFile.Name = "chkOutputResultsToFile";
            this.chkOutputResultsToFile.Size = new System.Drawing.Size(109, 17);
            this.chkOutputResultsToFile.TabIndex = 56;
            this.chkOutputResultsToFile.Text = "write results to file";
            this.chkOutputResultsToFile.UseVisualStyleBackColor = false;
            // 
            // txtCheckpoint
            // 
            this.txtCheckpoint.Location = new System.Drawing.Point(13, 165);
            this.txtCheckpoint.Name = "txtCheckpoint";
            this.txtCheckpoint.Size = new System.Drawing.Size(129, 20);
            this.txtCheckpoint.TabIndex = 49;
            // 
            // btnAddCheckpoint
            // 
            this.btnAddCheckpoint.Location = new System.Drawing.Point(13, 191);
            this.btnAddCheckpoint.Name = "btnAddCheckpoint";
            this.btnAddCheckpoint.Size = new System.Drawing.Size(128, 23);
            this.btnAddCheckpoint.TabIndex = 50;
            this.btnAddCheckpoint.Text = "add MPH &checkpoint";
            this.btnAddCheckpoint.UseVisualStyleBackColor = true;
            this.btnAddCheckpoint.Click += new System.EventHandler(this.btnAddCheckpoint_Click);
            // 
            // lstCheckpoints
            // 
            this.lstCheckpoints.FormattingEnabled = true;
            this.lstCheckpoints.Location = new System.Drawing.Point(147, 165);
            this.lstCheckpoints.Name = "lstCheckpoints";
            this.lstCheckpoints.Size = new System.Drawing.Size(100, 56);
            this.lstCheckpoints.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(144, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Acceleration (in g) needed to trigger start:";
            // 
            // txtTriggerValue
            // 
            this.txtTriggerValue.Location = new System.Drawing.Point(353, 234);
            this.txtTriggerValue.Name = "txtTriggerValue";
            this.txtTriggerValue.Size = new System.Drawing.Size(75, 20);
            this.txtTriggerValue.TabIndex = 48;
            this.txtTriggerValue.Text = ".02";
            this.txtTriggerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGO
            // 
            this.btnGO.Enabled = false;
            this.btnGO.Location = new System.Drawing.Point(352, 14);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 52;
            this.btnGO.Text = "&go";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "&add weight";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(13, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "&exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtGallonsOfGas
            // 
            this.txtGallonsOfGas.Location = new System.Drawing.Point(147, 67);
            this.txtGallonsOfGas.Name = "txtGallonsOfGas";
            this.txtGallonsOfGas.Size = new System.Drawing.Size(100, 20);
            this.txtGallonsOfGas.TabIndex = 44;
            this.txtGallonsOfGas.Text = "7";
            // 
            // txtWeightOfPass
            // 
            this.txtWeightOfPass.Location = new System.Drawing.Point(147, 40);
            this.txtWeightOfPass.Name = "txtWeightOfPass";
            this.txtWeightOfPass.Size = new System.Drawing.Size(100, 20);
            this.txtWeightOfPass.TabIndex = 43;
            this.txtWeightOfPass.Text = "200";
            // 
            // txtWeightOfCar
            // 
            this.txtWeightOfCar.Location = new System.Drawing.Point(147, 16);
            this.txtWeightOfCar.Name = "txtWeightOfCar";
            this.txtWeightOfCar.Size = new System.Drawing.Size(100, 20);
            this.txtWeightOfCar.TabIndex = 42;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.ControlBox = false;
            this.Controls.Add(this.txtStopTime);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtFrontalArea);
            this.Controls.Add(this.txtDrag);
            this.Controls.Add(this.chkOutputTraceToCSV);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.chkOutputResultsToFile);
            this.Controls.Add(this.txtCheckpoint);
            this.Controls.Add(this.btnAddCheckpoint);
            this.Controls.Add(this.lstCheckpoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTriggerValue);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGallonsOfGas);
            this.Controls.Add(this.txtWeightOfPass);
            this.Controls.Add(this.txtWeightOfCar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 306);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 306);
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gross Vehicle Weight Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStopTime;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txtFrontalArea;
        private System.Windows.Forms.TextBox txtDrag;
        internal System.Windows.Forms.CheckBox chkOutputTraceToCSV;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.CheckBox chkOutputResultsToFile;
        private System.Windows.Forms.TextBox txtCheckpoint;
        private System.Windows.Forms.Button btnAddCheckpoint;
        private System.Windows.Forms.ListBox lstCheckpoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTriggerValue;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtGallonsOfGas;
        private System.Windows.Forms.TextBox txtWeightOfPass;
        private System.Windows.Forms.TextBox txtWeightOfCar;

    }
}