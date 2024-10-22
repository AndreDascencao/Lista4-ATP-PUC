class exercicio1
{
        static int Potencia(int base1, int expoente) //Para chamar o parâmetro no Rodar, escrever mesmos parâmetris
        {
            int resultado = 1;
            for(int i = 0; i <= expoente; i++)
            {
                resultado *= base1;
            }

            return resultado;
        }

        public static void Rodar() 
        {
            int base1, expoente;
            Console.WriteLine("Digite a Base:");
            base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            expoente = int.Parse(Console.ReadLine());

            int result = Potencia(base1, expoente);
            Console.WriteLine("O resultado é:"+result);
        }
}