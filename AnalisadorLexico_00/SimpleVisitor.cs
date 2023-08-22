using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisadorLexico_00.Content;
using Antlr4.Runtime.Misc;

namespace AnalisadorLexico_00
{
    internal class SimpleVisitor: SimpleBaseVisitor<object?>    // cada visitor vai retornar um objeto nullo
    {
        private Dictionary<string, object> Variables { get; } = new();
        public override object VisitAssignment([NotNull] SimpleParser.AssignmentContext context)
        {
            var varName = context.IDENTIFIER().GetText();
            var value = Visit(context.expression());

            Console.Write("varname --> " + varName);
            Console.Write("varname --> " + varName.ToString());

            Variables[varName] = value;

            return null;
            //return base.VisitAssignment(context);
        }
    }
}
