namespace WebApplication1.Models
{
    public class Dados
    {
        public string nomeProduto { get; set; }
        public float pesoProduto { get; set; }
        public float altProduto { get; set; }
        public float larProduto { get; set; }
        public float comProduto { get; set; }
        public string UF { get; set; }

        public double taxaUf { get; private set; }

        public double calcVolume()
        {
            float Volume = altProduto * larProduto * comProduto;
            return Volume;
        }

        public double frete()
        {
            switch (UF)
            {
                case "MG": taxaUf = 55;
                    break;
                case "SP": taxaUf = 50;
                    break;
                case "RJ": taxaUf = 60;
                    break;
                default:
                    taxaUf = 70;
                    break;
            }
            return calcVolume() * 0.01 + taxaUf;
        }
    }
}
