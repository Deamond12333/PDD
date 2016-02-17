using System;
using System.Windows.Forms;
using System.Drawing;

namespace Tests
{
    internal static class DynamicControlGenerator
    {
        public static ButtonWithTicket CreateButton(Ticket ticket)
        {
            return new ButtonWithTicket()
            {
                BackColor = Color.Lime,
                Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                Size = new Size(88, 36),
                Text = "Билет " + ticket.Number,
                UseVisualStyleBackColor = false,
                Ticket = ticket
            };
        }

        public static RadioButtonWithAnswer CreateRadioButton(Answer answer)
        {
            return new RadioButtonWithAnswer()
            {
                AutoSize = false,
                Width = 650,
                Height = 65,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                Text = answer.Text,
                UseVisualStyleBackColor = true,
                Answer = answer
            };
        }
    }
}
