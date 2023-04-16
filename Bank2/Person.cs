using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
   
    
        public abstract class Person
        {
            public int ID;
            public string name;
            protected string Phone;
            public string Email;
            public Adress Direccion;

            
        }
    public class Employee : Person
    {
        public Enum departament;
        private float salary;

       

       
    }

    
    public class Customer : Person
    {
        public DateTime registration;
        private int creditScore;
        public Account account;

        
    }

}
