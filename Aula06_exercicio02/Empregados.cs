using System.Collections.Generic;
using System.Globalization;

namespace Aula06_exercicio02
{
    class Empregados
    {

        /* 
            
            Salário
            de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4% Imprimir o salário de um funcionário.*/
        public int Id;
        public string Nome;
        public string Cargo;
        public double SalarioMensal;

        public Empregados()
        {
        }

        public Empregados(int id, string nome, string cargo, double salarioMensal)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioMensal = salarioMensal;
        }
        public List<Empregados> Contracts { get; private set; } = new List<Empregados>();
        public double AumentoSalarial(double salario)
        {
            SalarioMensal = salario;
           double SalarioReajustado ;

            if (SalarioMensal < 0)
            {
                SalarioReajustado = 0.0;
            }
            else if ( SalarioMensal <= 400.00)
            {

                SalarioReajustado = SalarioMensal * 1.15;                
            }
            else if (SalarioMensal <= 800.00)
            {

                SalarioReajustado = SalarioMensal * 1.12;                
            }
            else if (SalarioMensal <= 1200.00)
            {

                SalarioReajustado = SalarioMensal * 1.10;               
            }
            else if ( SalarioMensal <= 2000.00)
            {

                SalarioReajustado = SalarioMensal *1.07;           
            }
            else
            {

                SalarioReajustado = SalarioMensal *1.04;

            }
            return SalarioReajustado;
        }
        public override string ToString()
        {
            return
                " Nome: "
                +Nome
                +"\n Cargo :"
                +Cargo
                + "\n Salario antigo R$ "
                + SalarioMensal.ToString("F2", CultureInfo.InvariantCulture)
                + "\n Salario Reajustado R$"
                + AumentoSalarial(SalarioMensal).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
