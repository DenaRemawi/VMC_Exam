using HR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Service
{
    public class servicecountry : Icountry
    {

        HRContext context;

        public servicecountry(HRContext contexts)
        {
            context = contexts;
        }

        public void loadcountry()
        {
            List<Country> servicecountries = context.count.ToList();

        }

    }
}
