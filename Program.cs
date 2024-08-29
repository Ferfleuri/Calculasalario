string[] historico = new string[10];
int indiceHistorico = 0 ;


while(true) //true pois é infinido, ate forçar para parar
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\tMENU");
    Console.WriteLine("Pressione F1 para calcular o salário líquido");
    Console.WriteLine("Pressione F2 para calcular o 13° salário");
    Console.WriteLine("Pressione F3 para exibir o histórico de cálculos");
    Console.WriteLine("Pressione DEL para sair");
    ConsoleKeyInfo tecla = Console.ReadKey(true); // armazena informação 
    // Console.ReadKey();  serve para ter que apertar uma tecla de função, como f1, f2, etc...

    if (tecla.Key == ConsoleKey.F1) // == atribuição
    { 
        Console.Clear ();
        Console.Write("Digite o valor da hora trabalhada: ");
        double valorHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de horas trabalhadas: ");
        double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o desconto total (em %) : ");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double salarioBruto = valorHora * horasTrabalhadas;
        double salarioLiquido = salarioBruto * (1 - desconto / 100);

        Console.WriteLine($"O salário bruto é de: R$ {salarioBruto:F2}"); // F2 para aparecer somento duas casas apos a virgula
        Console.WriteLine($"O salário líquido é de: R$ {salarioLiquido:F2}");
        Console.ReadKey();

        // Armazenando no vetor 
        if (indiceHistorico < historico.Length)
        {
            historico[indiceHistorico] = $"Salário Líquido: R$ {salarioLiquido:F2}";
            indiceHistorico++;
        }

        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();

    }  // if F1

    else if(tecla.Key == ConsoleKey.F2)
    {
        Console.Clear ();
        Console.Write("Digite o Salário Bruto: ");
        double salarioBruto = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n\n Digite a quantidade de meses trabalhados: ");
        int mesesTrabalhados = Convert.ToInt32(Console.ReadLine());

        if(mesesTrabalhados < 1 || mesesTrabalhados > 12)
        {
            Console.WriteLine("Numero de meses inválido!! Deve estar entra 1 a 12");
            Console.ReadKey();
            continue; 
        }

        double decimoTerceiro = (salarioBruto / 12) * mesesTrabalhados;
        Console.WriteLine($"O 13° salário proporcional é de: R$ {decimoTerceiro:F2}");

    } // chave do else if do f2

}
