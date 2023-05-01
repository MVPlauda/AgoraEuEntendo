internal class Program
{
    private static void Main(string[]args)
    {
      
        byte value1; // armazenará o primeiro valor digitado
        short value2; // armazenará o segundo valor digitado
        int value3; // armazenará o terceiro valor digitado
        long value4; // armazenará o quarto valor digitado
        float value5; // armazenará o quinto valor digitado
        int total, parteInteira; // serão utilizadas para armazenar os resultados das operações
        decimal media; // armazenará a média dos valores digitados

        Console.Write("Digite o Primeiro Valor: ");
        value1 = byte.Parse(Console.ReadLine());
        Console.Write("Digite o Segundo Valor: ");
        value2 = short.Parse(Console.ReadLine());
        Console.Write("Digite o Terceiro Valor: ");
        value3 = int.Parse(Console.ReadLine());
        Console.Write("Digite o Quarto Valor: ");
        value4 = long.Parse(Console.ReadLine());
        Console.Write("Digite o Quinto Valor: ");
        value5 = float.Parse(Console.ReadLine());

        // Calcula a soma dos valores e armazena na variável total
        total = value1 + value2 + value3 + (int)value4 + (int)value5;
        // Calcula a média dos valores e armazena na variável media
        media = (decimal)total / 5;
        // Calcula a parte inteira da média e armazena na variável parteInteira
        parteInteira = (int)Math.Floor(media);

      
        Console.Write("Soma: " + total);
        Console.Write("Média: " + media);
        Console.Write("Parte Inteira: " + parteInteira);
        Console.Write("Carácter: " + (char)parteInteira);
    }
}
