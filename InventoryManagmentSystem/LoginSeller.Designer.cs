namespace InventoryManagmentSystem
{
    partial class LoginSeller
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
            this.btnLoginSe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.usrlbError = new System.Windows.Forms.Label();
            this.psLbError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(285, 722);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.psLbError);
            this.rightPanel.Controls.Add(this.usrlbError);
            this.rightPanel.Controls.Add(this.btnLoginSe);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.txtPassword);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.txtUsername);
            this.rightPanel.Size = new System.Drawing.Size(956, 722);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtUsername, 0);
            this.rightPanel.Controls.SetChildIndex(this.label3, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtPassword, 0);
            this.rightPanel.Controls.SetChildIndex(this.label5, 0);
            this.rightPanel.Controls.SetChildIndex(this.btnLoginSe, 0);
            this.rightPanel.Controls.SetChildIndex(this.usrlbError, 0);
            this.rightPanel.Controls.SetChildIndex(this.psLbError, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(956, 48);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Size = new System.Drawing.Size(253, 44);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoginSe
            // 
            this.btnLoginSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSe.ForeColor = System.Drawing.Color.Maroon;
            this.btnLoginSe.Location = new System.Drawing.Point(490, 432);
            this.btnLoginSe.Name = "btnLoginSe";
            this.btnLoginSe.Size = new System.Drawing.Size(164, 67);
            this.btnLoginSe.TabIndex = 20;
            this.btnLoginSe.Text = "Login";
            this.btnLoginSe.UseVisualStyleBackColor = true;
            this.btnLoginSe.Click += new System.EventHandler(this.btnLoginSe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(166, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(382, 302);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(436, 34);
            this.txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(166, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter UserName";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(382, 206);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(436, 34);
            this.txtUsername.TabIndex = 12;
            // 
            // usrlbError
            // 
            this.usrlbError.AutoSize = true;
            this.usrlbError.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlbError.ForeColor = System.Drawing.Color.DarkRed;
            this.usrlbError.Location = new System.Drawing.Point(137, 210);
            this.usrlbError.Name = "usrlbError";
            this.usrlbError.Size = new System.Drawing.Size(23, 30);
            this.usrlbError.TabIndex = 22;
            this.usrlbError.Text = "*";
            // 
            // psLbError
            // 
            this.psLbError.AutoSize = true;
            this.psLbError.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psLbError.ForeColor = System.Drawing.Color.DarkRed;
            this.psLbError.Location = new System.Drawing.Point(137, 306);
            this.psLbError.Name = "psLbError";
            this.psLbError.Size = new System.Drawing.Size(23, 30);
            this.psLbError.TabIndex = 23;
            this.psLbError.Text = "*";
            // 
            // LoginSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 722);
            this.Name = "LoginSeller";
            this.Text = "LoginSeller";
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginSe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label psLbError;
        private System.Windows.Forms.Label usrlbError;
    }
}