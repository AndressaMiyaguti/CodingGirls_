using System;

namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_01();
            Task_02();
            Task_03();
            Task_04();
        }

        static void Task_01()
        {
            //  1)  Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.

            Console.WriteLine();
            Console.WriteLine("--------------------------------- Formulário Simples" +
                " ---------------------------------");

            Console.Write("Nome completo:");
            string name = Console.ReadLine();

            Console.Write("Meu endereço:");
            string address = Console.ReadLine();

            Console.Write("Meu CEP:");
            string cep = Console.ReadLine(); //Optei por não usar o intParse, devido ao dígito

            Console.Write("Meu telefone:");
            string phone = Console.ReadLine(); //Optei por não usar o intParse, devido ao dígito

            Console.WriteLine("---------------------------------Meu cadastro ---------------------------------");
            Console.WriteLine($" Nome:{name}\n Endereço:{address}\n CEP: {cep}\n Telefone: {phone}");
            Console.ReadLine();
        }
        static void Task_02()
        {
            /*  2)  Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, 
           * sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.*/

            string iconicWoman = "Grace Hopper";
            string UniversityGraduate = "Doutorado em Matemática";
            string contribution = "No campo da tecnologia, ela foi uma das criadoras do COBOL, uma linguagem de programação para bancos de dados comerciais. +" +
                " Entretanto, sua história mais famosa é a que remonta à popularização do termo “bug” para indicar problemas em software. +" +
                " Além do COBOL, Hopper também criou linguagens de programação para o UNIVAC, o primeiro computador comercial fabricado nos Estados Unidos";


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------ Uma das mulheres que contribuíram na área de Tecnologia ------------------------------ \n\n");

            Console.WriteLine($" Nome: {iconicWoman}\n Grau Acadêmico: {UniversityGraduate}\n" +
                $" Contribuição tecnológica: {contribution}");

            Console.ReadLine();

        }
        static void Task_03()
        {
            //  3)  Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------ Música escolhida ------------------------------ \n\n");

            string song = "Dancing Queen";
            string band = "ABBA";
            string genre = "Disco/Pop";
            string composer = " Benny Andersson\n Stig Anderson\n Björn Ulvaeus";
            string lyrics = "You can dance\nYou can jive\nHaving the time of your life\nSee that girl\nWatch that scene\nDigging the Dancing Queen" +
               " \nFriday night and the lights are low\nLooking out for a place to go\nWhere they play the right music\nGetting in the swing\nYou come to look for a King" +
               " \nAnybody could be that guy\nNight is young and the music's high\nWith a bit of rock music\nEverything is fine\nYou're in the mood for a dance" +
               "\nAnd when you get the chance\nYou are the Dancing Queen\nYoung and sweet, only seventeen\nDancing Queen\nFeel the beat from the tambourine, oh yeah!" +
               " \nYou can dance\nYou can jive\nHaving the time of your life\nSee that girl\nWatch that scene\nDigging the Dancing Queen\nYou're a teaser, you turn them on" +
               " \nLeave them burning and then you are gone\nLooking out for another, anyone will do\nYou're in the mood for a dance\nAnd when you get the chance " +
               "\nYou are the Dancing Queen\nYoung and sweet, only seventeen\nDancing Queen\nFeel the beat from the tambourine Oh Yeah!\nYou can dance" +
               "\nYou can jive\nHaving the time of your life\nSee that girl\nWatch that scene\nDigging the Dancing Queen\nDigging the Dancing Queen";

            Console.WriteLine($" Título: ' {song} '\n\n Banda: ' {band} '\n\n Gênero: ' {genre} '\n\n Compositores:\n{composer}\n\nLetra: '{lyrics}'");
            Console.ReadLine();
        }
        static void Task_04()
        {
            //   4)  Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------ Programa programar ------------------------------ \n\n");

            Console.WriteLine("Está preparada para mudar?");
            Console.WriteLine("Digite 1 para SIM e 2 para COM CERTEZA!");
            int res = int.Parse(Console.ReadLine());

            if (res != 1 && res != 2)
            {
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine(" Mesmo não se dando uma chance, lembre-se que a mudança vem.\n A vantagem é que temos o poder de modelar a nosso favor." +
                    "\n\n Volte quando estiver pronta!");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Então essa mensagem é pra você!");
                Console.WriteLine();
                Console.WriteLine(" Lugar de mulher é onde ela quiser, inclusive, na indústria da tecnologia.\n Seja programando, desenvolvendo produtos ou inovando\n O futuro é promissor para a mulher que consegue dar o melhor de si\n em um momento no qual, não se sente particularmente assim\n\n");
                Console.WriteLine("\n Programe-se e aprenda a programar, atualize-se, se arrisque\n");
                Console.WriteLine("\n Permita-se.\n\n Confie...\n\n Acredite...\n\n " +
                    "Você consegue!");
            }

            Console.ReadLine();
        }

    }
}
