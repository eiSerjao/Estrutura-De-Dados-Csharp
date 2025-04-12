// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Text.RegularExpressions;

//Esse progama converte Celsius para Fahrenheit

//A fórmula de conversão é: F = 1.8 * C + 32
double converterCelsiusParaFahrenheit(double c)
{
    double f;
    f = 1.8 * c + 32;
    return f;
}

//Declaração de variáveis
double t1;
double t2;

//Entrada de dados
Console.Write("Digite a temperatura em Celsius: ");
string valorEscolhido = Console.ReadLine()!;

//Validação de entrada
t1 = int.Parse(valorEscolhido);

//Validação da convenção de celsius para fahrenheit
t2 = converterCelsiusParaFahrenheit(t1);
Console.WriteLine($"A temperatura em Fahrenheit é: {t2}°F");

