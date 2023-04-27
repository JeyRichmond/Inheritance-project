using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;
        
        public Company(params Employee[] employees)
        {
            this.employees = employees;
        }

        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee x in employees)
            {
                x.SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay()
        {
            decimal sum = 0;
            foreach (Employee x in employees)
            {
                sum += x.ToPay();
            }
            return sum;
        }

        public string NameMaxSalary()
        {
            decimal maxsalary = 0;
            string lastname = employees[0].Name;
            foreach(Employee x in employees)
            {
                decimal sal = x.ToPay();
                if (sal > maxsalary)
                {
                    maxsalary = sal;
                    lastname = x.Name;
                }
            }
            return lastname;
        }
    }
}
