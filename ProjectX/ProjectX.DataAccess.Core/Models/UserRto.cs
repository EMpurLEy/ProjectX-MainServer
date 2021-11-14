using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectX.DataAccess.Core.Models
{
    [Table("User")]
    class UserRto
    {
      [Key] public int id { get; set; } 
      public string Email { get; set; }
      public string Login { get; set; }
      [Required]public string PhoneNumberPrefix { get; set; }
      [Required]public string PhoneNumber { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Patronymic { get; set; }
      public DateTimeOffset Birthday { get; set; }
      public string AvatarUrl { get; set; }
      [Required]public UserRoleRto Role { get; set; }
    }
}
