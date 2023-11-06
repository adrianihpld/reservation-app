namespace ReservationApp
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBedType = new System.Windows.Forms.Label();
            this.lstNumberOfPeople = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtSpecialRequest = new System.Windows.Forms.TextBox();
            this.lblSpecialRequest = new System.Windows.Forms.Label();
            this.chkAudioAid = new System.Windows.Forms.CheckBox();
            this.chkVisualAid = new System.Windows.Forms.CheckBox();
            this.chkMobileAid = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(339, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(339, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arrival Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departure Date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number Of People:";
            // 
            // lblBedType
            // 
            this.lblBedType.AutoSize = true;
            this.lblBedType.Location = new System.Drawing.Point(43, 158);
            this.lblBedType.Name = "lblBedType";
            this.lblBedType.Size = new System.Drawing.Size(55, 13);
            this.lblBedType.TabIndex = 5;
            this.lblBedType.Text = "Bed Type:";
            // 
            // lstNumberOfPeople
            // 
            this.lstNumberOfPeople.FormattingEnabled = true;
            this.lstNumberOfPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstNumberOfPeople.Location = new System.Drawing.Point(154, 103);
            this.lstNumberOfPeople.Name = "lstNumberOfPeople";
            this.lstNumberOfPeople.Size = new System.Drawing.Size(339, 21);
            this.lstNumberOfPeople.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "King";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(221, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "One Queen";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(96, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Two Queen";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtSpecialRequest
            // 
            this.txtSpecialRequest.Location = new System.Drawing.Point(46, 236);
            this.txtSpecialRequest.Multiline = true;
            this.txtSpecialRequest.Name = "txtSpecialRequest";
            this.txtSpecialRequest.Size = new System.Drawing.Size(447, 73);
            this.txtSpecialRequest.TabIndex = 6;
            // 
            // lblSpecialRequest
            // 
            this.lblSpecialRequest.AutoSize = true;
            this.lblSpecialRequest.Location = new System.Drawing.Point(43, 211);
            this.lblSpecialRequest.Name = "lblSpecialRequest";
            this.lblSpecialRequest.Size = new System.Drawing.Size(88, 13);
            this.lblSpecialRequest.TabIndex = 11;
            this.lblSpecialRequest.Text = "Special Request";
            // 
            // chkAudioAid
            // 
            this.chkAudioAid.AutoSize = true;
            this.chkAudioAid.Location = new System.Drawing.Point(49, 340);
            this.chkAudioAid.Name = "chkAudioAid";
            this.chkAudioAid.Size = new System.Drawing.Size(77, 17);
            this.chkAudioAid.TabIndex = 7;
            this.chkAudioAid.Text = "Audio Aid";
            this.chkAudioAid.UseVisualStyleBackColor = true;
            // 
            // chkVisualAid
            // 
            this.chkVisualAid.AutoSize = true;
            this.chkVisualAid.Location = new System.Drawing.Point(132, 340);
            this.chkVisualAid.Name = "chkVisualAid";
            this.chkVisualAid.Size = new System.Drawing.Size(77, 17);
            this.chkVisualAid.TabIndex = 8;
            this.chkVisualAid.Text = "Visual Aid";
            this.chkVisualAid.UseVisualStyleBackColor = true;
            // 
            // chkMobileAid
            // 
            this.chkMobileAid.AutoSize = true;
            this.chkMobileAid.Location = new System.Drawing.Point(215, 340);
            this.chkMobileAid.Name = "chkMobileAid";
            this.chkMobileAid.Size = new System.Drawing.Size(82, 17);
            this.chkMobileAid.TabIndex = 9;
            this.chkMobileAid.Text = "Mobile Aid";
            this.chkMobileAid.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(154, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 49);
            this.panel1.TabIndex = 15;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(418, 336);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(75, 23);
            this.cmdSubmit.TabIndex = 10;
            this.cmdSubmit.Text = "SUBMIT";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.cmdSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 381);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkMobileAid);
            this.Controls.Add(this.chkVisualAid);
            this.Controls.Add(this.chkAudioAid);
            this.Controls.Add(this.lblSpecialRequest);
            this.Controls.Add(this.txtSpecialRequest);
            this.Controls.Add(this.lstNumberOfPeople);
            this.Controls.Add(this.lblBedType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBedType;
        private System.Windows.Forms.ComboBox lstNumberOfPeople;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtSpecialRequest;
        private System.Windows.Forms.Label lblSpecialRequest;
        private System.Windows.Forms.CheckBox chkAudioAid;
        private System.Windows.Forms.CheckBox chkVisualAid;
        private System.Windows.Forms.CheckBox chkMobileAid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSubmit;
    }
}

