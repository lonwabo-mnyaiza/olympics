using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Credits
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Credits.txt";

            StreamWriter creditsWriter = new StreamWriter(fileName);
            creditsWriter.WriteLine("Olympic Application Credits");
            //creditsWriter.WriteLine("Credits");
            creditsWriter.WriteLine("_______________________________");
            creditsWriter.WriteLine("******************************************************************************");
            creditsWriter.WriteLine("Founder: Lonwabo Mnyaiza");
            creditsWriter.WriteLine();
            creditsWriter.WriteLine("Executive Producer: Lonwabo Mnyaiza");
            //creditsWriter.WriteLine();
            creditsWriter.WriteLine("Producer: Lonwabo Mnyaiza");
            //creditsWriter.WriteLine();
            creditsWriter.WriteLine("Chief Operating Officer: Lonwabo Mnyaiza");
            creditsWriter.WriteLine();
            creditsWriter.WriteLine("Lead Programmer: Lonwabo Mnyaiza");
            //creditsWriter.WriteLine();
            creditsWriter.WriteLine("Lead Designer: Lonwabo Mnyaiza");
            //creditsWriter.WriteLine();
            creditsWriter.WriteLine("Developed by: Lonwabo Mnyaiza");
            creditsWriter.WriteLine();
            creditsWriter.WriteLine("Tech Support: Lonwabo Mnyaiza");
            //creditsWriter.WriteLine();
            creditsWriter.WriteLine("IT Administrator: Lonwabo Mnyaiza");
            //creditsWriter.WriteLine();
            creditsWriter.WriteLine("Controler: Lonwabo Mnyaiza");
            creditsWriter.WriteLine();
            creditsWriter.WriteLine("Special thanks: Lonwabo Mnyaiza");
            creditsWriter.WriteLine();
            creditsWriter.WriteLine("*******************************************************************************");
            
            //creditsWriter.WriteLine("Press 'Enter' to exit");
            creditsWriter.Close();
            
        }
    }
}
