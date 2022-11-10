using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LibraryDatabase.Models
{
    [Table("history")]
    public partial class History
    {
        [Key]
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOut { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateToReturn { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateReturn { get; set; }

        [ForeignKey(nameof(BookId))]
        [InverseProperty("Histories")]
        public virtual Book Book { get; set; }
        [ForeignKey(nameof(ReaderId))]
        [InverseProperty("Histories")]
        public virtual Reader Reader { get; set; }
    }
}
