using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    
    public abstract class Account
    {
        private string iban;
        protected float amount;
        private Transaction transaction;

        public bool Transsaction(string details)
        {
         
            return true;
        }

        
    }

    
    public class Investing : Account
    {
        private float interest;

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
