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

                            if(!string.IsNullOrEmpty(listaalunos.Nome)){
                            Console.WriteLine($"ALUNO: {listaalunos.Nome} - NOTA: {listaalunos.Nota}");
                            }
                            
                        }

                        Console.WriteLine();
                        break;

                    case "3":
                        
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i=0; i< alunos.Length; i++){

                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        ConceitoEnum conceitoGeral;
                        if(mediaGeral < 2){
                            conceitoGeral = ConceitoEnum.E;
                        }else if(mediaGeral < 4){
                            conceitoGeral = ConceitoEnum.D;
                        }else if(mediaGeral <= 6){
                            conceitoGeral = ConceitoEnum.C;
                        }else if(mediaGeral < 8){
                            conceitoGeral = ConceitoEnum.B;
                        }else{
                            conceitoGeral = ConceitoEnum.A;
                        }

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
                        Console.WriteLine();

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
