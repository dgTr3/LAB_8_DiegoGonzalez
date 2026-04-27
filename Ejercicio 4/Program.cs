Console.WriteLine("Calificaciones más altas con matrices");
Console.WriteLine();
Console.WriteLine("Ingrese el número de estudiantes");
int estudiantes=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidades de  las evalucaiones: ");
int calificaciones=int.Parse(Console.ReadLine());
double[,] notas=new double[estudiantes,calificaciones];
for (int i=0; i<estudiantes; i++)
{
    for (int j=0; j<calificaciones; j++)
    {
        Console.WriteLine($"Ingrese la calificación del estudiante {i+1} de la evaluación {j+1}");
        notas[i,j]=double.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Calificaciones más alta de todo el grupo: ");
double mayor=0;
for (int f=0; f<estudiantes; f++)
{
    for (int c=0; c<calificaciones; c++)
    {
        if (notas[f,c]>mayor)
        {
            mayor=notas[f,c];
        }
    }
}
Console.WriteLine(mayor);