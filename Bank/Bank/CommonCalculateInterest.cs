using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Profiles
{
    /// <summary>
    /// Профиль для расчета процентной ставки обычного аккаунта по правилам банка
    /// </summary>
    public class CommonCalculateInterest : ICalculateProfile
    {

        public void CalculateInterest(Account account)
        {
            account.interest = account.balance * 0.4;

            if (account.balance < 1000)
            {
                account.interest -= account.balance * 0.2;
                
            }

            if (account.balance < 50000)
            {
                account.interest -= account.balance * 0.4;
               // Console.WriteLine($"Расчет процентной ставки обычного аккаунта по правилам банка: {account.Interest}");
            }

            Console.WriteLine($"Расчет процентной ставки обычного аккаунта по правилам банка: {account.interest}");
        }
    }
}
