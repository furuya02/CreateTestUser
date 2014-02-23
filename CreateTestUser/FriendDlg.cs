using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTestUser
{
    public partial class FriendDlg : Form{
        public List<OneUser> Ar; 
        public FriendDlg(List<OneUser> ar)
        {
            InitializeComponent();

            Ar = ar;
            foreach (var a in ar){
                checkedListBoxUsers.Items.Add(string.Format("({0}){1}", a.Id, a.Name));
            }
        }

        private void buttonOk_Click(object sender, EventArgs e){
            

            var indexes = checkedListBoxUsers.CheckedIndices;
            var ar = new List<OneUser>();
            for (var i = 0; i < Ar.Count; i++){
                if (indexes.IndexOf(i) >= 0){
                    ar.Add(Ar[i]);
                }
            }
            Ar = ar;
        }
    }
}
