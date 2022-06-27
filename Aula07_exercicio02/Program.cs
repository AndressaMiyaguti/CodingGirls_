using System;

namespace Aula07_exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Vamos modelar um cadastro de animais de uma pet-shop? Crie uma classe que modele os animais 
             * e contenha como atributos nome, espécie, cor, idade, observação e dados do dono. Os atributos 
             * relacionados ao dono do animal deve ser privados para proteção de dados. Forrneça métodos para 
             * cadastro e leitura das informações.*/

         
            Console.WriteLine();
            Console.WriteLine("______________________________  PET SHOP  CADASTRO  _____________________________ ");
            Console.WriteLine();

            Pets pet = new Pets();  
            Console.Write(" Número de Registro: ");
            int Codigo = int.Parse(Console.ReadLine());

            Console.Write(" Nome do animal: ");
            string NomeDoAnimal = Console.ReadLine();

            Console.Write(" Espécie: ");
            string Especie = Console.ReadLine();

            Console.Write(" Cor: ");
            string Cor = Console.ReadLine();

            Console.Write(" Idade: ");
            int Idade = int.Parse(Console.ReadLine());            

            Console.Write(" Telefone: ");
            string Telefone = Console.ReadLine();

            Console.Write(" Nome do Dono: ");
            string NomeDoDono = Console.ReadLine();

            Console.Write(" Observacões:\n [ 1 ] SIM \n [ 2 ] NÃO ");
            int res = int.Parse(Console.ReadLine());

            if(res == 2)
            {
                pet = new Pets(Codigo, NomeDoAnimal, Especie, Cor, Idade, NomeDoDono, Telefone);
            }
            else
            {
                Console.Write(" Insira as informações: ");
                string Observacao = Console.ReadLine();
                pet = new Pets(Codigo, NomeDoAnimal, Especie, Cor, Idade, NomeDoDono, Telefone, Observacao);
                
            }
            Console.WriteLine();
            Console.WriteLine(" Cadastro efetuado.\n Digite\n [ 1 ] Visualizar Cadastro\n [ 2 ] Finalizar");
            res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Console.WriteLine(pet);
                    break;
                case 2:
                    Console.WriteLine(" Sessão finalizada");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
