﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.BussinesLogic.Core.Models
{
     public class UserUpdateBlo
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string AvatarUrl { get; set; }
        public string Login { get; set; }
        public bool IsBoy { get; set; }
    }
}
