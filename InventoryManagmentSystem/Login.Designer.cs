namespace InventoryManagmentSystem
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsename = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.txtPassword);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.txtUsename);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(342, 719);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtUsename, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.txtPassword, 0);
            this.leftPanel.Controls.SetChildIndex(this.button1, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(342, 44);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Location = new System.Drawing.Point(342, 0);
            this.rightPanel.Size = new System.Drawing.Size(823, 719);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(823, 48);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(92, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "UserName";
            // 
            // txtUsename
            // 
            this.txtUsename.Location = new System.Drawing.Point(7, 261);
            this.txtUsename.MaxLength = 50;
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.Size = new System.Drawing.Size(329, 27);
            this.txtUsename.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(7, 336);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(330, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login as Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnWarehouse, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSeller, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 671);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackgroundImage = global::InventoryManagmentSystem.Properties.Resources.icons8_user_100;
            this.btnWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.Navy;
            this.btnWarehouse.Location = new System.Drawing.Point(208, 204);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(199, 128);
            this.btnWarehouse.TabIndex = 0;
            this.btnWarehouse.Text = "Login as WareHouse Member";
            this.btnWarehouse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.BackgroundImage = global::InventoryManagmentSystem.Properties.Resources.icons8_user_100;
            this.btnSeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeller.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeller.ForeColor = System.Drawing.Color.Navy;
            this.btnSeller.Location = new System.Drawing.Point(413, 204);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(199, 128);
            this.btnSeller.TabIndex = 1;
            this.btnSeller.Text = "Login as Seller Member";
            this.btnSeller.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeller.UseVisualStyleBackColor = true;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 719);
            this.Name = "Login";
            this.Text = "Login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnSeller;
    }
}