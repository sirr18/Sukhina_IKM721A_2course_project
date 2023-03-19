using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhina_IKM721A_2course_project
{
    internal class MajorWork
    {
        private string Data; // Input data
        private string Result;

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
        }
    }
}
