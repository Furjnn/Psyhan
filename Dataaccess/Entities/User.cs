using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess.Entities
{
    public class User : BaseClass   
    {
        public string  Name { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
