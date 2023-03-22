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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
                пускToolStripMenuItem.Text = "Стоп";
                this.Mode = false;
            }
            else
            {
                // After next click on the button, the fiels becomes inactive, the timer is stopped, the button changes value again
                // Also, the data is remembered, checked, and  true or false
                tbInput.Enabled = false;
                tClock.Stop();
                bStart.Text = "Пуск";
                пускToolStripMenuItem.Text = "Пуск";
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

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.ShowDialog();
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)// Виклик діалогового вікна збереження
            {
                MessageBox.Show(sfdSave.FileName);
            }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK) // Виклик діалогового вікна відкриття
            {
                MessageBox.Show(ofdOpen.FileName);
            }
        }

        private void проНакопичувачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] Disks = System.IO.Directory.GetLogicalDrives(); // Строковий масив з
            string disk = "";
            for (int i = 0; i < Disks.Length; i++)
            {
                try
                {
                    System.IO.DriveInfo D = new System.IO.DriveInfo(Disks[i]);
                    disk += D.Name + "-" + D.TotalSize*0.000000001 + "gb" + "-" + D.TotalFreeSpace*0.000000001 + "gb" 
                    + (char)13;// змінній присвоюється ім’я диска, загальна кількість місця и вільне місце на диску
                }
                catch
                {
                    disk += Disks[i] + "- не готовий" + (char)13; // якщо пристрій не готовий,то виведення на екран ім’я пристрою і повідомлення «не готовий»
                }
            }

            MessageBox.Show(disk, "Накопичувачі");
        }
    }
}

