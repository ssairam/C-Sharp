using System;
using System.Collections.Generic;
using System.Linq;

internal class Employee:IComparer<Employee>
{
    public string nameof { get; set; }
    public int Salary { get; set; }

    public void Run()
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        employees.Add(2, new Employee { nameof = "Veena", Salary = 200 });
        employees.Add(1, new Employee { nameof = "Sairam", Salary = 100 });
        employees.Add(3, new Employee { nameof = "Prianka", Salary = 300 });

        var values = employees.Values.ToList<Employee>();
        foreach (var v in values)
            Console.WriteLine(v.nameof);

        Console.WriteLine("-----------");

        values.Sort(new Employee());
        foreach (var v in values)
            Console.WriteLine(v.nameof);
    }

    public int Compare(Employee x, Employee y)
    {
        return x.Salary - y.Salary;
    }
}