﻿namespace CulturalAndArtsMIS.Models
{
    public class UserAccount
    {
        public int ua_ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string Role { get; set; }
    }
}