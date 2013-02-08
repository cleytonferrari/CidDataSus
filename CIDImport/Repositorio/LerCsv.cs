using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace Repositorio
{
    public class LerCsv<T> where T : class
    {
        public IEnumerable<T> Ler(string csv)
        {
            if (csv == null) return null;
            var configuracaoCsv = new CsvConfiguration { Delimiter = ";" };
            var csvReader = new CsvReader(new StringReader(csv), configuracaoCsv);
            return csvReader.GetRecords<T>();
        }
    }
}
