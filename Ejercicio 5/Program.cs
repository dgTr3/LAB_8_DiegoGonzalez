Console.WriteLine("Busqeuda de producto en inventario matrices");
Console.WriteLine();
Console.WriteLine("Ingrese las dimenciones del inventario");
Console.WriteLine("ingrese filas: ");
int filas=int.Parse(Console.ReadLine());
Console.WriteLine("ingrese columnas: ");
int columnas=int.Parse(Console.ReadLine());
string[,] inventario=new string[filas,columnas];
for (int i=0; i<filas; i++)
{
    for (int j=0; j<columnas; j++)
    {
        Console.WriteLine($"Ingrese el producto en la posición {i+1} {j+1}");
        inventario[i,j]=Console.ReadLine();
    }
}
Console.WriteLine("Ingrese el valor que quiere buscar: ");
int buscar=int.Parse(Console.ReadLine());
bool encontrado = false;
for (int f=0; f<filas; f++)
{
    for (int c=0; c<columnas; c++)
    {
        if (inventario[f,c]==buscar.ToString())
        {
            Console.WriteLine($"El producto se encuentra en la posición {f+1} {c+1}");
            encontrado=true;
            break;
        }
    }
    if (encontrado)
    {
        break;
    }
}