namespace WindowsFormsApp1
{
    partial class FormOrder
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
            this.radioButtonForHere = new System.Windows.Forms.RadioButton();
            this.radioButtonTakeOut = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cBoxProductType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxSweet = new System.Windows.Forms.ComboBox();
            this.cBoxIce = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxBag = new System.Windows.Forms.CheckBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonForHere
            // 
            this.radioButtonForHere.AutoSize = true;
            this.radioButtonForHere.Location = new System.Drawing.Point(107, 30);
            this.radioButtonForHere.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonForHere.Name = "radioButtonForHere";
            this.radioButtonForHere.Size = new System.Drawing.Size(90, 39);
            this.radioButtonForHere.TabIndex = 0;
            this.radioButtonForHere.TabStop = true;
            this.radioButtonForHere.Text = "內用";
            this.radioButtonForHere.UseVisualStyleBackColor = true;
            this.radioButtonForHere.CheckedChanged += new System.EventHandler(this.radioButtonForHere_CheckedChanged);
            // 
            // radioButtonTakeOut
            // 
            this.radioButtonTakeOut.AutoSize = true;
            this.radioButtonTakeOut.Location = new System.Drawing.Point(255, 30);
            this.radioButtonTakeOut.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTakeOut.Name = "radioButtonTakeOut";
            this.radioButtonTakeOut.Size = new System.Drawing.Size(90, 39);
            this.radioButtonTakeOut.TabIndex = 1;
            this.radioButtonTakeOut.TabStop = true;
            this.radioButtonTakeOut.Text = "外帶";
            this.radioButtonTakeOut.UseVisualStyleBackColor = true;
            this.radioButtonTakeOut.CheckedChanged += new System.EventHandler(this.radioButtonTakeOut_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(899, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 790);
            this.panel2.TabIndex = 45;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Wheat;
            this.panel9.Controls.Add(this.lblCustomer);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(899, 61);
            this.panel9.TabIndex = 70;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Wheat;
            this.lblCustomer.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Brown;
            this.lblCustomer.Location = new System.Drawing.Point(43, 9);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(123, 35);
            this.lblCustomer.TabIndex = 44;
            this.lblCustomer.Text = "顧客姓名";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 23);
            this.panel3.TabIndex = 65;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel8);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 84);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(459, 706);
            this.panel11.TabIndex = 71;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel14.Controls.Add(this.label1);
            this.panel14.Controls.Add(this.cBoxProductType);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(459, 69);
            this.panel14.TabIndex = 74;
            // 
            // cBoxProductType
            // 
            this.cBoxProductType.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxProductType.FormattingEnabled = true;
            this.cBoxProductType.Location = new System.Drawing.Point(334, 11);
            this.cBoxProductType.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxProductType.Name = "cBoxProductType";
            this.cBoxProductType.Size = new System.Drawing.Size(80, 43);
            this.cBoxProductType.TabIndex = 72;
            this.cBoxProductType.SelectedIndexChanged += new System.EventHandler(this.cBoxProductType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 35);
            this.label1.TabIndex = 73;
            this.label1.Text = "請先選擇餐點種類：";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.OldLace;
            this.panel13.Controls.Add(this.listBox1);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.textBoxAmount);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 69);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(459, 380);
            this.panel13.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(43, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 35);
            this.label3.TabIndex = 72;
            this.label3.Text = "品項：";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxAmount.Location = new System.Drawing.Point(302, 306);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(122, 43);
            this.textBoxAmount.TabIndex = 49;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(43, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 35);
            this.label2.TabIndex = 48;
            this.label2.Text = "請輸入購買數量：";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(49, 66);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 224);
            this.listBox1.TabIndex = 87;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OldLace;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cBoxSweet);
            this.panel4.Controls.Add(this.cBoxIce);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 146);
            this.panel4.TabIndex = 0;
            this.panel4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(249, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 31);
            this.label8.TabIndex = 83;
            this.label8.Text = "冰塊";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(89, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 31);
            this.label9.TabIndex = 84;
            this.label9.Text = "甜度";
            // 
            // cBoxSweet
            // 
            this.cBoxSweet.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxSweet.FormattingEnabled = true;
            this.cBoxSweet.Location = new System.Drawing.Point(155, 77);
            this.cBoxSweet.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxSweet.Name = "cBoxSweet";
            this.cBoxSweet.Size = new System.Drawing.Size(75, 37);
            this.cBoxSweet.TabIndex = 85;
            this.cBoxSweet.SelectedIndexChanged += new System.EventHandler(this.cBoxSweet_SelectedIndexChanged);
            // 
            // cBoxIce
            // 
            this.cBoxIce.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxIce.FormattingEnabled = true;
            this.cBoxIce.Location = new System.Drawing.Point(312, 77);
            this.cBoxIce.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxIce.Name = "cBoxIce";
            this.cBoxIce.Size = new System.Drawing.Size(75, 37);
            this.cBoxIce.TabIndex = 86;
            this.cBoxIce.SelectedIndexChanged += new System.EventHandler(this.cBoxIce_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 82;
            this.label4.Text = "客製化選項：";
            // 
            // checkBoxBag
            // 
            this.checkBoxBag.AutoSize = true;
            this.checkBoxBag.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxBag.Location = new System.Drawing.Point(120, 43);
            this.checkBoxBag.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBag.Name = "checkBoxBag";
            this.checkBoxBag.Size = new System.Drawing.Size(204, 35);
            this.checkBoxBag.TabIndex = 78;
            this.checkBoxBag.Text = "是否需要購物袋";
            this.checkBoxBag.UseVisualStyleBackColor = true;
            this.checkBoxBag.CheckedChanged += new System.EventHandler(this.checkBoxBag_CheckedChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuy.Location = new System.Drawing.Point(459, 564);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(440, 83);
            this.btnBuy.TabIndex = 63;
            this.btnBuy.Text = "確認購買";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.ForeColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 790);
            this.panel1.TabIndex = 44;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(459, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 69);
            this.panel5.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 80;
            this.label5.Text = "內用或外帶";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.OldLace;
            this.panel6.Controls.Add(this.radioButtonTakeOut);
            this.panel6.Controls.Add(this.radioButtonForHere);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold);
            this.panel6.Location = new System.Drawing.Point(459, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 91);
            this.panel6.TabIndex = 80;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.OldLace;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.checkBoxBag);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(459, 390);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(440, 174);
            this.panel7.TabIndex = 81;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.OldLace;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.lblPrice);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel8.Location = new System.Drawing.Point(0, 449);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(459, 114);
            this.panel8.TabIndex = 82;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(177, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 36);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "00000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(43, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "總金額：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(148, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "( 購物袋2元 )";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.OldLace;
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(459, 244);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(440, 146);
            this.panel10.TabIndex = 83;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1488, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrder";
            this.Text = "商品訂購";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonTakeOut;
        private System.Windows.Forms.RadioButton radioButtonForHere;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxProductType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxSweet;
        private System.Windows.Forms.ComboBox cBoxIce;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.CheckBox checkBoxBag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
    }
}