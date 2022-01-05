using System;

namespace SF.Practices_17_6_6
{
    public interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // расчёт процентной ставки
        void CalculateInterest();
    }
}
