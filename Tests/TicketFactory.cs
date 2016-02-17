using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Drawing;

namespace Tests
{
    /// <summary>
    /// Фабрика билетов
    /// </summary>
    public class TicketFactory
    {
        /// <summary>
        /// Путь к xml-файлу с билетами
        /// </summary>
        private readonly string _filePath;

        public TicketFactory(string file)
        {
            if (!File.Exists(file))
                throw new ArgumentException("Не найден файл с билетами");

            _filePath = file;
        }

        /// <summary>
        /// Создаёт коллекцию билетов, готовых для проведения теста.
        /// </summary>
        /// <returns>коллекция билетов</returns>
        public IEnumerable<Ticket> CreateTickets()
        {
            List<Ticket> list = new List<Ticket>();
            XmlDocument xml = new XmlDocument();
            xml.Load(_filePath);

            //Перебираем все билеты
            foreach (XmlNode node in xml.DocumentElement)
            {
                int number = Convert.ToInt32(node.Attributes["Number"].Value); //Получить номер билета
                Ticket ticket = new Ticket(number); //Создаём билет

                //Заполнить билет вопросами
                FillQuestions(ticket, node);

                list.Add(ticket);
            }

            return list;
        }

        private void FillQuestions(Ticket ticket, XmlNode nodes)
        {
            //Перебираем все вопросы для билета
            foreach (XmlNode node in nodes.ChildNodes)
            {
                //Текст вопроса
                string text = node.Attributes["Text"].Value;

                //Подсказка
                string help = node.Attributes["Help"].Value; 
                
                //Загружаем картинку, если она есть
                Image image = null;
                XmlNode n = node.Attributes.GetNamedItem("Image");
                if (n != null)
                    image = Image.FromFile(n.Value);

                //Создаём вопрос
                Question question = new Question(text, help, image);

                //Заполнить вопрос ответами
                FillAnswers(question, node);

                ticket.AddQuestion(question);
            }
        }

        private void FillAnswers(Question question, XmlNode nodes)
        {
            //Перебираем все ответы для вопроса
            foreach (XmlNode node in nodes.ChildNodes)
            {
                //Текст ответа
                string text = node.Attributes["Text"].Value; //Текст вопроса

                //Загружаем картинку, если она есть
                Image image = null;
                XmlNode n = node.Attributes.GetNamedItem("Image");
                if (n != null)
                    image = Image.FromFile(n.Value);

                //Создаём ответ
                Answer answer = new Answer(text, image);

                //Если ответ помечен как правильный, то устанавливаем его для вопроса
                XmlNode right = node.Attributes.GetNamedItem("IsRight");
                if (right != null)
                    question.SetRightAnswer(answer);

                //Добавляем ответ в вопрос
                question.AddAnswer(answer);
            }
        }
    }
}
