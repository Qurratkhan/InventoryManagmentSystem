namespace InventoryManagmentSystem
{
    partial class SellingProduct
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
            this.fetchDetail = new System.Windows.Forms.Button();
            this.btnAddPrdct = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.lb_barcodeError = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_PrQtyError = new System.Windows.Forms.Label();
            this.lb_PrNameError = new System.Windows.Forms.Label();
            this.txtPrdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(285, 771);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.txtBarcode);
            this.rightPanel.Controls.Add(this.fetchDetail);
            this.rightPanel.Controls.Add(this.btnAddPrdct);
            this.rightPanel.Controls.Add(this.txtQty);
            this.rightPanel.Controls.Add(this.label13);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.txtDesc);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.label11);
            this.rightPanel.Controls.Add(this.txtPrdName);
            this.rightPanel.Controls.Add(this.txtPerson);
            this.rightPanel.Controls.Add(this.lb_barcodeError);
            this.rightPanel.Controls.Add(this.lb_PrNameError);
            this.rightPanel.Controls.Add(this.label9);
            this.rightPanel.Controls.Add(this.lb_PrQtyError);
            this.rightPanel.Size = new System.Drawing.Size(1055, 771);
            this.rightPanel.Controls.SetChildIndex(this.lb_PrQtyError, 0);
            this.rightPanel.Controls.SetChildIndex(this.label9, 0);
            this.rightPanel.Controls.SetChildIndex(this.lb_PrNameError, 0);
            this.rightPanel.Controls.SetChildIndex(this.lb_barcodeError, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtPerson, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtPrdName, 0);
            this.rightPanel.Controls.SetChildIndex(this.label11, 0);
            this.rightPanel.Controls.SetChildIndex(this.label4, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtDesc, 0);
            this.rightPanel.Controls.SetChildIndex(this.label5, 0);
            this.rightPanel.Controls.SetChildIndex(this.label13, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtQty, 0);
            this.rightPanel.Controls.SetChildIndex(this.btnAddPrdct, 0);
            this.rightPanel.Controls.SetChildIndex(this.fetchDetail, 0);
            this.rightPanel.Controls.SetChildIndex(this.txtBarcode, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1055, 48);
            // 
            // fetchDetail
            // 
            this.fetchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchDetail.ForeColor = System.Drawing.Color.Maroon;
            this.fetchDetail.Location = new System.Drawing.Point(571, 169);
            this.fetchDetail.Name = "fetchDetail";
            this.fetchDetail.Size = new System.Drawing.Size(234, 52);
            this.fetchDetail.TabIndex = 67;
            this.fetchDetail.Text = "Fetch Detail";
            this.fetchDetail.UseVisualStyleBackColor = true;
            this.fetchDetail.Click += new System.EventHandler(this.fetchDetail_Click);
            // 
            // btnAddPrdct
            // 
            this.btnAddPrdct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrdct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrdct.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddPrdct.Location = new System.Drawing.Point(529, 540);
            this.btnAddPrdct.Name = "btnAddPrdct";
            this.btnAddPrdct.Size = new System.Drawing.Size(276, 67);
            this.btnAddPrdct.TabIndex = 66;
            this.btnAddPrdct.Text = "Sell Product ";
            this.btnAddPrdct.UseVisualStyleBackColor = true;
            this.btnAddPrdct.Click += new System.EventHandler(this.btnAddPrdct_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(250, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 28);
            this.label13.TabIndex = 65;
            this.label13.Text = "Selling Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(466, 377);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(409, 44);
            this.txtDesc.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(250, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 28);
            this.label11.TabIndex = 64;
            this.label11.Text = "Seller Person";
            // 
            // txtPerson
            // 
            this.txtPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerson.Location = new System.Drawing.Point(466, 444);
            this.txtPerson.Multiline = true;
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.ReadOnly = true;
            this.txtPerson.Size = new System.Drawing.Size(409, 44);
            this.txtPerson.TabIndex = 58;
            // 
            // lb_barcodeError
            // 
            this.lb_barcodeError.AutoSize = true;
            this.lb_barcodeError.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_barcodeError.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_barcodeError.Location = new System.Drawing.Point(221, 123);
            this.lb_barcodeError.Name = "lb_barcodeError";
            this.lb_barcodeError.Size = new System.Drawing.Size(23, 30);
            this.lb_barcodeError.TabIndex = 63;
            this.lb_barcodeError.Text = "*";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(466, 109);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(409, 44);
            this.txtBarcode.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(250, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 28);
            this.label9.TabIndex = 62;
            this.label9.Text = "Product Barcode";
            // 
            // lb_PrQtyError
            // 
            this.lb_PrQtyError.AutoSize = true;
            this.lb_PrQtyError.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrQtyError.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_PrQtyError.Location = new System.Drawing.Point(221, 326);
            this.lb_PrQtyError.Name = "lb_PrQtyError";
            this.lb_PrQtyError.Size = new System.Drawing.Size(23, 30);
            this.lb_PrQtyError.TabIndex = 60;
            this.lb_PrQtyError.Text = "*";
            // 
            // lb_PrNameError
            // 
            this.lb_PrNameError.AutoSize = true;
            this.lb_PrNameError.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrNameError.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_PrNameError.Location = new System.Drawing.Point(221, 262);
            this.lb_PrNameError.Name = "lb_PrNameError";
            this.lb_PrNameError.Size = new System.Drawing.Size(23, 30);
            this.lb_PrNameError.TabIndex = 56;
            this.lb_PrNameError.Text = "*";
            // 
            // txtPrdName
            // 
            this.txtPrdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdName.Location = new System.Drawing.Point(466, 248);
            this.txtPrdName.Multiline = true;
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.ReadOnly = true;
            this.txtPrdName.Size = new System.Drawing.Size(409, 44);
            this.txtPrdName.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(250, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 50;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(250, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 28);
            this.label5.TabIndex = 53;
            this.label5.Text = "Product Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(466, 312);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(409, 44);
            this.txtQty.TabIndex = 51;
            // 
            // SellingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 771);
            this.Name = "SellingProduct";
            this.Text = "SellingProduct";
            this.Load += new System.EventHandler(this.SellingProduct_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button fetchDetail;
        private System.Windows.Forms.Button btnAddPrdct;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrdName;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Label lb_barcodeError;
        private System.Windows.Forms.Label lb_PrNameError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_PrQtyError;
    }
}