using Core.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        public string  Name { get; set; }
        public double Price { get; set; }
        public Types Type { get; set; }
    }
}
