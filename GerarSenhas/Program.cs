using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GerarSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     --------------- Sistema de Geração de Senhas ---------------           ");
            Console.WriteLine("                     *************** Criado pro Gian K. de S. Araújo ***************");
            Console.WriteLine();

            Console.WriteLine("                                            BEM VINDO!!                           ");
            Console.WriteLine();

            Console.Write("Digite a Quantidade de Caractere da Senha a ser Gerada: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ex: abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890");
            Console.Write("Digite Todos os Caracteres que Deseja que Esteja na Senha Gerada: ");
            string s = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Digite a Quantidade de Senhas que Deseja Gerar: ");
            int q = Convert.ToInt32(Console.ReadLine());

            StreamWriter local = new StreamWriter("C:\\Desenv\\senhas.txt");
            try
            {
                for (int i = 0; i < q; i++)
                {
                    StringBuilder strbld = new StringBuilder(100);
                    Random random = new Random();
                    int r = x;
                    while (0 < r--)
                    {
                        strbld.Append(s[random.Next(s.Length)]);
                    }
                    //txtSenha.Text = strbld.ToString();
                    var t = strbld.ToString();
                    local.Write(t);
                    local.WriteLine();
                }
                local.Close();
                Console.WriteLine();
                Console.WriteLine("Verifique o seu txt de Senhas");
                Console.WriteLine();
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException("ERRO", ex);
            }

        }
    }
}
