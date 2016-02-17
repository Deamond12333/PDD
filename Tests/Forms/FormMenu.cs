using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tests
{
    public partial class FormMenu : Form
    {
        private readonly IEnumerable<Ticket> _tickets = null;
        private FormTests _formTests = null;

        public FormMenu()
        {
            InitializeComponent();
            _tickets = (new TicketFactory("tickets.tks")).CreateTickets(); //Получаем коллекцию билетов

            foreach (Ticket t in _tickets)
            {
                ButtonWithTicket button = DynamicControlGenerator.CreateButton(t);
                button.Click += Button_Click;
                flowPanel.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ButtonWithTicket button = sender as ButtonWithTicket;

            if (_formTests == null)
            {
                _formTests = new FormTests(button.Ticket);
                _formTests.FormClosed += FormTests_FormClosed;
                _formTests.Show(this);
            }
            else
            {

            }
        }

        private void FormTests_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formTests = null;
        }
    }
}
