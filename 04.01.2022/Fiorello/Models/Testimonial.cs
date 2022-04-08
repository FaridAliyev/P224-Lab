using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
    }
}
