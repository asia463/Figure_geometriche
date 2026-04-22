namespace Fig_Geom_C_MVC_JS_BOOTP
{
    abstract class FiguraConLati : IFiguraPiana
    {
        public FiguraConLati(string nome)
        {
            Nome = nome;
        }
        /// <summary>
        /// Solo quelli che possono essere diversi come lunghezza.
        /// </summary>
        protected double[] _lati;
        public double this[int i]
        {
            get
            {
                return _lati[i];
            }
            set
            {
                _lati[i] = value;
            }
        }
        public int NDati { get => _lati.Length; }
        public string Nome { get; private set; }
        public abstract double CalcoloPerimetro();
        public abstract double CalcoloArea();
        public override string ToString()
        {
            return "Figura con lati, nome: " + Nome;
        }
    }
}
