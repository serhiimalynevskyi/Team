using System;
using System.Collections.Generic;
using System.Text;
using StoreBusinessProcess.Model;

namespace StoreBusinessProcess.BLL
{
    //public class BeerStore : IStore
    //{
    //    List<IItem> ItemList = new List<IItem>();
    //    int buget = 0;

    //    public List<IItem> GetItems()
    //    {
    //        List <IItem> List = this.ItemList; // ?
    //        return List;
    //    }
    //    public BeerStore() // почему так?
    //    {
    //        Initializer();
    //    }
    //    private void Initializer()
    //    {
    //        ItemList.Add(new Beer { id = 1, name = "Obolon", price = 23, /*volume = 1.5*/ });
    //        ItemList.Add(new Beer { id = 2, name = "Budwieser", price = 37 });
    //        ItemList.Add(new Beer { id = 3, name = "Guinnes", price = 56 });
    //    }
    //    public IItem BuyItem(int money, int id) 
    //    {
    //        IItem DefinedBeer = FindItemById(id); //почему IItem DefinedCar?
    //        bool TransactionStatus = IsInafMoney(money, DefinedBeer.price);

    //    }

    //}
}
