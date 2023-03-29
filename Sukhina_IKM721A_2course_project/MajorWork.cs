using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Sukhina_IKM721A_2course_project
{
    internal class MajorWork
    {
        private System.DateTime TimeBegin;
        private string Data; // Input data
        private string Result;
        public bool Modify;
        private int Key;

        public void SetTime() // метод запису часу початку роботи програми
        {
            this.TimeBegin = System.DateTime.Now;
        }

        public System.DateTime GetTime() // Метод отримання часу завершення програми
        {
            return this.TimeBegin;
        }

        private string SaveFileName;// ім’я файлу для запису
        private string OpenFileName;// ім’я файлу для читання
        public void WriteSaveFileName(string S)// метод запису даних в об'єкт
        {
            this.SaveFileName = S;// запам'ятати ім’я файлу для запису
        }
        public void WriteOpenFileName(string S)
        {
            this.OpenFileName = S;// запам'ятати ім’я файлу для відкриття
        }

        public void Write(string D) // Method for writing data to an object
        {
            this.Data = D;
        }
        public string Read()
        {
            return this.Result;
        }

        public void Task() // Software realization method
        {
            if (this.Data.Length > 5)
            {
                this.Result = Convert.ToString(true);
            }
            else
            {
                this.Result = Convert.ToString(false);
            }
            this.Modify = true;
        }
        public void SaveToFile() // Запис даних до файлу
        {
            if (!this.Modify)
                return;
            try
            {
                Stream S; 
                if (File.Exists(this.SaveFileName))
                    S = File.Open(this.SaveFileName, FileMode.Append);
                else
                    S = File.Open(this.SaveFileName, FileMode.Create);
                Buffer D = new Buffer(); 
                D.Data = this.Data;
                D.Result = Convert.ToString(this.Result);
                D.Key = Key;
                BinaryFormatter BF = new BinaryFormatter(); 
                S.Flush(); 
                S.Close(); 
                this.Modify = false; 
            }
            catch
            {
                MessageBox.Show("Помилка роботи з файлом"); 
            }
        }
    }
}
