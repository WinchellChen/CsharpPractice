using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp.Properties
{
    public enum Currency
    {
        RMB, USD, EUR,
    }
    public class Money
    {
        public double FaceValue;
        public Currency currency;

        private double GetTrueValue
        {
            get
            {
                switch(this.currency)
                {
                    case Currency.RMB:
                        return FaceValue;
                    case Currency.EUR:
                        return FaceValue * 8.0;
                    case Currency.USD:
                        return FaceValue * 7.0;
                    default:
                        Console.WriteLine("包含非法输入");
                        return 0;
                }
            }
        }

        //Constructor
        public Money()
        {
            FaceValue = 0;
            currency = Currency.RMB;
        }

        public Money(double faceValue)
        {
            FaceValue = faceValue;
            currency = Currency.RMB;
        }
        public Money(double faceValue,Currency currency)
        {
            FaceValue = faceValue;
            this.currency = currency;
        }

        //reload of operator
        public static Money operator +(Money money1,Money money2)
        {
            double TotalFaceValue = money1.FaceValue + money2.FaceValue;
            return new Money(TotalFaceValue);

        }
        public static Money operator -(Money money1, Money money2)
        {
            double TotalFaceValue = money1.FaceValue - money2.FaceValue;
            return new Money(TotalFaceValue);

        }

        public override string ToString()
        {
            return $"{ this.FaceValue} { this.currency}";
        }

    }
}
