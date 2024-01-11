namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ZadanieTest();
            Zadanie1("nazwa.txt");
        }
        public static void ZadanieTest()
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
            lista.DeletePerson(0);
            lista.EditPerson(0, "Agata", "Meble", 23);
            lista.SortBySurname();
            lista.printData();
            Console.WriteLine(lista.FindOldestosoba());
            lista.SaveToJSON("nowedane.json");


        }
        public static void Zadanie1(string plik)
        {
            if (File.Exists(plik))
            {
                string content = File.ReadAllText(plik);
                Console.WriteLine("Current content of file:");
                Console.Write(content);
            }
            else
            {
                Console.WriteLine("Please enter new content for the file:");
                string newContent = Console.ReadLine();
                File.WriteAllText(plik, newContent);
            }
        }
    }
}