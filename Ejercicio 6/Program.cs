Console.WriteLine("Asistencia de estudiantes");
Console.WriteLine();
Console.WriteLine("Ingrese el número de estudiantes");
int estudiantes=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el número de días: ");
int dias=int.Parse(Console.ReadLine());
int[,] asistencia=new int[estudiantes,dias];
for (int i=0; i<estudiantes; i++)
{
    for (int j=0; j<dias; j++)
    {
        Console.WriteLine($"Ingrese la asistencia del estudiante {i+1} del día {j+1} (1 para presente, 0 para ausente)");
        asistencia[i,j]=int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Ingrese el número del estudiante para ver su asistencia: ");
int buscar=int.Parse(Console.ReadLine());
Console.WriteLine($"Registro del estudiente {buscar}: ");
for (int d=0; d<dias; d++)
{
    if (asistencia[buscar-1,d]==1)
    {
        Console.WriteLine($"Día {d+1}: Presente");
    }
    else
    {
        Console.WriteLine($"Día {d+1}: Ausente");
    }
}