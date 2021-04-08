using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Profiles;

namespace Bank
{
    public class Calculator
    {
        /// <summary>
        /// Запускает расчеты ставки
        /// Загружает профиль в виде аргумента
        /// </summary>
        public void PerformCalculate(ICalculateProfile calculateProfile, Account account)
        {
            calculateProfile.CalculateInterest(account);
        }
    }
}
