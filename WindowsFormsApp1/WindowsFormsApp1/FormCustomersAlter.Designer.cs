namespace WindowsFormsApp1
{
    partial class FormCustomersAlter
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
            this.btnRM = new System.Windows.Forms.Button();
            this.listBox搜尋結果 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBoxFilter欄位名稱 = new System.Windows.Forms.ComboBox();
            this.txtFind關鍵字 = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cboBoxFind欄位名稱 = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter關鍵字 = new System.Windows.Forms.TextBox();
            this.lbl筆數資訊 = new System.Windows.Forms.Label();
            this.btn儲存 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn回復資料 = new System.Windows.Forms.Button();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn最後一筆 = new System.Windows.Forms.Button();
            this.btn下一筆 = new System.Windows.Forms.Button();
            this.btn上一筆 = new System.Windows.Forms.Button();
            this.btn第一筆 = new System.Windows.Forms.Button();
            this.txt會員點數 = new System.Windows.Forms.TextBox();
            this.chk婚姻狀態 = new System.Windows.Forms.CheckBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRM
            // 
            this.btnRM.Location = new System.Drawing.Point(1500, 564);
            this.btnRM.Margin = new System.Windows.Forms.Padding(6);
            this.btnRM.Name = "btnRM";
            this.btnRM.Size = new System.Drawing.Size(162, 104);
            this.btnRM.TabIndex = 60;
            this.btnRM.Text = "移除Filter";
            this.btnRM.UseVisualStyleBackColor = true;
            // 
            // listBox搜尋結果
            // 
            this.listBox搜尋結果.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox搜尋結果.DisplayMember = "姓名";
            this.listBox搜尋結果.FormattingEnabled = true;
            this.listBox搜尋結果.ItemHeight = 24;
            this.listBox搜尋結果.Location = new System.Drawing.Point(778, 214);
            this.listBox搜尋結果.Margin = new System.Windows.Forms.Padding(6);
            this.listBox搜尋結果.Name = "listBox搜尋結果";
            this.listBox搜尋結果.Size = new System.Drawing.Size(676, 292);
            this.listBox搜尋結果.TabIndex = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cboBoxFilter欄位名稱);
            this.groupBox1.Controls.Add(this.txtFind關鍵字);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.cboBoxFind欄位名稱);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtFilter關鍵字);
            this.groupBox1.Location = new System.Drawing.Point(778, 522);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(680, 168);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋功能";
            // 
            // cboBoxFilter欄位名稱
            // 
            this.cboBoxFilter欄位名稱.FormattingEnabled = true;
            this.cboBoxFilter欄位名稱.Location = new System.Drawing.Point(386, 104);
            this.cboBoxFilter欄位名稱.Margin = new System.Windows.Forms.Padding(6);
            this.cboBoxFilter欄位名稱.Name = "cboBoxFilter欄位名稱";
            this.cboBoxFilter欄位名稱.Size = new System.Drawing.Size(86, 32);
            this.cboBoxFilter欄位名稱.TabIndex = 5;
            // 
            // txtFind關鍵字
            // 
            this.txtFind關鍵字.Location = new System.Drawing.Point(13, 42);
            this.txtFind關鍵字.Margin = new System.Windows.Forms.Padding(6);
            this.txtFind關鍵字.Name = "txtFind關鍵字";
            this.txtFind關鍵字.Size = new System.Drawing.Size(355, 36);
            this.txtFind關鍵字.TabIndex = 4;
            this.txtFind關鍵字.Text = "請輸入關鍵字";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(490, 34);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(162, 46);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // cboBoxFind欄位名稱
            // 
            this.cboBoxFind欄位名稱.FormattingEnabled = true;
            this.cboBoxFind欄位名稱.Location = new System.Drawing.Point(386, 42);
            this.cboBoxFind欄位名稱.Margin = new System.Windows.Forms.Padding(6);
            this.cboBoxFind欄位名稱.Name = "cboBoxFind欄位名稱";
            this.cboBoxFind欄位名稱.Size = new System.Drawing.Size(86, 32);
            this.cboBoxFind欄位名稱.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(490, 100);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(162, 46);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // txtFilter關鍵字
            // 
            this.txtFilter關鍵字.Location = new System.Drawing.Point(13, 100);
            this.txtFilter關鍵字.Margin = new System.Windows.Forms.Padding(6);
            this.txtFilter關鍵字.Name = "txtFilter關鍵字";
            this.txtFilter關鍵字.Size = new System.Drawing.Size(355, 36);
            this.txtFilter關鍵字.TabIndex = 0;
            this.txtFilter關鍵字.Text = "請輸入關鍵字";
            // 
            // lbl筆數資訊
            // 
            this.lbl筆數資訊.AutoSize = true;
            this.lbl筆數資訊.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl筆數資訊.Location = new System.Drawing.Point(854, 780);
            this.lbl筆數資訊.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl筆數資訊.Name = "lbl筆數資訊";
            this.lbl筆數資訊.Size = new System.Drawing.Size(169, 30);
            this.lbl筆數資訊.TabIndex = 57;
            this.lbl筆數資訊.Text = "第0筆/共0筆";
            // 
            // btn儲存
            // 
            this.btn儲存.BackColor = System.Drawing.Color.YellowGreen;
            this.btn儲存.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存.Location = new System.Drawing.Point(1270, 762);
            this.btn儲存.Margin = new System.Windows.Forms.Padding(6);
            this.btn儲存.Name = "btn儲存";
            this.btn儲存.Size = new System.Drawing.Size(162, 46);
            this.btn儲存.TabIndex = 56;
            this.btn儲存.Text = "儲存";
            this.btn儲存.UseVisualStyleBackColor = false;
            // 
            // btn新增
            // 
            this.btn新增.BackColor = System.Drawing.Color.YellowGreen;
            this.btn新增.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(1092, 762);
            this.btn新增.Margin = new System.Windows.Forms.Padding(6);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(162, 46);
            this.btn新增.TabIndex = 55;
            this.btn新增.Text = "新增";
            this.btn新增.UseVisualStyleBackColor = false;
            // 
            // btn回復資料
            // 
            this.btn回復資料.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn回復資料.Location = new System.Drawing.Point(401, 820);
            this.btn回復資料.Margin = new System.Windows.Forms.Padding(6);
            this.btn回復資料.Name = "btn回復資料";
            this.btn回復資料.Size = new System.Drawing.Size(162, 46);
            this.btn回復資料.TabIndex = 54;
            this.btn回復資料.Text = "回復資料";
            this.btn回復資料.UseVisualStyleBackColor = true;
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(223, 822);
            this.btn刪除.Margin = new System.Windows.Forms.Padding(6);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(162, 46);
            this.btn刪除.TabIndex = 53;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.Location = new System.Drawing.Point(48, 824);
            this.btn儲存修改.Margin = new System.Windows.Forms.Padding(6);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(162, 46);
            this.btn儲存修改.TabIndex = 52;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = true;
            // 
            // btn最後一筆
            // 
            this.btn最後一筆.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn最後一筆.Location = new System.Drawing.Point(579, 764);
            this.btn最後一筆.Margin = new System.Windows.Forms.Padding(6);
            this.btn最後一筆.Name = "btn最後一筆";
            this.btn最後一筆.Size = new System.Drawing.Size(162, 46);
            this.btn最後一筆.TabIndex = 51;
            this.btn最後一筆.Text = "最後一筆";
            this.btn最後一筆.UseVisualStyleBackColor = true;
            // 
            // btn下一筆
            // 
            this.btn下一筆.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下一筆.Location = new System.Drawing.Point(401, 764);
            this.btn下一筆.Margin = new System.Windows.Forms.Padding(6);
            this.btn下一筆.Name = "btn下一筆";
            this.btn下一筆.Size = new System.Drawing.Size(162, 46);
            this.btn下一筆.TabIndex = 50;
            this.btn下一筆.Text = "下一筆";
            this.btn下一筆.UseVisualStyleBackColor = true;
            // 
            // btn上一筆
            // 
            this.btn上一筆.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn上一筆.Location = new System.Drawing.Point(223, 762);
            this.btn上一筆.Margin = new System.Windows.Forms.Padding(6);
            this.btn上一筆.Name = "btn上一筆";
            this.btn上一筆.Size = new System.Drawing.Size(162, 46);
            this.btn上一筆.TabIndex = 49;
            this.btn上一筆.Text = "上一筆";
            this.btn上一筆.UseVisualStyleBackColor = true;
            // 
            // btn第一筆
            // 
            this.btn第一筆.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn第一筆.Location = new System.Drawing.Point(46, 764);
            this.btn第一筆.Margin = new System.Windows.Forms.Padding(6);
            this.btn第一筆.Name = "btn第一筆";
            this.btn第一筆.Size = new System.Drawing.Size(162, 46);
            this.btn第一筆.TabIndex = 48;
            this.btn第一筆.Text = "第一筆";
            this.btn第一筆.UseVisualStyleBackColor = true;
            // 
            // txt會員點數
            // 
            this.txt會員點數.Location = new System.Drawing.Point(213, 630);
            this.txt會員點數.Margin = new System.Windows.Forms.Padding(6);
            this.txt會員點數.Name = "txt會員點數";
            this.txt會員點數.Size = new System.Drawing.Size(429, 36);
            this.txt會員點數.TabIndex = 47;
            // 
            // chk婚姻狀態
            // 
            this.chk婚姻狀態.AutoSize = true;
            this.chk婚姻狀態.Location = new System.Drawing.Point(241, 578);
            this.chk婚姻狀態.Margin = new System.Windows.Forms.Padding(6);
            this.chk婚姻狀態.Name = "chk婚姻狀態";
            this.chk婚姻狀態.Size = new System.Drawing.Size(90, 28);
            this.chk婚姻狀態.TabIndex = 46;
            this.chk婚姻狀態.Text = "已婚";
            this.chk婚姻狀態.UseVisualStyleBackColor = true;
            // 
            // txt電話
            // 
            this.txt電話.Location = new System.Drawing.Point(213, 300);
            this.txt電話.Margin = new System.Windows.Forms.Padding(6);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(429, 36);
            this.txt電話.TabIndex = 45;
            // 
            // txt地址
            // 
            this.txt地址.Location = new System.Drawing.Point(213, 366);
            this.txt地址.Margin = new System.Windows.Forms.Padding(6);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(429, 36);
            this.txt地址.TabIndex = 44;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(213, 432);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(429, 36);
            this.txtEmail.TabIndex = 43;
            // 
            // dtp生日
            // 
            this.dtp生日.Location = new System.Drawing.Point(213, 498);
            this.dtp生日.Margin = new System.Windows.Forms.Padding(6);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(429, 36);
            this.dtp生日.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(39, 506);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 36);
            this.label9.TabIndex = 41;
            this.label9.Text = "生日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(39, 572);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 36);
            this.label8.TabIndex = 40;
            this.label8.Text = "婚姻狀況";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(39, 638);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 36);
            this.label7.TabIndex = 39;
            this.label7.Text = "會員點數";
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(213, 234);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(6);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(429, 36);
            this.txt姓名.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(215, 172);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(431, 44);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "0000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(39, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 36);
            this.label5.TabIndex = 36;
            this.label5.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(39, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 36);
            this.label4.TabIndex = 35;
            this.label4.Text = "電話";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(39, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(39, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 36);
            this.label2.TabIndex = 33;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(39, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // FormCustomersAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 998);
            this.Controls.Add(this.btnRM);
            this.Controls.Add(this.listBox搜尋結果);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl筆數資訊);
            this.Controls.Add(this.btn儲存);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.btn回復資料);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.btn儲存修改);
            this.Controls.Add(this.btn最後一筆);
            this.Controls.Add(this.btn下一筆);
            this.Controls.Add(this.btn上一筆);
            this.Controls.Add(this.btn第一筆);
            this.Controls.Add(this.txt會員點數);
            this.Controls.Add(this.chk婚姻狀態);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtp生日);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomersAlter";
            this.Text = "FormCustomersAlter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRM;
        private System.Windows.Forms.ListBox listBox搜尋結果;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBoxFilter欄位名稱;
        private System.Windows.Forms.TextBox txtFind關鍵字;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboBoxFind欄位名稱;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter關鍵字;
        private System.Windows.Forms.Label lbl筆數資訊;
        private System.Windows.Forms.Button btn儲存;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn回復資料;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn最後一筆;
        private System.Windows.Forms.Button btn下一筆;
        private System.Windows.Forms.Button btn上一筆;
        private System.Windows.Forms.Button btn第一筆;
        private System.Windows.Forms.TextBox txt會員點數;
        private System.Windows.Forms.CheckBox chk婚姻狀態;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}