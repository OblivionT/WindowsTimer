namespace WindowsTimer
{
    partial class Timer
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
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnSpecific = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutes.Location = new System.Drawing.Point(139, 59);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(61, 21);
            this.cmbMinutes.TabIndex = 25;
            // 
            // cmbHours
            // 
            this.cmbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHours.Location = new System.Drawing.Point(58, 60);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(61, 21);
            this.cmbHours.TabIndex = 24;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(4, 4);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(113, 23);
            this.btnTime.TabIndex = 23;
            this.btnTime.Text = "Select Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnSpecific
            // 
            this.btnSpecific.Location = new System.Drawing.Point(149, 4);
            this.btnSpecific.Name = "btnSpecific";
            this.btnSpecific.Size = new System.Drawing.Size(101, 23);
            this.btnSpecific.TabIndex = 22;
            this.btnSpecific.Text = "Select Specific";
            this.btnSpecific.UseVisualStyleBackColor = true;
            this.btnSpecific.Click += new System.EventHandler(this.btnSpecific_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(124, 63);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(10, 13);
            this.lbl.TabIndex = 21;
            this.lbl.Text = ":";
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Location = new System.Drawing.Point(164, 205);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(86, 13);
            this.lblMaker.TabIndex = 20;
            this.lblMaker.Text = "OblivionT \"B\" xd";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(74, 44);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 19;
            this.lblHours.Text = "Hours";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(148, 44);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 18;
            this.lblMinutes.Text = "Minutes";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(92, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(92, 108);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 26);
            this.btnSet.TabIndex = 16;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(140, 60);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(60, 20);
            this.txtMinutes.TabIndex = 15;
            this.txtMinutes.Text = "00";
            this.txtMinutes.Visible = false;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(58, 60);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(60, 20);
            this.txtHours.TabIndex = 14;
            this.txtHours.Text = "01";
            this.txtHours.Visible = false;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 227);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnSpecific);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblMaker);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.cmbMinutes);
            this.Controls.Add(this.cmbHours);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Name = "Timer";
            this.Text = "Windows Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnSpecific;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHours;
    }
}

