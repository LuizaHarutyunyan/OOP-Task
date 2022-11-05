using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace Task5
{
    internal class Polynomial
    {
        private int[] items;
        public Polynomial(int[] items)
        {
            this.items = items;
        }

        public static Polynomial operator +(Polynomial first, Polynomial second)
        {
            int[] result = first.items.Length > second.items.Length ? first.items : second.items;
            int[] smallest = second.items.Length > first.items.Length ? second.items : first.items;
            for (int i = 0; i < smallest.Length; i++)
            {
                result[i] = result[i] + smallest[i];
            }
            return new Polynomial(result);
        }

        public static Polynomial operator -(Polynomial first, Polynomial second)
        {
            int[] result = first.items.Length > second.items.Length ? first.items : second.items;
            int[] smallest = second.items.Length > first.items.Length ? second.items : first.items;
            for (int i = 0; i < smallest.Length; i++)
            {
                result[i] = result[i] - smallest[i];
            }
            return new Polynomial(result);
        }

        public static Polynomial operator *(Polynomial first, Polynomial second)
        {
            int[] result = new int[(first.items.Length + second.items.Length) - 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < first.items.Length; i++)
            {
                for (int j = 0; j < second.items.Length; j++)
                {
                    result[i+j] += first.items[i]  * second.items[j];
                }
            }
            return new Polynomial(result);
        }

        public override string ToString()
        {
            StringBuilder polinomial = new StringBuilder();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != 0)
                {
                    if (items[i] > 0 && i < items.Length && i>0)
                    {
                        polinomial.Append("+");
                    }
                    polinomial.Append(items[i]);
                    if (i >1 )
                    {
                        polinomial.Append("x^" + i);
                    }
                    if(i == 1)
                    {
                        polinomial.Append("x");
                    }
                   
                }
            }
            return polinomial.ToString();

        }

        // items = [1,2,3,4]  4x^3 + 3x^2 + 2x + 1

    }
}
