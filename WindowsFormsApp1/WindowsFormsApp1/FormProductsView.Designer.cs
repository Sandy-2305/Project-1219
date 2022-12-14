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
            this.btnListMode = new System.Windows.Forms.Button();
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
            this.listViewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(541, 605);
            this.listViewProduct.TabIndex = 1;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.ItemActivate += new System.EventHandler(this.listViewProduct_ItemActivate);
     
            // 
            // btnPicMode
            // 
            this.btnPicMode.BackColor = System.Drawing.Color.Maroon;
            this.btnPicMode.FlatAppearance.BorderSize = 0;
            this.btnPicMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicMode.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPicMode.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnPicMode.Location = new System.Drawing.Point(2, 127);
            this.btnPicMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPicMode.Name = "btnPicMode";
            this.btnPicMode.Size = new System.Drawing.Size(177, 46);
            this.btnPicMode.TabIndex = 3;
            this.btnPicMode.Text = "圖片模式";
            this.btnPicMode.UseVisualStyleBackColor = false;
            this.btnPicMode.Click += new System.EventHandler(this.btnPicMode_Click);
            // 
            // btnListMode
            // 
            this.btnListMode.BackColor = System.Drawing.Color.Maroon;
            this.btnListMode.FlatAppearance.BorderSize = 0;
            this.btnListMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMode.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnListMode.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnListMode.Location = new System.Drawing.Point(2, 177);
            this.btnListMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListMode.Name = "btnListMode";
            this.btnListMode.Size = new System.Drawing.Size(177, 46);
            this.btnListMode.TabIndex = 4;
            this.btnListMode.Text = "列表模式";
            this.btnListMode.UseVisualStyleBackColor = false;
            this.btnListMode.Click += new System.EventHandler(this.btnListMode_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Maroon;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReload.Location = new System.Drawing.Point(2, 227);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(177, 46);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "重新載入";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.Maroon;
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewProduct.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnNewProduct.Location = new System.Drawing.Point(2, 277);
            this.btnNewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(177, 46);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 605);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.btnNewProduct);
            this.panel2.Controls.Add(this.btnListMode);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnPicMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(541, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 605);
            this.panel2.TabIndex = 8;
            // 
            // imageListProduct
            // 
            this.imageListProduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListProduct.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListProduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(727, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnListMode;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageListProduct;
    }
}