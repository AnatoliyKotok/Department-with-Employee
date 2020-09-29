using System;
using System.Collections.Generic;
using System.Text;

namespace Department_hw
{
    class Employee
    {
        string name;
        string surname;
        double selery;
        
        public  void EnterName()
        {
            Console.Write("Input name->");
            this.name = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i])||Char.IsPunctuation(name[i]))
                {
                    throw new Exception("Name has incorect sumbol");
                   
                }
            }
        }
        public void EnterSurName()
        {
            Console.Write("Input sur name->");
            this.surname = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < surname.Length; i++)
            {
                if (Char.IsDigit(surname[i]) || Char.IsPunctuation(surname[i]))
                {
                    throw new Exception("Sur name has incorect sumbol");

                }
            }
        }
        public void EnterSelery()
        {
            Console.Write("Input salary->");
            this.selery = checked(Convert.ToDouble(Console.ReadLine()));
            if (this.selery <= 0)
            {
                throw new Exception("Selery loss then zero");
            }
            string selery=this.selery.ToString();
            for (int i = 0; i < selery.Length; i++)
            {
                if (Char.IsLetter(selery[i]) || Char.IsPunctuation(selery[i]))
                {
                    throw new Exception("Selery was input incorect");
                }
            }
        }
        public override string ToString()
        {
            return $"Name->{this.name}\nSur name->{this.surname}\nSelery->{this.selery}\n";
        }
    }
}
