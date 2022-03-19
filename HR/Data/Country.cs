using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Data
{
    public class Country
    {
        public int id { set; get; }
        public string Name { set; get;}

        public List<CEmployee> Emp;

    }
}
