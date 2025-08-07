using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"Sum of numbers: {numbers.Sum()}");

            //TODO: Print the Average of numbers
            Console.WriteLine($"Average of numbers: {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console
            var numbersOrdered = numbers.OrderBy(x => x).ToList();
            Console.WriteLine($"Ordered numbers: ");
            numbersOrdered.ForEach(Console.WriteLine);

            //TODO: Order numbers in descending order and print to the console
            var numbersOrderedDes = numbers.OrderByDescending(x => x).ToList();
            Console.WriteLine($"Ordered numbers Descending: ");
            numbersOrderedDes.ForEach(Console.WriteLine);
            
            //TODO: Print to the console only the numbers greater than 6
            var numbersGreaterSix = numbers.Where(x => x>6).ToList().OrderByDescending(x => x).ToList();
            Console.WriteLine($"Numbers Greater Six: ");
            numbersGreaterSix.ForEach(Console.WriteLine);

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var numbersOnlyFour = numbers.Take(4).ToList();
            Console.WriteLine($"Numbers Only: 4");
            
            // numbersOnlyFour.ForEach(Console.WriteLine);
            foreach (var item in numbersOnlyFour)
            {
                Console.WriteLine(item);
            }
            
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 40;
            Console.WriteLine($"My Age is: 40");
            numbers.OrderByDescending(x=>x).ToList().ForEach(Console.WriteLine);
            

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var nameWithCorS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x =>x.FirstName).ToList();
            Console.WriteLine($"\nName Employees with C or S: ");
            nameWithCorS.ForEach(x=>Console.WriteLine($"FullName: {x.FullName}, Age: {x.Age}, Experience: {x.YearsOfExperience}"));
            
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var nameOver26 = employees.Where(x => x.Age>26).OrderBy(x =>x.Age).ThenBy(x=>x.FirstName).ToList();
            Console.WriteLine($"\nName Employees over 26: ");
            nameOver26.ForEach(x=>Console.WriteLine($"FullName: {x.FullName}, Age: {x.Age}, Experience: {x.YearsOfExperience}"));

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            
            var nameOver35Exp10years = employees.Where(x => x.Age>35 && x.YearsOfExperience <= 10).Sum(x=>x.YearsOfExperience);
            Console.WriteLine($"\nName Employees over 35 with less than 10 years expiriance: {nameOver35Exp10years.ToString()}");
            
            // var nameOver35Exp10 = employees.Where(x => x.Age>35 && x.YearsOfExperience >= 10).ToList();
            // nameOver35Exp10.ForEach(x=>Console.WriteLine($"FullName: {x.FullName}, Age: {x.Age}, Experience: {x.YearsOfExperience}"));

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var AverYOEless10 = employees.Where(x => x.Age>35 && x.YearsOfExperience <= 10).Average(year => year.YearsOfExperience);
            Console.WriteLine($"\nName Employees over 35 with less than 10 years expirience: {Math.Round(AverYOEless10,2)}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Full Employees List");
            var fullListEmployee = employees.ToList();
            fullListEmployee.ForEach(x=>Console.WriteLine($"Full list of employees: {x.FullName}, Age: {x.Age}, Experience: {x.YearsOfExperience}"));
            Console.WriteLine("\nNew Employee Has Been Created");
            
            var fullListAddedEmployees = employees.Append(new Employee("True", "Coder", 35, 15));
            var fullListAddedEmployee = fullListAddedEmployees.ToList();
            fullListAddedEmployee.ForEach(x=>Console.WriteLine($"Full list of employees: {x.FullName}, Age: {x.Age}, Experience: {x.YearsOfExperience}"));

            var squares = Enumerable.Range(1, 100).Average(x=>x*x);
            Console.WriteLine($"Average of numbers: {squares.ToString()}");
            Console.WriteLine($"sqrt of numbers: {Math.Sqrt(squares)}");
            // Console.WriteLine();

            // Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
