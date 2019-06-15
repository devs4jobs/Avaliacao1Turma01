using System;
namespace Avalicao1
{
    public static class Turma
    {
        // Calcula a média da turma
        public static void CalculaMediaDaTurma(int[] notasAlunos)
        {
            int somaNotas = 0;
            foreach (var nota in notasAlunos)
                somaNotas += nota;

            Console.WriteLine($"A média da turma é de:{somaNotas / notasAlunos.Length}");
        }

        // Calcula % de aprovados e reprovados
        public static void CalculaAprovadosEReprovados(int[] notasAlunos)
        {
            int aprovados = 0;
            int reprovados = 0;

            foreach (var nota in notasAlunos)
                if (nota >= 5)
                    aprovados++;
                else
                    reprovados++;

            Console.WriteLine($"{aprovados * 20}% dos alunos foram aprovados!");
            Console.WriteLine($"{reprovados * 20}% dos alunos foram reprovados!");
        }


        // Aluno aprovado ou reprovado?
        public static string AprovadoOuReprovado(int nota)
        {
            if (nota >= 5)
                return "Aprovado";
            else
                return "Reprovado";
        }


        // Imprime o nome e a nota do aluno e se foi aprovado ou reprovado
        public static void ImprimeResultado(string[] alunos, int[] notasAlunos)
        {
            for (int i = 0; i < alunos.Length; i++)
                Console.WriteLine($"{alunos[i]} tirou a nota {notasAlunos[i]} e foi: {AprovadoOuReprovado(notasAlunos[i])}");

        }
    }
}
