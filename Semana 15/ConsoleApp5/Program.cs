using System;

namespace ConsoleApp5
{
    List<int> list = new List<int> { 4, 5, 8, -5, 7, 25, -1, 18, 1, -7, -2, 6, -4, 10 };
    int suma = 0;
            for (int i = 0; i<list.Count; i++)
            {
                suma = suma + list[i];  
            }
Console.WriteLine("La suma de todos los elementos es: " + suma);

int valor = 5;
int elemetos = 0;
for (int i = 0; i < list.Count; i++)
{
    if (list[i] > valor)
    {
        elemetos++;
    }
}
Console.WriteLine("La cantidad de elementos por encima es de: " + valor + ": " + elemetos);
int limite = 0;
int tmayores = 0;
for (int i = 0; i < list.Count; i++)
{
    if (list[i] > limite)
    {
        tmayores++;
    }
}
double porcent = tmayores / list.Count * 100;
Console.WriteLine("El porcentaje de elementos mayores son " + limite + ": " + porcent);
int posi = 0;
for (int i = 0; i < list.Count; i++)
{
    if (list[i] > 0)
    {
        posi++;
    }
}
Console.WriteLine("Cantidad de elementos positivos " + posi);

int elementbusq = 7;
int posii = -1;
for (int i = 0; i < list.Count; i++)
{
    if (list[i] == elementbusq)
    {
        posii = i;
    }
}
Console.WriteLine("Posicion del elemento " + elementbusq + ": " + posii);

Console.ReadLine();
Console.Clear();