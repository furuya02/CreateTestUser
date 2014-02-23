namespace CreateTestUser
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMeuSetupId = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuCreateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PopupMenuCreateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupMenuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupMenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.PopupMeuRefersh = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PopupMenuFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainMenuPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupMenuPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFile,
            this.MainMenuTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuFile
            // 
            this.MainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuExit});
            this.MainMenuFile.Name = "MainMenuFile";
            this.MainMenuFile.Size = new System.Drawing.Size(70, 20);
            this.MainMenuFile.Text = "ファイル(&F)";
            // 
            // MainMenuExit
            // 
            this.MainMenuExit.Name = "MainMenuExit";
            this.MainMenuExit.Size = new System.Drawing.Size(116, 22);
            this.MainMenuExit.Text = "終了(&X)";
            this.MainMenuExit.Click += new System.EventHandler(this.MainMenuExit_Click);
            // 
            // MainMenuTool
            // 
            this.MainMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMeuSetupId,
            this.toolStripMenuItem1,
            this.MainMenuCreateUser,
            this.MainMenuDeleteUser,
            this.MainMenuFriend,
            this.toolStripMenuItem2,
            this.MainMenuLogin,
            this.MainMenuOpen,
            this.MainMenuPassword,
            this.toolStripMenuItem3,
            this.MainMenuRefresh});
            this.MainMenuTool.Name = "MainMenuTool";
            this.MainMenuTool.Size = new System.Drawing.Size(66, 20);
            this.MainMenuTool.Text = "ツール(&T)";
            // 
            // MainMeuSetupId
            // 
            this.MainMeuSetupId.Name = "MainMeuSetupId";
            this.MainMeuSetupId.Size = new System.Drawing.Size(183, 22);
            this.MainMeuSetupId.Text = "アプリIDの初期化(&I)";
            this.MainMeuSetupId.Click += new System.EventHandler(this.MainMeuSetupId_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // MainMenuCreateUser
            // 
            this.MainMenuCreateUser.Name = "MainMenuCreateUser";
            this.MainMenuCreateUser.Size = new System.Drawing.Size(183, 22);
            this.MainMenuCreateUser.Text = "ユーザの作成(&C)";
            this.MainMenuCreateUser.Click += new System.EventHandler(this.MainMenuCreateUser_Click);
            // 
            // MainMenuDeleteUser
            // 
            this.MainMenuDeleteUser.Name = "MainMenuDeleteUser";
            this.MainMenuDeleteUser.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MainMenuDeleteUser.Size = new System.Drawing.Size(183, 22);
            this.MainMenuDeleteUser.Text = "ユーザの削除(&D)";
            this.MainMenuDeleteUser.Click += new System.EventHandler(this.MainMenuDeleteUser_Click);
            // 
            // MainMenuFriend
            // 
            this.MainMenuFriend.Name = "MainMenuFriend";
            this.MainMenuFriend.Size = new System.Drawing.Size(183, 22);
            this.MainMenuFriend.Text = "友達の追加(&F)";
            this.MainMenuFriend.Click += new System.EventHandler(this.MainMenuFriend_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
            // 
            // MainMenuLogin
            // 
            this.MainMenuLogin.Name = "MainMenuLogin";
            this.MainMenuLogin.Size = new System.Drawing.Size(183, 22);
            this.MainMenuLogin.Text = "ログイン(&L)";
            this.MainMenuLogin.Click += new System.EventHandler(this.MainMenuLogin_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 6);
            // 
            // MainMenuRefresh
            // 
            this.MainMenuRefresh.Name = "MainMenuRefresh";
            this.MainMenuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MainMenuRefresh.Size = new System.Drawing.Size(183, 22);
            this.MainMenuRefresh.Text = "最新表示(&R)";
            this.MainMenuRefresh.Click += new System.EventHandler(this.MainMenuRefresh_Click);
            // 
            // listViewUser
            // 
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewUser.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUser.FullRowSelect = true;
            this.listViewUser.Location = new System.Drawing.Point(0, 24);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(640, 314);
            this.listViewUser.TabIndex = 1;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            this.listViewUser.SelectedIndexChanged += new System.EventHandler(this.listViewUser_SelectedIndexChanged);
            this.listViewUser.DoubleClick += new System.EventHandler(this.MainMenuLogin_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No.";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性別";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "AccessToken";
            this.columnHeader4.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PopupMenuCreateUser,
            this.PopupMenuDeleteUser,
            this.PopupMenuFriend,
            this.toolStripMenuItem5,
            this.PopupMenuLogin,
            this.PopupMenuOpen,
            this.toolStripMenuItem4,
            this.PopupMeuRefersh,
            this.PopupMenuPassword});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 192);
            // 
            // PopupMenuCreateUser
            // 
            this.PopupMenuCreateUser.Name = "PopupMenuCreateUser";
            this.PopupMenuCreateUser.Size = new System.Drawing.Size(183, 22);
            this.PopupMenuCreateUser.Text = "ユーザの作成(&C)";
            this.PopupMenuCreateUser.Click += new System.EventHandler(this.MainMenuCreateUser_Click);
            // 
            // PopupMenuDeleteUser
            // 
            this.PopupMenuDeleteUser.Name = "PopupMenuDeleteUser";
            this.PopupMenuDeleteUser.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.PopupMenuDeleteUser.Size = new System.Drawing.Size(183, 22);
            this.PopupMenuDeleteUser.Text = "ユーザの削除(&D)";
            this.PopupMenuDeleteUser.Click += new System.EventHandler(this.MainMenuDeleteUser_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 6);
            // 
            // PopupMenuLogin
            // 
            this.PopupMenuLogin.Name = "PopupMenuLogin";
            this.PopupMenuLogin.Size = new System.Drawing.Size(183, 22);
            this.PopupMenuLogin.Text = "ログイン(&L)";
            this.PopupMenuLogin.Click += new System.EventHandler(this.MainMenuLogin_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 6);
            // 
            // PopupMeuRefersh
            // 
            this.PopupMeuRefersh.Name = "PopupMeuRefersh";
            this.PopupMeuRefersh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.PopupMeuRefersh.Size = new System.Drawing.Size(183, 22);
            this.PopupMeuRefersh.Text = "最新の状態(&R)";
            this.PopupMeuRefersh.Click += new System.EventHandler(this.MainMenuRefresh_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "LoginUrl";
            this.columnHeader6.Width = 300;
            // 
            // PopupMenuFriend
            // 
            this.PopupMenuFriend.Name = "PopupMenuFriend";
            this.PopupMenuFriend.Size = new System.Drawing.Size(183, 22);
            this.PopupMenuFriend.Text = "友達の追加(&F)";
            this.PopupMenuFriend.Click += new System.EventHandler(this.MainMenuFriend_Click);
            // 
            // MainMenuOpen
            // 
            this.MainMenuOpen.Name = "MainMenuOpen";
            this.MainMenuOpen.Size = new System.Drawing.Size(183, 22);
            this.MainMenuOpen.Text = "開く(&O)";
            this.MainMenuOpen.Click += new System.EventHandler(this.MainMenuOpen_Click);
            // 
            // PopupMenuOpen
            // 
            this.PopupMenuOpen.Name = "PopupMenuOpen";
            this.PopupMenuOpen.Size = new System.Drawing.Size(183, 22);
            this.PopupMenuOpen.Text = "開く(&O)";
            this.PopupMenuOpen.Click += new System.EventHandler(this.MainMenuOpen_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "パスワード";
            // 
            // MainMenuPassword
            // 
            this.MainMenuPassword.Name = "MainMenuPassword";
            this.MainMenuPassword.Size = new System.Drawing.Size(183, 22);
            this.MainMenuPassword.Text = "パスワード(&P)";
            this.MainMenuPassword.Click += new System.EventHandler(this.MainMenuPassword_Click);
            // 
            // PopupMenuPassword
            // 
            this.PopupMenuPassword.Name = "PopupMenuPassword";
            this.PopupMenuPassword.Size = new System.Drawing.Size(183, 22);
            this.PopupMenuPassword.Text = "パスワード(&P)";
            this.PopupMenuPassword.Click += new System.EventHandler(this.MainMenuPassword_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 338);
            this.Controls.Add(this.listViewUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CreateTestUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MainMenuExit;
        private System.Windows.Forms.ToolStripMenuItem MainMenuTool;
        private System.Windows.Forms.ToolStripMenuItem MainMeuSetupId;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuCreateUser;
        private System.Windows.Forms.ToolStripMenuItem MainMenuDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem MainMenuRefresh;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem MainMenuLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PopupMenuCreateUser;
        private System.Windows.Forms.ToolStripMenuItem PopupMenuDeleteUser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem PopupMenuLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem PopupMeuRefersh;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFriend;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem PopupMenuFriend;
        private System.Windows.Forms.ToolStripMenuItem MainMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem PopupMenuOpen;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem MainMenuPassword;
        private System.Windows.Forms.ToolStripMenuItem PopupMenuPassword;
    }
}

