// Saltos de linea y tabulación
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

// Comillas en texto
Console.WriteLine("Hello \"World\"!");

// Barra lateral invertida
Console.WriteLine("c:\\source\\repos");

// Uso de todo
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Cadena literal
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

Console.Write(@"c:\invoices");

// Caracteres unicodes
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// concatenar variable con cadena
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string firstName2 = "Bob";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName2}!"); // string message2 = greeting + " " + firstName2 + "!";

// concatenar un numero en una cadena
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}");

// ejercio de concatenar cadenas
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

Console.WriteLine($"view englis output:\n\t\t{englishLocation}\n");
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
