using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreSample
{
    public partial class Book
    {
        public int BookId { get; set; }

        [MaxLength(40)]
        public string Title { get; set; }
        public string Publisher { get; set; }
    }
}
