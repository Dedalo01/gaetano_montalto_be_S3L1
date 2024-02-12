using System.Text;

namespace esercizio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            List<double> items = new List<double>();
            bool isExit = false;

            do
            {
                Console.WriteLine("==============MENU==============");
                Console.WriteLine("1: Coca Cola 150ml (€ 2.50)");
                Console.WriteLine("2: Insalata di pollo (€ 5.20)");
                Console.WriteLine("3: Pizza Margherita (€ 10.00)");
                Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
                Console.WriteLine("5: Pz. patatine fritte (€ 3.50)");
                Console.WriteLine("6: Insalata di riso (€ 8.00)");
                Console.WriteLine("7: Frutta di stagione (€ 5.00)");
                Console.WriteLine("8: Pizza fritta (€ 5.00)");
                Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
                Console.WriteLine("10: Panino Hamburger (€ 7.00)");
                Console.WriteLine();
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine();
                Console.Write("Inserisci la tua opzione: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        items.Add(2.50);
                        break;
                    case 2:
                        items.Add(5.20);
                        break;
                    case 3:
                        items.Add(10.00);
                        break;
                    case 4:
                        items.Add(12.50);
                        break;
                    case 5:
                        items.Add(3.50);
                        break;
                    case 6:
                        items.Add(8.00);
                        break;
                    case 7:
                        items.Add(5.00);
                        break;
                    case 8:
                        items.Add(5.00);
                        break;
                    case 9:
                        items.Add(6.00);
                        break;
                    case 10:
                        items.Add(7.00);
                        break;
                    case 11:
                        double sum = 0;

                        foreach (double item in items)
                        {
                            sum += item;
                        }
                        sum += 3.50;
                        Console.WriteLine("Conto finale da pagare (incluso coperto 3.50€):");
                        Console.WriteLine($"{sum:C}");
                        Console.Write("Premi qualunque tasto per uscire... ");
                        Console.ReadKey();
                        isExit = true;
                        break;
                }
                Console.Clear();
            } while (!isExit);
        }
    }
}
