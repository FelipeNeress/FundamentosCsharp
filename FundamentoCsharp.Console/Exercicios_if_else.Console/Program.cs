# region Exercícios Básicos

#region 1 - Verificar número positivo: Peça ao usuário para inserir um número e verifique se ele é positivo.

//Console.Write("Dígite um número e vamos ver se ele é positivo: ");
//var entrada = Console.ReadLine();

//if (int.TryParse(entrada, out int numero))
//{
//    if (numero > 0)
//        Console.WriteLine("Seu número é positivo");
//    else if (numero < 0)
//        Console.WriteLine("Seu número é negativo");
//    else
//        Console.WriteLine("Seu número é zero");
//}
//else
//{
//    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
//}

#endregion

#region 2 - Par ou ímpar: Peça ao usuário para inserir um número e determine se ele é par ou ímpar.

//Console.Write("Dígite um número e vamos ver se ele é par ou ímpar: ");
//string entrada2 = Console.ReadLine();
//int numero2 = int.Parse(entrada2);

//if(numero2%2 == 0)
//    Console.WriteLine("Seu número é par");
//else
//    Console.WriteLine("Seu número é ímpar");

#endregion

#region 3 - Maior de dois números: Peça ao usuário para inserir dois números e determine qual é o maior.

//Console.WriteLine("Digite 2 números e vamos ver qual é o maior:");
//Console.Write("Digite o primeiro números: ");
//var primeiroNumero = int.Parse(Console.ReadLine());
//Console.Write("Digite o segunddo números: ");
//var segundoNumero = int.Parse(Console.ReadLine());

//if (primeiroNumero > segundoNumero)
//    Console.WriteLine($"Primeiro número é maior: {primeiroNumero}");
//else
//    Console.WriteLine($"Segundo número é maior: {segundoNumero}");

#endregion

#region 4 - Verificar maioridade: Peça ao usuário para inserir sua idade e verifique se ele é maior de idade (18 anos ou mais).

//Console.Write("Digite sua idade: ");
//var idade = int.Parse(Console.ReadLine());

//if (idade >= 18)
//    Console.WriteLine("Maior de idade");
//else
//    Console.WriteLine("Menor de idade");

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

#endregion

//Classificação de triângulo:
//Peça ao usuário para inserir os comprimentos dos três lados de um triângulo e determine o tipo do triângulo (equilátero, isósceles ou escaleno).

//Verificar múltiplos:

//Peça ao usuário para inserir dois números e determine se o primeiro é múltiplo do segundo.
//Classificação de ângulo:

//Peça ao usuário para inserir o valor de um ângulo e determine se ele é agudo, reto, obtuso ou raso.
//Determinar estação do ano:

//Peça ao usuário para inserir um mês (número de 1 a 12) e determine a estação do ano correspondente (considerando hemisfério norte).
//Ano bissexto:

//Peça ao usuário para inserir um ano e determine se é um ano bissexto.
//Verificação de senha:

//Peça ao usuário para inserir uma senha e verifique se ela corresponde a uma senha previamente definida.
//Classificação de IMC:

//Peça ao usuário para inserir seu peso e altura e calcule seu IMC. Classifique como abaixo do peso, peso normal, sobrepeso ou obesidade.
//Dia da semana:

//Peça ao usuário para inserir um número de 1 a 7 e imprima o dia da semana correspondente.
//Conversão de notas:

//Peça ao usuário para inserir uma nota de 0 a 100 e converta para conceitos (A, B, C, D, F).

#endregion

//Exercícios Avançados
//Calculadora básica:

//Peça ao usuário para inserir dois números e uma operação (+, -, *, /). Realize a operação e mostre o resultado.
//Jogo de adivinhação:

//Defina um número secreto e peça ao usuário para adivinhar. Forneça dicas se o palpite é maior ou menor que o número secreto.
//Verificar palíndromo:

//Peça ao usuário para inserir uma palavra e verifique se ela é um palíndromo.
//Verificação de CPF:

//Peça ao usuário para inserir um CPF e verifique se ele é válido (considerando apenas a estrutura básica).
//Classificação de idade:

//Peça ao usuário para inserir sua idade e classifique como criança, adolescente, adulto ou idoso.
//Cálculo de tarifa de transporte:

//Peça ao usuário para inserir a idade e determine a tarifa (considerando descontos para idosos e crianças).
//Verificação de número primo:

//Peça ao usuário para inserir um número e verifique se ele é primo.
//Calculadora de equação do segundo grau:

//Peça ao usuário para inserir os coeficientes de uma equação do segundo grau e determine suas raízes.
//Conversão de temperatura:

//Peça ao usuário para inserir uma temperatura em Celsius ou Fahrenheit e converta para a outra unidade.
//Classificação de caracteres:

//Peça ao usuário para inserir um caractere e determine se é uma vogal, consoante, número ou caractere especial.
//Exercícios Expert
//Validação de email:

//Peça ao usuário para inserir um email e verifique se ele é válido (considerando a estrutura básica).
//Comparação de strings:

//Peça ao usuário para inserir duas strings e verifique se são iguais, desconsiderando maiúsculas e minúsculas.
//Verificação de anagrama:

//Peça ao usuário para inserir duas palavras e verifique se são anagramas.
//Cálculo de bônus salarial:

//Peça ao usuário para inserir seu salário e tempo de serviço. Calcule o bônus com base em regras predefinidas.
//Simulação de caixa eletrônico:

//Peça ao usuário para inserir um valor a ser sacado e determine a quantidade de notas de cada denominação que o caixa eletrônico deve fornecer (considerando notas de 100, 50, 20, 10, 5 e 2).