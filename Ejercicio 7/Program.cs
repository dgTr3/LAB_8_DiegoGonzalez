Console.WriteLine("Producción de una fabrica");
Console.WriteLine();
Console.WriteLine("Ingrese la cantidad de maquinas");
int maquinas=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de turnos");
int turnos=int.Parse(Console.ReadLine());
int[,] produccion=new int[maquinas,turnos];
int total=0;
for (int i=0; i<maquinas; i++)
{
    for (int j=0; j<turnos; j++)
    {
        Console.WriteLine($"Ingrese la producción de la máquina {i+1} en el turno {j+1}");
        produccion[i,j]=int.Parse(Console.ReadLine());
        total+=produccion[i,j];
    }
}
Console.WriteLine($"Total de la produccion en la fabrica es de: {total}");