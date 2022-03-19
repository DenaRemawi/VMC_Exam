using HR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Service
{
    public class ServiceDepartment :Idepartment
    {
        HRContext context;

        public ServiceDepartment(HRContext contexts)
        {
            context = contexts;
        }
        public void loaddept()
        {
            List<CDepartment> servicecountries = context.Dep.ToList();

        }
    }
}
