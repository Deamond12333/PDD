using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tests
{
    /// <summary>
    /// Ответ на вопрос
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Картинка к ответу, если она нужна
        /// </summary>
        public Image Image { get; private set; }

        /// <summary>
        /// Текст ответа
        /// </summary>
        public string Text { get; private set; }

        public Answer(string s, Image image = null)
        {
            Image = image;
            Text = s;
        }
    }
}
