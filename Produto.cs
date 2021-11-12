namespace ClassProd
{
    public class Produto
    {
        private int IDProd;
        private string NomeProd;
        private int QuantProd;
        private float ValorProd;

        //Get Variables
        public int GetIDProd()
        {
            return IDProd;
        }

        public string GetNomeProd()
        {
            return NomeProd;
        }

        public int GetQuantProd()
        {
            return QuantProd;
        }
        public float GetValorProd()
        {
            return ValorProd;
        }
        //Set Variables
        public void SetIDProd(int ID)
        {
            IDProd = ID;
        }

        public void SetNomeProd(string nome)
        {
            NomeProd = nome;
        }

        public void SetQuantProd(int quant)
        {
            QuantProd = quant;
        }

        public void SetValorProd(float valor)
        {
            ValorProd = valor;
        }
    }
}

