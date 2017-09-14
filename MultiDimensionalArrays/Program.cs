using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st param = 4, 2nd param = 3;
            float[,] tempsGrid = new float[4, 3];

            //using 2 "nested for loops" to set all the values by formula
            //GetLength(0) - give the length of the first index of M.D.Array
            for (int x = 0; x < tempsGrid.GetLength(0); x++)
            {
                for (int y = 0; y < tempsGrid.GetLength(1); y++)
                {
                    //1st param = x, 2nd param = y;
                    tempsGrid[x, y] = x + 10 * y;
                }
            }

            Console.WriteLine("Length is " + tempsGrid.Length);
            Console.WriteLine("Rank is " + tempsGrid.Rank + ", this means it is a 2D array \r\n");

            //using 2 nested for loops again to control write order
            //using GetUpperBound() & LowerBound() VS GetLength()
            //NOTE: Use "<=" with GetUpperBound as it returns the last valid index
            for (int x = tempsGrid.GetLowerBound(0); 
                x <= tempsGrid.GetUpperBound(0); x++)
            {
                //NOTE: the rank changed from "0" to "1"
                for (int y = tempsGrid.GetLowerBound(1); 
                    y <= tempsGrid.GetLowerBound(1); y++)
                {
                    //making sure all value are written in one line
                    Console.Write(tempsGrid[x, y] + ", ");
                }
                //breaking the line after every "x++"
                Console.WriteLine();
            }


            ////with "foreach" we need only one loop
            ////but grid structure is lost as elements order cant be controlled
            //foreach (float temp in tempsGrid)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.WriteLine();

            ////2D arrays cant be converted to 1D arrays
            ////however internally they are stored the same way
            ////in a single block of memory where the elements are consecutive
            //float[] array1d = tempsGrid;
        }
    }
}
