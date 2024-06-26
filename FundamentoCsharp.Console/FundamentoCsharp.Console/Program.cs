// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Hello, World!");

#region Tipos e Variáveis

//var nome = Console.ReadLine();

//Console.WriteLine(nome);

float valorFloat = 3.14F; //Use float quando a memória for limitada e a precisão não for crítica. 7 dígitos de precisão
double valorDouble = 3.14; //Use double para cálculos gerais de ponto flutuante com precisão intermediária. 15-16 dígitos de precisão
decimal valorDecimal = 3.14M; //Use decimal para cálculos que requerem alta precisão, especialmente em contextos financeiros. 28-29 dígitos de precisão
int valorInteiro = 100;
bool valorBoolean = true;
char valorChar = 'A'; // O valor de char é atribuido com aspas simples ''
string valorString = "Felipe Neres";

const double PI = 3.1416; // É uma constante não muda a partir do momento que foi atribuida

Console.WriteLine();
Console.WriteLine("Tipos e Variáveis");
Console.WriteLine($"Double: {valorDouble}, Float: {valorFloat}, Decimal: {valorDecimal}");
Console.WriteLine($"Int: {valorInteiro}, Boolean: {valorBoolean}");
Console.WriteLine($"Char: {valorChar}, String: {valorString}");
//usando o simbolo do dolar $ para mesclar as variaveis é conhecimdo como interbolação 

#endregion

#region Operadores Artiméticos

int a = 1;
int b = 2;

int soma = a + b;
int subtracao = a - b;
int multiplicacao = a * b;
int divisao = b / a;
int modulo = a % b;

Console.WriteLine();
Console.WriteLine("Operadores Artiméticos");
Console.WriteLine($"soma: {soma}, Subtracao: {subtracao}, Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}, Modulo: {modulo}");

#endregion

#region Operadores Lógicos

bool x = true;
bool y = false;

var and = x && y; // AND
var or = x || y; // OR
var notX = !x; //NOT
var notY = !y; //NOT

Console.WriteLine();
Console.WriteLine("Operadores Lógicos");
Console.WriteLine("x = true, y = false");
Console.WriteLine($"AND: {and}, OR: {or}, NOT X: {notX}, NOT Y: {notY}");

#endregion

#region Operadores de Comparação

var p = 5;
var q = 10;

bool maior = p > q;
bool maiorOuIgual = p >= q;
bool menor = p < q;
bool menorOuIgual = p <= q;
bool igual = p == q;
bool diferente = p != q;

Console.WriteLine();
Console.WriteLine("Operadores de Comparação");
Console.WriteLine($"Maior: {maior}, Maior ou Igual: {maiorOuIgual},");
Console.WriteLine($"Menor: {menor}, Menor ou Igual: {menorOuIgual}," +
    $" Igual: {igual}, Diferente: {diferente}");

#endregion


#region Operadores de Igualdade e Atribuição

int k = 5;

Console.WriteLine();
Console.WriteLine("Operadores de Igualdade e Atribuição");

k = 10;
Console.WriteLine(k);

k += 5; // k = k + 5 = 15 ou 10 + 5 = 15
Console.WriteLine(k);

k -= 3; // K = K - 3 = 12 ou 15 - 3 = 12
Console.WriteLine(k);

k *= 2; // k = k * 2 = 24 ou 12 * 2 = 24 
Console.WriteLine(k);

k /= 4; // k = k / 4 = 6 ou 24 / 4 = 6 
Console.WriteLine(k);

k %= 5; // k = k % 5 = 1 ou 6 % 5 = 1
Console.WriteLine(k);

#endregion