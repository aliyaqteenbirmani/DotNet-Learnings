﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Matrix
    {
        int a, b, c, d;

        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
       
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a+obj2.a, obj1.b+obj2.b, obj1.c+obj2.c, obj1.d+obj2.d);
            return obj;
        }
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a-obj2.a, obj1.b-obj2.b, obj1.c-obj2.c, obj1.d-obj2.d);
            return obj;
        }
    }

    class TestMatrix
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(20, 18, 15, 14);
            Matrix m2 = new Matrix(19, 17, 14, 13);

            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);

            Console.ReadLine();
        }
    }
}