class Program
{
static void Main(string[] args)
{
        Teste1();
        Teste2();
        Teste3();

}

    //Teste 1
    static void Teste1()
    {
        Console.WriteLine("Teste 1");
        Console.WriteLine("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (fibonacci(num))
        {
            Console.WriteLine($"O número digitado {num} pertence a sequência de Fibonacci");
        }
        else
        {
            Console.WriteLine($"O número digitado {num} não pertence a sequência de Fibonacci");
        }
    }

    //Função para verificar se o número pertence a sequência
    static bool fibonacci(int n)
    {

        int a = 0;
        int b = 1;

        if (n== a || n == b)
        {
            return true;
        }

        int c = a + b;
        while (c <=n)
        {
            if (c == n)
            {
                return true;
            }

            a = b;
            b = c;
            c = a + b;
        }

        return false;

    }

    //Teste 2
    static void Teste2()
    {
        Console.WriteLine("Teste 2");
        Console.WriteLine("Digite uma string: ");
        string texto = Console.ReadLine();

        int count = 0;
        
        //Reealiza contagem de 'a' e 'A' na string
        foreach(char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {count} vezes na string");
        }
        else
        {
            Console.WriteLine($"A letra 'a' não aparece na string");
        }
    }

    // //Teste 3
    static void Teste3()
    {
        Console.WriteLine("Teste 3");
        int indice = 12;
        int soma = 0;
        int k = 1;

        while(k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        Console.WriteLine(soma);
    }

    
}