namespace PessoaController.Models
{
    public class pessoaDados
    {
        public string nome { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }

        public int MyProperty { get; set; }

        public double Imc()
        {
            return peso / Math.Pow((altura / 100), 2);
        }
    }
}
