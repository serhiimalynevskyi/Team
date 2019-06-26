using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBusinessProcess.Model
{
    class Car : IItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
}
