using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DesignPattern
{

    public class CodeBuilder
    {
        private StringBuilder code;

        public CodeBuilder(String className)
        {
            code = new StringBuilder();
            code.Append($"public class {className}\n").Append("{\n");
        }

        public CodeBuilder AddField(String fieldName, String typeName)
        {
            code.Append($"  public {typeName} {fieldName}").Append(" { get; set; }\n");
            return this;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(code.ToString());
            result.Append("}");
            return result.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int").AddField("Salary","float");
            Console.WriteLine(cb);
        }
    }
}
