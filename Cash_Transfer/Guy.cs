using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Transfer
{
    internal class Guy
    {
        public string name;
        public int cash;

        /// <summary>
        /// Выводит значение полей Name и Cash на консоль.
        /// </summary>
        public void WriteMyinfo() 
        {
            Console.WriteLine(name + " has " + cash + "bucks.");
        }
        /// <summary>
        /// Выдаёт часть денег, удаляет их и кармана (или выводит сообщение, что денег недостаточно)
        /// </summary>
        /// <param name="amount"> Выдаваемая сумма </param>
        /// <returns>
        /// Сумма денег, взятая из кармана или 0, если денег не хватает (Или ошибку, если сумма недействительна)
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(name + " says: " + amount + " isn't a valid amount");
                return 0;
            }
            if( amount > cash)
            {
                Console.WriteLine(name + " says: " + " I don't have enough cash to give you" + amount);
                return 0;
            }
            cash -= amount;
            return amount;
        }
        /// <summary>
        /// Получает деньги, добавляя их в карман (Или вывыоди сообщене о недействительной сумме)
        /// </summary>
        /// <param name="amount"> Получаемая сумма </param>
        public void ReceiveCash(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine(name + " says: " + amount + " isn't an amount I'll take");
            }
            else
            {
                cash += amount;
            }
        }
    }
}
