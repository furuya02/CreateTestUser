using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Facebook;

namespace CreateTestUser{
    internal class FbUtil{
        public static string GetAccessToken(string appId, string appSecret){
            if (appId != "" && appSecret != ""){
                try{
                    var client = new FacebookClient();
                    dynamic d = client.Get("oauth/access_token", new{client_id = appId, client_secret = appSecret, grant_type = "client_credentials"});
                    return d.access_token;
                } catch (Exception){
                    ;
                }
            }
            return "";
        }

        //JSONからOneUserを生成する
        static OneUser ParseOneUser(dynamic d){
            try {
                return  new OneUser { Id = d["id"], LoginUrl = d["login_url"], Password = d["password"],AccessToken = d["access_token"] };
            }
            catch (Exception) {
                try {
                    return  new OneUser { Id = d["id"], LoginUrl = d["login_url"], Password = d["password"],AccessToken = d["access_token"] };
                }catch(Exception){
                    return new OneUser { Id = d["id"], LoginUrl = d["login_url"]};
                }
            }
        }
        //ユーザの作成
        public static OneUser CreateUser(string appId, string name, bool installed, string permissions, string accessToken)
        {
            try {

                var client = new FacebookClient();
                dynamic result = client.Post(string.Format("{0}/accounts/test-users", appId), new
                {
                    installed = installed,
                    name = name,
                    //locale="en_US",
                    permissions = permissions,
                    access_token = accessToken
                });
                return ParseOneUser(result);
            }
            catch (Exception) {
                ;
            }
            return null;
        }

        public static List<OneUser> GetUsers(String appId, string accessToken)
        {
            var ar = new List<OneUser>();
            try {

                var fb = new FacebookClient();
                dynamic result = fb.Get(string.Format("{0}/accounts", appId), new
                {
                    access_token = accessToken
                });
                foreach (var d in result["data"]){
                    ar.Add(ParseOneUser(d));
                }
            }
            catch (Exception) {
                ar.Clear();
            }
            return ar;
        }
        
        public static OneUser GetOneUser(String userId,string loginUrl)
        {
            try {

                var fb = new FacebookClient();
                dynamic result = fb.Get(string.Format("{0}", userId));
                var o = new OneUser() { Id=userId,LoginUrl=loginUrl,Name=result["name"],Gender=result["gender"]};
                return o;
            }
            catch (Exception){
                ;
            }
            return null;
        }

        public static bool DeleteUser(string id, string accessToken)
        {
            try {

                var fb = new FacebookClient();
                dynamic result = fb.Delete(id,new{
                    access_token=accessToken
                });
                return true;
            }
            catch (Exception) {
                ;
            }
            return false;
        }

        public static bool CreateFriend(OneUser me, OneUser other){
            try {

                var fb = new FacebookClient();
                dynamic result = fb.Post(string.Format("{0}/friends/{1}",me.Id,other.Id), new
                {
                    access_token = me.AccessToken
                });
                if (result){
                    result = fb.Post(string.Format("{0}/friends/{1}", other.Id, me.Id), new
                    {
                        access_token = other.AccessToken
                    });
                    if (result){
                        return true;
                    }
                }
            }
            catch (Exception ex) {
                if (ex.Message.IndexOf("already friends") >= 0) {
                    return true; //既に友達になっている
                }
            }
            return false;
        }
        //パスワード設定
        public static bool SetPassword(string id, string password, string accessToken){
            try {

                var fb = new FacebookClient();
                dynamic result = fb.Post(id, new
                {
                    password = password,
                    access_token = accessToken
                });
                return true;
            }
            catch (Exception ex){
                ;
            }
            return false;
        }
    }

    enum EmailPermission{
        email
    }

    enum ExtendedProfileUser{
        user_about_me,
        user_activities,
        user_birthday,
        user_checkins,
        user_education_history,
        user_events,
        user_groups,
        user_hometown,
        user_interests,
        user_likes,
        user_location,
        user_notes,
        user_photos,
        user_questions,
        user_relationships,
        user_relationship_details,
        user_religion_politics,
        user_status,
        user_subscriptions,
        user_videos,
        user_website,
        user_work_history
    }

    enum ExtendedProfileFriends{
        friends_about_me,
        friends_activities,
        friends_birthday,
        friends_checkins,
        friends_education_history,
        friends_events,
        friends_groups,
        friends_hometown,
        friends_interests,
        friends_likes,
        friends_location,
        friends_notes,
        friends_photos,
        friends_questions,
        friends_relationships,
        friends_relationship_details,
        friends_religion_politics,
        friends_status,
        friends_subscriptions,
        friends_videos,
        friends_website,
        friends_work_history
    }

    internal enum ExtendedPermissionsRead{
        read_friendlists,
        read_insights,
        read_mailbox,
        read_requests,
        read_stream,
        xmpp_login,
        user_online_presence,
        friends_online_presence
    }

    internal enum ExtendedPermissionsPublish{
        ads_management,
        create_event,
        manage_friendlists,
        manage_notifications,
        publish_actions,
        publish_stream,
        rsvp_event
    }

}
