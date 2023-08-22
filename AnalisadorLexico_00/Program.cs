using AnalisadorLexico_00;
using AnalisadorLexico_00.Content;
using Antlr4.Runtime;

var fileName = "C:\\Users\\21070012\\Desktop\\Leka_VisualStudio\\AnalisadorLexico_00\\Content\\teste.ss";   //args[0]?
var fileContents = File.ReadAllText(fileName);


var inputStream = new AntlrInputStream(fileContents);
var simpleLexer = new SimpleLexer(inputStream);
var commonTokenStream = new CommonTokenStream(simpleLexer);
var simpleParser = new SimpleParser(commonTokenStream);
var simpleContext = simpleParser.program();
var visitor = new SimpleVisitor();

visitor.Visit(simpleContext);