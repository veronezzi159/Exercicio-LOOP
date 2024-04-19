int inicial = 0, final = 0, contador = 0, max = 0, aux = 0;

Console.WriteLine("Digite um numero inicial");
inicial = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero final");
final = int.Parse(Console.ReadLine());

max = final - inicial;
aux = inicial;
Console.WriteLine("Numero de partida: " + inicial);
do
{
    aux++;
    if ( aux < final) 
    {        
        if (aux % 2 == 0)
        {
            if (aux == 0)
            {
                Console.WriteLine($"{aux} é neutro");
            }
            else
            { 
                Console.WriteLine($"{aux} é par");
            }

        }
        else
        {
            Console.WriteLine($"{aux} é ímpar");
        }
        contador++;
    }
} while (contador < (max -1));
Console.WriteLine(max);
Console.WriteLine(contador);

Console.WriteLine("Numero de encerramento: " + final);