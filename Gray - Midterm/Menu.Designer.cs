namespace Gray___Midterm
{
    partial class Menu
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
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.CheckingsBal = new System.Windows.Forms.Label();
            this.SavingsBal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.AmountBal = new System.Windows.Forms.TextBox();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.SaveBox = new System.Windows.Forms.CheckBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(89, 26);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(93, 25);
            this.BalanceLabel.TabIndex = 0;
            this.BalanceLabel.Text = "Balances";
            // 
            // CheckingsBal
            // 
            this.CheckingsBal.AutoSize = true;
            this.CheckingsBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingsBal.Location = new System.Drawing.Point(35, 91);
            this.CheckingsBal.Name = "CheckingsBal";
            this.CheckingsBal.Size = new System.Drawing.Size(211, 29);
            this.CheckingsBal.TabIndex = 1;
            this.CheckingsBal.Text = "checkplaceholder";
            // 
            // SavingsBal
            // 
            this.SavingsBal.AutoSize = true;
            this.SavingsBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsBal.Location = new System.Drawing.Point(35, 181);
            this.SavingsBal.Name = "SavingsBal";
            this.SavingsBal.Size = new System.Drawing.Size(218, 29);
            this.SavingsBal.TabIndex = 2;
            this.SavingsBal.Text = "savingplaceholder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Checkings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Savings";
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(379, 106);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(409, 42);
            this.WithdrawBtn.TabIndex = 5;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            this.WithdrawBtn.Click += new System.EventHandler(this.ButtonWithdraw_Click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(379, 165);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(409, 42);
            this.TransferBtn.TabIndex = 6;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.ButtonTransfer_Click);
            // 
            // ExtBtn
            // 
            this.ExtBtn.Location = new System.Drawing.Point(379, 224);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(409, 42);
            this.ExtBtn.TabIndex = 7;
            this.ExtBtn.Text = "Exit";
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // AmountBal
            // 
            this.AmountBal.Location = new System.Drawing.Point(523, 57);
            this.AmountBal.Name = "AmountBal";
            this.AmountBal.Size = new System.Drawing.Size(243, 22);
            this.AmountBal.TabIndex = 9;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(412, 46);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(92, 20);
            this.CheckBox.TabIndex = 10;
            this.CheckBox.Text = "Checkings";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SaveBox
            // 
            this.SaveBox.AutoSize = true;
            this.SaveBox.Location = new System.Drawing.Point(412, 72);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(78, 20);
            this.SaveBox.TabIndex = 11;
            this.SaveBox.Text = "Savings";
            this.SaveBox.UseVisualStyleBackColor = true;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(292, 9);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(496, 16);
            this.InstructionLabel.TabIndex = 12;
            this.InstructionLabel.Text = "Select the primary account and then enter the amount you want to transfer or with" +
    "raw";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.SaveBox);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.AmountBal);
            this.Controls.Add(this.ExtBtn);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SavingsBal);
            this.Controls.Add(this.CheckingsBal);
            this.Controls.Add(this.BalanceLabel);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label CheckingsBal;
        private System.Windows.Forms.Label SavingsBal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Button ExtBtn;
        private System.Windows.Forms.TextBox AmountBal;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.CheckBox SaveBox;
        private System.Windows.Forms.Label InstructionLabel;
    }
}