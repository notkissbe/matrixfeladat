using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace matrixfeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] pontok;

            int kutyaszam = 2;
            int szempontok = 3;
            // fej, szor, okos - >ez harom szempont

            pontok = new int[kutyaszam, szempontok];

            int[] maxpontok = { 5, 10, 10 };
            int[] alsopontok = { 1, 3, 3 };
            Random r = new Random();

            for (int i = 0; i < pontok.GetLength(0); i++)
            {
                for (int j = 0; j < pontok.GetLength(1); j++)
                {
                    pontok[i, j] = r.Next(0, maxpontok[j]);
                }
            }

            

            void Kiiras()
            {
                for (int i = 0; i < pontok.GetLength(0); i++)
                {
                    for (int j = 0; j < pontok.GetLength(1); j++)
                    {
                        Console.Write(pontok[i, j] + " ");
                    }
                    Console.Write("\n");
                }
            }
            //kiesett az amelyik elso erteke 10
            void AutoKieso()
            {
                List<int> kieso = new List<int>();
                for (int i = 0; i < pontok.GetLength(0); i++)
                {
                    for (int j = 0; j < pontok.GetLength(1); j++)
                    {
                        if (pontok[i, j] < alsopontok[j] && !(kieso.Contains(i)))
                        {
                            kieso.Add(i);
                            Console.WriteLine(i);
                        }
                    }
                    
                }

            }

            bool MindbenGyoztes()
            {
                // szama, erteke, holtverseny
                int[] elso = { 0, 0, 0 };
                int[] masodik = { 0, 0, 0 };
                int[] harmadik = { 0, 0, 0 };

                

                for (int i = 0; i < pontok.GetLength(0); i++)
                {
                    if (elso[1] < pontok[i,0])
                    {
                        elso[0] = i;
                        elso[1] = pontok[i, 0];
                    }
                    
                }
                for (int i = 0; i < pontok.GetLength(0); i++)
                {
                    if (masodik[1] < pontok[i,1])
                    {
                        masodik[0] = i;
                        masodik[1] = pontok[i,1];
                    }
                }
                for (int i = 0; i < pontok.GetLength(0); i++)
                {
                    if (harmadik[1] < pontok[i,2])
                    {
                        harmadik[0] = i;
                        harmadik[1] = pontok[i,2];
                    }
                }
                Console.WriteLine(elso[0]);
                Console.WriteLine(masodik[0]);
                Console.WriteLine(harmadik[0]);
                if (elso[0] == masodik[0] && elso[0] == harmadik[0] && elso[1] != 0)
                {
                    return true;
                }
                return false;
            }








            Kiiras();
            //AutoKieso();
            Console.WriteLine(MindbenGyoztes());

            Console.ReadLine();
        }
    }
}
