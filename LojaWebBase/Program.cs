﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaWebBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Catalogo de jogo
            Jogos();
            Console.WriteLine("Digite o numero do jogo que vocé quer comprar: ");


            //Valor dos jogos
            PrecoJogos
                (
                299.00f //The Legend of Zelda: Breath of the Wild
                );

        }

        static int PrecoJogos(float jogo1)
        {
            int Num = Convert.ToInt32(Console.ReadLine());


            //Compra jogo1
            if (Num == 1)
            {
                Console.WriteLine($"O valor do jogo é {jogo1}");

                // Forma de pagamento
                Console.WriteLine($"Gostaria de seguir para a forma de pagamento? (S ou N) ");
                string Pag = Console.ReadLine();
                // Forma de pagamento apv
                if (Pag == "S")
                {
                    Pagamento();
                    Console.Write("Escolha a forma de pagamento: ");
                    int Ope = Convert.ToInt32(Console.ReadLine());
                    // Forma de pagamento esc
                    if (Ope == 1 || Ope == 2 || Ope == 3)
                    {
                        Console.WriteLine("Iremos Mandar a Chave do seu jogo No seu email");
                        Console.ReadLine();
                        Console.ReadLine();
                        Console.ReadLine();
                        Console.WriteLine("Chave do jogo foi resgatado obrigado pela preferencia");
                        Console.ReadLine();
                        return 1;  // Sucesso
                    }
                    // // Forma de pagamento N.E
                    else
                    {
                        Console.WriteLine("Forma de pagamento escolhida nao está no sistema");
                        Console.ReadLine();
                        return 0;  // Erro
                    }
                }
                // Forma de pagamento rec
                else
                {
                    Console.WriteLine("Vocé foi movido para a pagina inicial do site");
                    Console.ReadLine();
                    return 0;  // Usuário cancelou
                }
            }
            else
            {
                Console.WriteLine("Acabou o estoque dos outros jogos");
                Console.ReadLine();
                return -1;  // Estoque indisponível

            }

        }

        static void Jogos()
        {
            Console.WriteLine("1 - The Legend of Zelda: Breath of the Wild");
            Console.WriteLine("2 - Red Dead Redemption 2");
            Console.WriteLine("3 - God of War");
            Console.WriteLine("4 - Minecraft");
            Console.WriteLine("5 - The Witcher 3: Wild Hunt");
            Console.WriteLine("6 - Among Us");
            Console.WriteLine("7 - Fortnite (Pacotes de conteúdo)");
            Console.WriteLine("8 - Dark Souls III");
            Console.WriteLine("9 - Animal Crossing: New Horizons");
            Console.WriteLine("10 - Horizon Zero Dawn");
            Console.WriteLine(". . .");
        }

        static void Pagamento()
        {
            Console.WriteLine("1 - Pix");
            Console.WriteLine("2 - Cartão de debito");
            Console.WriteLine("3 - Cartão de Credito");
        }
    }
}