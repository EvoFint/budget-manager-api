using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetManagerAPI.Models.Repo
{
    [Table("ExpensesCategories")]
    public class ExpensesCategories
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("userid")]
        public int UserId { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
