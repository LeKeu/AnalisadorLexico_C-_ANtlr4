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
        public override object VisitAssignment([NotNull] SimpleParser.AssignmentContext context)
        {
            return base.VisitAssignment(context);
        }
    }
}
