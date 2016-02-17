using System;
using System.Windows.Forms;

namespace Tests
{
    /// <summary>
    /// Кнопка, которая содержит данные о билете
    /// </summary>
    internal class ButtonWithTicket : Button
    {
        /// <summary>
        /// Билет, который привязан к кнопке
        /// </summary>
        public Ticket Ticket { get; internal set; }
    }
}
