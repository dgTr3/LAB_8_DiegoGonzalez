Console.WriteLine("Consumo eléctrico total");
Console.WriteLine();
Console.WriteLine("Ingrese el número de apartamentos: ");
int apartamentos=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de Dias: ");
int dias=int.Parse(Console.ReadLine());
double[,] consumo=new double[apartamentos,dias];
for (int i=0; i<apartamentos; i++)
{
    for (int j=0; j<dias; j++)
    {
        Console.WriteLine($"Ingrese el consumo del apartamento {i+1} del día {j+1}");
        consumo[i,j]=double.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Cosnumo total de todos los apartamentos");
double total=0;
for (int f=0; f<apartamentos; f++)
{
    for (int c=0; c<dias; c++)
    {
        total+=consumo[f,c];
    }
}
Console.WriteLine($"El consumo total es: {total}");