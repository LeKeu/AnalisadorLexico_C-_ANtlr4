grammar Simple;

program: line* EOF;	// o programa funciona com 0 ou + linhas. Ai vou definir o que é uma linha.

line: statement | ifBlock | whileBlock;	// o que eu posso ter em uma linha

statement: (assignment | functionCall) ';';

ifBlock: 'if' expression block ('else' elseIfBlock)?;	// pode ser que nesse else eu tenha outro if, por isso adiciono outra regra para tal logo embaixo

elseIfBlock: block | ifBlock;

whileBlock: WHILE expression block; 

WHILE: 'while';

assignment: IDENTIFIER '=' expression;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

expression
	: constant								#constantExpression
	| IDENTIFIER							#identifierExpression
	| functionCall							#functionCallExpression		
	| '(' expression ')'					#parenthizedExpression
	| '!' expression						#notExpression
	| expression multOp expression			#multiplicativeExpression
	| expression addOp expression			#additiveExpression
	| expression compareOp expression		#comparisionExpression
	| expression boolOp expression			#booleanExpression
	;

multOp: '*' | '/' | '%';
addOp: '+' | '-';
compareOp: '==' | '!=' | '>' | '<' | '>=' | '<=';
boolOp: BOOL_OPERATOR;

BOOL_OPERATOR: 'and' | 'or' | 'xor';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;
INTEGER: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]+;
STRING: ('"' ~'"'* '"') | ('\'' ~'\''* '\'');	// comeca com uma aspa e segue com qlqr qntd de non aspas e fecha com aspas dnv
BOOL: 'true' | 'false';
NULL: 'null';

block: '{' line* '}';	// um bloco é qlqr numero de linhas dentro dos cochetes do if else

WS: [ \t\r\n]+ -> skip;
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;

