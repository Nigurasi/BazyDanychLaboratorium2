using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy_Laboratorium2
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Description { get; set; }
    }
}
