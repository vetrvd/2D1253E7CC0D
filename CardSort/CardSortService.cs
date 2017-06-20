using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSort
{
    /// <summary>
    /// Простая реализация алгоритма сортировки карточек
    /// Описание.
    /// 1) строим 2 хэштаблицы 
    /// 2) берем произвольный элемент из списка
    /// 3) начинаем делать обход
    /// 
    /// Текущая реализация имеет сложность - o(n)
    /// </summary>
    public class CardSortService :
        ICardSort
    {
        ILogger _logger = null;

        public CardSortService(
            ILogger logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            _logger = logger;
        }

        public Card[] Sort(Card[] cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException(nameof(cards));
            }

            if (cards.Any(it => it == null))
            {
                throw new ArgumentNullException("Коллекция содержит пустые элементы");
            }

            if (!cards.Any())
            {
                _logger.LogMessage($"Пустая коллекция не нуждается в сортировке");
                return cards;
            }


            _logger.LogMessage($"Начинается сортировка cards = { String.Join(",", cards.Select(it => it.ToString())) }");

            List<Card> result = new List<Card>();

            Card selectedItem, firstItem = cards.First();
            result.Add(firstItem);

            _logger.LogMessage($"Обход начинается с карточки = { firstItem }");

            
            ///записываем в конец списка последовательность после firstItem
            {
                Dictionary<City, Card> upper = cards.ToDictionary(it => it.From);
                selectedItem = firstItem;

                while (upper.TryGetValue(selectedItem.To, out selectedItem))
                {
                    result.Add(selectedItem);
                }
            }

            ///записываем в начало списка последовательность перед firstItem
            {
                Dictionary<City, Card> low = cards.ToDictionary(it => it.To);
                selectedItem = firstItem;

                while (low.TryGetValue(selectedItem.From, out selectedItem))
                {
                    result.Insert(0, selectedItem);
                }
            }

            _logger.LogMessage($"Сортировка окончена{ String.Join(",", result.Select(it => it.ToString())) }");
            return result.ToArray();
        }
    }
}
