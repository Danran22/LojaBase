using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaWebBase
{
    internal class Program
    {

    enum ope
    {
        Xbox = 1,
        Playstation,
        Nitendo,
        Steam,
        Playstore,
        AppleStore
    }
    static void Main(string[] args)
    {
        menu();
        Jogos();
        Console.Write("Qual jogo vc quer comprar?: ");
        PrecoJogos(5);
    }

    static void menu()
    {
        Console.WriteLine("Bem Vindo! A Games Star \nQual plataforma vc Gostaria de comprar? ");
        Console.WriteLine("1 - Xbox \n2 - Playstation \n3 - Nitendo \n4 - Steam \n5 - Playstore \n6 - AppleStore");
    }
    static int PrecoJogos(float jogo1)
    {
        int Num = Convert.ToInt32(Console.ReadLine());


        //Compra jogo1
        if (Num == 1 || Num == 2 || Num == 3)
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
        string[] Xbox = new string[3] {
             "1 - Starfield",
             "2 - Forza Motorsport 8",
             "3 - Elden Ring",
            };

        string[] Playstation = new string[3] {
            "1 - Spider-Man 2",
            "2 - Final Fantasy XVI",
            "3 - The Last of Us Part I (Remake)",
             };

        string[] Nintendo = new string[3] {
            "1 - The Legend of Zelda: Tears of the Kingdom",
            "2 - Super Mario Bros. Wonder",
            "3 - Metroid Dread",
             };

        string[] Steam = new string[3] {
            "1 - Baldur's Gate 3",
            "2 - Cyberpunk 2077",
            "3 - Resident Evil 4 (Remake)",
             };

        string[] PlayStore = new string[3] {
            "1 - Minecraft",
            "2 - Stardew Valley",
            "3 - Monument Valley 2",
             };

        string[] AppleStore = new string[3] {
            "1 - Stardew Valley",
            "2 - The Room: Old Sins",
            "3 - Monument Valley 2",
             };

        int Ope = Convert.ToInt32(Console.ReadLine());
        ope Esc = (ope)Ope;

        switch (Esc)
        {
            case ope.Xbox:
                Console.WriteLine("Temos esses Jogos no nosso catalogo \nLembrando claro cliente todos os jogos estão na promoção por 5 dolares");
                for (int i = 0; i < Xbox.Length; i++)
                {
                    Console.WriteLine(Xbox[i]);
                }
                break;
            case ope.Playstation:
                Console.WriteLine("Temos esses Jogos no nosso catalogo \nLembrando claro cliente todos os jogos estão na promoção por 5 dolares");
                for (int i = 0; i < Playstation.Length; i++)
                {
                    Console.WriteLine(Playstation[i]);
                }
                break;
            case ope.Nitendo:
                Console.WriteLine("Temos esses Jogos no nosso catalogo \nLembrando claro cliente todos os jogos estão na promoção por 5 dolares");
                for (int i = 0; i < Nintendo.Length; i++)
                {
                    Console.WriteLine(Nintendo[i]);
                }
                break;
            case ope.Steam:
                Console.WriteLine("Temos esses Jogos no nosso catalogo \nLembrando claro cliente todos os jogos estão na promoção por 5 dolares");
                for (int i = 0; i < Steam.Length; i++)
                {
                    Console.WriteLine(Steam[i]);
                }
                break;
            case ope.Playstore:
                Console.WriteLine("Temos esses Jogos no nosso catalogo \nLembrando claro cliente todos os jogos estão na promoção por 5 dolares");
                for (int i = 0; i < PlayStore.Length; i++)
                {
                    Console.WriteLine(PlayStore[i]);
                }
                break;
            case ope.AppleStore:
                Console.WriteLine("Temos esses Jogos no nosso catalogo \nLembrando claro cliente todos os jogos estão na promoção por 5 dolares");
                for (int i = 0; i < AppleStore.Length; i++)
                {
                    Console.WriteLine(AppleStore[i]);
                }
                break;
            default:
                Console.WriteLine("Opeção não registrada");
                break;
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
