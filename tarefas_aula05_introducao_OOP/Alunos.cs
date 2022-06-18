using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas_aula05_introducao_OOP
{
<<<<<<< HEAD
    internal class Alunos
=======
    class Alunos
>>>>>>> ca34c582ca30e3c1d24f3737b31a7354cc8c6c1d
    {
        /* 1 ) Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
               Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 
               2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
               - Calcular média: calcula e exibe a média final do aluno com base em suas notas;
               - Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.*/


<<<<<<< HEAD
        //Dados solicitados

        public int Matricula;
        public string Nome;
        public double Nota_prova01;
        public double Nota_prova02;
        public double Nota_trabalho;

=======
           //Dados solicitados

            public int Matricula;
            public string Nome;
            public double Nota_prova01;
            public double Nota_prova02;
            public double Nota_trabalho;      
        
>>>>>>> ca34c582ca30e3c1d24f3737b31a7354cc8c6c1d

        public double Media()
        {
            // Calculo de MEDIA FINAL ( conforme pede o enunciado). Efetuado calculo por " 4 " pois é com base nelas que o aluno poderá ou não ser aprovado. 
<<<<<<< HEAD

=======
                        
>>>>>>> ca34c582ca30e3c1d24f3737b31a7354cc8c6c1d
            return (Nota_prova01 + Nota_prova02 + Nota_trabalho) / 4;
        }

        public double Calculo_para_Aprov_Reprov()
        {

            //Calculo considerando 7 a nota mínima para Aprovação.
<<<<<<< HEAD

            //  double nota_projeto = 0;

            double diferenca = 0;


            if (Media() < 7)
            {
                diferenca = (7 - Media()) * 4;
                Console.WriteLine($" Para que o aluno seja APROVADO a nota mínima necessária na ultima avaliação é  ");
            }
            else
            {
                Console.WriteLine(" Com base nas avaliações até o momento, o aluno está aprovado. Entretanto aconselhamos a execução da ultima prova");
=======
            
          //  double nota_projeto = 0;
           
           double diferenca = 0;
           

            if( Media() < 7)
            {
               diferenca = (7 - Media()) * 4;
               Console.WriteLine($" Para que o aluno seja APROVADO a nota mínima necessária na ultima avaliação é  ");
            }
            else
            {
               Console.WriteLine(" Com base nas avaliações até o momento, o aluno está aprovado. Entretanto aconselhamos a execução da ultima prova");
>>>>>>> ca34c582ca30e3c1d24f3737b31a7354cc8c6c1d
            }
            return diferenca;
        }

        public override string ToString()
        {

            return " Nome do Alunos:" + Nome + "\n 1° Nota: " + Nota_prova01 + "\n 2° Nota: " + Nota_prova02 + "\n 3° Nota: " + Nota_trabalho +
                "\n Média atual com base em 4 avaliações: " + Media() + "\n";
        }
    }
}
