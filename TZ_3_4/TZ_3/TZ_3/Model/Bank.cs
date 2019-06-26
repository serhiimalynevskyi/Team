using System;
using System.Collections.Generic;
using System.Text;
using TZ_3.Model;

namespace TZ_3
{
    class Bank
    {
        public string BankName = "empty";
        public int BankBalance = 0;
        public int BankCode = 0;
        public List<Loan> LoanList = new List<Loan>();
        public int LoanPercent = 0;
        public List<Deposit> ListDeposit = new List<Deposit>();
        public int DepositPercent = 0;
    }
}
