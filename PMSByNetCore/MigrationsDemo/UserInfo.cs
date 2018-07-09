using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MigrationsDemo
{
    public class UserInfo
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
    }
}
