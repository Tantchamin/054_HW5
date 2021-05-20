using System;

namespace HW5Z
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputImage = Console.ReadLine();
            string convolution = Console.ReadLine();
            string testOutput = Console.ReadLine();
            double[,] image = ReadImageDataFromFile(inputImage);
            double[,] arrayConvolution = ReadImageDataFromFile(convolution);

            double[,] newImage = new double[7, 7];

            // Show image
            /*for (int row = 0; row < image.GetLength(0); row++)
            {
                for (int column = 0; column < image.GetLength(1); column++)
                {
                    Console.Write(image[row, column] + " ");
                }
                Console.WriteLine();
            }*/

            // Show arrayConvoluution
            /*for (int row = 0; row < arrayConvolution.GetLength(0); row++)
            {
                for (int column = 0; column < arrayConvolution.GetLength(1); column++)
                {
                    Console.Write(arrayConvolution[row, column] + " ");
                }
                Console.WriteLine();
            }*/

            // Make newImage
            for (int row = 0; row < image.GetLength(0); row++)
            {
                for (int column = 0; column < image.GetLength(1); column++)
                {
                    newImage[row + 1, column + 1] = image[row, column];
                }
            }

            newImage[0, 0] = image[4, 4];
            newImage[1, 0] = image[0, 4];
            newImage[2, 0] = image[1, 4];
            newImage[3, 0] = image[2, 4];
            newImage[4, 0] = image[3, 4];
            newImage[5, 0] = image[4, 4];
            newImage[6, 0] = image[0, 4];
            newImage[0, 1] = image[4, 0];
            newImage[6, 1] = image[0, 0];
            newImage[0, 2] = image[4, 1];
            newImage[6, 2] = image[0, 1];
            newImage[0, 3] = image[4, 2];
            newImage[6, 3] = image[0, 2];
            newImage[0, 4] = image[4, 3];
            newImage[6, 4] = image[0, 3];
            newImage[0, 5] = image[4, 4];
            newImage[6, 5] = image[0, 4];
            newImage[0, 6] = image[4, 0];
            newImage[1, 6] = image[0, 0];
            newImage[2, 6] = image[1, 0];
            newImage[3, 6] = image[2, 0];
            newImage[4, 6] = image[3, 0];
            newImage[5, 6] = image[4, 0];
            newImage[6, 6] = image[0, 0];

            // Show newImage
            /*for (int row2 = 0; row2 < newImage.GetLength(0); row2++)
            {
                for (int column2 = 0; column2 < newImage.GetLength(1); column2++)
                {
                    Console.Write(newImage[row2, column2] + " ");
                }
                Console.WriteLine();
            }*/

            // Make outputImage
            double[,] outputImage = new double[5,5];
            outputImage[0, 0] =
                (arrayConvolution[0, 0] * newImage[0, 0]) + (arrayConvolution[0, 1] * newImage[0, 1]) + (arrayConvolution[0, 2] * newImage[0, 2]) +
                (arrayConvolution[1, 0] * newImage[1, 0]) + (arrayConvolution[1, 1] * newImage[1, 1]) + (arrayConvolution[1, 2] * newImage[1, 2]) +
                (arrayConvolution[2, 0] * newImage[2, 0]) + (arrayConvolution[2, 1] * newImage[2, 1]) + (arrayConvolution[2, 2] * newImage[2, 2]);
            outputImage[0, 1] =
                (arrayConvolution[0, 0] * newImage[0, 1]) + (arrayConvolution[0, 1] * newImage[0, 2]) + (arrayConvolution[0, 2] * newImage[0, 3]) +
                (arrayConvolution[1, 0] * newImage[1, 1]) + (arrayConvolution[1, 1] * newImage[1, 2]) + (arrayConvolution[1, 2] * newImage[1, 3]) +
                (arrayConvolution[2, 0] * newImage[2, 1]) + (arrayConvolution[2, 1] * newImage[2, 2]) + (arrayConvolution[2, 2] * newImage[2, 3]);
            outputImage[0, 2] =
                (arrayConvolution[0, 0] * newImage[0, 2]) + (arrayConvolution[0, 1] * newImage[0, 3]) + (arrayConvolution[0, 2] * newImage[0, 4]) +
                (arrayConvolution[1, 0] * newImage[1, 2]) + (arrayConvolution[1, 1] * newImage[1, 3]) + (arrayConvolution[1, 2] * newImage[1, 4]) +
                (arrayConvolution[2, 0] * newImage[2, 2]) + (arrayConvolution[2, 1] * newImage[2, 3]) + (arrayConvolution[2, 2] * newImage[2, 4]);
            outputImage[0, 3] =
                (arrayConvolution[0, 0] * newImage[0, 3]) + (arrayConvolution[0, 1] * newImage[0, 4]) + (arrayConvolution[0, 2] * newImage[0, 5]) +
                (arrayConvolution[1, 0] * newImage[1, 3]) + (arrayConvolution[1, 1] * newImage[1, 4]) + (arrayConvolution[1, 2] * newImage[1, 5]) +
                (arrayConvolution[2, 0] * newImage[2, 3]) + (arrayConvolution[2, 1] * newImage[2, 4]) + (arrayConvolution[2, 2] * newImage[2, 5]);
            outputImage[0, 4] =
                (arrayConvolution[0, 0] * newImage[0, 4]) + (arrayConvolution[0, 1] * newImage[0, 5]) + (arrayConvolution[0, 2] * newImage[0, 6]) +
                (arrayConvolution[1, 0] * newImage[1, 4]) + (arrayConvolution[1, 1] * newImage[1, 5]) + (arrayConvolution[1, 2] * newImage[1, 6]) +
                (arrayConvolution[2, 0] * newImage[2, 4]) + (arrayConvolution[2, 1] * newImage[2, 5]) + (arrayConvolution[2, 2] * newImage[2, 6]);

            outputImage[1, 0] =
                (arrayConvolution[0, 0] * newImage[1, 0]) + (arrayConvolution[0, 1] * newImage[1, 1]) + (arrayConvolution[0, 2] * newImage[1, 2]) +
                (arrayConvolution[1, 0] * newImage[2, 0]) + (arrayConvolution[1, 1] * newImage[2, 1]) + (arrayConvolution[1, 2] * newImage[2, 2]) +
                (arrayConvolution[2, 0] * newImage[3, 0]) + (arrayConvolution[2, 1] * newImage[3, 1]) + (arrayConvolution[2, 2] * newImage[3, 2]);
            outputImage[1, 1] =
                (arrayConvolution[0, 0] * newImage[1, 1]) + (arrayConvolution[0, 1] * newImage[1, 2]) + (arrayConvolution[0, 2] * newImage[1, 3]) +
                (arrayConvolution[1, 0] * newImage[2, 1]) + (arrayConvolution[1, 1] * newImage[2, 2]) + (arrayConvolution[1, 2] * newImage[2, 3]) +
                (arrayConvolution[2, 0] * newImage[3, 1]) + (arrayConvolution[2, 1] * newImage[3, 2]) + (arrayConvolution[2, 2] * newImage[3, 3]);
            outputImage[1, 2] =
                (arrayConvolution[0, 0] * newImage[1, 2]) + (arrayConvolution[0, 1] * newImage[1, 3]) + (arrayConvolution[0, 2] * newImage[1, 4]) +
                (arrayConvolution[1, 0] * newImage[2, 2]) + (arrayConvolution[1, 1] * newImage[2, 3]) + (arrayConvolution[1, 2] * newImage[2, 4]) +
                (arrayConvolution[2, 0] * newImage[3, 2]) + (arrayConvolution[2, 1] * newImage[3, 3]) + (arrayConvolution[2, 2] * newImage[3, 4]);
            outputImage[1, 3] =
                (arrayConvolution[0, 0] * newImage[1, 3]) + (arrayConvolution[0, 1] * newImage[1, 4]) + (arrayConvolution[0, 2] * newImage[1, 5]) +
                (arrayConvolution[1, 0] * newImage[2, 3]) + (arrayConvolution[1, 1] * newImage[2, 4]) + (arrayConvolution[1, 2] * newImage[2, 5]) +
                (arrayConvolution[2, 0] * newImage[3, 3]) + (arrayConvolution[2, 1] * newImage[3, 4]) + (arrayConvolution[2, 2] * newImage[3, 5]);
            outputImage[1, 4] =
                (arrayConvolution[0, 0] * newImage[1, 4]) + (arrayConvolution[0, 1] * newImage[1, 5]) + (arrayConvolution[0, 2] * newImage[1, 6]) +
                (arrayConvolution[1, 0] * newImage[2, 4]) + (arrayConvolution[1, 1] * newImage[2, 5]) + (arrayConvolution[1, 2] * newImage[2, 6]) +
                (arrayConvolution[2, 0] * newImage[3, 4]) + (arrayConvolution[2, 1] * newImage[3, 5]) + (arrayConvolution[2, 2] * newImage[3, 6]);

            outputImage[2, 0] =
                (arrayConvolution[0, 0] * newImage[2, 0]) + (arrayConvolution[0, 1] * newImage[2, 1]) + (arrayConvolution[0, 2] * newImage[2, 2]) +
                (arrayConvolution[1, 0] * newImage[3, 0]) + (arrayConvolution[1, 1] * newImage[3, 1]) + (arrayConvolution[1, 2] * newImage[3, 2]) +
                (arrayConvolution[2, 0] * newImage[4, 0]) + (arrayConvolution[2, 1] * newImage[4, 1]) + (arrayConvolution[2, 2] * newImage[4, 2]);
            outputImage[2, 1] =
                (arrayConvolution[0, 0] * newImage[2, 1]) + (arrayConvolution[0, 1] * newImage[2, 2]) + (arrayConvolution[0, 2] * newImage[2, 3]) +
                (arrayConvolution[1, 0] * newImage[3, 1]) + (arrayConvolution[1, 1] * newImage[3, 2]) + (arrayConvolution[1, 2] * newImage[3, 3]) +
                (arrayConvolution[2, 0] * newImage[4, 1]) + (arrayConvolution[2, 1] * newImage[4, 2]) + (arrayConvolution[2, 2] * newImage[4, 3]);
            outputImage[2, 2] =
                (arrayConvolution[0, 0] * newImage[2, 2]) + (arrayConvolution[0, 1] * newImage[2, 3]) + (arrayConvolution[0, 2] * newImage[2, 4]) +
                (arrayConvolution[1, 0] * newImage[3, 2]) + (arrayConvolution[1, 1] * newImage[3, 3]) + (arrayConvolution[1, 2] * newImage[3, 4]) +
                (arrayConvolution[2, 0] * newImage[4, 2]) + (arrayConvolution[2, 1] * newImage[4, 3]) + (arrayConvolution[2, 2] * newImage[4, 4]);
            outputImage[2, 3] =
                (arrayConvolution[0, 0] * newImage[2, 3]) + (arrayConvolution[0, 1] * newImage[2, 4]) + (arrayConvolution[0, 2] * newImage[2, 5]) +
                (arrayConvolution[1, 0] * newImage[3, 3]) + (arrayConvolution[1, 1] * newImage[3, 4]) + (arrayConvolution[1, 2] * newImage[3, 5]) +
                (arrayConvolution[2, 0] * newImage[4, 3]) + (arrayConvolution[2, 1] * newImage[4, 4]) + (arrayConvolution[2, 2] * newImage[4, 5]);
            outputImage[2, 4] =
                (arrayConvolution[0, 0] * newImage[2, 4]) + (arrayConvolution[0, 1] * newImage[2, 5]) + (arrayConvolution[0, 2] * newImage[2, 6]) +
                (arrayConvolution[1, 0] * newImage[3, 4]) + (arrayConvolution[1, 1] * newImage[3, 5]) + (arrayConvolution[1, 2] * newImage[3, 6]) +
                (arrayConvolution[2, 0] * newImage[4, 4]) + (arrayConvolution[2, 1] * newImage[4, 5]) + (arrayConvolution[2, 2] * newImage[4, 6]);

            outputImage[3, 0] =
                (arrayConvolution[0, 0] * newImage[3, 0]) + (arrayConvolution[0, 1] * newImage[3, 1]) + (arrayConvolution[0, 2] * newImage[3, 2]) +
                (arrayConvolution[1, 0] * newImage[4, 0]) + (arrayConvolution[1, 1] * newImage[4, 1]) + (arrayConvolution[1, 2] * newImage[4, 2]) +
                (arrayConvolution[2, 0] * newImage[5, 0]) + (arrayConvolution[2, 1] * newImage[5, 1]) + (arrayConvolution[2, 2] * newImage[5, 2]);
            outputImage[3, 1] =
                (arrayConvolution[0, 0] * newImage[3, 1]) + (arrayConvolution[0, 1] * newImage[3, 2]) + (arrayConvolution[0, 2] * newImage[3, 3]) +
                (arrayConvolution[1, 0] * newImage[4, 1]) + (arrayConvolution[1, 1] * newImage[4, 2]) + (arrayConvolution[1, 2] * newImage[4, 3]) +
                (arrayConvolution[2, 0] * newImage[5, 1]) + (arrayConvolution[2, 1] * newImage[5, 2]) + (arrayConvolution[2, 2] * newImage[5, 3]);
            outputImage[3, 2] =
                (arrayConvolution[0, 0] * newImage[3, 2]) + (arrayConvolution[0, 1] * newImage[3, 3]) + (arrayConvolution[0, 2] * newImage[3, 4]) +
                (arrayConvolution[1, 0] * newImage[4, 2]) + (arrayConvolution[1, 1] * newImage[4, 3]) + (arrayConvolution[1, 2] * newImage[4, 4]) +
                (arrayConvolution[2, 0] * newImage[5, 2]) + (arrayConvolution[2, 1] * newImage[5, 3]) + (arrayConvolution[2, 2] * newImage[5, 4]);
            outputImage[3, 3] =
                (arrayConvolution[0, 0] * newImage[3, 3]) + (arrayConvolution[0, 1] * newImage[3, 4]) + (arrayConvolution[0, 2] * newImage[3, 5]) +
                (arrayConvolution[1, 0] * newImage[4, 3]) + (arrayConvolution[1, 1] * newImage[4, 4]) + (arrayConvolution[1, 2] * newImage[4, 5]) +
                (arrayConvolution[2, 0] * newImage[5, 3]) + (arrayConvolution[2, 1] * newImage[5, 4]) + (arrayConvolution[2, 2] * newImage[5, 5]);
            outputImage[3, 4] =
                (arrayConvolution[0, 0] * newImage[3, 4]) + (arrayConvolution[0, 1] * newImage[3, 5]) + (arrayConvolution[0, 2] * newImage[3, 6]) +
                (arrayConvolution[1, 0] * newImage[4, 4]) + (arrayConvolution[1, 1] * newImage[4, 5]) + (arrayConvolution[1, 2] * newImage[4, 6]) +
                (arrayConvolution[2, 0] * newImage[5, 4]) + (arrayConvolution[2, 1] * newImage[5, 5]) + (arrayConvolution[2, 2] * newImage[5, 6]);

            outputImage[4, 0] =
                (arrayConvolution[0, 0] * newImage[4, 0]) + (arrayConvolution[0, 1] * newImage[4, 1]) + (arrayConvolution[0, 2] * newImage[4, 2]) +
                (arrayConvolution[1, 0] * newImage[5, 0]) + (arrayConvolution[1, 1] * newImage[5, 1]) + (arrayConvolution[1, 2] * newImage[5, 2]) +
                (arrayConvolution[2, 0] * newImage[6, 0]) + (arrayConvolution[2, 1] * newImage[6, 1]) + (arrayConvolution[2, 2] * newImage[6, 2]);
            outputImage[4, 1] =
                (arrayConvolution[0, 0] * newImage[4, 1]) + (arrayConvolution[0, 1] * newImage[4, 2]) + (arrayConvolution[0, 2] * newImage[4, 3]) +
                (arrayConvolution[1, 0] * newImage[5, 1]) + (arrayConvolution[1, 1] * newImage[5, 2]) + (arrayConvolution[1, 2] * newImage[5, 3]) +
                (arrayConvolution[2, 0] * newImage[6, 1]) + (arrayConvolution[2, 1] * newImage[6, 2]) + (arrayConvolution[2, 2] * newImage[6, 3]);
            outputImage[4, 2] =
                (arrayConvolution[0, 0] * newImage[4, 2]) + (arrayConvolution[0, 1] * newImage[4, 3]) + (arrayConvolution[0, 2] * newImage[4, 4]) +
                (arrayConvolution[1, 0] * newImage[5, 2]) + (arrayConvolution[1, 1] * newImage[5, 3]) + (arrayConvolution[1, 2] * newImage[5, 4]) +
                (arrayConvolution[2, 0] * newImage[6, 2]) + (arrayConvolution[2, 1] * newImage[6, 3]) + (arrayConvolution[2, 2] * newImage[6, 4]);
            outputImage[4, 3] =
                (arrayConvolution[0, 0] * newImage[4, 3]) + (arrayConvolution[0, 1] * newImage[4, 4]) + (arrayConvolution[0, 2] * newImage[4, 5]) +
                (arrayConvolution[1, 0] * newImage[5, 3]) + (arrayConvolution[1, 1] * newImage[5, 4]) + (arrayConvolution[1, 2] * newImage[5, 5]) +
                (arrayConvolution[2, 0] * newImage[6, 3]) + (arrayConvolution[2, 1] * newImage[6, 4]) + (arrayConvolution[2, 2] * newImage[6, 5]);
            outputImage[4, 4] =
                (arrayConvolution[0, 0] * newImage[4, 4]) + (arrayConvolution[0, 1] * newImage[4, 5]) + (arrayConvolution[0, 2] * newImage[4, 6]) +
                (arrayConvolution[1, 0] * newImage[5, 4]) + (arrayConvolution[1, 1] * newImage[5, 5]) + (arrayConvolution[1, 2] * newImage[5, 6]) +
                (arrayConvolution[2, 0] * newImage[6, 4]) + (arrayConvolution[2, 1] * newImage[6, 5]) + (arrayConvolution[2, 2] * newImage[6, 6]);

            // Show outputImage         
            /*for (int row = 0; row < outputImage.GetLength(0); row++)
            {
                for (int column = 0; column < outputImage.GetLength(1); column++)
                {
                    Console.Write(outputImage[row, column] + " ");
                }
                Console.WriteLine();
            }*/

            WriteImageDataToFile(testOutput, outputImage);

        }
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }
        static void WriteImageDataToFile(string imageDataFilePath, double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }

    }
}
