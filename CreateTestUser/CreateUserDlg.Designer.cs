namespace CreateTestUser
{
    partial class CreateUserDlg
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
            if (disposing && (components != null)) {
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
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPermission = new System.Windows.Forms.Label();
            this.checkBoxInstalled = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlPermission = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBoxEmail = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBoxProfileUser = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkedListBoxProfileFriends = new System.Windows.Forms.CheckedListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkedListBoxExtendedRead = new System.Windows.Forms.CheckedListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.checkedListBoxExtendedPublish = new System.Windows.Forms.CheckedListBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPermission = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControlPermission.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(65, 36);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(100, 19);
            this.textBoxPrefix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ユーザ名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "未指定で自動生成されます。また、数字記号は使用できません";
            // 
            // labelPermission
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.Location = new System.Drawing.Point(12, 91);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(107, 12);
            this.labelPermission.TabIndex = 3;
            this.labelPermission.Text = "許可するパーミッション";
            // 
            // checkBoxInstalled
            // 
            this.checkBoxInstalled.AutoSize = true;
            this.checkBoxInstalled.Checked = true;
            this.checkBoxInstalled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInstalled.Location = new System.Drawing.Point(14, 61);
            this.checkBoxInstalled.Name = "checkBoxInstalled";
            this.checkBoxInstalled.Size = new System.Drawing.Size(121, 16);
            this.checkBoxInstalled.TabIndex = 2;
            this.checkBoxInstalled.Text = "アプリへのデータ許可";
            this.checkBoxInstalled.UseVisualStyleBackColor = true;
            this.checkBoxInstalled.CheckedChanged += new System.EventHandler(this.checkBoxInstalled_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 19);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "作成数";
            // 
            // tabControlPermission
            // 
            this.tabControlPermission.Controls.Add(this.tabPage1);
            this.tabControlPermission.Controls.Add(this.tabPage2);
            this.tabControlPermission.Controls.Add(this.tabPage3);
            this.tabControlPermission.Controls.Add(this.tabPage4);
            this.tabControlPermission.Controls.Add(this.tabPage5);
            this.tabControlPermission.Location = new System.Drawing.Point(14, 106);
            this.tabControlPermission.Name = "tabControlPermission";
            this.tabControlPermission.SelectedIndex = 0;
            this.tabControlPermission.Size = new System.Drawing.Size(486, 186);
            this.tabControlPermission.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBoxEmail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxEmail
            // 
            this.checkedListBoxEmail.CheckOnClick = true;
            this.checkedListBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxEmail.FormattingEnabled = true;
            this.checkedListBoxEmail.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxEmail.Name = "checkedListBoxEmail";
            this.checkedListBoxEmail.Size = new System.Drawing.Size(472, 154);
            this.checkedListBoxEmail.TabIndex = 0;
            this.checkedListBoxEmail.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEmail_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBoxProfileUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile (User)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxProfileUser
            // 
            this.checkedListBoxProfileUser.CheckOnClick = true;
            this.checkedListBoxProfileUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxProfileUser.FormattingEnabled = true;
            this.checkedListBoxProfileUser.Location = new System.Drawing.Point(3, 3);
            this.checkedListBoxProfileUser.Name = "checkedListBoxProfileUser";
            this.checkedListBoxProfileUser.Size = new System.Drawing.Size(472, 154);
            this.checkedListBoxProfileUser.TabIndex = 1;
            this.checkedListBoxProfileUser.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEmail_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkedListBoxProfileFriends);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(478, 160);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile (Friends)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxProfileFriends
            // 
            this.checkedListBoxProfileFriends.CheckOnClick = true;
            this.checkedListBoxProfileFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxProfileFriends.FormattingEnabled = true;
            this.checkedListBoxProfileFriends.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxProfileFriends.Name = "checkedListBoxProfileFriends";
            this.checkedListBoxProfileFriends.Size = new System.Drawing.Size(478, 160);
            this.checkedListBoxProfileFriends.TabIndex = 2;
            this.checkedListBoxProfileFriends.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEmail_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkedListBoxExtendedRead);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(478, 160);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Extended (Read)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxExtendedRead
            // 
            this.checkedListBoxExtendedRead.CheckOnClick = true;
            this.checkedListBoxExtendedRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxExtendedRead.FormattingEnabled = true;
            this.checkedListBoxExtendedRead.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxExtendedRead.Name = "checkedListBoxExtendedRead";
            this.checkedListBoxExtendedRead.Size = new System.Drawing.Size(478, 160);
            this.checkedListBoxExtendedRead.TabIndex = 3;
            this.checkedListBoxExtendedRead.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEmail_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.checkedListBoxExtendedPublish);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(478, 160);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Extended (Publish)";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxExtendedPublish
            // 
            this.checkedListBoxExtendedPublish.CheckOnClick = true;
            this.checkedListBoxExtendedPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxExtendedPublish.FormattingEnabled = true;
            this.checkedListBoxExtendedPublish.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxExtendedPublish.Name = "checkedListBoxExtendedPublish";
            this.checkedListBoxExtendedPublish.Size = new System.Drawing.Size(478, 160);
            this.checkedListBoxExtendedPublish.TabIndex = 4;
            this.checkedListBoxExtendedPublish.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEmail_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(176, 298);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(257, 298);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxPermission
            // 
            this.textBoxPermission.Location = new System.Drawing.Point(132, 88);
            this.textBoxPermission.Name = "textBoxPermission";
            this.textBoxPermission.Size = new System.Drawing.Size(364, 19);
            this.textBoxPermission.TabIndex = 9;
            // 
            // CreateUserDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 329);
            this.Controls.Add(this.textBoxPermission);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControlPermission);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBoxInstalled);
            this.Controls.Add(this.labelPermission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrefix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateUserDlg";
            this.Text = "ユーザの作成";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControlPermission.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPermission;
        private System.Windows.Forms.CheckBox checkBoxInstalled;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlPermission;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckedListBox checkedListBoxEmail;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckedListBox checkedListBoxProfileUser;
        private System.Windows.Forms.CheckedListBox checkedListBoxProfileFriends;
        private System.Windows.Forms.CheckedListBox checkedListBoxExtendedRead;
        private System.Windows.Forms.CheckedListBox checkedListBoxExtendedPublish;
        private System.Windows.Forms.TextBox textBoxPermission;
    }
}