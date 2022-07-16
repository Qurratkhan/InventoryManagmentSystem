namespace InventoryManagmentSystem
{
    partial class Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxInTSec = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnSave);
            this.leftPanel.Controls.Add(this.checkBoxInTSec);
            this.leftPanel.Controls.Add(this.txtPassword);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.txtUserId);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.txtDatabase);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.txtServer);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(285, 695);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtServer, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtDatabase, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtUserId, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtPassword, 0);
            this.leftPanel.Controls.SetChildIndex(this.checkBoxInTSec, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(870, 695);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(16, 219);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(253, 27);
            this.txtServer.TabIndex = 2;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(16, 280);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(253, 27);
            this.txtDatabase.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(16, 343);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(253, 27);
            this.txtUserId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 406);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 27);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // checkBoxInTSec
            // 
            this.checkBoxInTSec.AutoSize = true;
            this.checkBoxInTSec.Location = new System.Drawing.Point(16, 440);
            this.checkBoxInTSec.Name = "checkBoxInTSec";
            this.checkBoxInTSec.Size = new System.Drawing.Size(156, 24);
            this.checkBoxInTSec.TabIndex = 9;
            this.checkBoxInTSec.Text = "Integrated Security";
            this.checkBoxInTSec.UseVisualStyleBackColor = true;
            this.checkBoxInTSec.CheckedChanged += new System.EventHandler(this.checkBoxInTSec_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(16, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 41);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 695);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBoxInTSec;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label3;
    }
}