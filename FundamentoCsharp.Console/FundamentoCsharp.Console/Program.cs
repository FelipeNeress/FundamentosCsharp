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

Console.WriteLine($"soma: {soma}, Subtracao: {subtracao}, Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão: {divisao}, Modulo: {modulo}");

#endregion