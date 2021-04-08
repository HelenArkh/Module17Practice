using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Profiles;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            var account = new Account("Зарплатный", 900);

            var calculate = new Calculator();


            //расчеты для обычного аккаунта
            if (account.type == "Обычный")
                calculate.PerformCalculate(new CommonCalculateInterest(), account);

            // расчеты для зарплатного аккаунта
            if (account.type == "Зарплатный")
                calculate.PerformCalculate(new SalaryCalculateInterest(), account);

            Console.ReadLine();
        }
    }
}
