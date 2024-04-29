using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "c:\\Temp\\123.txt";

        try
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
            using (StreamWriter sw = new StreamWriter("c:\\Temp\\456.csv"))
            {
                while (sr.Peek() >= 0)
                {
                    string readline = sr.ReadLine();
                    sw.WriteLine(readline);
                }
            }

            Console.WriteLine("Data written to c:\\Temp\\456.csv successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.ReadKey(); // 按任意鍵退出
        }