using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "0")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Informe  nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }
                        else{
                            throw new ArithmeticException("Valor da nota deve ser decimal");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        Console.WriteLine();
                        break;

                    case "2":
                        //TODO: Listar alunos
                        foreach(var listaalunos in alunos){

                            if(string.IsNullOrEmpty(listaalunos.Nome)){
                            Console.WriteLine($"ALUNO: {listaalunos.Nome} - NOTA: {listaalunos.Nota}");
                            }
                            
                        }

                        Console.WriteLine();
                        break;

                    case "3":
                        //TODO: Calcular média geral
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Comando inválido!");
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
