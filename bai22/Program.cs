namespace bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("moi nhap vao so n 1-99:");
            n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 99)
            {
                Console.WriteLine("nhap lai n,n chi nhan 1-99");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" ban da nhap xong gia tri cua n:{0}", n);
            Console.ReadKey();
        }
    }
}
