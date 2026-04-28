Console.WriteLine("Ubicación de un error en sistema");
Console.WriteLine();
Console.WriteLine("Ingrese filas de la matriz");
int filas=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese columnas de la matriz");
int columnas=int.Parse(Console.ReadLine());
string[,] sistema=new string[filas,columnas];
for (int i = 0; i < filas; i++)
{
    for (int j=0;j<columnas;j++)
    {
        Console.WriteLine($"Codigo en [{i},{j}]: ");
        sistema[i,j]=Console.ReadLine();
    }
}
Console.WriteLine("Ingrese el codigo a buscar:"); 
string buscar=Console.ReadLine();
bool encontrado=false;
for (int f=0;f<filas;f++)
{
    for (int c=0;c<columnas;c++)
    {
        if (sistema[f,c]==buscar)
        {
            Console.WriteLine($"El error se encuentra en la posición [{f},{c}]");
            encontrado=true;
            break;
        }
    }
    if (encontrado)
    {
        break;
    }
}