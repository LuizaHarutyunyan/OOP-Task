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

        private int constant;
        private int power;
        private List<Polynomial> totalList = new List<Polynomial>();
        private int v;


        public Polynomial(int constant, int power)
        {
            this.constant = constant;
            this.power = power;
            totalList.Add(this);
        }

        public Polynomial(int constant)
        {
            this.constant = constant;
            totalList.Add(this);
        }


        public static Polynomial operator -(Polynomial i, Polynomial j)
        {
            j = j * -1;
            i.getTotalList().Add(j);
            return i;
        }

        public static Polynomial operator -(Polynomial i)
        {
            i = i * -1; 
            return i;
        }

        public static Polynomial operator +(Polynomial i, Polynomial j)
        {
            i.getTotalList().Add(j);
            return i;
        }

        public static Polynomial operator *(Polynomial i, int multiplikator)
        {
            i.setConstant(i.getConstant() * multiplikator);
            return i;
        }




        public String toString()
        {
            String result = "";
            foreach (var item in this.totalList)
            {
                if (item.getConstant() > 0)
                {
                    result = result + "+";
                }
                result = result + item.getConstant();
                if (item.getPower() != 0)
                {
                    result = result + "x^" + item.getPower();
                }
            }
            return result;
        }


        public List<Polynomial> getTotalList()
        {
            return this.totalList;
        }

        public int getConstant()
        {
            return this.constant;
        }

        public int getPower()
        {
            return this.power;
        }

        public void setConstant(int constant)
        {
            this.constant = constant;
        }




    }
}
