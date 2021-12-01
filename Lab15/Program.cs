using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {

            ArithProgression arith1 = new ArithProgression(1, 5);
            arith1.setStart(5);
            Console.WriteLine(arith1.getNext()); 
            arith1.reset();
            GeomProgression geom1 = new GeomProgression(2,6);
            geom1.setStart(6);
            Console.WriteLine(geom1.getNext());
            geom1.reset();
            Console.ReadKey();



        }


    }
    interface ISeries
    {


        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {


        public int a1;

        public int d;
        public ArithProgression(int D, int A1)
        {
            d = D;
            a1 = A1;
        }

        public void setStart(int a1)
        {

            Console.WriteLine("Первый член арифметической прогрессии: {0}", a1);

        }

        public int getNext()
        {
            int result = a1 + d;
            return result;
        }

        public void reset()
        {
            Console.WriteLine("Первый член арифметической прогрессии: {0}", a1);
        }


    }
    class GeomProgression : ISeries
    {


        public int b1;
        public int q;
        public GeomProgression(int Q, int B1)
        {
            q = Q;
            b1 = B1;
        }

        public void setStart(int b1)
        {

            Console.WriteLine("Первый член арифметической прогрессии: {0}", b1);

        }

        public int getNext()
        {
            return b1 * q;
        }

        public void reset()
        {
            Console.WriteLine("Первый член арифметической прогрессии: {0}", b1);
        }


    }

}
