Console.WriteLine("Control de puntuajes en videojuego");
Console.WriteLine();
Console.WriteLine("Ingrese número de jugadores");
int jugadores=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese número de niveles");
int niveles=int.Parse(Console.ReadLine());
int[,] puntuajes=new int[jugadores,niveles];
for(int i=0;i<jugadores;i++)
{
    for(int j=0;j<niveles;j++)
    {
        Console.WriteLine($"Ingrese el puntuaje del jugador {i+1} en el nivel {j+1}");
        puntuajes[i,j]=int.Parse(Console.ReadLine());
    }
}
int maximo = puntuajes[0, 0];
for (int f = 0; f < jugadores; f++)
{
    for (int c = 0; c < niveles; c++)
    {
        if (puntuajes[f, c] > maximo)
        {
            maximo = puntuajes[f, c];
        }
    }
}