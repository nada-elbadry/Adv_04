namespace Demo_Adv_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic - HashTable 

            //Hashtable hashtable = new Hashtable(new StringEqualityComparer())
            //{
            //	["Mona"] = 111,
            //	["Salma"] = 222,
            //	["Amr"] = 333
            //};
            #endregion

            #region Custom Equality Comparer

            //hashtable.Add("mona", 1000); // ArgumentException


            //foreach (var item in hashtable)
            //	Console.WriteLine(item);

            #endregion
            #region Iteration on HashTable 

            //foreach (DictionaryEntry item in hashtable)
            //	Console.WriteLine($"Person Name = {item.Key} , Number = {item.Value}");
            //// Person Name = Mona , Number = 111
            //// Person Name = Salma , Number = 222
            //// Person Name = Amr , Number = 333

            //foreach (string item in hashtable.Keys)
            //	Console.WriteLine(item);
            //// Mona
            //// Amr
            //// Salma

            //foreach (int item in hashtable.Values)
            //	Console.WriteLine(item);
            ////  111
            ////  222
            ////  333

            #endregion
        }
    }
}
