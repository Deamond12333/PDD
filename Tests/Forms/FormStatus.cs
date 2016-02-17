using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Tests.Forms
{
    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();

            XmlDocument xml = new XmlDocument();
            xml.Load("stata.xml");
            foreach(XmlNode node in xml.DocumentElement)
            {
                string[] row = new string[] { node.Attributes["Name"].Value, node.Attributes["Result"].Value, node.Attributes["Time"].Value};
                statTab.Rows.Add(row);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("stata.xml");
            xml.DocumentElement.RemoveAll();
            xml.Save("stata.xml");
            statTab.Rows.Clear();
        }

    }
}
