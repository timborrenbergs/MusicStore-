﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore2.Models
{
    public class Account
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}