namespace ConsoleApp2
{
    internal class SingnUser
    {
        private string _nome;
        private string _sexo;
        private int _idade;
        public string Nome
        {
            get { return _nome; }
            set { this._nome = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { this._sexo = value; }
        }
        public int Idade
        {
            get { return _idade; }
            set { this._idade = value; }

        }

    }
}