using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NDesk.Options.Fork;

namespace coop.bre.trim {
    public class ArgParser {
        private static readonly OptionSet options;

        public static int RetentionAge { get; set; }

        static ArgParser() {
            ArgParser.options = new OptionSet { {
                    "a|age=", (int v) => ArgParser.RetentionAge = v
            } };
        }

        public static void Parse(IEnumerable<string> args) {
            ArgParser.options.Parse(args);
        }
    }
}
