﻿using System;

namespace Model.Entity
{
    [Serializable]
    public class MemberProfile
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public bool Gender { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Verified { get; set; }
        public bool Status { get; set; }
        public string Ip { get; set; }
        public string LastIp { get; set; }
        public string Website { get; set; }
        public string ProfilePicture { get; set; }
        public bool RememberMe { get; set; }
        public bool RememberIp { get; set; }
    }
}