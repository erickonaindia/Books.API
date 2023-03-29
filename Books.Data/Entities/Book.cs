using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Data.Entities
{
    public class Book : EntityBase
    {
        [MaxLength(100)]
        [Required]
        [Column("title")]
        public string Title { get; set; }

        [MaxLength(50)]
        [Required]
        [Column("first_name")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required]
        [Column("total_copies")]
        public int TotalCopies { get; set; } 

        [Required]
        [Column("copies_in_use")]
        public int CopiesInUse { get; set; } 

        [MaxLength(50)]
        [Column("type")]
        public string Type { get; set; }

        [MaxLength(80)]
        [Column("isbn")]
        public string Isbn { get; set; }
        
        [MaxLength(50)]
        [Column("category")]
        public string Category { get; set; }
    }
}
