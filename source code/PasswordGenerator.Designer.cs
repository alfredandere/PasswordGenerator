
namespace PasswordGenerator
{
    partial class PasswordGenerator

    /*************************************************
        * Author: Alenzy
        * Program: This initializes all components of
        * the password generator application
        ***************************************************/
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboLength = new System.Windows.Forms.ComboBox();
            this.ChkNumbers = new System.Windows.Forms.CheckBox();
            this.ChkSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenPass = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Today\'s date";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(463, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Your username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the length of the password and check numbers and special characters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a length";
            // 
            // CboLength
            // 
            this.CboLength.FormattingEnabled = true;
            this.CboLength.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "16"});
            this.CboLength.Location = new System.Drawing.Point(245, 103);
            this.CboLength.Name = "CboLength";
            this.CboLength.Size = new System.Drawing.Size(108, 21);
            this.CboLength.TabIndex = 4;
            // 
            // ChkNumbers
            // 
            this.ChkNumbers.AutoSize = true;
            this.ChkNumbers.Location = new System.Drawing.Point(245, 139);
            this.ChkNumbers.Name = "ChkNumbers";
            this.ChkNumbers.Size = new System.Drawing.Size(101, 17);
            this.ChkNumbers.TabIndex = 5;
            this.ChkNumbers.Text = "Use a number ?";
            this.ChkNumbers.UseVisualStyleBackColor = true;
            // 
            // ChkSpecialCharacters
            // 
            this.ChkSpecialCharacters.AutoSize = true;
            this.ChkSpecialCharacters.Location = new System.Drawing.Point(245, 173);
            this.ChkSpecialCharacters.Name = "ChkSpecialCharacters";
            this.ChkSpecialCharacters.Size = new System.Drawing.Size(147, 17);
            this.ChkSpecialCharacters.TabIndex = 6;
            this.ChkSpecialCharacters.Text = "Use a special character ?";
            this.ChkSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(236, 210);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // btnGenPass
            // 
            this.btnGenPass.Location = new System.Drawing.Point(86, 242);
            this.btnGenPass.Name = "btnGenPass";
            this.btnGenPass.Size = new System.Drawing.Size(133, 23);
            this.btnGenPass.TabIndex = 9;
            this.btnGenPass.Text = "Generate Password ";
            this.btnGenPass.UseVisualStyleBackColor = true;
            this.btnGenPass.Click += new System.EventHandler(this.btnGenPass_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(280, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 25);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(428, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChkSpecialCharacters);
            this.Controls.Add(this.ChkNumbers);
            this.Controls.Add(this.CboLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDate);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboLength;
        private System.Windows.Forms.CheckBox ChkNumbers;
        private System.Windows.Forms.CheckBox ChkSpecialCharacters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenPass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

