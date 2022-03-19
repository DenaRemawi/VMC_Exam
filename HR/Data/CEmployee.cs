using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static HR.Helper.Birthday;

namespace HR.Data
{
    [Table("Employee")]
    public class CEmployee
    {
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }

        [Required]
        public string Phone { set; get; }

        [Required]
        public string Email { set; get; }

        [Required]
        public string Country { set; get; }

        [birthday]
        public DateTime Birthday { set; get; }

        public string Path { set; get; }

       [NotMapped]
        public IFormFile Image { set; get; }

        public CDepartment Dept;

          [ForeignKey("DepId")]
          public int Department_ID {set; get;}

        public Country country;


        [ForeignKey("ConId")]
        public int Country_id { set; get; }


    }
}

