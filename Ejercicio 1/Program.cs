Console.WriteLine("Registro de Temperaturas por zonaz con matrices");
Console.WriteLine("Ingrese la cantidad de zonas");
int filas=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de Dias");
int columnas=int.Parse(Console.ReadLine());
double[,] temperaturas=new double[filas,columnas];
for (int i=0;i<filas; i++)
{
    for (int j=0; j<columnas; j++)
    {
        Console.WriteLine($"ingrese la temperatura de la zona {i+1} del dia {j+1}");
        temperaturas[i,j]=double.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Tabla de dias: ");
for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        Console.Write(temperaturas[f,c]);
    }
    Console.WriteLine();
}


