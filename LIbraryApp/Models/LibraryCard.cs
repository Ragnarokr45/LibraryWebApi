using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIbraryApp.Models
{
    public class LibraryCard
    {
        [Key]
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime HandOverDate { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
