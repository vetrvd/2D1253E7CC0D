using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSort
{
    /// <summary>
    /// Объект класса маршрутов
    /// </summary>
    public class Card
    {
        public City From { get; private set; }
        public City To { get; private set; }

        public Card(City from, City to)
        {
            if (from == null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            this.From = from;
            this.To = to;
        }

        public override string ToString()
        {
            return $"{this.From} -> {this.To}";
        }
    }
}
