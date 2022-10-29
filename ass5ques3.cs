using System;
using System.Collections.Generic;

class Employee
{


    static public void Main()
    {


        LinkedList<String> my_list = new LinkedList<String>();

        // Adding elements in the LinkedList
        // Using AddLast() method
        my_list.AddLast("arya");
        my_list.AddLast("ansh");
        my_list.AddLast("anup");
        my_list.AddLast("arush");
        my_list.AddLast("arohi");
        my_list.AddLast("abhay");


        Console.WriteLine("Name of employees:");


        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("Number of employees: {0}" +my_list.Count);
        if (my_list.Contains("Shilpa") == true)
        {
            Console.WriteLine("Element Found...!!");
        }
        else
        {
            Console.WriteLine("Element Not found...!!");
        }


    }
}