using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using System.IO;

namespace Parser_for_DNS
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logger.Info("TEST: Нажата кнопка Run");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logger.Info("TEST: Нажата кнопка Clear");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Info("TEST: Нажата кнопка Setting");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logger.Info("TEST: Нажата кнопка About");
            MessageBox.Show("DNS Parser v0.1a " +
                            "\nНа текущий момент умеет нифига" +
                            "\nПодключены библиотеки AngleSharp, Leaf.xNet и NLog");
        }
    }
}
