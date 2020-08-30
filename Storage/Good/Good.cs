using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Good
    {
        string name;
        decimal price;
        public BaseGood baseGood;
        public Good(string name, decimal price, DateTime productionDate , int expiratonDate)
        {
            this.name = name;
            this.price = price;
            this.baseGood = new BaseGood(productionDate, expiratonDate);
        }
       public class BaseGood
        {
           DateTime productionDate;
           int expirationDate;

           public DateTime Expiration()
            {
                return productionDate.AddDays(expirationDate);
            }

            public BaseGood(DateTime productionDate, int expirationDate)
            {
                this.productionDate = productionDate;
                this.expirationDate = expirationDate;

            }
        }
        

    }
}
