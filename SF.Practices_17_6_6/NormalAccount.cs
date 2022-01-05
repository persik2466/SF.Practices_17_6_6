using System;

namespace SF.Practices_17_6_6
{
    /// <summary>
    /// Обычный счёт
    /// </summary>
    public class NormalAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        /// <summary>
        /// расчет процентной ставки обычного аккаунта по правилам банка
        /// </summary>
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}
