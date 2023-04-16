using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    
    public class Account
    {
        public string IBAN;
        protected float amount;
        public Transaction transaction;

        public bool Transaction(string transactionInfo)
        {
         
            return true;
        }

        
    }

    
    public class Investing : Account
    {
        public float interest;

        public void ApplyInterest()
        {
            
        }

      
    }

   
    public class Savings : Account
    {
        private float protectedAmount;

        public void LiberateSavings()
        {
           
        }

     
    }

}
