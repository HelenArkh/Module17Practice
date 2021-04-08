using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Profiles
{
    /// <summary>
    /// Общий интерфейс для расчета процентной ставки
    /// </summary>
    public interface ICalculateProfile
    {
        void CalculateInterest(Account account);
    }
}
