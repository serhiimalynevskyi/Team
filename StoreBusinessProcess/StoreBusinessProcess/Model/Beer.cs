using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBusinessProcess.Model
{
    class Beer : IItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        //public double volume;
    }
}
