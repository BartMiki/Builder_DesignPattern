using System;
using System.Text;

namespace Builder_DesignPattern
{
    public class CodeBuilder
    {
        private readonly StringBuilder _code;

        public CodeBuilder(string className)
        {
            _code = new StringBuilder();
            _code.Append($"public class {className}\n").Append("{\n");
        }

        public CodeBuilder AddField(string fieldName, string typeName)
        {
            _code.Append($"  public {typeName} {fieldName}").Append(" { get; set; }\n");
            return this;
        }

        public override string ToString()
        {
            var result = new StringBuilder(_code.ToString());
            result.Append("}");
            return result.ToString();
        }
    }
}