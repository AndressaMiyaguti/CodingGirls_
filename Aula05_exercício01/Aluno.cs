using System.Globalization;


namespace Aula05_exercício01
{
    class Aluno
    {

        //Dados solicitados

        public int Matricula;
        public string Nome;
        public double Nota_prova01;
        public double Nota_prova02;
        public double Nota_trabalho;


        public double Media()
        {
            // Calculo de MEDIA FINAL ( conforme pede o enunciado). Efetuado calculo por " 4 " pois é com base nelas que o aluno poderá ou não ser aprovado. 

            return (Nota_prova01 + Nota_prova02 + Nota_trabalho) / 4;
        }

        public double Calculo_para_Aprov_Reprov()
        {
            //Calculo considerando 7 a nota mínima para Aprovação.
            double diferenca = (7 - Media()) * 4;

            return diferenca;

        }
        public string resultadoFinal()
        {
            string mensagem;
            if (Calculo_para_Aprov_Reprov() > 7.0)
            {
                mensagem = "Para que o aluno seja APROVADO a nota mínima necessária na ultima avaliação é " + Calculo_para_Aprov_Reprov().ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                mensagem = "Com base nas avaliações até o momento, o aluno está aprovado. Entretanto aconselhamos a execução da ultima prova";
            }
            return mensagem;
        }

        public override string ToString()
        {

            return " Nome do Alunos:" + Nome + "\n 1° Nota: " + Nota_prova01.ToString("F2", CultureInfo.InvariantCulture) + "\n 2° Nota: " + Nota_prova02.ToString("F2", CultureInfo.InvariantCulture) + "\n 3° Nota: " + Nota_trabalho.ToString("F2", CultureInfo.InvariantCulture) +
                "\n Média atual com base em 4 avaliações: " + Media().ToString("F2", CultureInfo.InvariantCulture) + "\n" + resultadoFinal();
        }

    }
}
