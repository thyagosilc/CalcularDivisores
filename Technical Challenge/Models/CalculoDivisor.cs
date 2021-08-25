namespace Technical_Challenge.Models
{
    public class CalculoDivisor
    {
        public int numeroEntrada { get; set; }
        public string numeroDivisores { get; set; }
        public string divisoresPrimos { get; set; }

        public CalculoDivisor(int numeroEntrada, string numeroDivisores, string divisoresPrimos)
        {
            this.numeroEntrada = numeroEntrada;
            this.numeroDivisores = numeroDivisores;
            this.divisoresPrimos = divisoresPrimos;
        }

        public CalculoDivisor()
        {
        }

        public void ObterDivisores(int numeroEntrada)
        {
            this.numeroEntrada = numeroEntrada;

            for (int i = 1; i < numeroEntrada + 1; i++)
            {
                if (numeroEntrada % i == 0)
                {
                    numeroDivisores += " " + i;

                    if (IsNumeroPrimo(i))
                        divisoresPrimos += " " + i;
                }
            }
        }

        private bool IsNumeroPrimo(int indice)
        {
            bool nPrimo = true;
            int i = 0;
            for (i = 2; i <= indice / 2; i++)
            {
                if ((indice % i) == 0)
                    nPrimo = false;
            }
            return nPrimo;
        }
    }
}