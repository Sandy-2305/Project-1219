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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button訂購 = new System.Windows.Forms.Button();
            this.checkBox購物袋 = new System.Windows.Forms.CheckBox();
            this.GB內用和外帶 = new System.Windows.Forms.GroupBox();
            this.radioButton外帶 = new System.Windows.Forms.RadioButton();
            this.radioButton內用 = new System.Windows.Forms.RadioButton();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.GB配料 = new System.Windows.Forms.GroupBox();
            this.checkBox椰果 = new System.Windows.Forms.CheckBox();
            this.checkBoxQQ = new System.Windows.Forms.CheckBox();
            this.checkBox蒟蒻 = new System.Windows.Forms.CheckBox();
            this.checkBox芋圓 = new System.Windows.Forms.CheckBox();
            this.checkBox波霸 = new System.Windows.Forms.CheckBox();
            this.checkBox珍珠 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox冰塊 = new System.Windows.Forms.ComboBox();
            this.comboBox甜度 = new System.Windows.Forms.ComboBox();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt杯數 = new System.Windows.Forms.TextBox();
            this.txt訂購人電話 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GB內用和外帶.SuspendLayout();
            this.GB配料.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(98, 275);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 316);
            this.listBox1.TabIndex = 43;
            // 
            // button訂購
            // 
            this.button訂購.BackColor = System.Drawing.Color.LightBlue;
            this.button訂購.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button訂購.Location = new System.Drawing.Point(621, 911);
            this.button訂購.Name = "button訂購";
            this.button訂購.Size = new System.Drawing.Size(433, 106);
            this.button訂購.TabIndex = 42;
            this.button訂購.Text = "訂購";
            this.button訂購.UseVisualStyleBackColor = false;
            // 
            // checkBox購物袋
            // 
            this.checkBox購物袋.AutoSize = true;
            this.checkBox購物袋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox購物袋.Location = new System.Drawing.Point(428, 812);
            this.checkBox購物袋.Name = "checkBox購物袋";
            this.checkBox購物袋.Size = new System.Drawing.Size(305, 44);
            this.checkBox購物袋.TabIndex = 41;
            this.checkBox購物袋.Text = "是否需要送禮包裝";
            this.checkBox購物袋.UseVisualStyleBackColor = true;
            // 
            // GB內用和外帶
            // 
            this.GB內用和外帶.BackColor = System.Drawing.Color.MintCream;
            this.GB內用和外帶.Controls.Add(this.radioButton外帶);
            this.GB內用和外帶.Controls.Add(this.radioButton內用);
            this.GB內用和外帶.Location = new System.Drawing.Point(621, 125);
            this.GB內用和外帶.Name = "GB內用和外帶";
            this.GB內用和外帶.Size = new System.Drawing.Size(412, 93);
            this.GB內用和外帶.TabIndex = 40;
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
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.Location = new System.Drawing.Point(245, 880);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(144, 40);
            this.lbl總價.TabIndex = 36;
            this.lbl總價.Text = "00000元";
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
            this.GB配料.Location = new System.Drawing.Point(761, 420);
            this.GB配料.Name = "GB配料";
            this.GB配料.Size = new System.Drawing.Size(272, 375);
            this.GB配料.TabIndex = 39;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(245, 825);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 40);
            this.label6.TabIndex = 28;
            this.label6.Text = "品項總價";
            // 
            // comboBox冰塊
            // 
            this.comboBox冰塊.FormattingEnabled = true;
            this.comboBox冰塊.Location = new System.Drawing.Point(776, 332);
            this.comboBox冰塊.Name = "comboBox冰塊";
            this.comboBox冰塊.Size = new System.Drawing.Size(180, 32);
            this.comboBox冰塊.TabIndex = 38;
            // 
            // comboBox甜度
            // 
            this.comboBox甜度.FormattingEnabled = true;
            this.comboBox甜度.Location = new System.Drawing.Point(776, 244);
            this.comboBox甜度.Name = "comboBox甜度";
            this.comboBox甜度.Size = new System.Drawing.Size(180, 32);
            this.comboBox甜度.TabIndex = 37;
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(75, 880);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(144, 40);
            this.lbl單價.TabIndex = 35;
            this.lbl單價.Text = "00000元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(367, 628);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 40);
            this.label10.TabIndex = 34;
            this.label10.Text = "杯";
            // 
            // txt杯數
            // 
            this.txt杯數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt杯數.Location = new System.Drawing.Point(252, 623);
            this.txt杯數.Name = "txt杯數";
            this.txt杯數.Size = new System.Drawing.Size(100, 50);
            this.txt杯數.TabIndex = 33;
            // 
            // txt訂購人電話
            // 
            this.txt訂購人電話.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人電話.Location = new System.Drawing.Point(98, 168);
            this.txt訂購人電話.Name = "txt訂購人電話";
            this.txt訂購人電話.Size = new System.Drawing.Size(429, 50);
            this.txt訂購人電話.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(674, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 40);
            this.label9.TabIndex = 31;
            this.label9.Text = "甜度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(674, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 40);
            this.label8.TabIndex = 30;
            this.label8.Text = "冰塊";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(674, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 40);
            this.label7.TabIndex = 29;
            this.label7.Text = "配料";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(107, 825);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 40);
            this.label5.TabIndex = 27;
            this.label5.Text = "單價";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(338, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 75);
            this.label1.TabIndex = 26;
            this.label1.Text = "訂購單MENU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(155, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 25;
            this.label4.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(91, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 24;
            this.label3.Text = "飲料品項";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(91, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 40);
            this.label2.TabIndex = 23;
            this.label2.Text = "訂購人 (電話)";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 1108);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button訂購);
            this.Controls.Add(this.checkBox購物袋);
            this.Controls.Add(this.GB內用和外帶);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.GB配料);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox冰塊);
            this.Controls.Add(this.comboBox甜度);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt杯數);
            this.Controls.Add(this.txt訂購人電話);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormOrder";
            this.Text = "商品訂購";
            this.GB內用和外帶.ResumeLayout(false);
            this.GB內用和外帶.PerformLayout();
            this.GB配料.ResumeLayout(false);
            this.GB配料.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button訂購;
        private System.Windows.Forms.CheckBox checkBox購物袋;
        private System.Windows.Forms.GroupBox GB內用和外帶;
        private System.Windows.Forms.RadioButton radioButton外帶;
        private System.Windows.Forms.RadioButton radioButton內用;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.GroupBox GB配料;
        private System.Windows.Forms.CheckBox checkBox椰果;
        private System.Windows.Forms.CheckBox checkBoxQQ;
        private System.Windows.Forms.CheckBox checkBox蒟蒻;
        private System.Windows.Forms.CheckBox checkBox芋圓;
        private System.Windows.Forms.CheckBox checkBox波霸;
        private System.Windows.Forms.CheckBox checkBox珍珠;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox冰塊;
        private System.Windows.Forms.ComboBox comboBox甜度;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt杯數;
        private System.Windows.Forms.TextBox txt訂購人電話;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}