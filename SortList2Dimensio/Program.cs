using System;
using System.Collections.Generic;
using System.Linq;

namespace SortList2Dimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array2D = new List<List<string>>{
    new List<string> {"OS",     "Rua",   "Bairro",     "Cidade",    "Estado",     "CEP"},
    new List<string> {"343433", "Rua 1", "Centro",  "Taquaritinga",    "SP", "15900017"},
    new List<string> {"423423", "Rua 2", "Centro", "Taquaritinga",     "SP", "15900020"},
    new List<string> {"234234", "Rua 1", "Centro", "Taquaritinga",     "SP", "15900019" },
    new List<string> {"234234", "Rua 1", "Centro", "Taquaritinga",     "SP", "15900010" }
};

            List<string> columns = array2D[0];

            //var orderedMatrix = array2D.OrderBy(x => x[5)]));
            var orderedMatrix = array2D.OrderBy(x => x[columns.IndexOf("CEP")]);

        }
    }
}
