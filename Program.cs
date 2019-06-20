using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsApp.Properties;

namespace AccountsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("Work", Category.Income,1000);
            Item item2 = new Item("Work", Category.Income, "Salary", 5000,Currency.RMB);
            Item item3 = new Item("Food", Category.Spending, 100, Currency.RMB);
            Item item4 = new Item("Food", Category.Spending, 50, Currency.EUR, new DateTime(2019, 06, 06));
            Item item5 = new Item("Work", Category.Income, 3000, new DateTime(2019, 06, 06));
            Item item6 = new Item("Computer", Category.Spending, "Lenovo", "Buy a computer", 5000, Currency.RMB);
            Item item7 = new Item("Work", Category.Income, "Salary", "Two month", 10000, Currency.USD, new DateTime(2019, 06, 07));
            Item item8 = new Item("Food", Category.Spending, 500, Currency.RMB, new DateTime(2019, 05, 06));
            Item item9 = new Item("Food", Category.Spending, 100, new DateTime(2019, 07, 06));

            AccountItem AccountList = new AccountItem();
            AccountList.AddItem(item1);
            AccountList.AddItem(item2);
            AccountList.AddItem(item3);
            AccountList.AddItem(item4);
            AccountList.AddItem(item5);
            AccountList.AddItem(item6);
            AccountList.AddItem(item7);
            AccountList.AddItem(item8);
            AccountList.AddItem(item9);

            Money totalRevenue = AccountList.TotalRevenue(DateTime.Now);
            Money totalExpenditure = AccountList.TotalExpenditure(DateTime.Now);
            Money totalIncome = AccountList.TotalIncome(DateTime.Now);
            AccountList.DisplayFunction(DateTime.Now, totalRevenue, "The total revenue is ");
            AccountList.DisplayFunction(DateTime.Now, totalExpenditure, "The total expenditure is ");
            AccountList.DisplayFunction(DateTime.Now, totalIncome, "The total income is ");

            Console.WriteLine("\n----The accountList of the required month----\n");
            foreach (Item item in AccountList.Display(DateTime.Now))
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
