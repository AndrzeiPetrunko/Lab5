namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
        }
        public static void Zadanie1()
        {
            /*if (File.Exists("cos.txt"))
            {
                string content = File.ReadAllText("cos.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);


            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("cos.txt", newContent);*/
            ListaOsob lista = new ListaOsob();
            lista.Loaddata("dane.txt");
            lista.printData();
            lista.SortByAge();
            lista.SortBySurname();
            lista.printData();


        }
    }
}