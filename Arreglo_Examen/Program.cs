using System;
Console.Write("Ingrese la cantidad de estudiantes: ");
if (!int.TryParse(Console.ReadLine(), out int cantidadEstudiantes) || cantidadEstudiantes <= 0)
{
    Console.WriteLine("Error: la cantidad debe ser un número entero positivo.");
    return;
}
Console.Write("Ingrese la cantidad de preguntas del examen: ");
if (!int.TryParse(Console.ReadLine(), out int cantidadPreguntas) || cantidadPreguntas <= 0)
{
    Console.WriteLine("Error: la cantidad debe ser un número entero positivo.");
    return;
}
int[,] resultados = new int[cantidadEstudiantes, cantidadPreguntas];

for (int i = 0; i < cantidadEstudiantes; i++)
{
    for (int j = 0; j < cantidadPreguntas; j++)
    {
        Console.Write($"Ingrese el resultado del estudiante {i + 1} en la pregunta {j + 1}: ");
        if (!int.TryParse(Console.ReadLine(), out int resultado) || resultado < 0 || resultado > 10)
        {
            Console.WriteLine("Error: el resultado debe ser un número entero entre 0 y 10.");
            return;
        }
        resultados[i, j] = resultado;
    }
}
double[] promedios = new double[cantidadEstudiantes];
for (int i = 0; i < cantidadEstudiantes; i++)
{
    int suma = 0;
    for (int j = 0; j < cantidadPreguntas; j++)
    {
        suma += resultados[i, j];
    }
    promedios[i] = (double)suma / cantidadPreguntas;
}
double promedioGeneral = 0;
for (int i = 0; i < cantidadEstudiantes; i++)
{
    promedioGeneral += promedios[i];
}
promedioGeneral /= cantidadEstudiantes;
Console.WriteLine("Resultados:");
for (int i = 0; i < cantidadEstudiantes; i++)
{
    Console.WriteLine($"Estudiante {i + 1}: promedio {promedios[i]}");
}

Console.WriteLine($"Promedio general: {promedioGeneral}");