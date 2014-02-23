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
    public partial class CreateUserDlg : Form{
        public int Count { get; private set; }
        public string Prefix { get; private set; }
        public bool Installed { get; private set; }
        public string Permission { get; private set; }

        private List<CheckedListBox> ar = new List<CheckedListBox>();

        public CreateUserDlg(){
            InitializeComponent();

            foreach (var e in Enum.GetNames(typeof (EmailPermission))){
                checkedListBoxEmail.Items.Add(e);
            }
            foreach (var e in Enum.GetNames(typeof (ExtendedProfileUser))){
                checkedListBoxProfileUser.Items.Add(e);
            }
            foreach (var e in Enum.GetNames(typeof (ExtendedProfileFriends))){
                checkedListBoxProfileFriends.Items.Add(e);
            }
            foreach (var e in Enum.GetNames(typeof (ExtendedPermissionsRead))){
                checkedListBoxExtendedRead.Items.Add(e);
            }
            foreach (var e in Enum.GetNames(typeof (ExtendedPermissionsPublish))){
                checkedListBoxExtendedPublish.Items.Add(e);
            }
            ar.Add(checkedListBoxEmail);
            ar.Add(checkedListBoxProfileUser);
            ar.Add(checkedListBoxProfileFriends);
            ar.Add(checkedListBoxExtendedRead);
            ar.Add(checkedListBoxExtendedPublish);

            Init();

        }



        private void checkedListBoxEmail_SelectedIndexChanged(object sender, EventArgs e){
            var sb = new StringBuilder();
            foreach (var a in ar){
                foreach (int i in a.CheckedIndices){
                    if (sb.Length != 0){
                        sb.Append(",");
                    }
                    sb.Append(a.Items[i]);
                }
            }
            textBoxPermission.Text = sb.ToString();

        }

        private void Init(){
            var b = checkBoxInstalled.Checked;
            textBoxPermission.Visible = b;
            tabControlPermission.Visible = b;
            labelPermission.Visible = b;
        }

        private void checkBoxInstalled_CheckedChanged(object sender, EventArgs e){
            Init();
        }

        private void buttonOk_Click(object sender, EventArgs e){
            Count = (int)numericUpDown1.Value;
            Prefix = textBoxPrefix.Text;
            Installed = checkBoxInstalled.Checked;
            Permission = textBoxPermission.Text;
        }

    }
}
