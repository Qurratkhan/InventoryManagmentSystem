namespace InventorySystem
{
    partial class AddProductItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductItem));
            this.lbManuf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtManufacture = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPrName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddPr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPrQty = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtPrName = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbExpire = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtExpire = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbBarCode = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBarcode = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnfetch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbManuf
            // 
            this.lbManuf.AutoSize = true;
            this.lbManuf.BackColor = System.Drawing.Color.Transparent;
            this.lbManuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManuf.Location = new System.Drawing.Point(119, 365);
            this.lbManuf.Name = "lbManuf";
            this.lbManuf.Size = new System.Drawing.Size(182, 25);
            this.lbManuf.TabIndex = 19;
            this.lbManuf.Text = "Manufacturing Date";
            // 
            // txtManufacture
            // 
            this.txtManufacture.BackColor = System.Drawing.Color.Silver;
            this.txtManufacture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtManufacture.BackgroundImage")));
            this.txtManufacture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtManufacture.ForeColor = System.Drawing.Color.Blue;
            this.txtManufacture.Icon = ((System.Drawing.Image)(resources.GetObject("txtManufacture.Icon")));
            this.txtManufacture.Location = new System.Drawing.Point(345, 351);
            this.txtManufacture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtManufacture.Name = "txtManufacture";
            this.txtManufacture.Size = new System.Drawing.Size(359, 52);
            this.txtManufacture.TabIndex = 18;
            this.txtManufacture.text = "";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(119, 290);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 25);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Enter Quantity";
            // 
            // lblPrName
            // 
            this.lblPrName.AutoSize = true;
            this.lblPrName.BackColor = System.Drawing.Color.Transparent;
            this.lblPrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrName.Location = new System.Drawing.Point(118, 223);
            this.lblPrName.Name = "lblPrName";
            this.lblPrName.Size = new System.Drawing.Size(187, 25);
            this.lblPrName.TabIndex = 16;
            this.lblPrName.Text = "Enter Product Name";
            // 
            // btnAddPr
            // 
            this.btnAddPr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddPr.BackColor = System.Drawing.Color.Blue;
            this.btnAddPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPr.BorderRadius = 0;
            this.btnAddPr.ButtonText = "Add Product";
            this.btnAddPr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPr.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPr.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPr.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPr.Iconimage")));
            this.btnAddPr.Iconimage_right = null;
            this.btnAddPr.Iconimage_right_Selected = null;
            this.btnAddPr.Iconimage_Selected = null;
            this.btnAddPr.IconMarginLeft = 0;
            this.btnAddPr.IconMarginRight = 0;
            this.btnAddPr.IconRightVisible = true;
            this.btnAddPr.IconRightZoom = 0D;
            this.btnAddPr.IconVisible = true;
            this.btnAddPr.IconZoom = 90D;
            this.btnAddPr.IsTab = false;
            this.btnAddPr.Location = new System.Drawing.Point(269, 498);
            this.btnAddPr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPr.Name = "btnAddPr";
            this.btnAddPr.Normalcolor = System.Drawing.Color.Blue;
            this.btnAddPr.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddPr.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPr.selected = false;
            this.btnAddPr.Size = new System.Drawing.Size(303, 59);
            this.btnAddPr.TabIndex = 15;
            this.btnAddPr.Text = "Add Product";
            this.btnAddPr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPr.Textcolor = System.Drawing.Color.White;
            this.btnAddPr.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPr.Click += new System.EventHandler(this.btnAddPr_Click);
            // 
            // txtPrQty
            // 
            this.txtPrQty.BackColor = System.Drawing.Color.Silver;
            this.txtPrQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrQty.BackgroundImage")));
            this.txtPrQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPrQty.ForeColor = System.Drawing.Color.Blue;
            this.txtPrQty.Icon = ((System.Drawing.Image)(resources.GetObject("txtPrQty.Icon")));
            this.txtPrQty.Location = new System.Drawing.Point(345, 276);
            this.txtPrQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrQty.Name = "txtPrQty";
            this.txtPrQty.Size = new System.Drawing.Size(359, 52);
            this.txtPrQty.TabIndex = 14;
            this.txtPrQty.text = "";
            // 
            // txtPrName
            // 
            this.txtPrName.BackColor = System.Drawing.Color.Silver;
            this.txtPrName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrName.BackgroundImage")));
            this.txtPrName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPrName.ForeColor = System.Drawing.Color.Blue;
            this.txtPrName.Icon = ((System.Drawing.Image)(resources.GetObject("txtPrName.Icon")));
            this.txtPrName.Location = new System.Drawing.Point(345, 201);
            this.txtPrName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrName.Name = "txtPrName";
            this.txtPrName.Size = new System.Drawing.Size(359, 52);
            this.txtPrName.TabIndex = 13;
            this.txtPrName.text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbCancel);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 73);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(310, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add Product Detail";
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCancel.Location = new System.Drawing.Point(767, 25);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(27, 25);
            this.lbCancel.TabIndex = 16;
            this.lbCancel.Text = "X";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // lbExpire
            // 
            this.lbExpire.AutoSize = true;
            this.lbExpire.BackColor = System.Drawing.Color.Transparent;
            this.lbExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpire.Location = new System.Drawing.Point(119, 436);
            this.lbExpire.Name = "lbExpire";
            this.lbExpire.Size = new System.Drawing.Size(113, 25);
            this.lbExpire.TabIndex = 22;
            this.lbExpire.Text = "Expire Date";
            // 
            // txtExpire
            // 
            this.txtExpire.BackColor = System.Drawing.Color.Silver;
            this.txtExpire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtExpire.BackgroundImage")));
            this.txtExpire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtExpire.ForeColor = System.Drawing.Color.Blue;
            this.txtExpire.Icon = ((System.Drawing.Image)(resources.GetObject("txtExpire.Icon")));
            this.txtExpire.Location = new System.Drawing.Point(345, 422);
            this.txtExpire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExpire.Name = "txtExpire";
            this.txtExpire.Size = new System.Drawing.Size(359, 52);
            this.txtExpire.TabIndex = 21;
            this.txtExpire.text = "";
            // 
            // lbBarCode
            // 
            this.lbBarCode.AutoSize = true;
            this.lbBarCode.BackColor = System.Drawing.Color.Transparent;
            this.lbBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarCode.Location = new System.Drawing.Point(27, 111);
            this.lbBarCode.Name = "lbBarCode";
            this.lbBarCode.Size = new System.Drawing.Size(95, 25);
            this.lbBarCode.TabIndex = 24;
            this.lbBarCode.Text = "BarCode ";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.Silver;
            this.txtBarcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBarcode.BackgroundImage")));
            this.txtBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBarcode.ForeColor = System.Drawing.Color.Blue;
            this.txtBarcode.Icon = ((System.Drawing.Image)(resources.GetObject("txtBarcode.Icon")));
            this.txtBarcode.Location = new System.Drawing.Point(169, 94);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(359, 52);
            this.txtBarcode.TabIndex = 23;
            this.txtBarcode.text = "";
            // 
            // btnfetch
            // 
            this.btnfetch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfetch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfetch.BorderRadius = 0;
            this.btnfetch.ButtonText = "Fetch Data";
            this.btnfetch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfetch.DisabledColor = System.Drawing.Color.Gray;
            this.btnfetch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnfetch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnfetch.Iconimage")));
            this.btnfetch.Iconimage_right = null;
            this.btnfetch.Iconimage_right_Selected = null;
            this.btnfetch.Iconimage_Selected = null;
            this.btnfetch.IconMarginLeft = 0;
            this.btnfetch.IconMarginRight = 0;
            this.btnfetch.IconRightVisible = true;
            this.btnfetch.IconRightZoom = 0D;
            this.btnfetch.IconVisible = true;
            this.btnfetch.IconZoom = 90D;
            this.btnfetch.IsTab = false;
            this.btnfetch.Location = new System.Drawing.Point(570, 96);
            this.btnfetch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnfetch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnfetch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnfetch.selected = false;
            this.btnfetch.Size = new System.Drawing.Size(223, 43);
            this.btnfetch.TabIndex = 26;
            this.btnfetch.Text = "Fetch Data";
            this.btnfetch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnfetch.Textcolor = System.Drawing.Color.White;
            this.btnfetch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AddProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 636);
            this.Controls.Add(this.btnfetch);
            this.Controls.Add(this.lbBarCode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lbExpire);
            this.Controls.Add(this.txtExpire);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbManuf);
            this.Controls.Add(this.txtManufacture);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblPrName);
            this.Controls.Add(this.btnAddPr);
            this.Controls.Add(this.txtPrQty);
            this.Controls.Add(this.txtPrName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductItem";
            this.Load += new System.EventHandler(this.AddProductItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbManuf;
        private Bunifu.Framework.UI.BunifuTextbox txtManufacture;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPrName;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPr;
        private Bunifu.Framework.UI.BunifuTextbox txtPrQty;
        private Bunifu.Framework.UI.BunifuTextbox txtPrName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCancel;
        private Bunifu.Framework.UI.BunifuCustomLabel lbExpire;
        private Bunifu.Framework.UI.BunifuTextbox txtExpire;
        private Bunifu.Framework.UI.BunifuCustomLabel lbBarCode;
        private Bunifu.Framework.UI.BunifuTextbox txtBarcode;
        private Bunifu.Framework.UI.BunifuFlatButton btnfetch;
    }
}