namespace ExamOne
{
    partial class Form1
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
            this.btnFiveHours = new System.Windows.Forms.Button();
            this.btnEightHours = new System.Windows.Forms.Button();
            this.btnTwelveHours = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.tbVehicleSpeed = new System.Windows.Forms.TextBox();
            this.lblVehicleSpeed = new System.Windows.Forms.Label();
            this.lblDisplayOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFiveHours
            // 
            this.btnFiveHours.Location = new System.Drawing.Point(12, 191);
            this.btnFiveHours.Name = "btnFiveHours";
            this.btnFiveHours.Size = new System.Drawing.Size(103, 41);
            this.btnFiveHours.TabIndex = 2;
            this.btnFiveHours.Text = "Distance (5 Hours)";
            this.btnFiveHours.UseVisualStyleBackColor = true;
            this.btnFiveHours.Click += new System.EventHandler(this.btnFiveHours_Click);
            // 
            // btnEightHours
            // 
            this.btnEightHours.Location = new System.Drawing.Point(121, 191);
            this.btnEightHours.Name = "btnEightHours";
            this.btnEightHours.Size = new System.Drawing.Size(103, 41);
            this.btnEightHours.TabIndex = 3;
            this.btnEightHours.Text = "Distance (8 Hours)";
            this.btnEightHours.UseVisualStyleBackColor = true;
            this.btnEightHours.Click += new System.EventHandler(this.btnEightHours_Click);
            // 
            // btnTwelveHours
            // 
            this.btnTwelveHours.Location = new System.Drawing.Point(230, 191);
            this.btnTwelveHours.Name = "btnTwelveHours";
            this.btnTwelveHours.Size = new System.Drawing.Size(103, 41);
            this.btnTwelveHours.TabIndex = 4;
            this.btnTwelveHours.Text = "Distance (12 Hours)";
            this.btnTwelveHours.UseVisualStyleBackColor = true;
            this.btnTwelveHours.Click += new System.EventHandler(this.btnTwelveHours_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(371, 144);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(103, 41);
            this.btnClearFields.TabIndex = 5;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(371, 191);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(103, 41);
            this.btnExitProgram.TabIndex = 6;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // tbVehicleSpeed
            // 
            this.tbVehicleSpeed.Location = new System.Drawing.Point(175, 6);
            this.tbVehicleSpeed.Name = "tbVehicleSpeed";
            this.tbVehicleSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbVehicleSpeed.TabIndex = 1;
            // 
            // lblVehicleSpeed
            // 
            this.lblVehicleSpeed.AutoSize = true;
            this.lblVehicleSpeed.Location = new System.Drawing.Point(9, 9);
            this.lblVehicleSpeed.Name = "lblVehicleSpeed";
            this.lblVehicleSpeed.Size = new System.Drawing.Size(160, 13);
            this.lblVehicleSpeed.TabIndex = 6;
            this.lblVehicleSpeed.Text = "Please Enter the Vehicle Speed:";
            // 
            // lblDisplayOutput
            // 
            this.lblDisplayOutput.AutoSize = true;
            this.lblDisplayOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayOutput.Location = new System.Drawing.Point(5, 82);
            this.lblDisplayOutput.Name = "lblDisplayOutput";
            this.lblDisplayOutput.Size = new System.Drawing.Size(0, 19);
            this.lblDisplayOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 244);
            this.Controls.Add(this.lblDisplayOutput);
            this.Controls.Add(this.lblVehicleSpeed);
            this.Controls.Add(this.tbVehicleSpeed);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnTwelveHours);
            this.Controls.Add(this.btnEightHours);
            this.Controls.Add(this.btnFiveHours);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiveHours;
        private System.Windows.Forms.Button btnEightHours;
        private System.Windows.Forms.Button btnTwelveHours;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.TextBox tbVehicleSpeed;
        private System.Windows.Forms.Label lblVehicleSpeed;
        private System.Windows.Forms.Label lblDisplayOutput;
    }
}

