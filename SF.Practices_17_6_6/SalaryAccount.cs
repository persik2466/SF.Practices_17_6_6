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
        /// Расчёт процентной ставки в зависимости от баланса
        /// </summary>
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
