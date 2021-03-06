﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MSIP_Diagram.MSIP
{
    class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateJoined { get; set; }
        public string Bio { get; set; }
        public string LinkedInURL { get; set; }
        public string GitHubURL { get; set; }
        public int ForumPriv { get; set; }
    }
}
