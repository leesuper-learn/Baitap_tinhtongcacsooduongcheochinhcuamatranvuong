using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wo2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập kích thước ma trận vuông (max = 10): ");
            int input = int.Parse(Console.ReadLine());
            //Nhập kích thước của ma trận vuông 
            if (input > 10)
            {
                Console.Write("Kích thước ma trận quá lớn. Mời nhập lại: ");
                input = int.Parse(Console.ReadLine());
            }else if (input < 1)
            {
                Console.Write("Kích thước của ma trận không được nhỏ hơn 1. Mời nhập lại: ");
                input = int.Parse(Console.ReadLine());
            }
            //khai báo ma trận và nhập giá trị cho ma trận
            double[,] matrix = new double[input,input];
            for (int row = 0; row < input; row++)
            {
                
                for (int col = 0; col < input; col++)
                {
                    Console.Write("Nhập giá trị cho ma trận: [{0},{1}]",row + 1,col + 1);
                    matrix[row,col] = double.Parse(Console.ReadLine());
                }
            }
            //In ma trận vừa nhập lên màn hình
            Console.WriteLine("Ma trận vừa nhập là:");
            for (int row = 0; row < input; row++)
            {
                for (int col = 0; col < input; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine(); // Xuống dòng sau mỗi hàng
            }
            //tính tổng của các số ở đường chéo chính ma trận
            double total = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                total += matrix[i, i];
            }
            Console.WriteLine("Tổng các số ở đường chéo chính là: {0}", total);
            Console.ReadKey();

        }
    }
}