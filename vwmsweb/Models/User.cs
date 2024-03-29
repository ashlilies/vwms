﻿using System;
using System.Collections.Generic;

namespace vwmsweb.Models
{
    public partial class User
    {
        public User()
        {
            Workshops = new HashSet<Workshop>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public bool IsManager { get; set; }
        public string FullName { get; set; } = null!;
        public string PersonalIdentifier { get; set; } = null!;
        public string Telephone { get; set; } = null!;

        public virtual ICollection<Workshop> Workshops { get; set; }
    }
}
