using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSort
{
    interface ICardSort
    {
        /// <summary>
        /// Метод сортировки карт путешествиника 
        /// </summary>
        /// <param name="cards">коллекция карт</param>
        /// <returns>отсортированная коллекция карт</returns>
        Card[] Sort(Card[] cards);
    }
}
