using StoreBusinessProcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBusinessProcess.BLL
{
    interface IStore
    {
        //List<IItem> ItemList { get; set; }

        IItem BuyItem(int money, int id);
        int SellItem(IItem item);
        List<IItem> GetItemList();
    }
}
