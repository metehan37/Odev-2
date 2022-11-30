using System.Collections;
namespace Koleksiyonlar_Soru_2;
class Program
{
    static void Main(string[] args)
    {
        int[] array=new int[20];
        for (int i = 0; i < 20; i++)
        {
            try
            {
                Console.Write("{0}. sayıyı giriniz:",i+1);
                int num=int.Parse(Console.ReadLine());
                array[i]=num;
            }
            catch (System.Exception ex)
            {
            Console.WriteLine(ex.Message);
            } 
        }
        Array.Sort(array);
        Console.WriteLine("En küçük üç rakamın toplamı: {0} ve ortalaması: {1} ",array[0]+array[1]+array[2],array[0]+array[1]+array[2]/3);
        Array.Reverse(array);
        Console.WriteLine("En büyü üç rakamın toplamı: {0} ve ortalaması: {1} ",array[0]+array[1]+array[2],array[0]+array[1]+array[2]/3);
       
    }
}
