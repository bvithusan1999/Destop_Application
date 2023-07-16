using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destop_Application.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NicNo { get; set; }
        public int Maths { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }

        public double Average { get; set; }
    }
}
