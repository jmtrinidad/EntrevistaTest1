using EntrevistaTest1.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrevistaTest1.ConsoleReadTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            var addresses = new List<Address>();
            // Read the file and display it line by line.
            //NOTA: CUANDO PONES LA DIRECCION DE ESA MANERA ES PORQUE EL ARCHIVO
            //ESTA DENTRO DE LA MISMA CARPETA DE LA SOLUCION DE TU APLICACION
            StreamReader file = new StreamReader(@"\test.txt");

            while ((line = file.ReadLine()) != null)
            {
                var address = new Address
                {
                    Direction = line,
                };
                addresses.Add(address);
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
