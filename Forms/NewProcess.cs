using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.Forms
{
    public partial class NewProcess : Form
    {
        public NewProcess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите имя программы или путь.");
                return;
            }

            try
            {
                Process.Start(input);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка запуска: " + ex.Message);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
