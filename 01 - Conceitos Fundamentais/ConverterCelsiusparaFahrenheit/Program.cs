// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Text.RegularExpressions;

//Esse progama converte Celsius para Fahrenheit

double converterCelsiusParaFahrenheit(double c)
{
    double f;
    f = 1.8 * c + 32;
    return f;
}

double t1;
double t2;

Console.WriteLine("Digite a temperatura em Celsius: ");
string valorEscolhido = Console.ReadLine()!;

t1 = int.Parse(valorEscolhido);

t2 = converterCelsiusParaFahrenheit(t1);
Console.WriteLine($"A temperatura em Fahrenheit é: {t2}°F");

