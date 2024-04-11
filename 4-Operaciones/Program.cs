// operacion de suma, solo funciona si las variables que rodan al operador son numericos
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// concatenar numero y string, el compilador entiende que no se quiere sumar sino concatenar
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// para sumar y concatenar hay que envolver entre parentesis
string firstName2 = "Bob";
int widgetsSold2 = 7;
Console.WriteLine(firstName2 + " sold " + (widgetsSold2 + 7) + " widgets.");

// suma, resta, multiplicación y división
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// resto de operación, si da 0 es que es divisible
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// incremento de operaciones
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

int value2 = 0;     // value is now 0.
value2 = value2 + 1; // value is now 1.
value2++;           // value is now 2.

Console.WriteLine(3 + 1 * 5 / 2);