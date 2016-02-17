using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tests
{
    /// <summary>
    /// Вопрос к билету
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Ответы к вопросу
        /// </summary>
        private readonly List<Answer> _answers = new List<Answer>();

        /// <summary>
        /// Получает коллекцию вопросов в билете
        /// </summary>
        public IEnumerable<Answer> Answers { get { return _answers; } }

        /// <summary>
        /// Картинка к вопросу, если она нужна
        /// </summary>
        public Image Image { get; private set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Text { get; private set; }

        public string Help { get; private set; }

        /// <summary>
        /// Создаёт вопрос
        /// </summary>
        /// <param name="s">текст вопроса</param>
        /// <param name="image">поясняющая картинка, если надо</param>
        public Question(string s, string help, Image image = null)
        {
            Image = image;
            Help = help;
            Text = s;
        }

        /// <summary>
        /// Правильный ответ
        /// </summary>
        public Answer RightAnswer { get; private set; }

        /// <summary>
        /// Добавить ответ
        /// </summary>
        /// <param name="answer">ответ</param>
        public void AddAnswer(Answer answer)
        {
            if (answer == null)
                throw new ArgumentException("Некорректный аргумент");

            _answers.Add(answer);
        }

        /// <summary>
        /// Добавить ответы
        /// </summary>
        /// <param name="answer">ответы</param>
        public void AddQuestions(IEnumerable<Answer> answers)
        {
            if (answers == null)
                throw new ArgumentNullException("Задан пустой список ответов");

            foreach (Answer a in answers)
                AddAnswer(a);
        }

        /// <summary>
        /// Задаёт правильный ответ к вопросу
        /// </summary>
        /// <param name="a">правильный ответ</param>
        public void SetRightAnswer(Answer a)
        {
            if (RightAnswer != null)
                throw new InvalidOperationException("Попытка переустановить правильный ответ");

            if (a == null)
                throw new ArgumentNullException();

            RightAnswer = a;
        }
    }
}
