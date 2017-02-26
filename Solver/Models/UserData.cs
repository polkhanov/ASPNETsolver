using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solver.Models
{
    public class UserData
    {
        public double[] Nums { get; set; }
        public string Method { get; set; }
        public int Gen { get; set; }
        public int Individ { get; set; }
    }
}