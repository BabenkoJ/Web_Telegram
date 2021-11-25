using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Telegram.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string name { get; set; } // имя фамилия 
        public string email { get; set; } // email
        public string msg { get; set; } // сообщение
    }
}
