internal class Program
{

    private static int Antihistamine, Amoxicillin, Ibuprofen, Losartan , Paracetamol,
        薬1, 薬2, 薬3, 薬4, 薬5, 薬1の値段, 薬2の値段, 薬3の値段, 薬4の値段, 薬5の値段, トタル薬の値段 = 0;
    //just experimenting but why is this a thing...????
    private static bool flag = false;
    static void Main()
    {
        updateStocks();
    }
    static void checkInventory()
    {
        Console.WriteLine("Current Inventory Summary:");
        Console.WriteLine("\nAntihistamine: " + Antihistamine + " pcs");
        Console.WriteLine("\nAmoxicillin: " + Amoxicillin + " pcs");
        Console.WriteLine("\nIbuprofen: " + Ibuprofen + " pcs");
        Console.WriteLine("\nLosartan: " + Losartan + " pcs");
        Console.WriteLine("\nParacetamol: " + Paracetamol + " pcs");
        Console.WriteLine("==========================");
        userChoice();
        return;
    }
    static void updateSales()
    {
        Console.Write("Number of Medicine Sold:");
        Console.Write("\nAntihistamine: "); 薬1 = int.Parse(Console.ReadLine());
        Console.Write("\nAmoxicillin: "); 薬2 = int.Parse(Console.ReadLine());
        Console.Write("\nIbuprofen: ");　薬3 = int.Parse(Console.ReadLine());
        Console.Write("\nLosartan: ");　薬4 = int.Parse(Console.ReadLine());
        Console.Write("\nParacetamol: ");　薬5 = int.Parse(Console.ReadLine()); 
        Console.Write("===========================");
        if (薬1 > Antihistamine)
        {
            Console.WriteLine("Antihistamine sold has exceeded the Antihistamine stock limit and has been reset to 0.");
            薬1 = 0;
        }
        if (薬2 > Amoxicillin)
        {
            Console.WriteLine("Amoxicillin sold has exceeded the Amoxicillin stock limit and has been reset to 0.");
            薬2 = 0;
        }
        if (薬3 > Ibuprofen)
        {
            Console.WriteLine("Ibuprofen sold has exceeded the Ibuprofen stock limit and has been reset to 0.");
            薬3 = 0;
        }
        if (薬4 > Losartan)
        {
            Console.WriteLine("Losartan sold has exceeded the Losartan stock limit and has been reset to 0.");
            薬4 = 0;
        }
        if (薬5 > Paracetamol)
        {
            Console.WriteLine("Paracetamol sold has exceeded the Paracetamol stock limit and has been reset to 0.");
            薬5 = 0;
        }
        else
        {
            Antihistamine -= 薬1;
            Amoxicillin -= 薬2;
            Ibuprofen -= 薬3;
            Losartan -= 薬4;
            Paracetamol -= 薬5;
            薬1の値段 = 薬1 * 16;
            薬2の値段 = 薬2 * 20;
            薬3の値段 = 薬3 * 9;
            薬4の値段 = 薬4 * 13;
            薬5の値段 = 薬5 * 5;
            トタル薬の値段 = 薬1の値段 + 薬2の値段 + 薬3の値段 + 薬4の値段 + 薬5の値段 + トタル薬の値段;
            userChoice();
            return;
        }

    }

    static void updateStocks()
    {
        if (!flag)
        {
            Console.Write("Update Inventory of Medicines: First Time Stocking");
            Console.WriteLine("\n========================================");
            Console.Write("\nAntihistamine: "); Antihistamine = int.Parse(Console.ReadLine());
            Console.Write("\nAmoxicillin: "); Amoxicillin = int.Parse(Console.ReadLine());
            Console.Write("\nIbuprofen: "); Ibuprofen = int.Parse(Console.ReadLine());
            Console.Write("\nLosartan: "); Losartan = int.Parse(Console.ReadLine());
            Console.Write("\nParacetamol: "); Paracetamol = int.Parse(Console.ReadLine());
            Console.Write("\n============SAVING...===============");
            Thread.Sleep(1000);
            flag = true;
            userChoice();

        } if (flag)
        {
            Console.Write("Update Inventory of Medicines: Restocking");
            Console.WriteLine("\n========================================");
            Console.Write("\nAntihistamine: "); Antihistamine = int.Parse(Console.ReadLine());
            Console.Write("\nAmoxicillin: "); Amoxicillin = int.Parse(Console.ReadLine());
            Console.Write("\nIbuprofen: "); Ibuprofen = int.Parse(Console.ReadLine());
            Console.Write("\nLosartan: "); Losartan = int.Parse(Console.ReadLine());
            Console.Write("\nParacetamol: "); Paracetamol = int.Parse(Console.ReadLine());
            Console.Write("\n============SAVING...===============");
            Thread.Sleep(1000);
            userChoice();
        }

        return;
    }
    static void updateStockscheck()
    {
        if (((Antihistamine == 0) && (Amoxicillin == 0) && (Ibuprofen == 0) && (Losartan == 0) && (Paracetamol == 0)) || (トタル薬の値段　> 100000))
        {
            Console.WriteLine("ACCESS GRANTED");
            Thread.Sleep(3000);
            updateStocks();
        }
        else
        {
            Console.WriteLine("The goals have not been reached:");
            Console.WriteLine("Quota: PHP 100000 You sold only worth: " + トタル薬の値段);
            Console.WriteLine("Medicines have not yet depleted in stock");
            Thread.Sleep(3000);
            userChoice();
        }
        return;
    }
    static char userChoice()
    {
        Console.WriteLine("\n\n＝＝＝＝＝Kusuriya＝Katipunan＝＝＝＝＝\nA. Check Inventory\nB. Update Sales\nC. Stock Update\n＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝\n[Enter the letter of your\n     desired action]");
        char choice = char.ToUpper(char.Parse(Console.ReadLine()));
        Console.Clear();
        switch (choice)
        {
            case 'A':
                checkInventory();
                break;
            case 'B':
                updateSales();
                break;
            case 'C':
                updateStockscheck();
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose A, B, or C.");
                userChoice();
                break;
        }
        return choice;

    }

}