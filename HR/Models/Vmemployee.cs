using HR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Vmemployee
    {
        public CEmployee emp { set; get; }
        public List<CDepartment> Dep { set; get; }
        public List<Country> _country { set; get; }
    }
}
