using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_exercicio02
{
    internal class Voos
    {
        public string Nome { get; set; }
        public string Destino { get;  set; }
        public DateTime Data { get;  set; }
        public bool finalizar { get; private set; }

        public Voos()
        {
        }

        public Voos(string nome, string destino, DateTime data, bool finalizada)
        {
            Nome = nome;
            Destino = destino;
            Data = data;
            finalizada = false;           
        }
        public string VooManha()
        {

            string horario = "";
            Console.WriteLine(" Horarios Disponíveis:\n [ 1 ] 07:30hr\n [ 2 ] 09:30hr\n [ 3 ] 11:30hr\n\n");

            int hora = int.Parse(Console.ReadLine());

            if (hora == 1)
            {
                horario = " Horário: 07:30hr.";
            }
            else if (hora == 2)
            {
                horario = " Horário: 09:30hr.";
            }
            else if (hora == 3)
            {
                horario = " Horário: 11:30hr.";
            }
            else
            {
                Console.WriteLine(" Opção inválida!");
            }            

            Console.ReadLine();

            return horario;
        }
        public string VooTarde()
        {
            string horario = "";
            Console.WriteLine(" Horarios Disponíveis:\n [ 1 ] 13:30hr\n [ 2 ] 15:30hr\n [ 3 ] 17:30hr\n\n");

            int hora = int.Parse(Console.ReadLine());

            if (hora == 1)
            {
                horario = " Horário: 13:30hr.";
            }
            else if (hora == 2)
            {
                horario = " Horário: 15:30hr.";
            }
            else if (hora == 3)
            {
                horario = " Horário: 17:30hr.";
            }
            else
            {
                Console.WriteLine(" Opção inválida!");
            }

           
            return horario;
        }
        public string VooNoite()
        {
            string horario = "";
            Console.WriteLine(" Horarios Disponíveis:\n [ 1 ] 19:30hr\n [ 2 ] 21:30hr\n [ 3 ] 23:30hr\n");

            int hora = int.Parse(Console.ReadLine());

            if (hora == 1)
            {
                horario = " Horário: 19:30hr.";
            }
            else if (hora == 2)
            {
                horario = " Horário: 21:30hr.";
            }
            else if (hora == 3)
            {
                horario = " Horário: 23:30hr.";
            }
            else
            {
                Console.WriteLine(" Opção inválida!");
            }
            return horario;
        }
        public string VerificaAssentos( string choice)
        {

            string[,] assentos = Assentos();

              //  Console.Write("\n Insira o assento de sua escolha:");

               string escolha = choice;

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                        if (assentos[i, j] == "X" && assentos[i, j] == escolha)
                        {

                            Console.WriteLine(" Assento OCUPADO!");
                        }
                        if (assentos[i, j] != "X" && assentos[i, j] == escolha)
                        {
                            assentos[i, j] = "X";
                            Console.WriteLine(" Reserva feita com sucesso!");
                            
                    }

                    }
                }
            Assentos();
           
                //Tabela atualizada
             /*   Console.WriteLine("\n\n    __________________________ Assentos Disponíveis __________________________\n\n");

                Console.WriteLine($"    {assentos[0, 0]}   |  {assentos[0, 1]}   |  {assentos[0, 2]}   |  {assentos[0, 3]}   |  {assentos[1, 0]}   |  {assentos[1, 1]}   |  {assentos[1, 2]}   |  {assentos[1, 3]}   |  {assentos[2, 0]}   |  {assentos[2, 1]} ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[2, 2]}  |  {assentos[2, 3]}  |  {assentos[3, 0]}  |  {assentos[3, 1]}  |  {assentos[3, 2]}  |  {assentos[3, 3]}  |  {assentos[4, 0]}  |  {assentos[4, 1]}  |  {assentos[4, 2]}  |  {assentos[4, 3]}  ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[5, 0]}  |  {assentos[5, 1]}  |  {assentos[5, 2]}  |  {assentos[5, 3]}  |  {assentos[6, 0]}  |  {assentos[6, 1]}  |  {assentos[6, 2]}  |  {assentos[6, 3]}  |  {assentos[7, 0]}  |  {assentos[7, 1]}  ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[7, 2]}  |  {assentos[7, 3]}  |  {assentos[8, 0]}  |  {assentos[8, 1]}  |  {assentos[8, 2]}  |  {assentos[8, 3]}  |  {assentos[9, 0]}  |  {assentos[9, 1]}  |  {assentos[9, 2]}  |  {assentos[9, 3]}  ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[10, 0]}  |  {assentos[10, 1]}  |  {assentos[10, 2]}  |  {assentos[10, 3]}  |  {assentos[11, 0]}  |  {assentos[11, 1]}  |  {assentos[11, 2]}  |  {assentos[11, 3]}  |  {assentos[12, 0]}  |  {assentos[12, 1]} ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[12, 2]}  |  {assentos[12, 3]}  |  {assentos[13, 0]}  |  {assentos[13, 1]}  |  {assentos[13, 2]}  |  {assentos[13, 3]}  |  {assentos[14, 0]}  |  {assentos[14, 1]}  |  {assentos[14, 2]}  |  {assentos[14, 3]}  ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[15, 0]}  |  {assentos[15, 1]}  |  {assentos[15, 2]}  |  {assentos[15, 3]}  |  {assentos[16, 0]}  |  {assentos[16, 1]}  |  {assentos[16, 2]}  |  {assentos[16, 3]}  |  {assentos[17, 0]}  |  {assentos[17, 1]}");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[17, 2]}  |  {assentos[17, 3]}  |  {assentos[18, 0]}  |  {assentos[18, 1]}  |  {assentos[18, 2]}  |  {assentos[18, 3]}  |  {assentos[19, 0]}  |  {assentos[19, 1]}  |  {assentos[19, 2]}  |  {assentos[19, 3]}  ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[20, 0]}  |  {assentos[20, 1]}  |  {assentos[20, 2]}  |  {assentos[20, 3]}  |  {assentos[21, 0]}  |  {assentos[21, 1]}  |  {assentos[21, 2]}  |  {assentos[21, 3]}  |  {assentos[22, 0]}  |  {assentos[22, 1]} ");
                Console.WriteLine();
                Console.WriteLine($"    {assentos[22, 2]}  |  {assentos[22, 3]}  |  {assentos[23, 0]}  |  {assentos[23, 1]}  |  {assentos[23, 2]}  |  {assentos[23, 3]}  |  {assentos[24, 0]}  |  {assentos[24, 1]}  |  {assentos[24, 2]}  |  {assentos[24, 3]}  ");

                */

                Console.WriteLine(" \n\n\nDeseja fazer nova reserva: \n [ 1 ] SIM\n [ 2 ] NÃO\n");
                int res = int.Parse(Console.ReadLine());
                if (res == 2)
                {
                    finalizar = true;
                    Console.WriteLine(" Obrigado!\n Volte Sempre.");
                    
                }

            

            Console.ReadLine();

            return string.Empty;
        }
        public void VerificaVoo(int periodo)
        {
            int periodoEscolhido = (int)periodo;

            if (periodoEscolhido == 1)
            {
                VooManha();
            }
            else if (periodoEscolhido == 2)
            {
                VooTarde();
            }
            else if (periodoEscolhido == 3)
            {
                VooNoite();
            }
            else
            {
                Console.WriteLine(" Opção Inválida!");
            }
          
        }

       
        public string[,] Assentos()
        {
            //Matriz
            string[,] assentos = new string[10, 10];
            int count = 0;

            //Design das posições
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    count++;
                    if (count < 10 )
                    {                        
                        assentos[i, j] = "A 0" + Convert.ToString(count);
                        Console.Write($"  {assentos[i, j]}  |");
                    }
                    else if(count == 100)
                    {
                         assentos[i, j] = "A" + Convert.ToString(count);
                         Console.Write($"  {assentos[i, j]}  |");                       
                    }
                    else {                       
                        assentos[i, j] = "A " + Convert.ToString(count);
                        Console.Write($"  {assentos[i, j]}  |");
                    }
                }
                Console.WriteLine();
            }

         return assentos;
        }
    }
}

