using Locadora.src;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Locadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool on = true;
            int resp;

            List<Filmes> filmes = new List<Filmes>();
            filmes.Add(new Filmes("Piratas do Caribe", 14, 120, "Disney", "Ingles - Português", "3D", Categoria.ACAO));
            filmes.Add(new Filmes("Para Todos os Garotos que já Amei", 15, 120, "NETFLIX", "Ingles - Português", "2D", Categoria.ROMANCE));
            filmes.Add(new Filmes("Interestelar", 14, 120, "Lengedary", "Ingles - Português", "3D", Categoria.FICCAO));
            filmes.Add(new Filmes("Sim Senhor", 14, 120, "Warner Bros. Pictures", "Ingles - Português", "2D", Categoria.COMEDIA));
            filmes.Add(new Filmes("O Homem Invisivel ", 16, 120, "Universal Pictures", "Ingles - Português", "3D", Categoria.SUSPENSE));

            do
            {
                Console.WriteLine("===== LOCADORA DOTNET GRUPO 4 =====" +
                    "Bem Vindes !");
                Console.WriteLine("1 - COMEDIA\n" +
                                  "2 - ROMANCE\n" +
                                  "3 - FICCAO\n" +
                                  "4 - ACAO\n" +
                                  "5 - SUSPENSE\n" +
                                  "0 - SAIR DA LOCADORA\n");
                Console.Write("Digite a Categoria que você deseja: ");
                int menu = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Filme Disponivel:");
                        Console.WriteLine(filmes[3]);
                        Console.WriteLine("Deseja alugar esse filme? \n" +
                                              "1 - Sim | 2 - Não");
                        resp = int.Parse(Console.ReadLine());
                        if (resp == 1)
                        {
                            Console.Write("Filme Alugado \n");
                            on = true;
                        }
                        else if (resp == 2)
                        {

                        }
                        break;

                    case 2:
                        Console.WriteLine("Filme Disponivel:");
                        Console.WriteLine(filmes[1]);
                        Console.WriteLine("Deseja alugar esse filme? \n" +
                                          "1 - Sim | 2 - Não");
                        resp = int.Parse(Console.ReadLine());
                        if (resp == 1)
                        {
                            Console.Write("Filme Alugado \n");
                            on = false;
                        }
                        else if (resp == 2)
                        {

                        }
                        break;
                    case 3:
                        Console.WriteLine("Filme Disponivel:");
                        Console.WriteLine(filmes[2]);
                        Console.WriteLine("Deseja alugar esse filme? \n" +
                                          "1 - Sim | 2 - Não");
                        resp = int.Parse(Console.ReadLine());
                        if (resp == 1)
                        {
                            Console.Write("Filme Alugado \n");
                            on = false;
                        }
                        else if (resp == 2)
                        {

                        }
                        break;
                    case 4:
                        Console.WriteLine("Filme Disponivel:");
                        Console.WriteLine(filmes[0]);
                        Console.WriteLine("Deseja alugar esse filme? \n" +
                                          "1 - Sim | 2 - Não");
                        resp = int.Parse(Console.ReadLine());
                        if (resp == 1)
                        {
                            Console.Write("Filme Alugado \n");
                            on = false;
                        }
                        else if (resp == 2)
                        {

                        }
                        break;
                    case 5:
                        Console.WriteLine("Filme Disponivel:");
                        Console.WriteLine(filmes[4]);
                        Console.WriteLine("Deseja alugar esse filme? \n" +
                                          "1 - Sim | 2 - Não");
                        resp = int.Parse(Console.ReadLine());
                        if (resp == 1)
                        {
                            Console.Write("Filme Alugado \n");
                            on = false;
                        }
                        else if (resp == 2)
                        {

                        }
                        break;

                    case 0:
                        Console.WriteLine("");
                        on = false;
                        break;

                    default:
                        Console.WriteLine("Digite a opção correspondente ao menu!");
                        break;
                }

            } while (on == true);

        }
    }
}
