using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testz.App.Classes
{
    public class Result
    {
        public int[] Array { get; set; }
        public int[] ResultArray { get; set; }
        public int Loops { get; set; }
        public int EqualsLoop { get; set; }
        public override string ToString()
        {
            return string.Format("Начальный массив - [{0}]\nКонечный массив - [{1}]\nВыполнено итераций - {2}\nЦиклических итераций - {3}\n", 
                string.Join(", ", Array), string.Join(", ", ResultArray), Loops, EqualsLoop);
        }
    }
}
