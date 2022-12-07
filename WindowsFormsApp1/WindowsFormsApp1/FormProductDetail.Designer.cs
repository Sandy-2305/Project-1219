namespace WindowsFormsApp1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectPic2 = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.groupBoxAlterProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNewProduct
            // 
            this.groupBoxNewProduct.Controls.Add(this.btnSave);
            this.groupBoxNewProduct.Controls.Add(this.btnSelectPic2);
            this.groupBoxNewProduct.Controls.Add(this.btnClear);
            this.groupBoxNewProduct.Location = new System.Drawing.Point(734, 775);
            this.groupBoxNewProduct.Name = "groupBoxNewProduct";
            this.groupBoxNewProduct.Size = new System.Drawing.Size(528, 242);
            this.groupBoxNewProduct.TabIndex = 22;
            this.groupBoxNewProduct.TabStop = false;
            this.groupBoxNewProduct.Text = " 新增商品資訊";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 61);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存商品";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSelectPic2
            // 
            this.btnSelectPic2.Location = new System.Drawing.Point(217, 102);
            this.btnSelectPic2.Name = "btnSelectPic2";
            this.btnSelectPic2.Size = new System.Drawing.Size(253, 61);
            this.btnSelectPic2.TabIndex = 2;
            this.btnSelectPic2.Text = "選取商品圖片";
            this.btnSelectPic2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(217, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(253, 61);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空欄位";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(734, 213);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(528, 547);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 23;
            this.pictureBoxProduct.TabStop = false;
            // 
            // groupBoxAlterProduct
            // 
            this.groupBoxAlterProduct.Controls.Add(this.btnAlter);
            this.groupBoxAlterProduct.Controls.Add(this.btnSelectPic1);
            this.groupBoxAlterProduct.Location = new System.Drawing.Point(158, 775);
            this.groupBoxAlterProduct.Name = "groupBoxAlterProduct";
            this.groupBoxAlterProduct.Size = new System.Drawing.Size(528, 242);
            this.groupBoxAlterProduct.TabIndex = 21;
            this.groupBoxAlterProduct.TabStop = false;
            this.groupBoxAlterProduct.Text = " 修改商品資訊";
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(237, 149);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(253, 61);
            this.btnAlter.TabIndex = 1;
            this.btnAlter.Text = "儲存修改";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnSelectPic1
            // 
            this.btnSelectPic1.Location = new System.Drawing.Point(237, 56);
            this.btnSelectPic1.Name = "btnSelectPic1";
            this.btnSelectPic1.Size = new System.Drawing.Size(253, 61);
            this.btnSelectPic1.TabIndex = 0;
            this.btnSelectPic1.Text = "選取商品圖片";
            this.btnSelectPic1.UseVisualStyleBackColor = true;
            // 
            // txtProductDetail
            // 
            this.txtProductDetail.Location = new System.Drawing.Point(310, 365);
            this.txtProductDetail.Multiline = true;
            this.txtProductDetail.Name = "txtProductDetail";
            this.txtProductDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProductDetail.Size = new System.Drawing.Size(376, 395);
            this.txtProductDetail.TabIndex = 20;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(310, 289);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(376, 36);
            this.txtProductPrice.TabIndex = 19;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(310, 213);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(376, 36);
            this.txtProductName.TabIndex = 18;
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.Location = new System.Drawing.Point(372, 125);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(227, 48);
            this.lblPID.TabIndex = 17;
            this.lblPID.Text = "000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(727, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 40);
            this.label5.TabIndex = 16;
            this.label5.Text = "商品圖檔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(151, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "商品描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(151, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "商品價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(151, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(224, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "PID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(517, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 61);
            this.label6.TabIndex = 24;
            this.label6.Text = "商品詳細資訊";
            // 
            // FormProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 1056);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}