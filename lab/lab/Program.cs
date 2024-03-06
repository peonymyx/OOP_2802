using System.Text;

namespace lab
{
    internal class Program
    {
        static Random random = new Random();

        //Tạo hàm CreateVecto sinh ra các IVecto ngẫu nhiên
        public static IVecto CreateVector()
        {
            if (random.Next(2) == 0)
            {
                return new Vecto2D(random.Next(1,10), random.Next(1,10));
            }
            else
            {
                return new Vecto3D(random.Next(1,10), random.Next(1, 10), random.Next(1, 10));
            }
        }

        public static void Main(string[] args)
        {
            //Tạo list và add vecto vao list
            List<IVecto> list = new List<IVecto>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(CreateVector());
            }
            
            //In ra các Vecto, Module và Vecto sau khi chuyển đổi
            foreach (var vector in list)
            {
                Console.Write($"Vector: {vector};");
                Console.SetCursorPosition(20, Console.CursorTop);
                Console.WriteLine($"\t Module: {vector.Module()}");

                Console.SetCursorPosition(3, Console.CursorTop);

                if (vector is  Vecto3D) 
                    Console.WriteLine("Chuyen sang kieu 2D: "+(~vector).ToString());
                else 
                    Console.WriteLine("Chuyen sang kieu 3D: " + (~vector).ToString());

                Console.WriteLine();
            }

            //In ra các toán tử của 2 Vecto
            for(int i = 0;i < list.Count - 1; i++)
            {
                for (int j = i+1; j< list.Count ; j++)
                {
                    if (list[i] + list[j] != null)
                    {
                        Console.WriteLine(list[i].ToString() + " + " + list[j].ToString() + " = " + (list[i] + list[j]).ToString());
                        Console.WriteLine(list[i].ToString() + " * " + list[j].ToString() + " = " + (list[i] * list[j]));
                        Console.WriteLine();

                    }

                }
            }
        }

    }
}