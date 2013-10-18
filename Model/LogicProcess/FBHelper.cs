using System;
using Facebook;
using Model.DataAccess;
using Model.Entity;
using Models;


namespace Model.LogicProcess
{
    public class FBHelper
    {
        private readonly FacebookClient _fb = new FacebookClient();
        public FBHelper(string accessToken)
        {
            _fb.AccessToken = accessToken;
            _fb.AppId = Config.AppID;
            _fb.AppSecret = Config.AppSecret;
        }

        public User GetUser()
        {
            dynamic me = _fb.Get("me");
            //Check Login
            User user = UserImpl.Impl.FacebookLogin(me.email);
            if (user == null) //Register for this email
            {
                user = new User();
                user.FacebookID = me.id;
                user.Fullname = me.name;
                user.Email = me.email;
                user.Gender = me.gender == "male";
                user.ProfilePicture = string.Format("http://profile.ak.fbcdn.net/hprofile-ak-prn2/187622_{0}_181846136_s.jpg", me.id);
                user.Status = true;
                user.Verified = false;
                user.Country = me.location.name;
                user.Description = me.bio;
                user.JoinedDate = DateTime.Now;
                user = UserImpl.Impl.FacebookRegister(user);
                if (user == null)
                {
                    throw new Exception("Email này đã tồn tại, xin vui lòng sử dụng email khác");
                }
            }
            return user;
        } 
        
    }
}
