﻿namespace WindowsFormsApp1
{
    partial class FormProductDetail
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
            this.groupBoxNewProduct = new System.Windows.Forms.GroupBox();
            this.btnSelectPic2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.groupBoxAlterProduct = new System.Windows.Forms.GroupBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnSelectPic1 = new System.Windows.Forms.Button();
            this.txtProductDetail = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxProductType = new System.Windows.Forms.ComboBox();
            this.groupBoxNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.groupBoxAlterProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewProduct
            // 
            this.groupBoxNewProduct.BackColor = System.Drawing.Color.Wheat;
            this.groupBoxNewProduct.Controls.Add(this.btnSelectPic2);
            this.groupBoxNewProduct.Controls.Add(this.btnSave);
            this.groupBoxNewProduct.Controls.Add(this.btnClear);
            this.groupBoxNewProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxNewProduct.Location = new System.Drawing.Point(667, 692);
            this.groupBoxNewProduct.Name = "groupBoxNewProduct";
            this.groupBoxNewProduct.Size = new System.Drawing.Size(528, 325);
            this.groupBoxNewProduct.TabIndex = 22;
            this.groupBoxNewProduct.TabStop = false;
            this.groupBoxNewProduct.Text = " 新增商品資訊";
            // 
            // btnSelectPic2
            // 
            this.btnSelectPic2.BackColor = System.Drawing.Color.Maroon;
            this.btnSelectPic2.FlatAppearance.BorderSize = 0;
            this.btnSelectPic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPic2.ForeColor = System.Drawing.Color.White;
            this.btnSelectPic2.Location = new System.Drawing.Point(131, 139);
            this.btnSelectPic2.Name = "btnSelectPic2";
            this.btnSelectPic2.Size = new System.Drawing.Size(296, 61);
            this.btnSelectPic2.TabIndex = 2;
            this.btnSelectPic2.Text = "選取商品圖片";
            this.btnSelectPic2.UseVisualStyleBackColor = false;
            this.btnSelectPic2.Click += new System.EventHandler(this.btnSelectPic1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(131, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(296, 61);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存商品";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(131, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(296, 61);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空欄位";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(667, 214);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(528, 446);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 23;
            this.pictureBoxProduct.TabStop = false;
            // 
            // groupBoxAlterProduct
            // 
            this.groupBoxAlterProduct.BackColor = System.Drawing.Color.Wheat;
            this.groupBoxAlterProduct.Controls.Add(this.btnAlter);
            this.groupBoxAlterProduct.Controls.Add(this.btnSelectPic1);
            this.groupBoxAlterProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxAlterProduct.Location = new System.Drawing.Point(92, 692);
            this.groupBoxAlterProduct.Name = "groupBoxAlterProduct";
            this.groupBoxAlterProduct.Size = new System.Drawing.Size(528, 325);
            this.groupBoxAlterProduct.TabIndex = 21;
            this.groupBoxAlterProduct.TabStop = false;
            this.groupBoxAlterProduct.Text = " 修改商品資訊";
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.Maroon;
            this.btnAlter.FlatAppearance.BorderSize = 0;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.ForeColor = System.Drawing.Color.White;
            this.btnAlter.Location = new System.Drawing.Point(237, 178);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(253, 61);
            this.btnAlter.TabIndex = 1;
            this.btnAlter.Text = "儲存修改";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnSelectPic1
            // 
            this.btnSelectPic1.BackColor = System.Drawing.Color.Maroon;
            this.btnSelectPic1.FlatAppearance.BorderSize = 0;
            this.btnSelectPic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPic1.ForeColor = System.Drawing.Color.White;
            this.btnSelectPic1.Location = new System.Drawing.Point(237, 85);
            this.btnSelectPic1.Name = "btnSelectPic1";
            this.btnSelectPic1.Size = new System.Drawing.Size(253, 61);
            this.btnSelectPic1.TabIndex = 0;
            this.btnSelectPic1.Text = "選取商品圖片";
            this.btnSelectPic1.UseVisualStyleBackColor = false;
            this.btnSelectPic1.Click += new System.EventHandler(this.btnSelectPic1_Click);
            // 
            // txtProductDetail
            // 
            this.txtProductDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductDetail.Location = new System.Drawing.Point(244, 433);
            this.txtProductDetail.Multiline = true;
            this.txtProductDetail.Name = "txtProductDetail";
            this.txtProductDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProductDetail.Size = new System.Drawing.Size(376, 227);
            this.txtProductDetail.TabIndex = 20;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(244, 293);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(376, 36);
            this.txtProductPrice.TabIndex = 19;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(244, 221);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(376, 36);
            this.txtProductName.TabIndex = 18;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.BackColor = System.Drawing.Color.Wheat;
            this.lblPID.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.Location = new System.Drawing.Point(300, 139);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(227, 48);
            this.lblPID.TabIndex = 17;
            this.lblPID.Text = "000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(660, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 40);
            this.label5.TabIndex = 16;
            this.label5.Text = "商品圖檔";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(85, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "商品價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(85, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(55, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "ProductID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(525, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 61);
            this.label6.TabIndex = 24;
            this.label6.Text = "商品詳細資訊";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 100);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1017);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 100);
            this.panel2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(85, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "商品描述";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(85, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 40);
            this.label7.TabIndex = 27;
            this.label7.Text = "商品種類";
            // 
            // cBoxProductType
            // 
            this.cBoxProductType.FormattingEnabled = true;
            this.cBoxProductType.Location = new System.Drawing.Point(244, 369);
            this.cBoxProductType.Name = "cBoxProductType";
            this.cBoxProductType.Size = new System.Drawing.Size(376, 32);
            this.cBoxProductType.TabIndex = 28;
            this.cBoxProductType.SelectedIndexChanged += new System.EventHandler(this.cBoxProductType_SelectedIndexChanged);
            // 
            // FormProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1301, 1068);
            this.Controls.Add(this.cBoxProductType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxNewProduct);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.groupBoxAlterProduct);
            this.Controls.Add(this.txtProductDetail);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductDetail";
            this.Text = "商品詳細資訊";
            this.Load += new System.EventHandler(this.FormProductDetail_Load);
            this.groupBoxNewProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.groupBoxAlterProduct.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNewProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectPic2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.GroupBox groupBoxAlterProduct;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnSelectPic1;
        private System.Windows.Forms.TextBox txtProductDetail;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxProductType;
    }
}