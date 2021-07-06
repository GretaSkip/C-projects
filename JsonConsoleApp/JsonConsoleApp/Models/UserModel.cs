using JsonConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonConsoleApp.Models
{
    class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AdressModel Address { get; set; }
    }

}
