using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Xml;
using Tests.Forms;

namespace Tests
{
    public partial class FormTests : Form
    {
        public int _rightAnswers = 0; //Количество правильных ответов
        public int _badAnswers = 0; //Количество неправильных ответов
        private List<Question> _questions = null; //Список вопросов для выбранного билета
        private Question _currentQuestion; //Текущий вопрос
        private int timeLeft, allTime = 0; //Время ответа на вопрос
        private string name = null; //Имя оппонента

        public FormTests()
        {
            InitializeComponent();
        }

        public FormTests(Ticket ticket)
            : this()
        {
            if (ticket == null)
                throw new ArgumentNullException("Не задан билет");

            _questions = ticket.Questions.ToList<Question>();
            Text = "Тестирование по билету №" + ticket.Number;
            NextQuestion();
        }
        /// <summary>
        /// Запуск таймера
        /// </summary>
        private void TimerStart() 
        {
            timeLeft = 59;
            timerLabel.Text = "Осталось 59 секунд";
            timerLabel.ForeColor = Color.Black;
            timerQuest.Start();
        }

        private void TestEnded()
        {
            //тест окончен. Результат теста.
            XmlDocument xml = new XmlDocument();
            xml.Load("stata.xml");
            XmlNode addNode = xml.CreateElement("Opponent");
            XmlNode xn = xml.DocumentElement;
            XmlAttribute nam = xml.CreateAttribute("Name");
            XmlAttribute res = xml.CreateAttribute("Result");
            XmlAttribute tim = xml.CreateAttribute("Time");
            nam.Value = name;
            FormResult result = new FormResult();
            if (_badAnswers >= 3)
            {
                result.label1.Text = "Не сдал!";
                result.label1.ForeColor = Color.Red;
                result.label2.Text = "Ошибок: " + _badAnswers + " из 20";
                result.label2.ForeColor = Color.Red;
                result.pictureBox1.Image = Properties.Resources.Bad;
                res.Value = "Не сдал(а)";
            }
            else
            {
                result.label1.Text = "Поздравляем!";
                result.label1.ForeColor = Color.Green;
                result.label2.Text = "Правильных: " + _rightAnswers + " из 20";
                result.label2.ForeColor = Color.Green;
                result.pictureBox1.Image = Properties.Resources.Good;
                res.Value = "Сдал(а)";
            }
            result.ShowDialog();
            if ((int)(allTime % 60) < 10)
                tim.Value = (int)(allTime - allTime % 60) / 60 + ":0" + (int)(allTime % 60);
            else
                tim.Value = (int)(allTime - allTime % 60) / 60 + ":" + (int)(allTime % 60);
            addNode.Attributes.Append(nam);
            addNode.Attributes.Append(res);
            addNode.Attributes.Append(tim);
            xn.AppendChild(addNode);
            xml.Save("stata.xml");
            Close();
        }
        /// <summary>
        /// Отображает вопрос для ответа на форме
        /// </summary>
        private void NextQuestion()
        {
            if (_questions.Count == 0)
                TestEnded();
            else
            {
                _currentQuestion = _questions[0];
                RefreshForm();
            }
        }
        /// <summary>
        /// Обновить форму для нового вопроса
        /// </summary>
        private void RefreshForm()
        {
            labelQuestion.Text = _currentQuestion.Text;
            if (_currentQuestion.Image != null)
                pictureBox1.Image = _currentQuestion.Image;

            flowPanel.Controls.Clear();
            foreach (Answer answer in _currentQuestion.Answers)
            {
                RadioButtonWithAnswer button = DynamicControlGenerator.CreateRadioButton(answer);
                flowPanel.Controls.Add(button);
                flowPanel.SetFlowBreak(button, true);
            }

            labelCount.Text = "Осталось вопросов: " + (_questions.Count - 1);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            panelQuestion.Visible = true;
            identPanel.Visible = false;
            TimerStart();
        }
        //Пользователь нажал ответить
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            RadioButtonWithAnswer answerRadio = null;
            foreach (RadioButtonWithAnswer radioButton in flowPanel.Controls.OfType<RadioButtonWithAnswer>())
                if (radioButton.Checked)
                {
                    answerRadio = radioButton;
                    break;
                }

            if (answerRadio == null)
            {
                MessageBox.Show("Выберите ответ", "Не выбран ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Answer answer = answerRadio.Answer;
                if (answer == _currentQuestion.RightAnswer)
                {
                    timerQuest.Stop();
                    _rightAnswers++; //был правильный ответ
                }
                else
                {
                    timerQuest.Stop();
                    MessageBox.Show(_currentQuestion.Help, "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _badAnswers++; //был неправильный ответ
                }
                allTime += (59 - timeLeft);
                _questions.Remove(_currentQuestion);
                NextQuestion();
                TimerStart();
            }
        }
        /// <summary>
        /// Интервал таймера
        /// </summary>
        private void timerQuest_Tick(object sender, EventArgs e)
        {
            if (timeLeft < 12) timerLabel.ForeColor = Color.Red;

            if (timeLeft > 0)
            {
                timeLeft -= 1;
                timerLabel.Text = "Осталось " + timeLeft + " секунд";
            }
            else
            {
                timerQuest.Stop();
                MessageBox.Show("Попробуйте еще раз!", "Время вышло", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XmlDocument xml = new XmlDocument();
                xml.Load("stata.xml");
                XmlNode xn = xml.DocumentElement;
                XmlNode addNode = xml.CreateElement("Opponent");
                XmlAttribute nam = xml.CreateAttribute("Name");
                XmlAttribute res = xml.CreateAttribute("Result");
                XmlAttribute tim = xml.CreateAttribute("Time");
                nam.Value = name;
                res.Value = "Не сдал(а)";
                tim.Value = "Время вышло";
                addNode.Attributes.Append(nam);
                addNode.Attributes.Append(res);
                addNode.Attributes.Append(tim);
                xn.AppendChild(addNode);
                xml.Save("stata.xml");
                Close();
            }
        }
        //Закрываем форму
        private void FormTests_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerQuest.Stop();
            panelQuestion.Controls.Clear();
        }
    }
}
