namespace AustriaTime
{
    partial class Austria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCheckSms = new Button();
            label1 = new Label();
            txtTimer = new MaskedTextBox();
            chkStart = new CheckBox();
            SuspendLayout();
            // 
            // BtnCheckSms
            // 
            BtnCheckSms.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            BtnCheckSms.Location = new Point(12, 212);
            BtnCheckSms.Name = "BtnCheckSms";
            BtnCheckSms.Size = new Size(262, 33);
            BtnCheckSms.TabIndex = 0;
            BtnCheckSms.Text = "check sms webservice";
            BtnCheckSms.UseVisualStyleBackColor = true;
            BtnCheckSms.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "timer";
            // 
            // txtTimer
            // 
            txtTimer.Location = new Point(12, 27);
            txtTimer.Mask = "0000000000";
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(262, 23);
            txtTimer.TabIndex = 3;
            txtTimer.Text = "30000";
            txtTimer.ValidatingType = typeof(int);
            // 
            // chkStart
            // 
            chkStart.AutoSize = true;
            chkStart.Checked = true;
            chkStart.CheckState = CheckState.Checked;
            chkStart.Font = new Font("Segoe UI", 20F);
            chkStart.Location = new Point(90, 165);
            chkStart.Name = "chkStart";
            chkStart.Size = new Size(88, 41);
            chkStart.TabIndex = 6;
            chkStart.Text = "start";
            chkStart.UseVisualStyleBackColor = true;
            // 
            // Austria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 265);
            Controls.Add(chkStart);
            Controls.Add(txtTimer);
            Controls.Add(label1);
            Controls.Add(BtnCheckSms);
            Name = "Austria";
            Text = "check job seeker asutria ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheckSms;
        private Label label1;
        private MaskedTextBox txtTimer;
        private CheckBox chkStart;
    }
}
