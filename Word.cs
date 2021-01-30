using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simbirsoft
{
    public class Word
    {
        [Key]
        [MaxLength(350)]
        public String SplittedWord { get; set; }
        public int Count { get; set; }
    }
}
