// See https://aka.ms/new-console-template for more information
using System;


public class KodeBuah 
{
    public string getKodeBuah_1302210113(string buah)
    {
        switch (buah)
        {
            case "Apel":
                return "A00";
            case "Aprikot":
                return "B00";
            case "Alpukat":
                return "C00";
            case "Pisang":
                return "D00";
            case "Paprika":
                return "E00";
            case "Blackberry":
                return "F00";
            case "Ceri":
                return "H00";
            case "Kelapa":
                return "I00";
            case "Jagung":
                return "J00";
            default:
                return "Kode buah tidak ditemukan";
        }
    }
}


public class modul_1302210113
{
    static void Main()
    {
        //Bagian Tabel Keluarahan kodebuah1
        KodeBuah kodebuah1 = new KodeBuah();

        Console.WriteLine("| Nama Buah\t\t| Kode Buah \t|");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"| Apel\t\t\t| {kodebuah1.getKodeBuah_1302210113("Apel")}\t\t|");
        Console.WriteLine($"| Aprikot\t\t| {kodebuah1.getKodeBuah_1302210113("Aprikot")}\t\t|");
        Console.WriteLine($"| Alpukat\t\t| {kodebuah1.getKodeBuah_1302210113("Alpukat")}\t\t|");
        Console.WriteLine($"| Pisang\t\t| {kodebuah1.getKodeBuah_1302210113("Pisang")}\t\t|");
        Console.WriteLine($"| Paprika\t\t| {kodebuah1.getKodeBuah_1302210113("Paprika")}\t\t|");
        Console.WriteLine($"| Blackberry\t\t| {kodebuah1.getKodeBuah_1302210113("Blackberry")}\t\t|");
        Console.WriteLine($"| Ceri\t\t\t| {kodebuah1.getKodeBuah_1302210113("Ceri")}\t\t|");
        Console.WriteLine($"| Kelapa\t\t| {kodebuah1.getKodeBuah_1302210113("Kelapa")}\t\t|");
        Console.WriteLine($"| Jagung\t\t| {kodebuah1.getKodeBuah_1302210113("Jagung")}\t\t|");

        Console.WriteLine("--------------------------------------");



    }
}






/*

public class KodeBuah
{
    public static string getKodeBuah(string codebuah)
    {
        string[] kodenya =
        {
        "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00"
        };

        string[] buahnya =
        {
            "Apel", "Aprikot", "Alpukat", "Pisang", "Papripka", "Blackberry","Ceri", "Kelapa", "Jagung" 
        };

        int MaxKode = kodenya.Length - 1;
        string akhirKode = "J00";
        int levelkode = 0;

        while ((akhirKode == "J00") && (levelkode < MaxKode))
        {
            if(codebuah > buahnya[levelkode])
            {

            }
        }
    }

};

*/