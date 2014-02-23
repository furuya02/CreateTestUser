using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace CreateTestUser{
    public partial class MainForm : Form{

        private string _appId = "";
        private string _appSecret = "";
        private string _accessToken = "";

        private const int ColNo = 0;
        private const int ColName = 1;
        private const int ColId = 2;
        private const int ColGender = 3;
        private const int ColAccessToken = 4;
        private const int ColLoginurl = 5;
        private const int ColPassword = 6;

        public MainForm(){
            InitializeComponent();

            //保存されたアプリID読み込み
            Setup.Read(out _appId, out _appSecret);
            Init(); //初期化
        }

        private void MainMenuExit_Click(object sender, EventArgs e){
            Close();
        }

        //アプリIDの指定
        private void MainMeuSetupId_Click(object sender, EventArgs e){

            var dlg = new SetupIdDlg(_appId, _appSecret);
            if (DialogResult.OK == dlg.ShowDialog()){
                _appId = dlg.AppId;
                _appSecret = dlg.AppSecret;
                Init(); //初期化
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e){
            //終了時にアプリID保存
            Setup.Save(_appId, _appSecret);
        }

        //初期化
        private void Init(){

            _accessToken = FbUtil.GetAccessToken(_appId, _appSecret);
            if (_accessToken == ""){
                MessageBox.Show("初期化に失敗しました。\nアプリID若しくはアプリのシークレットに誤りがないかを確認してください。", "ERROR");
            }
            //メニュー初期化
            var initialize = (_accessToken != "");
            MainMenuCreateUser.Enabled = initialize;
            MainMenuDeleteUser.Enabled = initialize;
            MainMenuLogin.Enabled = initialize;
            MainMenuFriend.Enabled = initialize;
            MainMenuRefresh.Enabled = initialize;

            //最新の状態
            MainMenuRefresh_Click(null, null);

        }

        ListViewItem OneUser2Item(OneUser oneUser){
            var item = new ListViewItem();
            item.SubItems.Add(oneUser.Name);
            item.SubItems.Add(oneUser.Id);
            item.SubItems.Add(oneUser.Gender);
            item.SubItems.Add(oneUser.AccessToken);
            item.SubItems.Add(oneUser.LoginUrl);
            item.SubItems.Add(oneUser.Password);
            return item;
        }

        OneUser Item2OneUser(ListViewItem item){
            return new OneUser(){
                Id = item.SubItems[ColId].Text,
                Name = item.SubItems[ColName].Text,
                AccessToken = item.SubItems[ColAccessToken].Text,
                LoginUrl = item.SubItems[ColLoginurl].Text,
                Gender = item.SubItems[ColGender].Text,
                Password = item.SubItems[ColPassword].Text
            };
        }



        //ユーザ作成
        private void MainMenuCreateUser_Click(object sender, EventArgs e){
            var dlg = new CreateUserDlg();
            if (DialogResult.OK == dlg.ShowDialog()){
                int count = dlg.Count;
                for (int i = 0; i < count; i++){
                    var oneUser = FbUtil.CreateUser(_appId, dlg.Prefix, dlg.Installed, dlg.Permission, _accessToken);
                    if (oneUser == null){
                        MessageBox.Show("ユーザの作成に失敗しました", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    } else{
                        listViewUser.Items.Insert(0, OneUser2Item(oneUser));
                        SetNumber();//採番
                    }
                }

            }
        }

        //最新の状態
        private void MainMenuRefresh_Click(object sender, EventArgs e){
            listViewUser.Items.Clear();
            var users = FbUtil.GetUsers(_appId, _accessToken);
            foreach (var user in users){
                listViewUser.Items.Add(OneUser2Item(user));
            }
            SetNumber();//採番
        }

        //LoginUrl及びAccessTokenの更新
        private void RefreshUrl(){
            var users = FbUtil.GetUsers(_appId, _accessToken);
            foreach (var user in users){
                for (var i = 0; i < listViewUser.Items.Count; i++){
                    var item = listViewUser.Items[i];
                    if (user.Id == item.SubItems[ColId].Text){
                        item.SubItems[ColLoginurl].Text = user.LoginUrl;
                        item.SubItems[ColAccessToken].Text = user.AccessToken;
                        break;
                    }
                }
            }
        }

        //各行の表示更新 名前及び性別の更新
        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e){
            foreach (ListViewItem item in listViewUser.SelectedItems){
                if (item.SubItems[ColName].Text == "" || item.SubItems[ColGender].Text == ""){
                    var oneUser = FbUtil.GetOneUser(item.SubItems[ColId].Text, item.SubItems[ColLoginurl].Text);
                    if (oneUser != null){
                        item.SubItems[ColName].Text = oneUser.Name;
                        item.SubItems[ColGender].Text = oneUser.Gender;
                    }
                }
            }
        }

        //ユーザの削除
        private void MainMenuDeleteUser_Click(object sender, EventArgs e){
            foreach (ListViewItem item in listViewUser.SelectedItems){
                var id = item.SubItems[ColId].Text;
                if (!FbUtil.DeleteUser(id, _accessToken)){
                    MessageBox.Show("削除に失敗しました。", "ERROR");
                } else{
                    listViewUser.Items.Remove(item);
                }
            }
            SetNumber();//採番

        }

        //ログイン
        private void MainMenuLogin_Click(object sender, EventArgs e){
            foreach (ListViewItem item in listViewUser.SelectedItems){
                var url = item.SubItems[ColLoginurl].Text;
                Process.Start(url);
                RefreshUrl();
                break;//１人づつしか処理しない（どうせ複数のユーザを開くことはできない）
            }
        }

        //採番
        void SetNumber(){
            for (var i = 0; i < listViewUser.Items.Count; i++) {
                listViewUser.Items[i].SubItems[ColNo].Text = (i+1).ToString();
            }
        }

        //友達の追加
        private void MainMenuFriend_Click(object sender, EventArgs e){
            if (listViewUser.SelectedItems.Count <= 0){
                return;
            }
            OneUser me = null;
            var ar = new List<OneUser>();
            for (var i = 0; i < listViewUser.Items.Count; i++){
                var item = listViewUser.Items[i];
                var oneUser = Item2OneUser(item);
                
                if (listViewUser.SelectedItems[0] == item){
                    me = oneUser; //自分
                    if (string.IsNullOrEmpty(me.AccessToken)) {
                        MessageBox.Show("アプリ許可が無いので、友達を作成することはできません", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; //AccessTokenが無い場合、友達の作成はできない
                    }
                }
                else {
                    //AccessTokenがある（アプリ許可されているユーザ）のみが対象になる
                    if (!string.IsNullOrEmpty(oneUser.AccessToken)){
                        ar.Add(oneUser); //自分以外
                    }
                }
            }
            var dlg = new FriendDlg(ar);
            if (DialogResult.OK == dlg.ShowDialog()){
                foreach (var a in dlg.Ar){
                    if (!FbUtil.CreateFriend(me,a)){
                        MessageBox.Show("友達の追加に失敗しました", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

            }
        }

        //開く
        private void MainMenuOpen_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewUser.SelectedItems) {
                var id = item.SubItems[ColId].Text;
                Process.Start(string.Format("https://www.facebook.com/{0}", id));
            }

        }
        //パスワード
        private void MainMenuPassword_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewUser.SelectedItems) {
                var password = item.SubItems[ColPassword].Text;
                if (password == ""){
                    var id = item.SubItems[ColId].Text;
                    //未設定の場合は、再取得する
                    var rnd = new Random(Environment.TickCount);
                    password = string.Format("{0}abc#${1}", rnd.Next(100, 999), rnd.Next(100, 999));
                    if (!FbUtil.SetPassword(id, password, _accessToken)){
                        password = "";
                        MessageBox.Show("パスワードの変更に失敗しました", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else{
                        RefreshUrl();//パスワード変更に成功した場合は、ログインURLも再取得する必要がある
                    }
                }
                item.SubItems[ColPassword].Text = password;
                if (password != ""){
                    Clipboard.SetText(password);
                }
                break; //１行のみ処理
            }
        }
    }

}


