using System;
using System.Collections.Generic;
using System.Text;

namespace TZ_3
{
    class PaySystem
    {
        List<Balance> BalanceList = new List<Balance>();
        public int Create(string name)
        {
            Balance CreatedBalance = new Balance();
            CreatedBalance.Name = name;
            Random rnd = new Random();
            int random = rnd.Next(1000, 9999);
            CreatedBalance.AccountNumber = random;
            CreatedBalance.MoneyAmount = 0;
            BalanceList.Add(CreatedBalance);
            return CreatedBalance.AccountNumber;
        }

        public bool Replenish(int BalanceNumber, int _MoneyAmount)
        {
            foreach (var i in BalanceList ) 
            {
                if (i.AccountNumber == BalanceNumber)
                {
                    i.MoneyAmount += _MoneyAmount;
                    return true;
                }
            }
            return false;
        }
        public bool WithdrawMoney(int BalanceNumber, int _MoneyAmount)
        {
            foreach(var i in BalanceList)
            {
                if(i.AccountNumber == BalanceNumber)
                {
                    i.MoneyAmount -= _MoneyAmount;
                    return true;
                }
            }
            return false;
        }
        public bool SendMoney(int BalanceNumber1, int BalanceNumber2, int _MoneyAmount)
        {
            Balance sender = FindBalanceByNumber(BalanceNumber1);
            Balance receiver = FindBalanceByNumber(BalanceNumber2);
            if (sender != null && receiver != null)
            {
                sender.MoneyAmount -= _MoneyAmount;
                receiver.MoneyAmount += _MoneyAmount;
                return true;
            }
            return false;
            
        }
        public Balance FindBalanceByNumber(int BalanceNumber)
        {
            foreach (var a in BalanceList)
            {
                if (a.AccountNumber == BalanceNumber)
                {
                    return a;
                }
            }
            return null;
        }

    }
}
