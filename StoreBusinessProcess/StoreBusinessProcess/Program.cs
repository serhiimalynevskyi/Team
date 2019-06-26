using StoreBusinessProcess.BLL;
using StoreBusinessProcess.UI;
using System;

namespace StoreBusinessProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            CarStore cs = new CarStore();
            StoreUI StoreUI = new StoreUI(cs);
            StoreUI.Run();
        }
    }
}
