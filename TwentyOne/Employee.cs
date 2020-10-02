using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //CREATE CLASS 'Employee' THAT INHERITS SUPERCLASS 'Person' 
    public class Employee<T>
    {
        //ADD PROPERTY CALLED 'things' AS GENERIC DATA TYPE LIST
        public List<T> Things { get; set; }
    }
}
