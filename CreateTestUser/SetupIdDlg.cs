using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTestUser{
    public partial class SetupIdDlg : Form{
        public string AppId { get; private set; }
        public string AppSecret { get; private set; }

        public SetupIdDlg(string appId, string appSecret){
            InitializeComponent();

            textBoxAppId.Text = appId;
            textBoxAppSecret.Text = appSecret;
        }

        private void buttonOk_Click(object sender, EventArgs e){
            AppId = textBoxAppId.Text;
            AppSecret = textBoxAppSecret.Text;
        }

    }
}
