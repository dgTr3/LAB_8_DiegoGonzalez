Console.WriteLine("Ventas de productos por día matrices");
Console.WriteLine();
Console.WriteLine("Ingrese el número de productos: ");
int productos=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el número de días: ");
int dias=int.Parse(Console.ReadLine());
double[,] ventas=new double[productos,dias];
for (int i=0; i<productos; i++)
{
    for (int j=0; j<dias; j++)
    {
        Console.WriteLine($"Ingrese las ventas del producto {i+1} del día {j+1}");
        ventas[i,j]=double.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Indique que producto quiere ver: ");
int selecc=int.Parse(Console.ReadLine());
Console.WriteLine($"Muestra del día seleccionado: ");
for (int c=0; c<dias; c++)
{
    Console.Write(ventas[selecc-1,c]+" ");
}