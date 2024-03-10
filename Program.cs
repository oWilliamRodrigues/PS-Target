using System;

class Program
{
    static void Main()
    {
        // Exercício 1
        Exercicio1();

        Console.WriteLine();

        // Exercício 2
        int limite = 1000;
        int numero = 34;

        Exercicio2(numero, limite);

        Exercicio5();
    }

    static void Exercicio1()
    {
        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("Resultado do Exercício 1:");
        Console.WriteLine("Soma dos números de 1 a 13: " + SOMA);
    }

    static void Exercicio2(int numero, int limite)
    {
        int primeiro = 0;
        int segundo = 1;
        int proximo = 0;

        while (proximo <= limite) {
            if (proximo == numero)
            {
                Console.WriteLine("O numero " + numero +" pertence a sequencia de Fibonacci!");
                return;
            }

            primeiro = segundo;
            segundo = proximo;
            proximo= primeiro + segundo;
        }

        Console.WriteLine("O numero " + numero + " não pertence a sequência de Fibonacci até o limite: " + limite + "!");
    }

    static void Exercicio5()
    {
        Console.WriteLine("Digite uma string para inverter");
        string input = Console.ReadLine();

        string stringinvertida = InverterString(input);

        Console.WriteLine("String invertida " + stringinvertida);
    }

    static string InverterString(string input)
    {
        // Abriga os caracteres digitado no input
        char[] caracteres = input.ToCharArray();

        int inicio = 0;
        int fim = caracteres.Length - 1;


        // Troca das Posições
        while (inicio < fim)
        {
            // Troca os caracteres nas posições inicio e fim
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            // Move os índices para a próxima posição
            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}
