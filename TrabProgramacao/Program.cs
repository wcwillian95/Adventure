using System;
using System.Collections.Generic;

namespace TrabProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {            
            Boolean Continua = true;
            List<SingnUser> listaPessoas = new List<SingnUser>();

            do
            {
                Console.WriteLine("Menu de Cadastro");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Listar");
                Console.WriteLine("5 - Pesquisar");
                Console.WriteLine("00 - Sair");
                Console.WriteLine("Digite sua opção: ");
                String opc = Console.ReadLine();

                switch (opc)
                {
                    case "1": Console.WriteLine("\nInserir\n");
                        listaPessoas.Add(IncluirPessoa());
                        break;
                    case "2":
                        Console.WriteLine("\nAlterar\n");

                        Console.WriteLine("Digite o Nome do usuário à ser alterado");
                        string usuario = (Console.ReadLine());
                        usuario = usuario.ToUpper();                            
                        SingnUser Config = listaPessoas.Find(x => x.Nome == usuario);
                        //----------------------------------------------------
                        Console.Write("\n Nome:");
                        Config.Nome = Console.ReadLine();
                        Config.Nome = Config.Nome.ToUpper();
                        //----------------------------------------------------
                        bool sexoConfig = true;
                        do
                        {
                            Console.Write("Sexo: (M) - (F)");
                            Config.Sexo = Console.ReadLine();
                            Config.Sexo = Config.Sexo.ToUpper();
                            if (Config.Sexo == "M" || Config.Sexo == "F")
                            {
                                sexoConfig = false;
                            }
                            else
                            {
                                Console.WriteLine("*** Insira um valor aceito M - F ***");
                                sexoConfig = true;
                            }
                        }
                        while (sexoConfig);
                        //----------------------------------------------------
                        bool idadeConfig = true;
                        do
                        {
                            Console.Write("\n Idade:");
                            Config.Idade = Int32.Parse(Console.ReadLine());
                            if (Config.Idade > 100)
                            {
                                Console.WriteLine("***Idade digitada inválida, digite uma idade válida***");
                            }
                            else
                            {
                                idadeConfig = false;
                            }
                        }
                        while (idadeConfig);

                        break;
                    case "3":
                        Console.WriteLine("\n Excluir \n");
                        Console.WriteLine("Digite o ID do Usuário à ser excuido");
                        int userDel = Int32.Parse(Console.ReadLine());

                        if(userDel <= listaPessoas.Count )
                        {
                            listaPessoas.RemoveAt(userDel);
                        }
                        else
                        {
                            Console.WriteLine("Usuário não encontrado na lista.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n Listar");
                        Console.WriteLine("ID    Nome     Sexo     Idade");
                        for (int i =1; i < listaPessoas.Count; i++)
                        {
                            foreach (SingnUser pessoa in listaPessoas)
                            {
                                Console.WriteLine($" {i} - {pessoa.Nome} - {pessoa.Sexo} - {pessoa.Idade}");
                            }
                        }

                        break;
                    case "5":
                        Console.WriteLine("\n Pesquisar");
                        Console.WriteLine("Digite o Nome do usuário");
                        string receber = Console.ReadLine();
                        SingnUser Pesquisar = listaPessoas.Find(x => x.Nome == receber);

                        Console.WriteLine($"Nome: {Pesquisar.Nome}");
                        Console.WriteLine($"Sexo: {Pesquisar.Sexo}");
                        Console.WriteLine($"Idade: {Pesquisar.Idade}");


                        break;
                    case "00":
                        Console.WriteLine("\n Sair");
                        Continua = false;
                        break;

                    default:
                        Console.WriteLine("Opção não existente!");
                        break;
                }
            }
            while (Continua);

        }

        private static SingnUser IncluirPessoa()
        {
            SingnUser pessoa = new SingnUser();

            Console.WriteLine("Cadastro de usuario \n Digite os dados a seguir:");
            Console.Write("Nome:");
                pessoa.Nome = Console.ReadLine();
            pessoa.Nome = pessoa.Nome.ToUpper();
            //----------------------------------------------------
            bool sexoConfig = true;
            do
            {
                Console.Write("Sexo: (M) - (F)");
                pessoa.Sexo = Console.ReadLine();
                pessoa.Sexo = pessoa.Sexo.ToUpper();
                if(pessoa.Sexo == "M" || pessoa.Sexo == "F")
                {
                    sexoConfig = false;
                }
                else
                {
                    Console.WriteLine("*** Insira um valor aceito M - F ***");
                    sexoConfig = true;
                }
            }
            while (sexoConfig);
            //----------------------------------------------------
            bool idadeConfig = true;
            do
            {
                Console.Write("Idade:");
                pessoa.Idade = Int32.Parse(Console.ReadLine());
                if (pessoa.Idade > 100)
                {
                    Console.WriteLine("***Idade digitada inválida, digite uma idade válida***");
                }
                else
                {
                    idadeConfig = false;
                }
            }
            while (idadeConfig);

            return pessoa;
        }
    }
}
