using System.Collections;

namespace Demo_Adv_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            #region Q1 - Count frequency of elements using HashTable
            int[] arr = { 1, 2, 2, 3, 1, 4, 2 };
            Hashtable freq = new Hashtable();
            foreach (int n in arr)
            {
                if (freq.ContainsKey(n))
                    freq[n] = (int)freq[n] + 1;
                else
                    freq[n] = 1;
            }
            Console.WriteLine("Q1: Frequency of each element:");
            foreach (DictionaryEntry entry in freq)
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            Console.WriteLine();
            #endregion


            #region Q2 - Key with highest value in HashTable
            Hashtable table = new Hashtable { { "A", 5 }, { "B", 9 }, { "C", 3 } };
            string maxKey = "";
            int maxValue = int.MinValue;
            foreach (DictionaryEntry entry in table)
            {
                if ((int)entry.Value > maxValue)
                {
                    maxValue = (int)entry.Value;
                    maxKey = (string)entry.Key;
                }
            }
            Console.WriteLine($"Q2: Key with highest value => {maxKey}");
            Console.WriteLine();
            #endregion


            #region Q3 - Find all keys by target value
            Hashtable ht = new Hashtable { { "key1", "apple" }, { "key2", "banana" }, { "key3", "apple" } };
            Console.Write("Q3: Enter target value: ");
            string targetValue = Console.ReadLine() ?? "";
            var keys = ht.Keys.Cast<string>().Where(k => (string)ht[k] == targetValue).ToList();
            if (keys.Any())
                keys.ForEach(Console.WriteLine);
            else
                Console.WriteLine("Key not found");
            Console.WriteLine();
            #endregion


            #region Q4 - Group Anagrams
            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var grouped = words.GroupBy(w => new string(w.OrderBy(c => c).ToArray()));
            Console.WriteLine("Q4: Grouped Anagrams:");
            foreach (var group in grouped)
                Console.WriteLine("[" + string.Join(", ", group) + "]");
            Console.WriteLine();
            #endregion


            #region Q5 - Check duplicates in array
            int[] nums = { 1, 2, 3, 4, 2 };
            bool hasDuplicate = nums.Length != nums.Distinct().Count();
            Console.WriteLine($"Q5: Contains duplicates? {hasDuplicate}");
            Console.WriteLine();
            #endregion


            #region Q6 - SortedDictionary for students
            var students = new SortedDictionary<int, string>
            {
                [101] = "Ali",
                [103] = "Sara",
                [102] = "Omar"
            };
            students.Add(104, "Nour");
            #endregion
        }
    }
}
