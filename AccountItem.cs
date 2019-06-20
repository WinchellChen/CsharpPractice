using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp.Properties
{
    public class AccountItem
    {
        private List<Item> AccountList = new List<Item>();
        public void AddItem(Item item)
        {
            AccountList.Add(item);
        }

        public Money TotalRevenue(DateTime time)
        {
            Money revenue = new Money();
            foreach (Item item in AccountList)
            {
                if(item.category ==Category.Spending && item.OccuredTime.ToString("y") == time.ToString("y"))
                {
                    revenue -= item.Amount;
                }
                if (item.category== Category.Income)
                {
                    revenue += item.Amount;
                }
            }
            return revenue;
        }
        public Money TotalIncome(DateTime time)
        {
            Money income = new Money();
            foreach (Item item in AccountList)
            {
                
                if (item.category == Category.Income && item.OccuredTime.ToString("y") == time.ToString("y"))
                {
                    income += item.Amount;
                }
            }
            return income;

        }

        public Money TotalExpenditure(DateTime time)
        {
            Money expenditure = new Money();
            foreach (Item item in AccountList)
            {

                if (item.category == Category.Spending && item.OccuredTime.ToString("y") == time.ToString("y"))
                {
                    expenditure += item.Amount;
                }
            }
            return expenditure;

        }

        public void DisplayFunction(DateTime time,Money money,string str)
        {
            Console.WriteLine(time.ToString("MMMM") + str + money);
        }

        public IEnumerable<Item> Display(DateTime time)
        {
            foreach (Item item in AccountList)
            {
                if(item.OccuredTime.ToString("y") == time.ToString("y"))
                {
                    yield return item;
                }
            }
        }


    }
}
