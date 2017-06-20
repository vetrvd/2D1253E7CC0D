using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardSort
{
    /// <summary>
    /// логер системы
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// логировать сообщение
        /// </summary>
        /// <param name="message"></param>
        void LogMessage(string message);

        /// <summary>
        /// логировать ошибку
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        void LogException(string message, Exception ex);
    }
}
