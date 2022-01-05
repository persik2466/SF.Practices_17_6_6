using System;

namespace SF.Practices_17_6_6
{
    /// <summary>
    /// Зарплатный счёт
    /// </summary>
    public class SalaryAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        /// <summary>
        /// расчет процентной ставки зарплатного аккаунта по правилам банка
        /// </summary>
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
