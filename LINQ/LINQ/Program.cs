using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firm> firms = new List<Firm>
            {
                new Firm
                {
                    Name = "White Food Company",
                    FoundationDate = DateTime.Now.AddYears(-3),
                    BusinessProfile = "Marketing",
                    DirectorFullName = "John White",
                    EmployeesCount = 150,
                    Address = "London",
                    Employees = new List<Employee>
                    {
                        new Employee{ FullName="Lionel Messi", Position="Manager", Phone="2311111", Email="di_manager@gmail.com", Salary=5000 },
                        new Employee{ FullName="David Brown", Position="Developer", Phone="4511111", Email="dev@gmail.com", Salary=4000 }
                    }
                },

                new Firm
                {
                    Name = "Black IT Solutions",
                    FoundationDate = DateTime.Now.AddDays(-123),
                    BusinessProfile = "IT",
                    DirectorFullName = "James Black",
                    EmployeesCount = 250,
                    Address = "Paris",
                    Employees = new List<Employee>
                    {
                        new Employee{ FullName="Lionel Richie", Position="Manager", Phone="2399999", Email="director@gmail.com", Salary=7000 }
                    }
                }
            };

          
            //1
       

            Console.WriteLine("=== ВСЕ ФИРМЫ ===");
            var allFirms = from f in firms select f;
            foreach (var f in allFirms)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== Название содержит Food ===");
            var foodFirms = from f in firms
                            where f.Name.Contains("Food")
                            select f;
            foreach (var f in foodFirms)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== Маркетинг ===");
            var marketing = from f in firms
                            where f.BusinessProfile == "Marketing"
                            select f;
            foreach (var f in marketing)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== Маркетинг или IT ===");
            var marketingOrIT = from f in firms
                                where f.BusinessProfile == "Marketing"
                                   || f.BusinessProfile == "IT"
                                select f;
            foreach (var f in marketingOrIT)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== > 100 сотрудников ===");
            var more100 = from f in firms
                          where f.EmployeesCount > 100
                          select f;
            foreach (var f in more100)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== 100-300 сотрудников ===");
            var range = from f in firms
                        where f.EmployeesCount >= 100 && f.EmployeesCount <= 300
                        select f;
            foreach (var f in range)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== В Лондоне ===");
            var london = from f in firms
                         where f.Address == "London"
                         select f;
            foreach (var f in london)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== Директор White ===");
            var directorWhite = from f in firms
                                where f.DirectorFullName.Contains("White")
                                select f;
            foreach (var f in directorWhite)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== Старше 2 лет ===");
            var older2 = from f in firms
                         where (DateTime.Now - f.FoundationDate).TotalDays > 365 * 2
                         select f;
            foreach (var f in older2)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== Ровно 123 дня ===");
            var days123 = from f in firms
                          where (DateTime.Now - f.FoundationDate).Days == 123
                          select f;
            foreach (var f in days123)
                Console.WriteLine(f.Name);

            Console.WriteLine("\n=== Director Black И название содержит White ===");
            var complex = from f in firms
                          where f.DirectorFullName.Contains("Black")
                             && f.Name.Contains("White")
                          select f;
            foreach (var f in complex)
                Console.WriteLine(f.Name);


           
            //2
            

            var methodExample = firms
                .Where(f => f.BusinessProfile == "IT");

            //3 
          

            Console.WriteLine("\n=== Сотрудники White Food Company ===");
            var employeesFirm = firms
                .First(f => f.Name.Contains("White"))
                .Employees;
            foreach (var e in employeesFirm)
                Console.WriteLine(e.FullName);

            Console.WriteLine("\n=== Зарплата > 4500 ===");
            var highSalary = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Salary > 4500);
            foreach (var e in highSalary)
                Console.WriteLine(e.FullName);

            Console.WriteLine("\n=== Все менеджеры ===");
            var managers = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Position == "Manager");
            foreach (var e in managers)
                Console.WriteLine(e.FullName);

            Console.WriteLine("\n=== Телефон начинается с 23 ===");
            var phone23 = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Phone.StartsWith("23"));
            foreach (var e in phone23)
                Console.WriteLine(e.FullName);

            Console.WriteLine("\n=== Email начинается с di ===");
            var emailDi = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.Email.StartsWith("di"));
            foreach (var e in emailDi)
                Console.WriteLine(e.FullName);

            Console.WriteLine("\n=== Имя Lionel ===");
            var lionel = firms
                .SelectMany(f => f.Employees)
                .Where(e => e.FullName.StartsWith("Lionel"));
            foreach (var e in lionel)
                Console.WriteLine(e.FullName);

            Console.ReadLine();
        }
    }
}
