using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreSample
{
    // [Table("tblBooks")]
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public string Publisher { get; set; }
    }
}
