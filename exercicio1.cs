using System;

 class Program
{
        static int Potencia(int base, int expoente) // Por que eu tenho que declarar o tipo dentro do parâmetro? Devo declarar de novo lá no Main?
        {
            int resultado = 1;
            for(int i = 0; i <= expoente; i++)
            {
                resultado *= base;
            }

            return resultado;
        }

        static void Main() 
        {
            int base, expoente;
            Console.WriteLine("Digite a Base:");
            base = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            expoente = int.Parse(Console.ReadLine());

            int result = Potencia(resultado);
            Console.WriteLine("O resultado é:"+result);
        }
}