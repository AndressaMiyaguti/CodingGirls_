namespace Aula07_exercicio02
{
     class Pets
    {
        public int Codigo { get; set; }
        public string NomeDoAnimal { get; set; }
        public string Especie { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }
        public string NomeDoDono { get; protected set; }
        
        public string Telefone { get; protected set; }
        public string Observacao { get; protected set; }

        public Pets()
        {
        }

        public Pets(int codigo, string nomeDoAnimal, string especie, string cor, int idade, string nomeDoDono, string telefone)
        {
            Codigo = codigo;
            NomeDoAnimal = nomeDoAnimal;
            Especie = especie;
            Cor = cor;
            Idade = idade;
            NomeDoDono = nomeDoDono;
            Telefone = telefone;
        }

        public Pets(int codigo, string nomeDoAnimal, string especie, string cor, int idade,  string nomeDoDono, string telefone, string observacao) :
            this(codigo, nomeDoAnimal, especie, cor, idade, nomeDoDono, telefone)
        {
            Observacao = observacao;
          
        }
        public void Obs(string observacao)
        {
            Observacao += observacao;
        }


        public override string ToString()
        {
            return " Dados cadastrados\n" +
                " N° Registro :  "
                + Codigo
                + "\n Nome do Animal : "
                + NomeDoAnimal
                + "\n Espécie :  "
                + Especie
                + "\n Idade :"
                + Idade
                + "\n Nome de dono :"
                + NomeDoDono
                + "\n Telefone :"
                + Telefone
                + "\n Observação :"
                + Observacao;
                
        }


    }
}
