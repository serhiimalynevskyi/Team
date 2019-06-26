using StoreBusinessProcess.BLL;
using StoreBusinessProcess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBusinessProcess.UI
{
    class StoreUI
    {
        IStore Store { get; set; }

        public StoreUI(IStore _Store)
        {
            this.Store = _Store;
        }

        public void Run()
        {
            while(true)
            {
                Notifier();
                UserChoose();
            }
        }

        private void UserChoose()
        {
            Console.WriteLine("Write your action");
            string str = Console.ReadLine();
            int i = Int32.Parse(str);
            if(i == 1)
            {
                BuyItemUI();
            } else if (i == 2)
            {
                SellItemUI();
            }
        }

        private int ConsoleReadlineInt()
        {
            string str = Console.ReadLine();
            return Int32.Parse(str);
        }

        private void BuyItemUI()
        {
            ShowItemList();
            Console.WriteLine("Please write id of item you want to buy");
            int id = ConsoleReadlineInt();
            Console.WriteLine("Please write money amount you pay");
            int money = ConsoleReadlineInt();
            IItem item = Store.BuyItem(money, id);
            if(item != null)
            {
                Console.WriteLine("Item successfuly payed");
            } else { Console.WriteLine("Error, defined id does not exist, or money amaount to less"); }
        }

        private void SellItemUI()
        {

        }

        private void ShowItemList()
        {
            Console.WriteLine("Available item list");
            List<IItem> ItemList = Store.GetItemList();
            foreach(var i in ItemList)
            {
                Console.WriteLine(i.id + " " + i.name + " " + i.price);
            }
        }

        private void Notifier()
        {
            Console.WriteLine("Hello in StoreBusinessProcess");
            Console.WriteLine("Arbitrum inc. All rights reserved.");

            Console.WriteLine("1.Buy item");
            Console.WriteLine("2.Sell item");
        }
    }
}
