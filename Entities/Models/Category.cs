using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("Category", Schema ="Dev")]
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [DisplayName("Quantity")]
        public int DisplayOrder { get; set; }
        public DateTime CreateOn { get; set; } = DateTime.Now;
    }
}
