using System;
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
                if (Pag == "S" || Pag == "s")
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
            string[] Jogo = new string[10] {
                 "1 - The Legend of Zelda: Breath of the Wild",
                 "2 - Red Dead Redemption 2",
                 "3 - God of War",
                 "4 - Minecraft",
                 "5 - The Witcher 3: Wild Hunt",
                 "6 - Among Us",
                 "7 - Fortnite (Pacotes de conteúdo)",
                 "8 - Dark Souls III",
                 "9 - Animal Crossing: New Horizons",
                 "10 - Horizon Zero Dawn",
                };

            for (int i = 0; i < Jogo.Length; i++)
            {
                Console.WriteLine(Jogo[i]);
            }
        }

        static void Pagamento()
        {
            Console.WriteLine("1 - Pix");
            Console.WriteLine("2 - Cartão de debito");
            Console.WriteLine("3 - Cartão de Credito");
        }
    }
}
