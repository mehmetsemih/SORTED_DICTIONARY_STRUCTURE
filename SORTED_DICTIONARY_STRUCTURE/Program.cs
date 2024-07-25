namespace SORTED_DICTIONARY_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORTED_DICTIONARY_DESCRIBING

           var kitap_indeks=new SortedDictionary<string,List<int>>()
           {
               {"HMTL",new List<int> {1,2,3,4} },
               {"CSS",new List<int>{40,50,60} },
           };

            kitap_indeks.Add("JAVASCRİPT",new List<int>() { 100,300,400});

            foreach (var k in kitap_indeks)
            {
                Console.WriteLine($"{k.Key}");
                k.Value.ForEach(x => Console.WriteLine(x));
            }
            Console.ReadKey();
        }
    }
}
