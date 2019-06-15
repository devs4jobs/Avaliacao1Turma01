using System;

namespace Avalicao1
{
    class Program
    {
        static string[] alunos = new string[5];
        static int[] notas = new int[5];

        // Bloco inicial do programa - Captura das informações com validações dos valores das notas informados
        static void Main(string[] args)
        {
            int notasInformadas = 0;

            while (notasInformadas < 5)

            {
                Console.WriteLine("Informe o nome do aluno");
                alunos[notasInformadas] = Console.ReadLine();


                try
                {
                    Console.WriteLine("Informe a nota do aluno");
                    int nota = Convert.ToInt32(Console.ReadLine());

                    while (!(nota >= 0 && nota <= 10))
                    {
                        Console.WriteLine("Valor inválido para nota. Informa uma nota válida!");
                        nota = Convert.ToInt32(Console.ReadLine());
                    }

                    notas[notasInformadas] = nota;
                    notasInformadas++;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor inválido para nota!");
                    //
                    alunos[notasInformadas].Remove(0);

                }

            }

            Turma.CalculaMediaDaTurma(notas);
            Turma.CalculaAprovadosEReprovados(notas);
            Console.WriteLine();
            Turma.ImprimeResultado(alunos, notas);
            Console.ReadKey();
        }
    }
}
