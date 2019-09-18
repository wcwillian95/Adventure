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
                Console.WriteLine("Menu de Cadastro \n");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Listar");
                Console.WriteLine("5 - Pesquisar");
                Console.WriteLine("00 - Sair\n");
                Console.WriteLine("Digite sua opção: ");
                String opc = Console.ReadLine();
                Console.Clear();

                switch (opc)
                {
                    case "1":
                                Console.WriteLine("\nInserir\n");
                                listaPessoas.Add(IncluirPessoa());
                                Console.WriteLine("----------------------------------------------------------------------------------------------------------\n");

                        break;
                    case "2":
                        Console.WriteLine("\nAlterar\n");

                        Console.WriteLine("Digite o Nome do usuário à ser alterado");
                        string usuario = (Console.ReadLine());
                        usuario = usuario.ToUpper();                            
                        SingnUser Config = listaPessoas.Find(x => x.Nome == usuario);
                        //----------------------------------------------------
                        Console.Write("Nome:");
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
                            Console.Write("Idade:");
                            Config.Idade = Int32.Parse(Console.ReadLine());
                            if (Config.Idade > 100 && Config.Idade < 120)
                            {
                                Console.WriteLine("***Tem certeza que está é a sua idade?*** \n   (S) - (N)");
                                string conf = Console.ReadLine();
                                conf = conf.ToUpper();
                                if (conf == "S")
                                {
                                    idadeConfig = false;
                                }
                                else if (conf == "N")
                                {
                                    idadeConfig = true;
                                }
                            }
                            else if(Config.Idade >= 120)
                            {
                                Console.WriteLine("***Tá de brincadeira né!? Digite uma idade válida!***");
                                    idadeConfig = true;
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
                        Console.Clear();

                        break;
                    case "4":
                        Console.WriteLine("\n Listar");
                        Console.WriteLine(" Nome     Sexo     Idade");
                            foreach (SingnUser pessoa in listaPessoas)
                            {                           
                                Console.WriteLine($"{pessoa.Nome}   -   {pessoa.Sexo}   -   {pessoa.Idade}");
                            }
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------\n");
                        break;
                    case "5":
                        Console.WriteLine("\n Pesquisar");
                        Console.WriteLine("Digite o Nome do usuário");
                        string receber = Console.ReadLine();
                        receber = receber.ToUpper();
                        SingnUser Pesquisar = listaPessoas.Find(x => x.Nome == receber);
                                               
                        Console.WriteLine($"\n Nome: {Pesquisar.Nome}");
                        Console.WriteLine($"Sexo: {Pesquisar.Sexo}");
                        Console.WriteLine($"Idade: {Pesquisar.Idade}");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------\n");

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
                if (pessoa.Idade > 100 && pessoa.Idade < 120)
                {
                    Console.WriteLine("***Tem certeza que está é a sua idade?*** \n   (S) - (N)");
                    string conf = Console.ReadLine();
                    conf = conf.ToUpper();
                    if(conf == "S")
                    {
                        idadeConfig = false;
                    }
                    else if(conf == "N")
                    {
                        idadeConfig = true;
                    }
                }
                else if (pessoa.Idade >= 120)
                {
                    Console.WriteLine("***Tá de brincadeira né!? Digite uma idade válida!***");
                    idadeConfig = true;
                }
                else
                {
                    idadeConfig = false;
                }
                Console.Clear();

            }
            while (idadeConfig);

            return pessoa;
        }
    }
}
