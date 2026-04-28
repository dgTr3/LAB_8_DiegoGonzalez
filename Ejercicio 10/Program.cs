Console.WriteLine("Control de inventario por sucursal");
Console.WriteLine();
Console.WriteLine("Ingrese el número de sucursales");
int sucursales=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el número de preoductos");
int productos=int.Parse(Console.ReadLine());    
int[,] inventario=new int[sucursales,productos];
for (int i=0; i<sucursales; i++)
{
    for (int j=0; j<productos; j++)
    {
        Console.WriteLine($"Ingrese la cantidad del producto {j+1} en la sucursal {i+1}");
        inventario[i,j]=int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("De qeu sucursal quiere ver el inventario?");
int buscar=int.Parse(Console.ReadLine());
Console.WriteLine($"Inventario {buscar}");
for (int p=0; p<productos; p++)
{
    Console.WriteLine($"Producto {p+1}: {inventario[buscar-1,p]} unidades");
}