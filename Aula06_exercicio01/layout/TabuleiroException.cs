using System;


namespace Aula06_exercicio01.layout
{
    class TabuleiroException : Exception
    {
        //Construtor que repassa a mensagem para Exception
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
