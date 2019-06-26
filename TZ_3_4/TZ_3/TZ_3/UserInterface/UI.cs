using System;
using System.Collections.Generic;
using System.Text;

namespace TZ_3
{
    class UI
    {
        PaySystem SystemPay = new PaySystem();
        BankSystem SystemBank = new BankSystem();

        public void Run()
        {
            Console.WriteLine("Bank Malinas");
            for (; ; )
            {
                this.BasicOutput();
                string action = Console.ReadLine();
                this.ValidateAndExecute(action);
            }
        }

        private void BasicOutput()
        {
            Console.WriteLine("1. Создать счет");
            Console.WriteLine("2. Пополнить счет");
            Console.WriteLine("3. Снять средства");
            Console.WriteLine("4. Переслать средства");
            Console.WriteLine("5. Проверить средства на счете");
            Console.WriteLine("6. Взять кедит");
            Console.WriteLine("7. Оформить депозит");
            Console.WriteLine("0. Получить номер банка");
        }

        private void ValidateAndExecute(string ActionNumber)
        {
            switch (ActionNumber)
            {
                case "1":
                    this.UICreateBalance();
                    break;
                case "2":
                    this.ReplenishBalance();
                    break;
                case "3":
                    this.UIWithdrawMoney();
                    break;
                case "4":
                    this.UISendMoney();
                    break;
                case "5":
                    this.UIOutputBalance();
                    break;
                case "6":
                    this.UILoan();
                    break;
                case "7":
                    this.UIDeposit();
                    break;
                case "0":
                    this.CreateBank();
                    break;
            }
            //if (ActionNumber == "1")
            //{
            //    this.UICreateBalance();
            //}
            //else if (ActionNumber == "2")
            //{
            //    this.UIDepositMoney();
            //}
            //else if (ActionNumber == "3")
            //{
            //    this.UIWithdrawMoney();
            //}
            //else if (ActionNumber == "4")
            //{
            //    UIOutputBalance();
            //}
        }

        private void UICreateBalance()
        {
            Console.WriteLine("Создайте имя счета");
            string name = Console.ReadLine();
            int AccountNumber = SystemPay.Create(name);
            Console.WriteLine("Номер вашего счета: " + AccountNumber);
            
        }
        private void ReplenishBalance()
        {
            Console.WriteLine("Введите номер счета");
            string str = Console.ReadLine();
            int number = Int32.Parse(str);
            Console.WriteLine("Введите сумму попоплнения");
            string money = Console.ReadLine();
            int cash = Int32.Parse(money);
            bool OperationStatus = SystemPay.Replenish(number, cash);
            if (OperationStatus == true)
            {
                Console.WriteLine("Operation Succesful");
            }
            else if (OperationStatus == false)
            {
                Console.WriteLine("Cannot find balance by writed number");
            }
        }
        private void UIWithdrawMoney()
        {
            Console.WriteLine("Введите номер счета");
            string str = Console.ReadLine();
            int number = Int32.Parse(str);
            Console.WriteLine("Введите сумму снятия");
            string money = Console.ReadLine();
            int cash = Int32.Parse(money);
            bool OperationStatus = SystemPay.WithdrawMoney(number, cash);
            if (OperationStatus == true)
            {
                Console.WriteLine("Operation Succesful");
            }
            else if (OperationStatus == false)
            {
                Console.WriteLine("cannot find balance by writed number ");
            }
        }
        private void UISendMoney()
        {
            Console.WriteLine("Введите номер счета");
            string str = Console.ReadLine();
            int number1 = Int32.Parse(str);
            Console.WriteLine("Введите номер счета получателя");
            string str2 = Console.ReadLine();
            int number2 = Int32.Parse(str2);
            Console.WriteLine("Введите сумму");
            string money = Console.ReadLine();
            int cash = Int32.Parse(money);
            bool OperationStatus = SystemPay.SendMoney(number1, number2, cash);
            if (OperationStatus == true)
            {
                Console.WriteLine("Operation Succesful");
            }
            else if (OperationStatus == false)
            {
                Console.WriteLine("cannot find balance by writed number ");
            }

        }
        private void UIOutputBalance()
        {
            Console.WriteLine("Введите номер счета");
            string str = Console.ReadLine();
            int number = Int32.Parse(str);
            Balance balance = SystemPay.FindBalanceByNumber(number);
            if ( balance != null)
            {
                Console.WriteLine(balance.Name);
                Console.WriteLine(balance.MoneyAmount);
            }
            else if (balance == null)
            {
                Console.WriteLine("Not found Balance with defined number");
            }
        }
        private void UILoan()
        {
            Console.WriteLine("Введите номер счета");
            string str = Console.ReadLine();
            int BalanceNumber = Int32.Parse(str);
            Balance balance = SystemPay.FindBalanceByNumber(BalanceNumber);
            Console.WriteLine("Введите сумму");
            string money = Console.ReadLine();
            int requestedMoneyAmount = Int32.Parse(money);
            Console.WriteLine("Введите номер банка");
            string code = Console.ReadLine();
            int BankCode = Convert.ToInt32(code);
            Bank bank = SystemBank.FindBankByCode(BankCode);
            bool OperationStatus = SystemBank.MakeLoan(bank ,balance, requestedMoneyAmount);
            if (OperationStatus == true)
            {
                Console.WriteLine("Operation Succesful");
                Console.WriteLine(bank.BankBalance);
            }
            else if (OperationStatus == false)
            {
                Console.WriteLine("Loan is not available");
            }
        } 
        private void UIDeposit()
        {
            Console.WriteLine("Введите номер счета");
            string a = Console.ReadLine();
            int BalanceNumber = Convert.ToInt32(a);
            Balance balance = SystemPay.FindBalanceByNumber(BalanceNumber);
            Console.WriteLine("Введите сумму");
            string b = Console.ReadLine();
            int MoneyAmount = Convert.ToInt32(b);
            Console.WriteLine("Введите номер банка");
            string c = Console.ReadLine();
            int BankCode = Convert.ToInt32(c);
            Bank bank = SystemBank.FindBankByCode(BankCode);
            bool OperationStatus = SystemBank.MakeDeposit(bank, balance, MoneyAmount);
            if (OperationStatus == true)
            {
                Console.WriteLine("Operation Succesful");
                Console.WriteLine(bank.BankBalance);
            }
            else if (OperationStatus == false)
            {
                Console.WriteLine("Taking loan is not available");
            }

        }
        private void CreateBank()
        {
            string name = "UltraBank";
            //int balance = 1000000;
            //int credpercent = 24;
            //int depospercent = 15;
            int a = SystemBank.Create(name/*, balance, credpercent,  depospercent*/);
            Console.WriteLine("Code of bank is :" + a);
        }
    }
}
