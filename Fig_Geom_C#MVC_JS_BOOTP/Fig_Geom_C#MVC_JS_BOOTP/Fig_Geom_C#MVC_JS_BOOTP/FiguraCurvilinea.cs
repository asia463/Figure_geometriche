namespace Fig_Geom_C_MVC_JS_BOOTP
{
    abstract class FiguraCurvilinea : IFiguraPiana
    {
        public FiguraCurvilinea(string nome)
        {
            Nome = nome;
        }

        /// Solo quelli che possono essere diversi come lunghezza.
        /// nome scelto opinabile da un punto di vista matematico.

        protected double[] _dimensionali;
        public double this[int i]
        {
            get
            {
                return _dimensionali[i];
            }
            set
            {
                _dimensionali[i] = value;
            }
        }
        public int NDati { get => _dimensionali.Length; }
        public string Nome { get; private set; }
        public abstract double CalcoloPerimetro();
        public abstract double CalcoloArea();
        public override string ToString()
        {
            return "Figura curvilinea, nome: " + Nome;
        }
    }
}