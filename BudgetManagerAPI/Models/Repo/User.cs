using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManagerAPI.Models.Repo
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string UserName { get; set; }

        [Column("passwordhash")]
        public string PasswordHash { get; set; }

        [Column("email")]   
        public string Email { get; set; }
    }
}
