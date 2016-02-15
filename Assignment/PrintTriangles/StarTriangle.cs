using System;

namespace TriangleFunctions
{
    /// <summary>
    /// This class defines the methods for displaying Star Triangles
    /// </summary>
    public class StarTriangle
    {
        public static int HeightOfTriangle = 1;
       
        public static void PrintStarTriangle()
        {

            Console.WriteLine("\n\n\n Below is the triangle with height of {0} lines\n", HeightOfTriangle);

            var arraySize = 4 * HeightOfTriangle - 3;
            var triangleArray = new char[arraySize];
            var halfTriangleArrayLength = triangleArray.Length / 2;
            for (int i = 0; i <= halfTriangleArrayLength; i += 2)
            {
                triangleArray[halfTriangleArrayLength] = '*';
                triangleArray[halfTriangleArrayLength - i] = '*';
                triangleArray[halfTriangleArrayLength + i] = '*';

                Console.WriteLine(triangleArray);
            }

            Console.WriteLine("\n");
        }

    }
}
