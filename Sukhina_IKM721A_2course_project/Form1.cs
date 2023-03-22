using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sukhina_IKM721A_2course_project
{
    public partial class Form1 : Form
    {
        private bool Mode; // Working mode
        MajorWork MajorObject; // Create object
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            About A = new About();
            A.tAbout.Start();
            A.ShowDialog();
            MajorObject = new MajorWork();
            MajorObject.SetTime();
            this.Mode = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                //After clicking the button, the field becomes active, the timer is started, the button changes value
                tbInput.Enabled = true;// Режим дозволу введення
                tbInput.Focus();
                tClock.Start();
                bStart.Text = "Стоп"; // зміна тексту на кнопці на "Стоп"
                this.Mode = false;
            }
            else
            {
                // After next click on the button, the fiels becomes inactive, the timer is stopped, the button changes value again
                // Also, the data is remembered, checked, and  true or false
                tbInput.Enabled = false;
                tClock.Stop();
                bStart.Text = "Пуск";
                this.Mode = true;
                MajorObject.Write(tbInput.Text);
                MajorObject.Task();
                label1.Text = MajorObject.Read();
            }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //When you press a key, the timer reloads
            tClock.Stop();
            tClock.Start();

            if ((e.KeyChar >= '0' && e.KeyChar <= '9') | (e.KeyChar == (char)8)) // You can enter only digits
            {
                return;
            }
            else
            {
                //When you enter a wrong symbol, the error message appears, the timer reloads, and the wrong symbol disappears
                tClock.Stop();
                MessageBox.Show("Неправильний символ", "Помилка");
                tClock.Start();
                e.KeyChar = (char)0;

            }
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("The time has passed!");// Showing the Message
            tClock.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string s;
            s = (System.DateTime.Now - MajorObject.GetTime()).ToString();
            MessageBox.Show(s, "Час роботи програми"); 
        }
    }
}
