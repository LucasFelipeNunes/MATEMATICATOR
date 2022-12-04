using System;
namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "2", auxiliar = "";
            int numeroLinhas = 0, numeroColunas = 0, auxInt = 0;
            double[,] matriz2x2 = new double[2, 4];
            double auxDouble = 0;
            while (opcao == "2")
            {
                Console.Write("MATEMATICATOR\n\nQual operação você gostaria de fazer?\n\n1 - Equação do Primeiro Grau\n2 - Equação do Segundo Grau\n3 - Soma, Subtração e Multiplicação de Duas Matrizes\n4 - Multiplicação de um número por uma Matriz\n5 - Matriz Inversa de Uma Matriz de ordem 2\n6 - Resolver sistema de equação com duas variáveis\n7 - Calcular determinante de matriz 3x3\n\nDigite aqui: ");
                string operacao = Console.ReadLine();
                while (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "6" && operacao != "7")
                {
                    Console.Write("Operação inválida, favor digitar um número válido: ");
                    operacao = Console.ReadLine();
                }
                switch (operacao)
                {
                    case "1":
                        Console.Write("Digite o valor (que não pode ser nulo) de a: ");
                        double a1 = double.Parse(Console.ReadLine());
                        while (a1 == 0)
                        {
                            Console.Write("O valor de a não pode ser 0, digite outro valor: ");
                            a1 = double.Parse(Console.ReadLine());
                        }
                        Console.Write("Digite o valor de b: ");
                        double b1 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor da solução desta equação é {-b1 / a1}");
                    break;
                    case "2":
                        Console.Write("Digite o valor (que não pode ser nulo) de a: ");
                        double a2 = double.Parse(Console.ReadLine());
                        while (a2 == 0)
                        {
                            Console.Write("O valor de a não pode ser 0, digite outro valor: ");
                            a2 = double.Parse(Console.ReadLine());
                        }
                        Console.Write("Digite o valor de b: ");
                        double b2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de c: ");
                        double c2 = double.Parse(Console.ReadLine());
                        double delta = Math.Pow(b2, 2) - 4 * a2 * c2;
                        if (delta < 0)
                        {
                            Console.WriteLine($"Não há soluções reais para esta equação, já que o  valor do delta ({delta}) é negativo.");
                        }
                        else if (delta == 0)
                        {
                            double x1 = -b2 / (2 * a2);
                            Console.WriteLine($"Como o valor do delta é {delta}, existe apenas uma solução real para esta equação: {x1}");
                        }
                        else
                        {
                            double x1 = (-b2 + delta) / (2 * a2);
                            double x2 = (-b2 - delta) / (2 * a2);
                            Console.WriteLine($"Como o valor do delta ({delta}) é positivo, existem duas soluções reais para esta equação: {x1} e {x2}");
                        }
                    break;
                    case "3":
                        Console.Write("Digite quantas linhas a primeira matriz tem: ");
                        int numeroLinhas1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite quantas colunas a primeira matriz tem: ");
                        int numeroColunas1 = int.Parse(Console.ReadLine());
                        double[,] matriz1 = new double[numeroLinhas1, numeroColunas1];
                        for (int i = 0; i < numeroLinhas1; i++)
                        {
                            for (int j = 0; j < numeroColunas1; j++)
                            {
                                Console.Write($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz A: ");
                                matriz1[i, j] = double.Parse(Console.ReadLine());
                            }
                        }
                        Console.Write("Digite quantas linhas a segunda matriz tem: ");
                        int numeroLinhas2 = int.Parse(Console.ReadLine());
                        Console.Write("Digite quantas colunas a segunda matriz tem: ");
                        int numeroColunas2 = int.Parse(Console.ReadLine());
                        double[,] matriz2 = new double[numeroLinhas2, numeroColunas2];
                        for (int i = 0; i < numeroLinhas2; i++)
                        {
                            for (int j = 0; j < numeroColunas2; j++)
                            {
                                Console.Write($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz B: ");
                                matriz2[i, j] = double.Parse(Console.ReadLine());
                            }
                        }
                        if (numeroLinhas1 == numeroLinhas2 && numeroColunas1 == numeroColunas2)
                        {
                            double[,] soma = new double[numeroLinhas1, numeroColunas1], subtracao1 = new double[numeroLinhas1, numeroColunas1], subtracao2 = new double[numeroLinhas1, numeroColunas1];
                            Console.Write("\nA matriz soma resultante é:");
                            for (int i = 0; i < numeroLinhas1; i++)
                            {
                                Console.Write("\n");
                                for (int j = 0; j < numeroColunas1; j++)
                                {
                                    soma[i, j] = matriz1[i, j] + matriz2[i, j];
                                    Console.Write(soma[i, j] + "\t");
                                }
                            }
                            Console.Write("\n\nA matriz da subtração A-B resultante é:");
                            for (int i = 0; i < numeroLinhas1; i++)
                            {
                                Console.Write("\n");
                                for (int j = 0; j < numeroColunas1; j++)
                                {
                                    subtracao1[i, j] = matriz1[i, j] - matriz2[i, j];
                                    Console.Write(subtracao1[i, j] + "\t");
                                }
                            }
                            Console.Write("\n\nA matriz da subtração B-A resultante é:");
                            for (int i = 0; i < numeroLinhas1; i++)
                            {
                                Console.Write("\n");
                                for (int j = 0; j < numeroColunas1; j++)
                                {
                                    subtracao2[i, j] = matriz2[i, j] - matriz1[i, j];
                                    Console.Write(subtracao2[i, j] + "\t");
                                }
                            }
                        }
                        else
                        {
                            Console.Write("\nÉ impossível fazer a soma A + B e as subtrações A - B e B - A, porque o número de linhas e/ou o número de colunas das duas matrizes são diferentes.");
                        }
                        if (numeroLinhas2 == numeroColunas1)
                        {
                            double[,] multiplicacao1 = new double[numeroLinhas1, numeroColunas2];
                            Console.Write("\n\nA matriz da multiplicação A * B resultante é:");
                            for (int i = 0; i < numeroLinhas1; i++)
                            {
                                Console.Write("\n");
                                for (int j = 0; j < numeroColunas2; j++)
                                {
                                    for (int k = 0; k < numeroLinhas2; k++)
                                    {
                                        multiplicacao1[i, j] += matriz1[i, k] * matriz2[k, j];
                                    }
                                    Console.Write(multiplicacao1[i, j] + "\t");
                                }
                            }
                        }
                        else
                        {
                            Console.Write("\n\nÉ impossível fazer a multplicação A * B porque o número de linhas da matriz A é diferente do número de colunas da matriz B.");
                        }
                        if (numeroLinhas1 == numeroColunas2)
                        {
                            double[,] multiplicacao2 = new double[numeroLinhas2, numeroColunas1];
                            Console.Write("\n\nA matriz da multiplicação B*A resultante é:");
                            for (int i = 0; i < numeroLinhas2; i++)
                            {
                                Console.Write("\n");
                                for (int j = 0; j < numeroColunas1; j++)
                                {
                                    for (int k = 0; k < numeroLinhas1; k++)
                                    {
                                        multiplicacao2[i, j] += matriz2[i, k] * matriz1[k, j];
                                    }
                                    Console.Write(multiplicacao2[i, j] + "\t");
                                }
                            }
                        }
                        else
                        {
                            Console.Write("\n\nÉ impossível fazer a multplicação B * A porque o número de linhas da matriz B é diferente do número de colunas da matriz A.");
                        }
                    break;
                    case "4":
                        Console.Write("Digite o número que vai multiplicar a matriz: ");
                        double numero = double.Parse(Console.ReadLine());
                        Console.Write("Digite quantas linhas a matriz tem: ");
                        numeroLinhas = int.Parse(Console.ReadLine());
                        Console.Write("Digite quantas colunas a matriz tem: ");
                        numeroColunas = int.Parse(Console.ReadLine());
                        double[,] matriz = new double[numeroLinhas, numeroColunas], matrizResultante = new double[numeroLinhas, numeroColunas];
                        for (int i = 0; i < numeroLinhas; i++)
                        {
                            for (int j = 0; j < numeroColunas; j++)
                            {
                                Console.Write($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz A: ");
                                matriz[i, j] = double.Parse(Console.ReadLine());
                                matrizResultante[i, j] = numero * matriz[i, j];
                            }
                        }
                        Console.Write("A matriz resultante é:");
                        for (int i = 0; i < numeroLinhas; i++)
                        {
                            Console.Write("\n");
                            for (int j = 0; j < numeroColunas; j++)
                            {
                                Console.Write(matrizResultante[i, j] + "\t");
                            }
                        }
                    break;
                    case "5":
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write($"Digite o número que está na linha {i + 1} e coluna {j + 1} da matriz: ");
                                matriz2x2[i, j] = double.Parse(Console.ReadLine());
                                if (i == j)
                                {
                                    matriz2x2[i, j + 2] = 1;
                                }
                                else
                                {
                                    matriz2x2[i, j + 2] = 0;
                                }
                            }
                        }
                        if (matriz2x2[0, 0] * matriz2x2[1, 1] - matriz2x2[0, 1] * matriz2x2[1, 0] == 0)
                        {
                            Console.WriteLine("Não é possível fazer a matriz inversa, já que o determinante é igual a 0.");
                        }
                        else
                        {
                            auxDouble = matriz2x2[0, 0];
                            if (matriz2x2[0, 0] != 1)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    matriz2x2[0, i] /= auxDouble;
                                }
                            }
                            auxDouble = matriz2x2[1, 0];
                            for (int i = 0; i < 4; i++)
                            {
                                matriz2x2[1, i] += matriz2x2[0, i] * -auxDouble;
                            }
                            auxDouble = matriz2x2[1, 1];
                            if (matriz2x2[1, 1] != 1)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    matriz2x2[1, i] /= auxDouble;
                                }
                            }
                            auxDouble = matriz2x2[0, 1];
                            for (int i = 0; i < 4; i++)
                            {
                                matriz2x2[0, i] += matriz2x2[1, i] * -auxDouble;
                            }
                            Console.Write("A matriz inversa desta matriz é: ");
                            for (int i = 0; i < 2; i++)
                            {
                                Console.Write("\n");
                                for (int j = 2; j < 4; j++)
                                {
                                    Console.Write(matriz2x2[i, j] + "\t");
                                }
                            }
                        }
                    break;
                    case "6":
                        double[,] matrizCofatores = new double[2, 2];
                        double[] vetorResposta = new double[2], vetorVariaveis = new double[2];
                        for (int i = 0; i < 2; i++)
                        {
                            Console.Write($"Digite o valor de a na {i + 1}ª equação: ");
                            matrizCofatores[i, 0] = double.Parse(Console.ReadLine());
                            Console.Write($"Digite o valor de b na {i + 1}ª equação: ");
                            matrizCofatores[i, 1] = double.Parse(Console.ReadLine());
                            Console.Write($"Digite o valor do resultado na {i + 1}ª equação: ");
                            vetorResposta[i] = double.Parse(Console.ReadLine());
                        }
                        Console.Write("\nA matriz de cofatores é:");
                        for (int i = 0; i < 2; i++)
                        {
                            Console.Write("\n");
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write(matrizCofatores[i, j] + "\t");
                            }
                        }
                        Console.Write("\n\nO vetor resposta é:");
                        for (int i = 0; i < 2; i++)
                        {
                            Console.Write("\n" + vetorResposta[i]);
                        }
                        Console.WriteLine("\n\nO vetor de variáveis é:\nx\ny\n");
                        double determinante2x2 = matrizCofatores[0, 0] * matrizCofatores[1, 1] - matrizCofatores[0, 1] * matrizCofatores[1, 0];
                        if (determinante2x2 == 0)
                        {
                            Console.WriteLine("Entretanto, não é possível fazer a matriz inversa, já que o determinante é igual a 0, então é impossível determinar os valores de x e y por este método.");
                        }
                        else
                        {
                            auxDouble = matrizCofatores[0, 0];
                            matrizCofatores[0, 0] = matrizCofatores[1, 1] / determinante2x2;
                            matrizCofatores[1, 1] = auxDouble / determinante2x2;
                            matrizCofatores[0, 1] /= -determinante2x2;
                            matrizCofatores[1, 0] /= -determinante2x2;
                            for (int i = 0; i < 2; i++)
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    vetorVariaveis[i] += matrizCofatores[i, j] * vetorResposta[j];
                                }
                                auxiliar = (i == 0) ? "x" : "y";
                                Console.Write($"\nO valor da variável {auxiliar} é {vetorVariaveis[i]}");
                            }
                        }
                    break;
                    case "7":
                        double[,] matriz3x3 = new double[3, 3];
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write($"Digite o número que está na linha {i + 1} e coluna {j + 1} da matriz: ");
                                matriz3x3[i, j] = double.Parse(Console.ReadLine());
                            }
                        }
                        double determinante3x3 = matriz3x3[0, 0] * matriz3x3[1, 1] * matriz3x3[2, 2] + matriz3x3[0, 1] * matriz3x3[1, 2] * matriz3x3[2, 0] + matriz3x3[0, 2] * matriz3x3[1, 0] * matriz3x3[2, 1] - matriz3x3[0, 2] * matriz3x3[1, 1] * matriz3x3[2, 0] - matriz3x3[0, 0] * matriz3x3[1, 2] * matriz3x3[2, 1] - matriz3x3[0, 1] * matriz3x3[1, 0] * matriz3x3[2, 2];
                        Console.Write($"\nO determinante desta matriz é {determinante3x3}");
                    break;
                }
                Console.Write("\n\nOperação concluída!\nO que você deseja fazer?\n1 - Fechar o Programa\n2 - Voltar ao Menu Principal\nDigite aqui: ");
                opcao = Console.ReadLine();
                while (opcao != "1" && opcao != "2")
                {
                    Console.Write("Opção inválida, digite 1 ou 2 por favor: ");
                    opcao = Console.ReadLine();
                }
            }
        }
    }
}