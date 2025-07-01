using System;
using System.Collections;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n=== Menu ===");
            Console.WriteLine("1. ArrayList");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Stack");
            Console.WriteLine("4. Queue");
            Console.WriteLine("5. Dictionary");
            Console.WriteLine("6. Hashtable");
            Console.WriteLine("-1. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("---- ArrayList ----");
                    ArrayList A1 = new ArrayList();
                    A1.Add(23);
                    A1.Add("Kunj");
                    A1.Add(true);
                    A1.Add("Esha");
                    A1.Add("Krisha");
                    A1.Add("Nidhi");
                    A1.Add("Palak");
                    A1.Add("Drashti");
                    A1.Add("Parth");

                    foreach (var item in A1)
                        Console.WriteLine(item);

                    A1.Remove(7);
                    //A1.RemoveAt(10);          --> exception
                    A1.RemoveRange(3, 3);

                    Console.WriteLine("\nAfter Removals:");
                    foreach (var item in A1)
                        Console.WriteLine(item);

                    Console.WriteLine("Contains 'Parth': " + A1.Contains("Parth"));
                    //Equals check the whole object, for specific, give index
                    Console.WriteLine("Equals A1[1] with 'Kunj': " + A1[1].Equals("Kunj"));

                    A1.Insert(2, "Hello");

                    Console.WriteLine("\nFinal ArrayList:");
                    foreach (object obj in A1)
                        Console.WriteLine(obj.ToString());
                    break;

                case 2:
                    Console.WriteLine("---- List ----");
                    List<string> li = new List<string>();

                    li.Add("23");
                    li.Add("Kunj");
                    li.Add("Hello");
                    li.Add("Esha");
                    li.Add("Krisha");
                    li.Add("Nidhi");
                    li.Add("Palak");
                    li.Add("Drashti");
                    li.Add("Parth");

                    foreach (string s in li)
                        Console.WriteLine(s);

                    li.Remove("Hello");
                    li.RemoveAt(li.Count - 2);
                    li.RemoveRange(4, 3);
                    li.RemoveAll(x => x.Contains("Hello")); //--> removes all where that condition matches

                    Console.WriteLine("\nAfter Removals:");
                    foreach (string s in li)
                        Console.WriteLine(s);

                    li.Clear();
                    break;

                case 3:
                    Console.WriteLine("---- Stack ----");
                    Stack st = new Stack();
                    st.Push(2);
                    st.Push(3);
                    st.Push("Hello");
                    st.Push("from");
                    st.Push("Kunj");
                    st.Push("Temp");

                    foreach (var i in st)
                        Console.WriteLine(i);

                    st.Pop();
                    Console.WriteLine("Peeking: " + st.Peek());
                    Console.WriteLine("Contains 'Kunj': " + st.Contains("Kunj"));
                    st.Clear();
                    break;

                case 4:
                    Console.WriteLine("---- Queue ----");
                    Queue qu = new Queue();
                    qu.Enqueue(2);
                    qu.Enqueue(3);
                    qu.Enqueue("Hello");
                    qu.Enqueue("from");
                    qu.Enqueue("Kunj");
                    qu.Enqueue("Temp");

                    foreach (var i in qu)
                        Console.WriteLine(i);

                    qu.Dequeue();
                    Console.WriteLine("Peeking: " + qu.Peek());
                    Console.WriteLine("Contains 'Kunj': " + qu.Contains("Kunj"));
                    qu.Clear();
                    break;

                case 5:
                    Console.WriteLine("---- Dictionary ----");
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    dict.Add("1", "Kunj");
                    dict.Add("2", "Hello");
                    dict.Add("3", "From");
                    dict["4"] = "Temp";
                    dict["23"] = "She";

                    Console.WriteLine("------Keys------");
                    foreach (string key in dict.Keys)
                        Console.WriteLine(key);

                    Console.WriteLine("------Values------");
                    foreach (object obj in dict.Values)
                        Console.WriteLine(obj);

                    dict.Remove("1");
                    Console.WriteLine("ContainsKey '23': " + dict.ContainsKey("23"));
                    Console.WriteLine("ContainsValue 'Hello': " + dict.ContainsValue("Hello"));
                    dict.Clear();
                    break;

                case 6:
                    Console.WriteLine("---- Hashtable ----");
                    Hashtable ht = new Hashtable();
                    ht.Add("1", "Kunj");
                    ht.Add("2", "Hello");
                    ht.Add("3", "Her");
                    ht.Add("4", "Still I Rise");

                    Console.WriteLine("Hashtable Values:");
                    foreach (object obj in ht.Values)
                        Console.WriteLine(obj);


                    ht.Remove("36"); //no exception
                    Console.WriteLine("ContainsKey '23': " + ht.ContainsKey("23"));
                    Console.WriteLine("ContainsValue 'Hello': " + ht.ContainsValue("Hello"));
                    ht.Clear();
                    break;

                case -1:
                    Console.WriteLine("Exiting program");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6 or -1 to exit.");
                    break;
            }

        } while (choice != -1);
    }
}
