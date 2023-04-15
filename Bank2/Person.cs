using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
   
    
        public abstract class Person
        {
            protected int ID;
            protected string name;
            private string Phone;
            private string Email;
            protected Adress Direccion;

            
        }
    public class Employee : Person
    {
        private Departament departament;
        private float salary;

        public enum Departament
        {
            
        }

       
    }

    
    public class Customer : Person
    {
        private DateTime registration;
        private int creditScore;
        private Account account;

        
    }

}
