using System.Collections;
namespace Koleksiyonlar_Soru_1;
class Program
{
    static void Main(string[] args)
    {
        
        List<int> Numbers=new List<int>();
        for(int i =0;i<20;i++)
        {
            try
            {
                Console.Write("{0}. pozitif sayıyı giriniz: ",i+1);
                int num=int.Parse(Console.ReadLine());
                if (num<0)
                {
                    Console.Write("Negatif sayı girdiniz, girdiğiniz sayı pozitif yapılmıştır");
                    Numbers.Add(Math.Abs(num));
                }
                else{
                    Numbers.Add(num);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        List<int> Primes=new List<int>();
        List<int> notPrimes=new List<int>();
        methods method=new methods();
        for(int j=0;j<20;j++)
        {
          if(method.isThatPrime(Numbers[j])){
            Primes.Add(Numbers[j]);
          }
          else{
            notPrimes.Add(Numbers[j]);
          }
        }
        Primes.Sort();
        Primes.Reverse();
        Console.WriteLine("****Asal Sayılar****");
        int sum1=0;
        foreach (var item in Primes)
        {
            sum1+=item;
            Console.Write(item+" ");
        }
        notPrimes.Sort();
        notPrimes.Reverse();
        Console.WriteLine("\n****Asal Olmayan Sayılar****");
        int sum2=0;
        foreach (var item in notPrimes)
        {
            sum2+=item;
            Console.Write(item+" ");
        }
        Console.WriteLine("\nAsal sayılar {0} elemanlı ve ortalamaları {1}",Primes.Count,sum1/Primes.Count);
        Console.WriteLine("Asal olmayan sayılar {0} elemanlı ve ortalamaları {1}",notPrimes.Count,sum2/notPrimes.Count);
    }
}

public class methods{
    public bool isThatPrime(int num)
    {
        for (int i=2;i<num;i++){
            if(num % i==0){
                return false;
            }
        }
        return true;
    }
}

