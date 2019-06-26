using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBusinessProcess.Model
{
    public interface IItem
    {
        int id { get; set; }
        string name { get; set; }
        int price { get; set; }
    }
}
