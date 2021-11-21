﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectX.DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
      [Key] public int id { get; set; } 
      public string Email { get; set; }
      public string Login { get; set; }
      public bool IsBoy { get; set; }
      [Required]public string PhoneNumberPrefix { get; set; }
      [Required]public string PhoneNumber { get; set; }
      [Required, MinLength(7)] public string Password { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Patronymic { get; set; }
      public DateTimeOffset Birthday { get; set; }
      public string AvatarUrl { get; set; }
      [Required]public UserRoleRto Role { get; set; }
      public int RoleId { get; set; }
        [NotMapped] public string GetFullName
        {
            get => FirstName + " " + LastName + "" + Patronymic;
        }
    }
}
