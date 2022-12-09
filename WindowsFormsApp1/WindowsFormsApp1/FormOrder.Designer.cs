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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.GBInOut = new System.Windows.Forms.GroupBox();
            this.radioButtonForHere = new System.Windows.Forms.RadioButton();
            this.radioButtonTakeOut = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cBoxIce = new System.Windows.Forms.ComboBox();
            this.cBoxSweet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxProductType = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.checkBoxBag = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel16.SuspendLayout();
            this.GBInOut.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.ForeColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 1356);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.GBInOut);
            this.panel16.Controls.Add(this.panel10);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(686, 165);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(529, 995);
            this.panel16.TabIndex = 73;
            // 
            // GBInOut
            // 
            this.GBInOut.BackColor = System.Drawing.Color.Wheat;
            this.GBInOut.Controls.Add(this.radioButtonForHere);
            this.GBInOut.Controls.Add(this.radioButtonTakeOut);
            this.GBInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBInOut.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GBInOut.ForeColor = System.Drawing.Color.Brown;
            this.GBInOut.Location = new System.Drawing.Point(0, 773);
            this.GBInOut.Name = "GBInOut";
            this.GBInOut.Size = new System.Drawing.Size(529, 222);
            this.GBInOut.TabIndex = 61;
            this.GBInOut.TabStop = false;
            this.GBInOut.Text = "內用或外帶";
            // 
            // radioButtonForHere
            // 
            this.radioButtonForHere.AutoSize = true;
            this.radioButtonForHere.Location = new System.Drawing.Point(188, 71);
            this.radioButtonForHere.Name = "radioButtonForHere";
            this.radioButtonForHere.Size = new System.Drawing.Size(112, 44);
            this.radioButtonForHere.TabIndex = 0;
            this.radioButtonForHere.TabStop = true;
            this.radioButtonForHere.Text = "內用";
            this.radioButtonForHere.UseVisualStyleBackColor = true;
            this.radioButtonForHere.CheckedChanged += new System.EventHandler(this.radioButtonForHere_CheckedChanged);
            // 
            // radioButtonTakeOut
            // 
            this.radioButtonTakeOut.AutoSize = true;
            this.radioButtonTakeOut.Location = new System.Drawing.Point(330, 71);
            this.radioButtonTakeOut.Name = "radioButtonTakeOut";
            this.radioButtonTakeOut.Size = new System.Drawing.Size(112, 44);
            this.radioButtonTakeOut.TabIndex = 1;
            this.radioButtonTakeOut.TabStop = true;
            this.radioButtonTakeOut.Text = "外帶";
            this.radioButtonTakeOut.UseVisualStyleBackColor = true;
            this.radioButtonTakeOut.CheckedChanged += new System.EventHandler(this.radioButtonTakeOut_CheckedChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cBoxIce);
            this.panel10.Controls.Add(this.cBoxSweet);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 100);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(529, 673);
            this.panel10.TabIndex = 80;
            // 
            // cBoxIce
            // 
            this.cBoxIce.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxIce.FormattingEnabled = true;
            this.cBoxIce.Location = new System.Drawing.Point(244, 176);
            this.cBoxIce.Name = "cBoxIce";
            this.cBoxIce.Size = new System.Drawing.Size(120, 55);
            this.cBoxIce.TabIndex = 81;
            // 
            // cBoxSweet
            // 
            this.cBoxSweet.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxSweet.FormattingEnabled = true;
            this.cBoxSweet.Location = new System.Drawing.Point(244, 78);
            this.cBoxSweet.Name = "cBoxSweet";
            this.cBoxSweet.Size = new System.Drawing.Size(120, 55);
            this.cBoxSweet.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(131, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 47);
            this.label9.TabIndex = 79;
            this.label9.Text = "甜度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(131, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 47);
            this.label8.TabIndex = 78;
            this.label8.Text = "冰塊";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label4);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(529, 100);
            this.panel17.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(33, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 40);
            this.label4.TabIndex = 74;
            this.label4.Text = "客製化選項：";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Wheat;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(665, 165);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(21, 995);
            this.panel15.TabIndex = 72;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(84, 165);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(581, 995);
            this.panel11.TabIndex = 71;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Wheat;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 773);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(581, 222);
            this.panel6.TabIndex = 74;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Wheat;
            this.panel8.Controls.Add(this.lblPrice);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel8.Location = new System.Drawing.Point(31, 22);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(298, 50);
            this.panel8.TabIndex = 70;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Wheat;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(131, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(167, 47);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.Text = "00000元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 47);
            this.label5.TabIndex = 48;
            this.label5.Text = "價錢：";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.listView1);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.textBoxAmount);
            this.panel13.Controls.Add(this.label3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 100);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(581, 673);
            this.panel13.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(24, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 40);
            this.label2.TabIndex = 48;
            this.label2.Text = "請輸入購買數量：";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(335, 485);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(195, 43);
            this.textBoxAmount.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 47);
            this.label3.TabIndex = 72;
            this.label3.Text = "品項：";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label1);
            this.panel14.Controls.Add(this.cBoxProductType);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(581, 100);
            this.panel14.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "請先選擇餐點種類：";
            // 
            // cBoxProductType
            // 
            this.cBoxProductType.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBoxProductType.FormattingEnabled = true;
            this.cBoxProductType.Location = new System.Drawing.Point(402, 34);
            this.cBoxProductType.Name = "cBoxProductType";
            this.cBoxProductType.Size = new System.Drawing.Size(128, 43);
            this.cBoxProductType.TabIndex = 72;
            this.cBoxProductType.SelectedIndexChanged += new System.EventHandler(this.cBoxProductType_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Wheat;
            this.panel9.Controls.Add(this.lblCustomer);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(84, 74);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1131, 91);
            this.panel9.TabIndex = 70;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Wheat;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomer.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Brown;
            this.lblCustomer.Location = new System.Drawing.Point(0, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(196, 55);
            this.lblCustomer.TabIndex = 44;
            this.lblCustomer.Text = "顧客姓名";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Wheat;
            this.panel7.Controls.Add(this.btnBuy);
            this.panel7.Controls.Add(this.checkBoxBag);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(84, 1160);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1131, 91);
            this.panel7.TabIndex = 69;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuy.Location = new System.Drawing.Point(762, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(369, 91);
            this.btnBuy.TabIndex = 63;
            this.btnBuy.Text = "確認購買";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // checkBoxBag
            // 
            this.checkBoxBag.AutoSize = true;
            this.checkBoxBag.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxBag.Location = new System.Drawing.Point(170, 24);
            this.checkBoxBag.Name = "checkBoxBag";
            this.checkBoxBag.Size = new System.Drawing.Size(311, 51);
            this.checkBoxBag.TabIndex = 78;
            this.checkBoxBag.Text = "是否需要購物袋";
            this.checkBoxBag.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 1177);
            this.panel4.TabIndex = 66;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1215, 105);
            this.panel5.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 74);
            this.panel3.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 1356);
            this.panel2.TabIndex = 45;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(499, 360);
            this.listView1.TabIndex = 73;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1271, 1356);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrder";
            this.Text = "商品訂購";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.GBInOut.ResumeLayout(false);
            this.GBInOut.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox GBInOut;
        private System.Windows.Forms.RadioButton radioButtonTakeOut;
        private System.Windows.Forms.RadioButton radioButtonForHere;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxProductType;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxBag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cBoxIce;
        private System.Windows.Forms.ComboBox cBoxSweet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listView1;
    }
}