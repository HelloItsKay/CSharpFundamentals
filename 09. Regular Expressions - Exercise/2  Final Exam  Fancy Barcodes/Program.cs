using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;


namespace _2__Final_Exam__Fancy_Barcodes
{
    class Program
    {

        static void Main(string[] args)
        {
            Regex regex = new Regex(@"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+");
            Regex digitRegex = new Regex(@"(?<numbers>\d+)");


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var match = regex.Match(input);


                if (match.Success)
                {
                    string name = match.Groups["barcode"].Value;
                    var digitMatch = digitRegex.Matches(name);
                    string productGroup = string.Empty;
                    foreach (Match item in digitMatch)
                    {
                        if (item.Success)
                        {
                            productGroup += item.Value;
                        }
                    }

                    if (productGroup.Length==0)
                    {
                        productGroup = "00";
                    }



                    Console.WriteLine($"Product group: {productGroup}");

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
