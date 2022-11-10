using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LibraryDatabase.Models
{
    [Table("books")]
    public partial class Book
    {
        public Book()
        {
            Histories = new HashSet<History>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        [Required]
        [StringLength(16)]
        public string BookState { get; set; }
        public int? Price { get; set; }//can be null
        public int BookCount { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Books")]
        public virtual Author Author { get; set; }
        [InverseProperty(nameof(History.Book))]
        public virtual ICollection<History> Histories { get; set; }

        public override string ToString()
        {
            return String.Format("{0} | {1}", this.Title, this.BookCount);
        }
    }
}
