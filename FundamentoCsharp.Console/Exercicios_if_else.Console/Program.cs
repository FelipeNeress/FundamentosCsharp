# region Exercícios Básicos

#region 1 - Verificar número positivo: Peça ao usuário para inserir um número e verifique se ele é positivo.

Console.Write("Dígite um número e vamos ver se ele é positivo: ");
var entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    if (numero > 0)
        Console.WriteLine("Seu número é positivo");
    else if (numero < 0)
        Console.WriteLine("Seu número é negativo");
    else
        Console.WriteLine("Seu número é zero");
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
}

#endregion

#region 2 - Par ou ímpar: Peça ao usuário para inserir um número e determine se ele é par ou ímpar.

Console.Write("Dígite um número e vamos ver se ele é par ou ímpar: ");
string entrada2 = Console.ReadLine();
int numero2 = int.Parse(entrada2);

if (numero2 % 2 == 0)
    Console.WriteLine("Seu número é par");
else
    Console.WriteLine("Seu número é ímpar");

#endregion

#region 3 - Maior de dois números: Peça ao usuário para inserir dois números e determine qual é o maior.

Console.WriteLine("Digite 2 números e vamos ver qual é o maior:");
Console.Write("Digite o primeiro números: ");
var primeiroNumero = int.Parse(Console.ReadLine());
Console.Write("Digite o segunddo números: ");
var segundoNumero = int.Parse(Console.ReadLine());

if (primeiroNumero > segundoNumero)
    Console.WriteLine($"Primeiro número é maior: {primeiroNumero}");
else
    Console.WriteLine($"Segundo número é maior: {segundoNumero}");

#endregion

#region 4 - Verificar maioridade: Peça ao usuário para inserir sua idade e verifique se ele é maior de idade (18 anos ou mais).

Console.Write("Digite sua idade: ");
var idade = int.Parse(Console.ReadLine());

if (idade >= 18)
    Console.WriteLine("Maior de idade");
else
    Console.WriteLine("Menor de idade");

#endregion

#region 5 - Nota de aprovação: Peça ao usuário para inserir sua nota e determine se ele foi aprovado (nota maior ou igual a 60).

Console.Write("Digite sua nota: ");
var nota = int.Parse(Console.ReadLine());

if (nota >= 60)
    Console.WriteLine("Aprovado");
else
    Console.WriteLine("Reprovado");

#endregion

#endregion

#region Exercícios Intermediários

#region 6 - Comparação de três números: Peça ao usuário para inserir três números e determine qual é o maior.

Console.WriteLine("Forneça 3 números e vamos ver qual é o maior ");
Console.Write("Primeiro número: ");
var primeiroNumeroInt = int.Parse(Console.ReadLine());
Console.Write("Segundo Numero: ");
var segundoNumeroInt = int.Parse(Console.ReadLine());
Console.Write("Terceiro número: ");
var terceiroNumeroInt = int.Parse(Console.ReadLine());

if (primeiroNumeroInt > segundoNumeroInt && primeiroNumeroInt > terceiroNumeroInt)
    Console.WriteLine($"O primeiro numero é maior: {primeiroNumeroInt}");
else if (segundoNumeroInt > primeiroNumeroInt && segundoNumeroInt > terceiroNumeroInt)
    Console.WriteLine($"O segundo número é maior: {segundoNumeroInt}");
else
    Console.WriteLine($"O terceiro número é maior: {terceiroNumeroInt}");

#endregion

#region 7 - Classificação de triângulo: Peça ao usuário para inserir os comprimentos dos três lados de um triângulo e determine o tipo do triângulo (equilátero, isósceles ou escaleno).

Console.WriteLine("Insira três medidas para determinamos se o triângulo é equilátero, isósceles ou escaleno");
Console.Write("Primeiro Lado A: ");
var ladoA = int.Parse(Console.ReadLine());
Console.Write("Segundo Lado B: ");
var ladoB = int.Parse(Console.ReadLine());
Console.Write("Terceiro Lado C: ");
var ladoC = int.Parse(Console.ReadLine());

if (ladoA == ladoB && ladoA == ladoC)
    Console.WriteLine("Seu triângulo é equilátero");
else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    Console.WriteLine("Seu triângulo é isósceles");
else
    Console.WriteLine("Seu triângulo é escaleno");

#endregion

#region 8 - Verificar múltiplos: Peça ao usuário para inserir dois números e determine se o primeiro é múltiplo do segundo.

Console.WriteLine("Vamos verificar se os números é múltiplo um do outro");
Console.Write("Digite o primeiro Número: ");
var primeiroNumeroMultiplo = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo Número: ");
var segundoNumeroMultiplo = int.Parse(Console.ReadLine());

if (primeiroNumero > segundoNumero)
    if(primeiroNumeroMultiplo % segundoNumeroMultiplo == 0)
        Console.WriteLine("Os números são múltiplo um do outro");
    else
        Console.WriteLine("Os números não são múltiplo um do outro");
else
    if(primeiroNumeroMultiplo % segundoNumeroMultiplo == 0)
        Console.WriteLine("Os números são múltiplo um do outro");
    else
        Console.WriteLine("Os números não são múltiplo um do outro");

#endregion

#region 9 - Classificação de ângulo: Peça ao usuário para inserir o valor de um ângulo e determine se ele é agudo, reto, obtuso ou raso.

Console.WriteLine("Vamos determinar se o ângulo é agudo, reto, obtuso ou raso");
Console.Write("Insira a medida A do ângulo: ");
var medidaA = int.Parse(Console.ReadLine());
Console.Write("Insira a medida B do ânngulo: ");
var medidaB = int.Parse(Console.ReadLine());

var medidaAngulo = 180 - (medidaA + medidaB);

if (medidaAngulo > 0 && medidaAngulo < 90 )
    Console.WriteLine("Ângulo Agudo");
else if (medidaAngulo == 90)
    Console.WriteLine("Ângulo Reto");
else if (medidaAngulo > 90 && medidaAngulo < 180)
    Console.WriteLine("Ângulo Obtuso");
else if (medidaAngulo == 180)
    Console.WriteLine("Ângulo Raso");
else
    Console.WriteLine("Valores Invalidos para o Angulo");

#endregion

#region 10 - Determinar estação do ano: Peça ao usuário para inserir um mês (número de 1 a 12) e determine a estação do ano correspondente (considerando hemisfério norte).

Console.WriteLine("Vamos ver qual é a estação do ano, informe o mês");
var mes = int.Parse(Console.ReadLine());
 if (mes >= 1 &&  mes <=3)
    Console.WriteLine("Verão");
else if (mes >= 4 &&  mes <=6)
    Console.WriteLine("Outono");
else if (mes >= 7 &&  mes <=9)
    Console.WriteLine("Inverno");
else if (mes >= 10 &&  mes <=12)
    Console.WriteLine("Primavera");


#endregion

#region 11 - Ano bissexto: Peça ao usuário para inserir um ano e determine se é um ano bissexto.

Console.WriteLine("Por favor, insira um ano:");
string inputano = Console.ReadLine();

if (int.TryParse(inputano, out int ano))
{
    if (EhAnoBissexto(ano))
    {
        Console.WriteLine($"{ano} é um ano bissexto.");
    }
    else
    {
        Console.WriteLine($"{ano} não é um ano bissexto.");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
}

static bool EhAnoBissexto(int ano)
{
    return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
}

#endregion

#region 12 - Verificação de senha: Peça ao usuário para inserir uma senha e verifique se ela corresponde a uma senha previamente definida.




#endregion

#region 13 - Classificação de IMC: Peça ao usuário para inserir seu peso e altura e calcule seu IMC. Classifique como abaixo do peso, peso normal, sobrepeso ou obesidade.




#endregion

#region 14 - Dia da semana: Peça ao usuário para inserir um número de 1 a 7 e imprima o dia da semana correspondente.



#endregion

#region 15 - Conversão de notas: Peça ao usuário para inserir uma nota de 0 a 100 e converta para conceitos (A, B, C, D, F).



#endregion

#endregion

#region Exercícios Avançados

#region 16 - Calculadora básica: Peça ao usuário para inserir dois números e uma operação (+, -, *, /). Realize a operação e mostre o resultado.




#endregion

#region 17 - Jogo de adivinhação: Defina um número secreto e peça ao usuário para adivinhar. Forneça dicas se o palpite é maior ou menor que o número secreto.




#endregion

#region 18 - Verificar palíndromo: Peça ao usuário para inserir uma palavra e verifique se ela é um palíndromo.



#endregion

#region 19 - Verificação de CPF: Peça ao usuário para inserir um CPF e verifique se ele é válido (considerando apenas a estrutura básica).




#endregion

#region 20 - Classificação de idade: Peça ao usuário para inserir sua idade e classifique como criança, adolescente, adulto ou idoso.




#endregion

#region 21 - Cálculo de tarifa de transporte: Peça ao usuário para inserir a idade e determine a tarifa (considerando descontos para idosos e crianças).



#endregion

#region 22 - Verificação de número primo: Peça ao usuário para inserir um número e verifique se ele é primo.



#endregion

#region 23 - Calculadora de equação do segundo grau: Peça ao usuário para inserir os coeficientes de uma equação do segundo grau e determine suas raízes.



#endregion

#region 24 - Conversão de temperatura: Peça ao usuário para inserir uma temperatura em Celsius ou Fahrenheit e converta para a outra unidade.



#endregion

#region 25 - Classificação de caracteres: Peça ao usuário para inserir um caractere e determine se é uma vogal, consoante, número ou caractere especial.



#endregion

#endregion

#region Exercícios Expert

#region 26 - Validação de email: Peça ao usuário para inserir um email e verifique se ele é válido (considerando a estrutura básica).



#endregion

#region 27 - Comparação de strings: Peça ao usuário para inserir duas strings e verifique se são iguais, desconsiderando maiúsculas e minúsculas.



#endregion

#region 28 - Verificação de anagrama: Peça ao usuário para inserir duas palavras e verifique se são anagramas.



#endregion

#region 29 - Cálculo de bônus salarial: Peça ao usuário para inserir seu salário e tempo de serviço. Calcule o bônus com base em regras predefinidas.



#endregion

#region 30 - Simulação de caixa eletrônico: Peça ao usuário para inserir um valor a ser sacado e determine a quantidade de notas de cada denominação que o caixa eletrônico deve fornecer (considerando notas de 100, 50, 20, 10, 5 e 2).




#endregion

#endregion