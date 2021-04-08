using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Profiles
{
    /// <summary>
    /// Профиль для расчета процентной ставки зарплатного аккаунта по правилам банка
    /// </summary>
    public class SalaryCalculateInterest : ICalculateProfile
    {
        public void CalculateInterest(Account account)
        {
            account.interest = account.balance * 0.5;

            Console.WriteLine($"Расчет процентной ставки зарплатного аккаунта по правилам банка: {account.interest}");
        }
    }
}
