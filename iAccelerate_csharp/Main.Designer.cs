namespace CarAccelerometer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.velocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longLatHelp = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.colTimeDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSetup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeTimerStatus = new System.Windows.Forms.Button();
            this.gridCheckpoints = new System.Windows.Forms.DataGridView();
            this.colSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.lblWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckpoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // HP
            // 
            this.HP.HeaderText = "Horsepower";
            this.HP.Name = "HP";
            this.HP.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // velocity
            // 
            this.velocity.HeaderText = "MPH";
            this.velocity.Name = "velocity";
            this.velocity.ReadOnly = true;
            // 
            // gs
            // 
            this.gs.HeaderText = "gs";
            this.gs.Name = "gs";
            this.gs.ReadOnly = true;
            // 
            // distance
            // 
            this.distance.HeaderText = "Distance";
            this.distance.Name = "distance";
            this.distance.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(539, 151);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "&exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // colTimeDiff
            // 
            this.colTimeDiff.HeaderText = "difference (s)";
            this.colTimeDiff.Name = "colTimeDiff";
            // 
            // btnSetup
            // 
            this.btnSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSetup.Location = new System.Drawing.Point(629, 151);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 41;
            this.btnSetup.Text = "s&etup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(149, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Checkpoints:";
            // 
            // colTime
            // 
            this.colTime.HeaderText = "time (s)";
            this.colTime.Name = "colTime";
            // 
            // btnChangeTimerStatus
            // 
            this.btnChangeTimerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangeTimerStatus.Location = new System.Drawing.Point(629, 8);
            this.btnChangeTimerStatus.Name = "btnChangeTimerStatus";
            this.btnChangeTimerStatus.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTimerStatus.TabIndex = 38;
            this.btnChangeTimerStatus.Text = "&start";
            this.btnChangeTimerStatus.UseVisualStyleBackColor = true;
            this.btnChangeTimerStatus.Click += new System.EventHandler(this.btnChangeTimerStatus_Click);
            // 
            // gridCheckpoints
            // 
            this.gridCheckpoints.AllowUserToAddRows = false;
            this.gridCheckpoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCheckpoints.BackgroundColor = System.Drawing.Color.Black;
            this.gridCheckpoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckpoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSpeed,
            this.colTime,
            this.colTimeDiff});
            this.gridCheckpoints.Location = new System.Drawing.Point(252, 37);
            this.gridCheckpoints.Name = "gridCheckpoints";
            this.gridCheckpoints.Size = new System.Drawing.Size(258, 137);
            this.gridCheckpoints.TabIndex = 37;
            // 
            // colSpeed
            // 
            this.colSpeed.HeaderText = "MPH";
            this.colSpeed.Name = "colSpeed";
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResults.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.HP,
            this.velocity,
            this.distance,
            this.gs});
            this.gridResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridResults.Location = new System.Drawing.Point(11, 197);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.Size = new System.Drawing.Size(697, 228);
            this.gridResults.TabIndex = 36;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWeight.Location = new System.Drawing.Point(27, 8);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(135, 24);
            this.lblWeight.TabIndex = 39;
            this.lblWeight.Text = "Not Initialized";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(718, 432);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeTimerStatus);
            this.Controls.Add(this.gridCheckpoints);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.lblWeight);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(734, 468);
            this.MinimumSize = new System.Drawing.Size(734, 468);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iAccelerate";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckpoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridViewTextBoxColumn HP;
        internal System.Windows.Forms.DataGridViewTextBoxColumn time;
        internal System.Windows.Forms.DataGridViewTextBoxColumn velocity;
        internal System.Windows.Forms.DataGridViewTextBoxColumn gs;
        internal System.Windows.Forms.DataGridViewTextBoxColumn distance;
        private System.Windows.Forms.ToolTip longLatHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeDiff;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.Button btnChangeTimerStatus;
        private System.Windows.Forms.DataGridView gridCheckpoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeed;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.Label lblWeight;

    }
}

