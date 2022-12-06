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
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.groupBoxSearchFunction = new System.Windows.Forms.GroupBox();
            this.cboBoxFilterField = new System.Windows.Forms.ComboBox();
            this.txtFindKeyWord = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cboBoxFindField = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterKeyWord = new System.Windows.Forms.TextBox();
            this.lbl筆數資訊 = new System.Windows.Forms.Label();
            this.btn儲存 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btnDataRecovery = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtBonusPoint = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdrr = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxSearchFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1433, 534);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 104);
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "移除Filter";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxSearch.DisplayMember = "姓名";
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 24;
            this.listBoxSearch.Location = new System.Drawing.Point(711, 176);
            this.listBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(676, 292);
            this.listBoxSearch.TabIndex = 59;
            // 
            // groupBoxSearchFunction
            // 
            this.groupBoxSearchFunction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxSearchFunction.Controls.Add(this.cboBoxFilterField);
            this.groupBoxSearchFunction.Controls.Add(this.txtFindKeyWord);
            this.groupBoxSearchFunction.Controls.Add(this.btnFind);
            this.groupBoxSearchFunction.Controls.Add(this.cboBoxFindField);
            this.groupBoxSearchFunction.Controls.Add(this.btnFilter);
            this.groupBoxSearchFunction.Controls.Add(this.txtFilterKeyWord);
            this.groupBoxSearchFunction.Location = new System.Drawing.Point(711, 492);
            this.groupBoxSearchFunction.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxSearchFunction.Name = "groupBoxSearchFunction";
            this.groupBoxSearchFunction.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxSearchFunction.Size = new System.Drawing.Size(680, 168);
            this.groupBoxSearchFunction.TabIndex = 58;
            this.groupBoxSearchFunction.TabStop = false;
            this.groupBoxSearchFunction.Text = "搜尋功能";
            // 
            // cboBoxFilterField
            // 
            this.cboBoxFilterField.FormattingEnabled = true;
            this.cboBoxFilterField.Location = new System.Drawing.Point(386, 104);
            this.cboBoxFilterField.Margin = new System.Windows.Forms.Padding(6);
            this.cboBoxFilterField.Name = "cboBoxFilterField";
            this.cboBoxFilterField.Size = new System.Drawing.Size(86, 32);
            this.cboBoxFilterField.TabIndex = 5;
            // 
            // txtFindKeyWord
            // 
            this.txtFindKeyWord.Location = new System.Drawing.Point(13, 42);
            this.txtFindKeyWord.Margin = new System.Windows.Forms.Padding(6);
            this.txtFindKeyWord.Name = "txtFindKeyWord";
            this.txtFindKeyWord.Size = new System.Drawing.Size(355, 36);
            this.txtFindKeyWord.TabIndex = 4;
            this.txtFindKeyWord.Text = "請輸入關鍵字";
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
            // cboBoxFindField
            // 
            this.cboBoxFindField.FormattingEnabled = true;
            this.cboBoxFindField.Location = new System.Drawing.Point(386, 42);
            this.cboBoxFindField.Margin = new System.Windows.Forms.Padding(6);
            this.cboBoxFindField.Name = "cboBoxFindField";
            this.cboBoxFindField.Size = new System.Drawing.Size(86, 32);
            this.cboBoxFindField.TabIndex = 1;
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
            // txtFilterKeyWord
            // 
            this.txtFilterKeyWord.Location = new System.Drawing.Point(13, 100);
            this.txtFilterKeyWord.Margin = new System.Windows.Forms.Padding(6);
            this.txtFilterKeyWord.Name = "txtFilterKeyWord";
            this.txtFilterKeyWord.Size = new System.Drawing.Size(355, 36);
            this.txtFilterKeyWord.TabIndex = 0;
            this.txtFilterKeyWord.Text = "請輸入關鍵字";
            // 
            // lbl筆數資訊
            // 
            this.lbl筆數資訊.AutoSize = true;
            this.lbl筆數資訊.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl筆數資訊.Location = new System.Drawing.Point(798, 770);
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
            this.btn儲存.Location = new System.Drawing.Point(1208, 762);
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
            this.btn新增.Location = new System.Drawing.Point(1034, 762);
            this.btn新增.Margin = new System.Windows.Forms.Padding(6);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(162, 46);
            this.btn新增.TabIndex = 55;
            this.btn新增.Text = "新增";
            this.btn新增.UseVisualStyleBackColor = false;
            // 
            // btnDataRecovery
            // 
            this.btnDataRecovery.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDataRecovery.Location = new System.Drawing.Point(401, 820);
            this.btnDataRecovery.Margin = new System.Windows.Forms.Padding(6);
            this.btnDataRecovery.Name = "btnDataRecovery";
            this.btnDataRecovery.Size = new System.Drawing.Size(162, 46);
            this.btnDataRecovery.TabIndex = 54;
            this.btnDataRecovery.Text = "回復資料";
            this.btnDataRecovery.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(223, 822);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 46);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveChanges.Location = new System.Drawing.Point(48, 824);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(162, 46);
            this.btnSaveChanges.TabIndex = 52;
            this.btnSaveChanges.Text = "儲存修改";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLast.Location = new System.Drawing.Point(579, 764);
            this.btnLast.Margin = new System.Windows.Forms.Padding(6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(162, 46);
            this.btnLast.TabIndex = 51;
            this.btnLast.Text = "最後一筆";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(401, 764);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(162, 46);
            this.btnNext.TabIndex = 50;
            this.btnNext.Text = "下一筆";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevious.Location = new System.Drawing.Point(223, 762);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(162, 46);
            this.btnPrevious.TabIndex = 49;
            this.btnPrevious.Text = "上一筆";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFirst.Location = new System.Drawing.Point(46, 764);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(6);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(162, 46);
            this.btnFirst.TabIndex = 48;
            this.btnFirst.Text = "第一筆";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // txtBonusPoint
            // 
            this.txtBonusPoint.Location = new System.Drawing.Point(223, 582);
            this.txtBonusPoint.Margin = new System.Windows.Forms.Padding(6);
            this.txtBonusPoint.Name = "txtBonusPoint";
            this.txtBonusPoint.Size = new System.Drawing.Size(429, 36);
            this.txtBonusPoint.TabIndex = 47;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(223, 314);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(429, 36);
            this.txtPhone.TabIndex = 45;
            // 
            // txtAdrr
            // 
            this.txtAdrr.Location = new System.Drawing.Point(223, 381);
            this.txtAdrr.Margin = new System.Windows.Forms.Padding(6);
            this.txtAdrr.Name = "txtAdrr";
            this.txtAdrr.Size = new System.Drawing.Size(429, 36);
            this.txtAdrr.TabIndex = 44;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(223, 448);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(429, 36);
            this.txtEmail.TabIndex = 43;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(223, 515);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(6);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(429, 36);
            this.dtpBirth.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(39, 511);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 40);
            this.label9.TabIndex = 41;
            this.label9.Text = "生日";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(39, 578);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 40);
            this.label7.TabIndex = 39;
            this.label7.Text = "會員點數";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 247);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(429, 36);
            this.txtName.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(223, 172);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(429, 44);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "0000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(39, 377);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 40);
            this.label5.TabIndex = 36;
            this.label5.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(39, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 35;
            this.label4.Text = "電話";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(39, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 40);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(39, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 33;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(39, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 40);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(529, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 61);
            this.label6.TabIndex = 61;
            this.label6.Text = "顧客資料編輯";
            // 
            // FormCustomersAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 998);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.groupBoxSearchFunction);
            this.Controls.Add(this.lbl筆數資訊);
            this.Controls.Add(this.btn儲存);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.btnDataRecovery);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtBonusPoint);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdrr);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomersAlter";
            this.Text = "顧客資料編輯";
            this.groupBoxSearchFunction.ResumeLayout(false);
            this.groupBoxSearchFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxSearchFunction;
        private System.Windows.Forms.ComboBox cboBoxFilterField;
        private System.Windows.Forms.TextBox txtFindKeyWord;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cboBoxFindField;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterKeyWord;
        private System.Windows.Forms.Label lbl筆數資訊;
        private System.Windows.Forms.Button btn儲存;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btnDataRecovery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtBonusPoint;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdrr;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}