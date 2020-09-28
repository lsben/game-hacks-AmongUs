using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructGenerator {
    class Program {
        static void Main(string[] args) {

            const String path = @"I:\Games\Among us\Among.Us.Incl.DLC.v09.22.2020s\Memory Dump for hack\Structs\Xml";
            const String output = @"I:\Games\Among us\Among.Us.Incl.DLC.v09.22.2020s\Memory Dump for hack\Structs\Generated";

            StructGenerator.StructGenerator.Generate(path, output);
            Console.WriteLine("Done .. \nEnter any key to exit");
            Console.ReadLine();

        }
    }
}
