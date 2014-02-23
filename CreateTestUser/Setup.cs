using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTestUser{
    internal class Setup{
        private const string Filename = "CreateTestUser.ini";

        public static void Read(out string appId, out string appSecret){
            appId = "";
            appSecret = "";
            if (File.Exists(Filename)){
                var text = File.ReadAllText(Filename);
                var tmp = text.Split(',');
                if (tmp.Count() == 2){
                    appId = tmp[0];
                    appSecret = tmp[1];
                }
            }
        }

        public static void Save(string appId, string appSecret){
            File.WriteAllText(Filename, string.Format("{0},{1}", appId, appSecret));
        }

    }
}

