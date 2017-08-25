using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coop.bre.trim {

    class Program {

        static void Main(string[] args) {
            ArgParser.Parse(args);
            Console.WriteLine("Hello, Fool! " + ArgParser.RetentionAge);
        }

    }

}
