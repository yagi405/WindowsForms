
namespace WindowsForms.Demo
{
    partial class ControlsSample
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.chkFamily = new System.Windows.Forms.CheckBox();
            this.chkExpense = new System.Windows.Forms.CheckBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.rdoFeMale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(362, 24);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 37);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMain.Controls.Add(this.chkFamily);
            this.pnlMain.Controls.Add(this.chkExpense);
            this.pnlMain.Controls.Add(this.cmbAddress);
            this.pnlMain.Controls.Add(this.dtpBirthDay);
            this.pnlMain.Controls.Add(this.rdoFeMale);
            this.pnlMain.Controls.Add(this.rdoMale);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.lblOthers);
            this.pnlMain.Controls.Add(this.lblBirthDay);
            this.pnlMain.Controls.Add(this.lblGender);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Location = new System.Drawing.Point(26, 78);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(434, 207);
            this.pnlMain.TabIndex = 6;
            // 
            // chkFamily
            // 
            this.chkFamily.AutoSize = true;
            this.chkFamily.Location = new System.Drawing.Point(85, 169);
            this.chkFamily.Margin = new System.Windows.Forms.Padding(2);
            this.chkFamily.Name = "chkFamily";
            this.chkFamily.Size = new System.Drawing.Size(90, 16);
            this.chkFamily.TabIndex = 11;
            this.chkFamily.Text = "扶養家族あり";
            this.chkFamily.UseVisualStyleBackColor = true;
            // 
            // chkExpense
            // 
            this.chkExpense.AutoSize = true;
            this.chkExpense.Location = new System.Drawing.Point(85, 143);
            this.chkExpense.Margin = new System.Windows.Forms.Padding(2);
            this.chkExpense.Name = "chkExpense";
            this.chkExpense.Size = new System.Drawing.Size(84, 16);
            this.chkExpense.TabIndex = 10;
            this.chkExpense.Text = "交通費支給";
            this.chkExpense.UseVisualStyleBackColor = true;
            // 
            // cmbAddress
            // 
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Items.AddRange(new object[] {
            "東京都",
            "神奈川県"});
            this.cmbAddress.Location = new System.Drawing.Point(85, 113);
            this.cmbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(74, 20);
            this.cmbAddress.TabIndex = 9;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(85, 83);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(122, 19);
            this.dtpBirthDay.TabIndex = 8;
            // 
            // rdoFeMale
            // 
            this.rdoFeMale.AutoSize = true;
            this.rdoFeMale.Location = new System.Drawing.Point(135, 56);
            this.rdoFeMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFeMale.Name = "rdoFeMale";
            this.rdoFeMale.Size = new System.Drawing.Size(47, 16);
            this.rdoFeMale.TabIndex = 7;
            this.rdoFeMale.TabStop = true;
            this.rdoFeMale.Text = "女性";
            this.rdoFeMale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(85, 56);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(47, 16);
            this.rdoMale.TabIndex = 6;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男性";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 19);
            this.txtName.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 115);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "住所";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Location = new System.Drawing.Point(21, 144);
            this.lblOthers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(36, 12);
            this.lblOthers.TabIndex = 3;
            this.lblOthers.Text = "その他";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(21, 85);
            this.lblBirthDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(53, 12);
            this.lblBirthDay.TabIndex = 2;
            this.lblBirthDay.Text = "生年月日";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(21, 56);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(29, 12);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "性別";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 27);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名前";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(22, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 22);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "社員情報入力";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(250, 24);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(98, 37);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // ControlsSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 308);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRegister);
            this.Name = "ControlsSample";
            this.Text = "ControlsSample";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckBox chkFamily;
        private System.Windows.Forms.CheckBox chkExpense;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.RadioButton rdoFeMale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegister;
    }
}