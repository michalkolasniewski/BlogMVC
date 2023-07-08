using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVC.Domain.Model
{
    public class Quote
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Source { get; set; }
    }
}
