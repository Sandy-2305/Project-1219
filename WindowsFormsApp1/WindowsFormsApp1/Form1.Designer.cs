namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn資料筆數 = new System.Windows.Forms.Button();
            this.gBSubscriberInfo = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gBSubscriberInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn刪除資料);
            this.groupBox1.Controls.Add(this.btn新增資料);
            this.groupBox1.Controls.Add(this.btn資料修改);
            this.groupBox1.Controls.Add(this.btn資料筆數);
            this.groupBox1.Location = new System.Drawing.Point(39, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(221, 430);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.BackColor = System.Drawing.SystemColors.Control;
            this.btn刪除資料.Location = new System.Drawing.Point(24, 238);
            this.btn刪除資料.Margin = new System.Windows.Forms.Padding(6);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(162, 46);
            this.btn刪除資料.TabIndex = 4;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = false;
            // 
            // btn新增資料
            // 
            this.btn新增資料.BackColor = System.Drawing.SystemColors.Control;
            this.btn新增資料.Location = new System.Drawing.Point(24, 180);
            this.btn新增資料.Margin = new System.Windows.Forms.Padding(6);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(162, 46);
            this.btn新增資料.TabIndex = 3;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = false;
            // 
            // btn資料修改
            // 
            this.btn資料修改.BackColor = System.Drawing.SystemColors.Control;
            this.btn資料修改.Location = new System.Drawing.Point(24, 122);
            this.btn資料修改.Margin = new System.Windows.Forms.Padding(6);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(162, 46);
            this.btn資料修改.TabIndex = 2;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = false;
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.BackColor = System.Drawing.SystemColors.Control;
            this.btn資料搜尋.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料搜尋.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn資料搜尋.Location = new System.Drawing.Point(349, 107);
            this.btn資料搜尋.Margin = new System.Windows.Forms.Padding(6);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(366, 46);
            this.btn資料搜尋.TabIndex = 1;
            this.btn資料搜尋.Text = "利用姓名搜尋資料";
            this.btn資料搜尋.UseVisualStyleBackColor = false;
            // 
            // btn資料筆數
            // 
            this.btn資料筆數.BackColor = System.Drawing.SystemColors.Control;
            this.btn資料筆數.Location = new System.Drawing.Point(24, 64);
            this.btn資料筆數.Margin = new System.Windows.Forms.Padding(6);
            this.btn資料筆數.Name = "btn資料筆數";
            this.btn資料筆數.Size = new System.Drawing.Size(162, 46);
            this.btn資料筆數.TabIndex = 0;
            this.btn資料筆數.Text = "資料筆數";
            this.btn資料筆數.UseVisualStyleBackColor = false;
            // 
            // gBSubscriberInfo
            // 
            this.gBSubscriberInfo.Controls.Add(this.dateTimePicker1);
            this.gBSubscriberInfo.Controls.Add(this.label7);
            this.gBSubscriberInfo.Controls.Add(this.lblID);
            this.gBSubscriberInfo.Controls.Add(this.label6);
            this.gBSubscriberInfo.Controls.Add(this.btn資料搜尋);
            this.gBSubscriberInfo.Controls.Add(this.textBox4);
            this.gBSubscriberInfo.Controls.Add(this.txtAddress);
            this.gBSubscriberInfo.Controls.Add(this.txtPhone);
            this.gBSubscriberInfo.Controls.Add(this.txtName);
            this.gBSubscriberInfo.Controls.Add(this.label5);
            this.gBSubscriberInfo.Controls.Add(this.label2);
            this.gBSubscriberInfo.Controls.Add(this.label4);
            this.gBSubscriberInfo.Controls.Add(this.label1);
            this.gBSubscriberInfo.Controls.Add(this.label3);
            this.gBSubscriberInfo.Location = new System.Drawing.Point(299, 36);
            this.gBSubscriberInfo.Name = "gBSubscriberInfo";
            this.gBSubscriberInfo.Size = new System.Drawing.Size(755, 430);
            this.gBSubscriberInfo.TabIndex = 8;
            this.gBSubscriberInfo.TabStop = false;
            this.gBSubscriberInfo.Text = "資料欄位";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(188, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(138, 24);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "XXXXXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "會員編號：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 279);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(396, 36);
            this.textBox4.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(192, 225);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(396, 36);
            this.txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(192, 171);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(396, 36);
            this.txtPhone.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 36);
            this.txtName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "生日：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "連絡電話：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "地址：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 36);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(24, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "清空欄位";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 1095);
            this.Controls.Add(this.gBSubscriberInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "訂單管理系統";
            this.groupBox1.ResumeLayout(false);
            this.gBSubscriberInfo.ResumeLayout(false);
            this.gBSubscriberInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn資料筆數;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.GroupBox gBSubscriberInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

