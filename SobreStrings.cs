/*
Métodos:
Adicionam espaços em branco para fins de formatação (PadLeft(), PadRight())
Comparam duas cadeias de caracteres ou facilitam a comparação (Trim(), TrimStart(), TrimEnd(), GetHashcode(), a propriedade Length)
Ajudam a determinar o que há dentro de uma cadeia de caracteres ou até mesmo recuperar apenas uma parte da cadeia de caracteres (Contains(), StartsWith(), EndsWith(), Substring())
Alteram o conteúdo da cadeia de caracteres substituindo, inserindo ou removendo partes (Replace(), Insert(), Remove())
Transformam uma cadeia de caracteres em uma matriz de cadeias de caracteres ou de caracteres (Split(), ToCharArray())

.IndexOf() retorna o índice da primeira ocorrência de um caractere ou cadeia de caracteres dentro de uma determinada cadeia de caracteres. 
.LastIndexOf() retorna a posição de índice da última ocorrência de um caractere ou cadeia de caracteres dentro de uma determinada cadeia de caracteres.
.IndexOfAny() informa o índice da primeira ocorrência de qualquer caractere em um array de caracteres fornecido.
Os métodos Indexof() | LastIndexOf() | IndexOfAny() retornarão -1 se o caractere ou a cadeia de caracteres não forem encontrados.
*/
string message = "What is the value <span>between the tags</span>?";
Console.WriteLine(message.IndexOf("is"));
Console.WriteLine(message.LastIndexOf("is"));
char[] charsToFind = { 'a', 'e', 'i' };
Console.WriteLine(message.IndexOfAny(charsToFind));

// Remove() quando houver uma posição padrão e consistente dos caracteres que deseja remover da cadeia de caracteres.
string data = "Teste23          5000  3  ";
string updatedData = data.Remove(6, 20);
Console.WriteLine(updatedData);

// Replace() é usado quando você precisa substituir um ou mais caracteres por um caractere diferente (ou nenhum caractere).
string message = "This--is--ex-amp-le--da-ta";
Console.WriteLine(message.Replace("--", " "));

// Variáveis para exemplos de uso abaixo
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
