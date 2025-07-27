/*
Métodos:
Adicionam espaços em branco para fins de formatação (PadLeft(), PadRight())
Comparam duas cadeias de caracteres ou facilitam a comparação (Trim(), TrimStart(), TrimEnd(), GetHashcode(), a propriedade Length)
Ajudam a determinar o que há dentro de uma cadeia de caracteres ou até mesmo recuperar apenas uma parte da cadeia de caracteres (Contains(), StartsWith(), EndsWith(), Substring())
Alteram o conteúdo da cadeia de caracteres substituindo, inserindo ou removendo partes (Replace(), Insert(), Remove())
Transformam uma cadeia de caracteres em uma matriz de cadeias de caracteres ou de caracteres (Split(), ToCharArray())
*/

// Variáveis para exemplos de uso
string first = "Hello";
string second = "World";

// Formatação Composta:
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

// Interpolação de Caracteres:
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");

// Moeda de Formatação (de acordo com o idioma selecionado no Windows pelo usuário):
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatação de Números:
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
