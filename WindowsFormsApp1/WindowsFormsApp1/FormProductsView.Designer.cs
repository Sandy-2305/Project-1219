namespace WindowsFormsApp1
{
    partial class FormProductsView
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.btnPicMode = new System.Windows.Forms.Button();
            this.btnLstMode = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(330, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品展示";
            // 
            // listViewProduct
            // 
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(51, 124);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(797, 765);
            this.listViewProduct.TabIndex = 1;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoginInfo.Location = new System.Drawing.Point(720, 54);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(145, 40);
            this.lblLoginInfo.TabIndex = 2;
            this.lblLoginInfo.Text = "登入身分";
            // 
            // btnPicMode
            // 
            this.btnPicMode.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPicMode.Location = new System.Drawing.Point(879, 195);
            this.btnPicMode.Name = "btnPicMode";
            this.btnPicMode.Size = new System.Drawing.Size(294, 106);
            this.btnPicMode.TabIndex = 3;
            this.btnPicMode.Text = "圖片模式";
            this.btnPicMode.UseVisualStyleBackColor = true;
            // 
            // btnLstMode
            // 
            this.btnLstMode.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLstMode.Location = new System.Drawing.Point(879, 307);
            this.btnLstMode.Name = "btnLstMode";
            this.btnLstMode.Size = new System.Drawing.Size(294, 106);
            this.btnLstMode.TabIndex = 4;
            this.btnLstMode.Text = "列表模式";
            this.btnLstMode.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.Location = new System.Drawing.Point(879, 419);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(294, 106);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "重新載入";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewProduct.Location = new System.Drawing.Point(879, 531);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(294, 106);
            this.btnNewProduct.TabIndex = 6;
            this.btnNewProduct.Text = "新增商品";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            // 
            // FormProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 968);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnLstMode);
            this.Controls.Add(this.btnPicMode);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.label1);
            this.Name = "FormProductsView";
            this.Text = "商品展示";
            this.Load += new System.EventHandler(this.FormProductsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Button btnPicMode;
        private System.Windows.Forms.Button btnLstMode;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnNewProduct;
    }
}