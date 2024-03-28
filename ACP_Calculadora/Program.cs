
#region Nossa calculadora deve ter a possibilidade de fazer várias operações de soma
/* Especificação Calculadora Básica


CONTEXTO 
A Dona Mariana precisa de um sistema para calcular operações matemáticas simples, como adição, subtração, multiplicação e divisão entre dois números. 

Requisito 01 

//Nossa calculadora deve ter a possibilidade de somar dois números


Requisito 02 

//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma


Requisito 03 

//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração


Requisito 04 

//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática


Requisito 05 

//Nossa calculadora deve realizar as operações com "0"


Requisito 06

//Nossa calculadora deve validar a opções do menu 


Requisito 07
//Nossa calculadora deve realizar as operações com números com duas casas decimais

*/
#endregion


while (true)
{
    Console.Clear();
    Console.WriteLine("Bem Vinda Mariana");

    Console.WriteLine("Informe o numero da operação de que deseja fazer:");
    Console.WriteLine("1 =====>>> Soma");
    Console.WriteLine("2 =====>>> Subtração");
    Console.WriteLine("3 =====>>> Multiplicação");
    Console.WriteLine("4 =====>>> Divisão");
    int opcao = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Primeiro número: ");
    double primeiroNumero = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Segundo número: ");
    double segundoNumero = Convert.ToDouble(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Soma: {(primeiroNumero + segundoNumero).ToString("F2")}");
            break;

        case 2:
            Console.WriteLine($"Subtração: {(primeiroNumero - segundoNumero).ToString("F2")}");
            break;

        case 3:
            Console.WriteLine($"Multiplicação: {(primeiroNumero * segundoNumero).ToString("F2")}");
            break;

        case 4:
            if (segundoNumero == 0)
            {
                Console.WriteLine("O segundo operador não pode ser 0");
            }
            else
            {
                double result = primeiroNumero / segundoNumero;
                Console.WriteLine($"Divisão: {result.ToString("F2")}");
            }
            break;

        default:
            Console.WriteLine("Operação não reconhecida");
            break;
    }

    Console.WriteLine("Deseja realizar outra operação? ");
    Console.WriteLine("1 =====>>> Sim");
    Console.WriteLine("2 =====>>> Não");
    int resposta = Convert.ToInt16(Console.ReadLine());

    if (resposta == 2)
        break;
}


