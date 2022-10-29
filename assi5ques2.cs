using System;
using System.Collections;

namespace ArrayListEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList personList = new ArrayList();
            personList.Add("Neha");
            personList.Add("Narul");
            personList.Add("Sapna");
            personList.Add("Ravina");
            for (int i = 0; i < personList.Count; i++)
            {
                string arrayItem = string.Format($"Name is {personList[i]}");
                Console.WriteLine(arrayItem);
            }
            Console.Read();
        }
    }
}
