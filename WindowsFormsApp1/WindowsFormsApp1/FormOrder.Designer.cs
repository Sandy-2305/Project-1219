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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddInList = new System.Windows.Forms.Button();
            this.checkBox購物袋 = new System.Windows.Forms.CheckBox();
            this.GB內用和外帶 = new System.Windows.Forms.GroupBox();
            this.radioButton外帶 = new System.Windows.Forms.RadioButton();
            this.radioButton內用 = new System.Windows.Forms.RadioButton();
            this.GB配料 = new System.Windows.Forms.GroupBox();
            this.checkBox椰果 = new System.Windows.Forms.CheckBox();
            this.checkBoxQQ = new System.Windows.Forms.CheckBox();
            this.checkBox蒟蒻 = new System.Windows.Forms.CheckBox();
            this.checkBox芋圓 = new System.Windows.Forms.CheckBox();
            this.checkBox波霸 = new System.Windows.Forms.CheckBox();
            this.checkBox珍珠 = new System.Windows.Forms.CheckBox();
            this.comboBox冰塊 = new System.Windows.Forms.ComboBox();
            this.comboBox甜度 = new System.Windows.Forms.ComboBox();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt杯數 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.GB內用和外帶.SuspendLayout();
            this.GB配料.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.checkBox購物袋);
            this.panel1.Controls.Add(this.GB內用和外帶);
            this.panel1.Controls.Add(this.GB配料);
            this.panel1.Controls.Add(this.comboBox冰塊);
            this.panel1.Controls.Add(this.comboBox甜度);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt杯數);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 1108);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(141, 310);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 316);
            this.listBox1.TabIndex = 64;
            // 
            // btnAddInList
            // 
            this.btnAddInList.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddInList.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddInList.FlatAppearance.BorderSize = 0;
            this.btnAddInList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInList.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddInList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddInList.Location = new System.Drawing.Point(654, 0);
            this.btnAddInList.Name = "btnAddInList";
            this.btnAddInList.Size = new System.Drawing.Size(369, 92);
            this.btnAddInList.TabIndex = 63;
            this.btnAddInList.Text = "加入購物車";
            this.btnAddInList.UseVisualStyleBackColor = false;
            // 
            // checkBox購物袋
            // 
            this.checkBox購物袋.AutoSize = true;
            this.checkBox購物袋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox購物袋.Location = new System.Drawing.Point(405, 786);
            this.checkBox購物袋.Name = "checkBox購物袋";
            this.checkBox購物袋.Size = new System.Drawing.Size(305, 44);
            this.checkBox購物袋.TabIndex = 62;
            this.checkBox購物袋.Text = "是否需要送禮包裝";
            this.checkBox購物袋.UseVisualStyleBackColor = true;
            // 
            // GB內用和外帶
            // 
            this.GB內用和外帶.BackColor = System.Drawing.Color.MintCream;
            this.GB內用和外帶.Controls.Add(this.radioButton外帶);
            this.GB內用和外帶.Controls.Add(this.radioButton內用);
            this.GB內用和外帶.Location = new System.Drawing.Point(664, 160);
            this.GB內用和外帶.Name = "GB內用和外帶";
            this.GB內用和外帶.Size = new System.Drawing.Size(412, 93);
            this.GB內用和外帶.TabIndex = 61;
            this.GB內用和外帶.TabStop = false;
            this.GB內用和外帶.Text = "內用或外帶";
            // 
            // radioButton外帶
            // 
            this.radioButton外帶.AutoSize = true;
            this.radioButton外帶.Location = new System.Drawing.Point(190, 43);
            this.radioButton外帶.Name = "radioButton外帶";
            this.radioButton外帶.Size = new System.Drawing.Size(89, 28);
            this.radioButton外帶.TabIndex = 1;
            this.radioButton外帶.TabStop = true;
            this.radioButton外帶.Text = "外帶";
            this.radioButton外帶.UseVisualStyleBackColor = true;
            // 
            // radioButton內用
            // 
            this.radioButton內用.AutoSize = true;
            this.radioButton內用.Location = new System.Drawing.Point(70, 43);
            this.radioButton內用.Name = "radioButton內用";
            this.radioButton內用.Size = new System.Drawing.Size(89, 28);
            this.radioButton內用.TabIndex = 0;
            this.radioButton內用.TabStop = true;
            this.radioButton內用.Text = "內用";
            this.radioButton內用.UseVisualStyleBackColor = true;
            // 
            // GB配料
            // 
            this.GB配料.BackColor = System.Drawing.Color.MintCream;
            this.GB配料.Controls.Add(this.checkBox椰果);
            this.GB配料.Controls.Add(this.checkBoxQQ);
            this.GB配料.Controls.Add(this.checkBox蒟蒻);
            this.GB配料.Controls.Add(this.checkBox芋圓);
            this.GB配料.Controls.Add(this.checkBox波霸);
            this.GB配料.Controls.Add(this.checkBox珍珠);
            this.GB配料.Location = new System.Drawing.Point(804, 455);
            this.GB配料.Name = "GB配料";
            this.GB配料.Size = new System.Drawing.Size(272, 375);
            this.GB配料.TabIndex = 60;
            this.GB配料.TabStop = false;
            this.GB配料.Text = "一種十元";
            // 
            // checkBox椰果
            // 
            this.checkBox椰果.AutoSize = true;
            this.checkBox椰果.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox椰果.Location = new System.Drawing.Point(65, 296);
            this.checkBox椰果.Name = "checkBox椰果";
            this.checkBox椰果.Size = new System.Drawing.Size(107, 41);
            this.checkBox椰果.TabIndex = 5;
            this.checkBox椰果.Text = "椰果";
            this.checkBox椰果.UseVisualStyleBackColor = true;
            // 
            // checkBoxQQ
            // 
            this.checkBoxQQ.AutoSize = true;
            this.checkBoxQQ.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxQQ.Location = new System.Drawing.Point(65, 247);
            this.checkBoxQQ.Name = "checkBoxQQ";
            this.checkBoxQQ.Size = new System.Drawing.Size(97, 41);
            this.checkBoxQQ.TabIndex = 4;
            this.checkBoxQQ.Text = "QQ";
            this.checkBoxQQ.UseVisualStyleBackColor = true;
            // 
            // checkBox蒟蒻
            // 
            this.checkBox蒟蒻.AutoSize = true;
            this.checkBox蒟蒻.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox蒟蒻.Location = new System.Drawing.Point(65, 198);
            this.checkBox蒟蒻.Name = "checkBox蒟蒻";
            this.checkBox蒟蒻.Size = new System.Drawing.Size(107, 41);
            this.checkBox蒟蒻.TabIndex = 3;
            this.checkBox蒟蒻.Tag = "";
            this.checkBox蒟蒻.Text = "蒟蒻";
            this.checkBox蒟蒻.UseVisualStyleBackColor = true;
            // 
            // checkBox芋圓
            // 
            this.checkBox芋圓.AutoSize = true;
            this.checkBox芋圓.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox芋圓.Location = new System.Drawing.Point(65, 149);
            this.checkBox芋圓.Name = "checkBox芋圓";
            this.checkBox芋圓.Size = new System.Drawing.Size(107, 41);
            this.checkBox芋圓.TabIndex = 2;
            this.checkBox芋圓.Text = "芋圓";
            this.checkBox芋圓.UseVisualStyleBackColor = true;
            // 
            // checkBox波霸
            // 
            this.checkBox波霸.AutoSize = true;
            this.checkBox波霸.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox波霸.Location = new System.Drawing.Point(65, 100);
            this.checkBox波霸.Name = "checkBox波霸";
            this.checkBox波霸.Size = new System.Drawing.Size(107, 41);
            this.checkBox波霸.TabIndex = 1;
            this.checkBox波霸.Text = "波霸";
            this.checkBox波霸.UseVisualStyleBackColor = true;
            // 
            // checkBox珍珠
            // 
            this.checkBox珍珠.AutoSize = true;
            this.checkBox珍珠.Font = new System.Drawing.Font("微軟正黑體", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox珍珠.Location = new System.Drawing.Point(65, 51);
            this.checkBox珍珠.Name = "checkBox珍珠";
            this.checkBox珍珠.Size = new System.Drawing.Size(107, 41);
            this.checkBox珍珠.TabIndex = 0;
            this.checkBox珍珠.Text = "珍珠";
            this.checkBox珍珠.UseVisualStyleBackColor = true;
            // 
            // comboBox冰塊
            // 
            this.comboBox冰塊.FormattingEnabled = true;
            this.comboBox冰塊.Location = new System.Drawing.Point(819, 367);
            this.comboBox冰塊.Name = "comboBox冰塊";
            this.comboBox冰塊.Size = new System.Drawing.Size(180, 32);
            this.comboBox冰塊.TabIndex = 59;
            // 
            // comboBox甜度
            // 
            this.comboBox甜度.FormattingEnabled = true;
            this.comboBox甜度.Location = new System.Drawing.Point(819, 279);
            this.comboBox甜度.Name = "comboBox甜度";
            this.comboBox甜度.Size = new System.Drawing.Size(180, 32);
            this.comboBox甜度.TabIndex = 58;
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.OldLace;
            this.lbl單價.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl單價.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.ForeColor = System.Drawing.Color.Black;
            this.lbl單價.Location = new System.Drawing.Point(108, 0);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(144, 40);
            this.lbl單價.TabIndex = 56;
            this.lbl單價.Text = "00000元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(410, 663);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 40);
            this.label10.TabIndex = 55;
            this.label10.Text = "杯";
            // 
            // txt杯數
            // 
            this.txt杯數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt杯數.Location = new System.Drawing.Point(295, 658);
            this.txt杯數.Name = "txt杯數";
            this.txt杯數.Size = new System.Drawing.Size(100, 50);
            this.txt杯數.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(717, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 40);
            this.label9.TabIndex = 52;
            this.label9.Text = "甜度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(717, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 40);
            this.label8.TabIndex = 51;
            this.label8.Text = "冰塊";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(717, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 40);
            this.label7.TabIndex = 50;
            this.label7.Text = "配料";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 40);
            this.label5.TabIndex = 48;
            this.label5.Text = "價錢：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(198, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 46;
            this.label4.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(134, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 45;
            this.label3.Text = "飲料品項";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.OldLace;
            this.lblCustomer.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Brown;
            this.lblCustomer.Location = new System.Drawing.Point(98, 123);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(196, 55);
            this.lblCustomer.TabIndex = 44;
            this.lblCustomer.Text = "顧客姓名";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 1108);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 100);
            this.panel3.TabIndex = 65;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 908);
            this.panel4.TabIndex = 66;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1008);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1215, 100);
            this.panel5.TabIndex = 67;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1119, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(96, 908);
            this.panel6.TabIndex = 68;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btnAddInList);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(96, 916);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1023, 92);
            this.panel7.TabIndex = 69;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbl單價);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(26, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 49);
            this.panel8.TabIndex = 70;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(2001, 1108);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrder";
            this.Text = "商品訂購";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GB內用和外帶.ResumeLayout(false);
            this.GB內用和外帶.PerformLayout();
            this.GB配料.ResumeLayout(false);
            this.GB配料.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddInList;
        private System.Windows.Forms.CheckBox checkBox購物袋;
        private System.Windows.Forms.GroupBox GB內用和外帶;
        private System.Windows.Forms.RadioButton radioButton外帶;
        private System.Windows.Forms.RadioButton radioButton內用;
        private System.Windows.Forms.GroupBox GB配料;
        private System.Windows.Forms.CheckBox checkBox椰果;
        private System.Windows.Forms.CheckBox checkBoxQQ;
        private System.Windows.Forms.CheckBox checkBox蒟蒻;
        private System.Windows.Forms.CheckBox checkBox芋圓;
        private System.Windows.Forms.CheckBox checkBox波霸;
        private System.Windows.Forms.CheckBox checkBox珍珠;
        private System.Windows.Forms.ComboBox comboBox冰塊;
        private System.Windows.Forms.ComboBox comboBox甜度;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt杯數;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}