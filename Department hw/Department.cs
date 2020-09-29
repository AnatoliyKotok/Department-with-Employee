using System;
using System.Collections.Generic;
using System.Text;

namespace Department_hw
{
    class Department
    {
        static int size = 5;
        Employee[] arr = new Employee[size];
        public static int index = 0;
        public  void AddEmployee(Employee e)
        {
            arr[index] = e;
            ++index;
            if (index > size)
            {
                throw new Exception("Array employees is full");
            }
        }
        public void dellEmployee(Employee e)
        {
            bool found = false;
            if (arr == null)
            {
                throw new Exception("Array is empty");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == e)
                {
                    found = true;
                    arr[i] = null;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Employee not found");
            }
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine();
            }
        }
    }
}
