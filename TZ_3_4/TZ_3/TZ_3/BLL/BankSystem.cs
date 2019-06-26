using System;
using System.Collections.Generic;
using System.Text;
using TZ_3.BLL;
using TZ_3.Model;

namespace TZ_3
{
    class BankSystem : ISystem
    {
        List<Bank> BankList = new List<Bank>();

        public int Create(string name/*, int balance, int loanpercent,   int depositpercent*/)
        {
            Bank bank = new Bank();
            bank.BankName = name;
            Random rnd = new Random();
            int random = rnd.Next(100000, 999999);
            bank.BankCode = random;
            bank.BankBalance = 1000000;
            bank.LoanPercent = 24;
            bank.DepositPercent = 15;
            BankList.Add(bank);
            Console.WriteLine(bank.BankBalance);
            return bank.BankCode;
        }

        public Bank FindBankByCode(int BankCode)
        {
            foreach(var a in BankList)
            {
                if (a.BankCode == BankCode)
                {
                    return a;
                }
            }
            return null;
        }

        private bool LoanApproval(int MoneyAmount, Bank bank)
        {
            double AvailableFunds = bank.BankBalance / 100 * bank.LoanPercent;
            if(MoneyAmount <= AvailableFunds)
            {
                return true;
            }
            return false;
        }

        public bool MakeLoan(Bank bank, Balance balance, int RequestedMoney)
        {
            bool ApprovalStatus = LoanApproval(RequestedMoney, bank);
            if(ApprovalStatus == true)
            {
                Loan loan = new Loan();
                bank.BankBalance -= RequestedMoney;
                balance.MoneyAmount += RequestedMoney;
                loan.LoanBank = bank;
                loan.LoanBalance = balance;
                loan.LoanMoneyAmount = RequestedMoney;
                bank.LoanList.Add(loan);
                return true;
            }
            return false;
        }
        public bool MakeDeposit(Bank bank, Balance balance, int MoneyAmount)
        {
            if (balance.MoneyAmount <= MoneyAmount)
            {
                Deposit deposit = new Deposit();
                bank.BankBalance += MoneyAmount;
                balance.MoneyAmount -= MoneyAmount;
                deposit.DepositBank = bank;
                deposit.DepositBalance = balance;
                deposit.DepositMoneyAmount = MoneyAmount;
                bank.ListDeposit.Add(deposit);
         
                return true;
            }
            return false;
        }

   
    }
}
