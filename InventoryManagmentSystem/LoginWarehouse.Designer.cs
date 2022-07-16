namespace InventoryManagmentSystem
{
    partial class LoginWarehouse
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
            this.btnLoginWr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.psLbError = new System.Windows.Forms.Label();
            this.usrlbError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(285, 784);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.psLbError);
            this.rightPanel.Controls.Add(this.btnLoginWr);
            this.rightPanel.Controls.Add(this.usrlbError);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.txtUsername);
            this.rightPanel.Controls.Add(this.txtPassword);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Size = new System.Drawing.Size(985, 784);
            this.rightPanel.Controls.SetChildIndex(this.label3, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtPassword, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtUsername, 0);
            this.rightPanel.Controls.SetChildIndex(this.label5, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.usrlbError, 0);
            this.rightPanel.Controls.SetChildIndex(this.btnLoginWr, 0);
            this.rightPanel.Controls.SetChildIndex(this.psLbError, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(985, 48);
            // 
            // btnLoginWr
            // 
            this.btnLoginWr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginWr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginWr.ForeColor = System.Drawing.Color.Maroon;
            this.btnLoginWr.Location = new System.Drawing.Point(527, 476);
            this.btnLoginWr.Name = "btnLoginWr";
            this.btnLoginWr.Size = new System.Drawing.Size(164, 67);
            this.btnLoginWr.TabIndex = 25;
            this.btnLoginWr.Text = "Login";
            this.btnLoginWr.UseVisualStyleBackColor = true;
            this.btnLoginWr.Click += new System.EventHandler(this.btnLoginWr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(203, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enter Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(419, 346);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(436, 34);
            this.txtPassword.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(203, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter UserName";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(419, 250);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(436, 34);
            this.txtUsername.TabIndex = 21;
            // 
            // psLbError
            // 
            this.psLbError.AutoSize = true;
            this.psLbError.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psLbError.ForeColor = System.Drawing.Color.DarkRed;
            this.psLbError.Location = new System.Drawing.Point(174, 353);
            this.psLbError.Name = "psLbError";
            this.psLbError.Size = new System.Drawing.Size(23, 30);
            this.psLbError.TabIndex = 25;
            this.psLbError.Text = "*";
            // 
            // usrlbError
            // 
            this.usrlbError.AutoSize = true;
            this.usrlbError.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlbError.ForeColor = System.Drawing.Color.DarkRed;
            this.usrlbError.Location = new System.Drawing.Point(174, 257);
            this.usrlbError.Name = "usrlbError";
            this.usrlbError.Size = new System.Drawing.Size(23, 30);
            this.usrlbError.TabIndex = 24;
            this.usrlbError.Text = "*";
            // 
            // LoginWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 784);
            this.Name = "LoginWarehouse";
            this.Text = "LoginWarehouse";
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginWr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label psLbError;
        private System.Windows.Forms.Label usrlbError;
    }
}