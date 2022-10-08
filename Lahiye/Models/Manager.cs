using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiye.Models
{
    public  class Manager:BaseEntity
    {
        public string Surname { get; set; }
        public string Username { get; set; }
        public int Userpassword { get; set; }
        public Manager()
        {
            Username = "Eli";
            Userpassword = 12345;
        }
    }
}
