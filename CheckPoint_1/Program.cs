void ExibirTituloEMenu()
{
    Thread.Sleep(500);

    Console.Clear();

    Console.WriteLine("=========================================================");
    Console.WriteLine("Calculadora(Adição / Subtração / Multiplicação / Divisão)");
    Console.WriteLine("=========================================================\n");

    Console.WriteLine(@"Escolha uma opção:
1-Adição
2-Subtração
3-Multiplicação
4-Divisão
5-Sair
");
}


while (true)
{
    ExibirTituloEMenu();

    int opcao = int.TryParse(Console.ReadLine(), out int valor) ? valor : 0;

    switch (opcao)
    {
        case 1:
            Adicao();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        case 5:
            Console.WriteLine("Programa encerrado.");
            return;
        default:
            Console.WriteLine("Digite uma opção válida.");
            break;
    }
}


void Adicao()
{
    Console.Clear();

    Console.WriteLine("******************");
    Console.WriteLine("      ADIÇÃO      ");
    Console.WriteLine("******************\n");

    Console.Write("Digite um número: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite outro número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");

    Thread.Sleep(500);

}

void Subtracao()
{
    Console.Clear();

    Console.WriteLine("*****************");
    Console.WriteLine("    SUBTRAÇÃO    ");
    Console.WriteLine("*****************\n");

    Console.Write("Digite um número: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite outro número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");

    Thread.Sleep(500);
}

void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("*********************");
    Console.WriteLine("    MULTIPLICAÇÃO    ");
    Console.WriteLine("*********************\n");

    Console.Write("Digite um número: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite outro número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine($"{n1} x {n2} = {n1 * n2}");

    Thread.Sleep(500);
}

void Divisao()
{
    Console.Clear();

    Console.WriteLine("***************");
    Console.WriteLine("    DIVISÃO    ");
    Console.WriteLine("***************\n");

    Console.Write("Digite um número: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite outro número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    if (n1 == 0 || n2 == 0)
        Console.WriteLine("Não é possível realizar a divisão por 0.");
    else
        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");

    Thread.Sleep(500);
}