using System;

namespace SF.Practices_17_6_6
{
    /// <summary>
    /// Класс расчёта процентной ставки
    /// </summary>
    public class Calculator
    {
        // Метод для расчета процентной ставки
        public void CommonInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
