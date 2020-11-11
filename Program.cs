using System;
using System.Collections.Generic;


namespace ColectionsTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, string> staffs = new Dictionary<string, string>();
            staffs.Add("Tom Lee", "Training");
            staffs.Add("James Anderson", "HR");
            staffs.Add("Michael Chan", "Content Development");
            staffs.Add("Jackie Jackson", "Training");
            staffs.Add("Bruce Douglas", "Graphics");
            staffs.Add("Kim Date", "HR");
            staffs.Add("Joseph Mathews", "Content Development");
            staffs.Add("Rose Dorson", "Marketing");
            staffs.Add("Andrews Stephan", "Graphics");


             foreach (var item in staffs)
            {
                Console.WriteLine($" {item.Key} : {item.Value}\n");

            }

            
            if(staffs.ContainsKey("Andrews Stephan"))
            {
                staffs.Remove("Andrews Stephan");
            }


            Console.Write("\nStaffs after removing key Andrews\n\n");

             foreach (var item in staffs)
            {
                Console.WriteLine($"Name: {item.Key}, Department: {item.Value}");

            }


                
                
            SortedList<string, string> sortedStaffs = new SortedList<string, string>();

            sortedStaffs.Add("Tom Lee", "Training");
            sortedStaffs.Add("James Anderson", "HR");
            sortedStaffs.Add("Michael Chan", "Content Development");
            sortedStaffs.Add("Jackie Jackson", "Training");
            sortedStaffs.Add("Bruce Douglas", "Graphics");
            sortedStaffs.Add("Kim Date", "HR");
            sortedStaffs.Add("Joseph Mathews", "Content Development");
            sortedStaffs.Add("Rose Dorson", "Marketing");
            sortedStaffs.Add("Andrews Stephan", "Graphics");


                Console.WriteLine("Using the SortedList generic class");
                Console.WriteLine();


                foreach (var staff in sortedStaffs)
                {
                    Console.WriteLine($" Staffs: {staff.Key}, \tDEpartment: {staff.Value}\t");
                }

                        Console.WriteLine(" using Sortedlist properties");


                        Console.WriteLine();

                    Console.WriteLine($"Staffs Capacity: {sortedStaffs.Capacity}");

                        Console.WriteLine();


                        Console.WriteLine($"Number of SortedStaffs: {sortedStaffs.Count}");

                            Console.WriteLine();


                                            

             


        }
    }
}
