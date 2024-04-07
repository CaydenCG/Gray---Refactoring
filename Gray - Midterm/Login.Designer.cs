namespace Gray___Midterm
{
    partial class Login
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
            this.CustPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogClr = new System.Windows.Forms.Button();
            this.LogSub = new System.Windows.Forms.Button();
            this.CustNumLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustPin
            // 
            this.CustPin.Location = new System.Drawing.Point(166, 141);
            this.CustPin.Name = "CustPin";
            this.CustPin.Size = new System.Drawing.Size(247, 22);
            this.CustPin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter PIN";
            // 
            // LogClr
            // 
            this.LogClr.Location = new System.Drawing.Point(166, 182);
            this.LogClr.Name = "LogClr";
            this.LogClr.Size = new System.Drawing.Size(115, 23);
            this.LogClr.TabIndex = 2;
            this.LogClr.Text = "Clear";
            this.LogClr.UseVisualStyleBackColor = true;
            this.LogClr.Click += new System.EventHandler(this.LoginClear_Click);
            // 
            // LogSub
            // 
            this.LogSub.Location = new System.Drawing.Point(298, 182);
            this.LogSub.Name = "LogSub";
            this.LogSub.Size = new System.Drawing.Size(115, 23);
            this.LogSub.TabIndex = 3;
            this.LogSub.Text = "Enter";
            this.LogSub.UseVisualStyleBackColor = true;
            this.LogSub.Click += new System.EventHandler(this.LoginSubmission_Click);
            // 
            // CustNumLog
            // 
            this.CustNumLog.Location = new System.Drawing.Point(166, 97);
            this.CustNumLog.Name = "CustNumLog";
            this.CustNumLog.Size = new System.Drawing.Size(247, 22);
            this.CustNumLog.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Customer Number";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustNumLog);
            this.Controls.Add(this.LogSub);
            this.Controls.Add(this.LogClr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustPin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogClr;
        private System.Windows.Forms.Button LogSub;
        private System.Windows.Forms.TextBox CustNumLog;
        private System.Windows.Forms.Label label2;
    }
}

