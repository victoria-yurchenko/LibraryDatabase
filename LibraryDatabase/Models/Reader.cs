using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LibraryDatabase.Models
{
    [Table("readers")]
    public partial class Reader
    {
        public Reader()
        {
            Histories = new HashSet<History>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(64)]
        public string LastName { get; set; }
        [Required]
        [StringLength(64)]
        public string Email { get; set; }

        [InverseProperty(nameof(History.Reader))]
        public virtual ICollection<History> Histories { get; set; }
    }
}
