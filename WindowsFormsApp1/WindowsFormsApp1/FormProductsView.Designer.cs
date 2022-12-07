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
            this.components = new System.ComponentModel.Container();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.btnPicMode = new System.Windows.Forms.Button();
            this.btnLstMode = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageListProduct = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProduct
            // 
            this.listViewProduct.BackColor = System.Drawing.Color.OldLace;
            this.listViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(0, 0);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(879, 968);
            this.listViewProduct.TabIndex = 1;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.ItemActivate += new System.EventHandler(this.listViewProduct_ItemActivate);
            this.listViewProduct.SelectedIndexChanged += new System.EventHandler(this.listViewProduct_SelectedIndexChanged);
            // 
            // btnPicMode
            // 
            this.btnPicMode.BackColor = System.Drawing.Color.Maroon;
            this.btnPicMode.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPicMode.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnPicMode.Location = new System.Drawing.Point(3, 203);
            this.btnPicMode.Name = "btnPicMode";
            this.btnPicMode.Size = new System.Drawing.Size(288, 74);
            this.btnPicMode.TabIndex = 3;
            this.btnPicMode.Text = "圖片模式";
            this.btnPicMode.UseVisualStyleBackColor = false;
            this.btnPicMode.Click += new System.EventHandler(this.btnPicMode_Click);
            // 
            // btnLstMode
            // 
            this.btnLstMode.BackColor = System.Drawing.Color.Maroon;
            this.btnLstMode.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLstMode.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnLstMode.Location = new System.Drawing.Point(3, 283);
            this.btnLstMode.Name = "btnLstMode";
            this.btnLstMode.Size = new System.Drawing.Size(288, 74);
            this.btnLstMode.TabIndex = 4;
            this.btnLstMode.Text = "列表模式";
            this.btnLstMode.UseVisualStyleBackColor = false;
            this.btnLstMode.Click += new System.EventHandler(this.btnLstMode_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Maroon;
            this.btnReload.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReload.Location = new System.Drawing.Point(3, 363);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(288, 74);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "重新載入";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.Maroon;
            this.btnNewProduct.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewProduct.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnNewProduct.Location = new System.Drawing.Point(3, 443);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(288, 74);
            this.btnNewProduct.TabIndex = 6;
            this.btnNewProduct.Text = "新增商品";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 968);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewProduct);
            this.panel2.Controls.Add(this.btnLstMode);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnPicMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(879, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 968);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // imageListProduct
            // 
            this.imageListProduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListProduct.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListProduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1182, 968);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormProductsView";
            this.Text = "商品展示";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormProductsView_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.Button btnPicMode;
        private System.Windows.Forms.Button btnLstMode;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageListProduct;
    }
}