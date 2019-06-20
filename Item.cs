using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp.Properties
{
    public enum Category { Spending,Income};
    public class Item
    {
        protected string Name { get; set; }
        protected string Content { get; set; }
        protected string Note { get; set; }
        public DateTime OccuredTime;
        public Category category;
        public Money Amount;

        //public Item(string name, Category category) : this(name, category, "None", "None", 0, Currency.RMB, DateTime.Now) { }
        //public Item(string name, Category category,DateTime occuredTime) : this(name, category, "None", "None", 0, Currency.RMB, occuredTime) { }
        public Item(string name, Category category,double amount) : this(name, category, "None", "None", amount, Currency.RMB, DateTime.Now) { }
        public Item(string name, Category category, string content, double amount) : this(name, category, content, "None", amount, Currency.RMB, DateTime.Now) { }
        public Item(string name, Category category, double amount, DateTime occuredTime) : this(name, category, "None", "None", amount, Currency.RMB, occuredTime) { }
        public Item(string name, Category category, double amount,Currency currency) : this(name, category, "None", "None", amount, currency, DateTime.Now) { }
        public Item(string name, Category category, double amount, Currency currency, DateTime occuredTime) : this(name, category, "None", "None", amount, currency, occuredTime) { }
        public Item(string name, Category category,string content, double amount, Currency currency) : this(name, category,content, "None", amount, currency, DateTime.Now) { }
        //public Item(string name, Category category, string note, double amount, Currency currency) : this(name, category, "None", note, amount, currency, DateTime.Now) { }
        public Item(string name, Category category, string content, double amount, Currency currency, DateTime occuredTime) : this(name, category, content, "None", amount, currency, occuredTime) { }
        public Item(string name, Category category, string content, string note, double amount, Currency currency) : this(name, category, content, note, amount, currency, DateTime.Now) { }
        public Item(string name, Category category, string content, string note,double amount,Currency currency,DateTime occuredTime)
        {
            this.Name = name;
            this.category = category;
            this.Content = content;
            this.Note = note;
            this.Amount = new Money(amount, currency);
            this.OccuredTime = occuredTime;
        }


        public override string ToString()
        {
            return $"{OccuredTime.ToString("d")} ||{Name}||{category}{Amount.ToString()}||{Content}||{Note}";
        }
    }
}
