using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16
{
    public class Calculator
    {
        public int Additional(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Miltiplication(int a, int b)
        {
            return checked(a * b); //Добавил ключевое слово checked, чтобы форсировать проверку на переполнение. Был удивлен поведению по умолчанию o_O
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
