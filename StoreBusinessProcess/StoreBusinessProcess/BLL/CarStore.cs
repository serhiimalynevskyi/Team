using StoreBusinessProcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBusinessProcess.BLL
{
    public class CarStore : IStore
    {
        List<IItem> ItemList = new List<IItem>();
        int buget = 0;

        public List<IItem> GetItemList()
        {
            List<IItem> List = this.ItemList;
            return List;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CarStore()
        {
            Initializer();
        }

        /// <summary>
        /// Initialize some objects in collection
        /// </summary>
        private void Initializer()
        {
            ItemList.Add(new Car { id = 1, name = "BMW", price = 20000 });
            ItemList.Add(new Car { id = 2, name = "Subaru Forester", price = 7000 });
            ItemList.Add(new Car { id = 3, name = "Opel", price = 6000 });
            ItemList.Add(new Motorcycle { id = 4, name = "Harley Davidson", price = 7000 });
        }

        public IItem BuyItem(int money, int id)
        {
            IItem DefinedCar = FindItemById(id); //почему IItem?
            bool TransactionStatus = IsInafMoney(money, DefinedCar.price);
            if(TransactionStatus == true)
            {
                buget += money;
                ItemList.Remove(DefinedCar as Car);
                return DefinedCar;
            }
            return null;
        }

        /// <summary>
        /// Find car in collection by id witch user write
        /// </summary>
        /// <param name="id">id witch user write in ui for find car</param>
        /// <returns>Requested car</returns>
        private IItem FindItemById(int id)
        {
            foreach(var i in ItemList)
            {
                if(i.id == id)
                {
                    return i;
                }
            }
            return null;
        }

        private bool IsInafMoney(int money, int cost)
        {
            if(money >= cost)
            {
                return true;
            }
            return false;
        }

        public int SellItem(IItem item)
        {
            Car car = item as Car;
            int money = item.price;
            ItemList.Add(car);
            return money;
        }
    }
}
