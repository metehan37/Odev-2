namespace Koleksiyonlar_Soru_3;
class Program
{
    static void Main(string[] args)
    {
        char[] sesli=new char[]{'a','e','ı','i','o','ö','u','ü'};
        List<string> Harfler=new List<string>();
        Console.Write("Bir cümle Giriniz: ");
        string cumle=Console.ReadLine().ToLower();
        for (int i = 0; i < cumle.Length; i++)
        {
            for (int j = 0; j < sesli.Length; j++)
            {
                if(cumle[i]==sesli[j]){
                    Harfler.Add(cumle[i].ToString());
                }
            }
            
        }
        Harfler.Sort();
        foreach (var item in Harfler)
        {
            Console.Write(item+" ");
        }
    }
}
