﻿using Visitor.EmployeeGroup;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
        }
    }
}


