
namespace Collection_Demo_Problem
{
    internal class CollectionDemo
    {
        public static void DoListDemo()
        {
            Console.WriteLine("\nIn DoListDemo");
            List<string> list = new List<string>();
            list.Add("Mahesh");
            list.Add("Yashwant");
            list.Add("Tushar");
            list.Add("Rushikesh");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void DoStackDemo()
        {
            Console.WriteLine("\nIn DoStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Mahesh");
            stack.Push("Yashwant");
            stack.Push("Tushar");
            stack.Push("Rushikesh");
            string pop = stack.Pop();

            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Poped Element : " + pop);
        }
        public static void DoSetDemo()
        {
            Console.WriteLine("\nIn DoSetDemo");
            HashSet<string> set = new HashSet<string>();

            set.Add("Mahesh");
            set.Add("Yashwant");
            set.Add("Tushar");
            set.Add("Rushikesh");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void DoDictionaryDemo()
        {
            Console.WriteLine("\nIn DoDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Mahesh");
            dictionary.Add(101, "Yashwant");
            dictionary.Add(102, "Tushar");
            dictionary.Add(103, "Rushikesh");

            Console.WriteLine("Access Value Using key(key=100) : " + dictionary[100]);

            Console.WriteLine("\nIterating Dictionary");
            foreach (var item in dictionary)
            {
                Console.WriteLine("Key = " + item.Key + " and Value = " + item.Value);
            }
        }
        public static void DoQueueDemo()
        {
            Console.WriteLine("\nIn DoQueueDemo");
            // Creating Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Mahesh");
            queue.Enqueue("Yashwant");
            queue.Enqueue("Tushar");
            queue.Enqueue("Rushikesh");

            Console.WriteLine("Head : " + queue.Peek());
            Console.WriteLine("\nIterating the Queue Elements");
            // Iterating Queue Elements
            foreach (string element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue Element : " + dequeue);

            Console.WriteLine("\nIterating the Queue Elements after Dequeue one Element");
            // Iterating Queue Elements Using Enumerator 
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

    }
}
