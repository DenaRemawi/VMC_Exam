using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR.Data
{
    [Table("Department")]
    public class CDepartment
    {

        public int ID { set; get; }
        [Required]
        public string Depatment_Name { set; get; }
        [Required]
        public int Mimum_Salary { set; get; }
        [Required]
        public int Max_Salary { set; get; }

        public List<CEmployee> Emp;
}
}
