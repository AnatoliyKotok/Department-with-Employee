using System;

namespace Department_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee e = new Employee();
                e.EnterName();
                e.EnterSurName();
                e.EnterSelery();
                Employee e2 = new Employee();
                e2.EnterName();
                e2.EnterSurName();
                e2.EnterSelery();
               // Console.WriteLine(e);
                Department d = new Department();
                d.AddEmployee(e);
                d.AddEmployee(e2);
                d.dellEmployee(e2);
                d.Print();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
