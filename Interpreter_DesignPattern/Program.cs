using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ep = new ExpressionProcessor();
            ep.Variables.Add('x', 3);
            Console.WriteLine($"1+2+3={ep.Calculate("1+2+3")}");
            Console.WriteLine($"1+2+xy={ep.Calculate("1+2+xy")}");
            Console.WriteLine($"10-2-x={ep.Calculate("10-2-x")}");
        }

        public class ExpressionProcessor
        {
            public Dictionary<char, int> Variables = new Dictionary<char, int>();

            private List<string> tokens;
            private List<char> operations;

            public int Calculate(string expression)
            {
                Lex(expression);
                return ParseTokens();
            }

            private void Lex(string expression)
            {
                StringBuilder sb = new StringBuilder();
                operations = new List<char>();
                tokens = new List<string>();
                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] == '+')
                    {
                        tokens.Add(sb.ToString());
                        sb.Clear();
                        operations.Add('+');
                    }
                    else if (expression[i] == '-')
                    {
                        tokens.Add(sb.ToString());
                        sb.Clear();
                        operations.Add('-');
                    }
                    else
                    {
                        sb.Append(expression[i]);
                    }
                }
                tokens.Add(sb.ToString());
            }

            private int ParseTokens()
            {
                int result = 0;
                int operation = 0;
                try
                {
                    result += ParseToken(tokens[0]);
                    for (var index = 1; index < tokens.Count; index++)
                    {

                        switch (operations[operation])
                        {
                            case '+':
                                result += ParseToken(tokens[index]);
                                break;
                            case '-':
                                result -= ParseToken(tokens[index]);
                                break;
                            default:
                                throw new ArgumentException();
                        }
                        operation++;
                    }
                }
                catch (Exception e)
                {
                    return 0;
                }
                return result;
            }

            private int ParseToken(string token)
            {
                if (int.TryParse(token, out var result))
                    return result;
                if (token.Length != 1)
                    throw new ArgumentException();
                return Variables[token[0]];
            }
        }
    }
}
