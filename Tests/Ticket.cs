using System;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Билет
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Вопросы к билету
        /// </summary>
        private readonly List<Question> _questions = new List<Question>();

        /// <summary>
        /// Получает коллекцию вопросов в билете
        /// </summary>
        public IEnumerable<Question> Questions { get { return _questions; } }

        /// <summary>
        /// Номер билета
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Создаёт билет
        /// </summary>
        public Ticket(int number)
        {
            Number = number;
        }


        /// <summary>
        /// Добавить вопрос
        /// </summary>
        /// <param name="question">вопрос</param>
        public void AddQuestion(Question question)
        {
            if (question == null)
                throw new ArgumentException("Некорректный аргумент");

            _questions.Add(question);
        }

        /// <summary>
        /// Добавить вопросы
        /// </summary>
        /// <param name="questions">вопросы</param>
        public void AddQuestions(IEnumerable<Question> questions)
        {
            if (questions == null)
                throw new ArgumentNullException("Задан пустой список ответов");

            foreach (Question q in questions)
                AddQuestion(q);
        }
    }
}
