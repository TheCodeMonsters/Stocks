using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Stocks {
    public static class Data {
        static readonly string logicalName = "symbols";

        static IList<Symbol> symbols;
        public static IList<Symbol> Symbols {
            get {
                if (symbols == null) {
                    symbols = GetSymbols();
                }
                return symbols;
            }
        }

        static IList<Symbol> GetSymbols() {
            List<Symbol> symbols = null;
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(logicalName))
            using (StreamReader reader = new(stream, Encoding.UTF8)) {
                var json = reader.ReadToEnd();
                symbols = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Symbol>>(json);
            }
            return symbols;
        }
    }
}
