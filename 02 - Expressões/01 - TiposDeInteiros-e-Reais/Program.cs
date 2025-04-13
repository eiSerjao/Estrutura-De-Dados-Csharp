
// Tipos de Inteiros

// Esse é tipo sbyte e ele tem valor de 8bits na memória e aramazena valores inteiros de -128 a 127
sbyte tipoSbyte = 10;

// Esse é tipo byte e ele tem valor de 8bits na memória e aramazena valores inteiros de 0 a 255
byte tipoByte = 10;

// Esse é tipo short e ele tem valor de 16bits na memória e aramazena valores inteiros de -32.768 a 32.767
short tipoShort = 10; 

// Esse é tipo ushort e ele tem valor de 16bits na memória e aramazena valores inteiros de 0 a 65.535
ushort tipoUshort = 10;

// Esse é tipo int o mais comum e ele tem valor de 32bits na memória e aramazena valores inteiros de -2.147.483.648 a 2.147.483.647
int tipoInt = 10;

// Esse é tipo uint e ele tem valor de 32bits na memória e aramazena valores inteiros de 0 a 4.294.967.295
uint tipoUint = 10;

// Esse é tipo long e ele tem valor de 64bits na memória e aramazena valores inteiros de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
long tipoLong = 10;

// Esse é tipo ulong e ele tem valor de 64bits na memória e aramazena valores inteiros de 0 a 18.446.744.073.709.551.615
ulong tipoUlong = 10;

// Esse é tipo nint e ele tem valor de 64bits na memória e aramazena valores inteiros de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
nint tipoNint = 10;

// Esse é tipo nuint e ele tem valor de 64bits na memória e aramazena valores inteiros de 0 a 18.446.744.073.709.551.615
nuint tipoNuint = 10;

Console.WriteLine("=========================================");
Console.WriteLine("Valores dos tipos inteiros:");
Console.WriteLine("=========================================");
// Exibindo os valores na tela
Console.WriteLine($"Valor do tipo sbyte: {tipoSbyte}");
Console.WriteLine($"Valor do tipo byte: {tipoByte}");
Console.WriteLine($"Valor do tipo short: {tipoShort}");
Console.WriteLine($"Valor do tipo ushort: {tipoUshort}");
Console.WriteLine($"Valor do tipo int: {tipoInt}");
Console.WriteLine($"Valor do tipo uint: {tipoUint}");
Console.WriteLine($"Valor do tipo long: {tipoLong}");
Console.WriteLine($"Valor do tipo ulong: {tipoUlong}");
Console.WriteLine($"Valor do tipo nint: {tipoNint}");
Console.WriteLine($"Valor do tipo nuint: {tipoNuint}");

Console.WriteLine("=========================================");
Console.WriteLine("Valores do tipo real:");
Console.WriteLine("=========================================");

// Também existem os tipos basicos para representação de numeros reais
// float, double e decimal, mas esses não são considerados inteiros.

float tipoFloat = 10.5f; // 32bits - 7 casas decimais valores reais de -3.40282347E+38 a 3.40282347E+38

// O que é esse f?

// O sufixo f indica que o número é do tipo float. Sem o sufixo, o número é considerado um double por padrão.

double tipoDouble = 10.5; // 64bits - 15 casas decimais valores reais de -1.79769313486232E308 a 1.79769313486232E308

// Tipo não necessitam de sufixo, mas é uma boa prática usar o sufixo d para indicar que o número é do tipo double.

// O tipo double é mais preciso que o tipo float, mas ocupa mais espaço na memória.

decimal tipoDecimal = 10.5m; // 128bits - 28 casas decimais valores reais de -79.2288799999999999999999999999 a 79.2288799999999999999999999999

// O sufixo m indica que o número é do tipo decimal. Sem o sufixo, o número é considerado um double por padrão.

// O tipo decimal é mais preciso que o tipo double, mas ocupa mais espaço na memória.

Console.WriteLine($"Valor do tipo float: {tipoFloat}");
Console.WriteLine($"Valor do tipo double: {tipoDouble}");   
Console.WriteLine($"Valor do tipo decimal: {tipoDecimal}");