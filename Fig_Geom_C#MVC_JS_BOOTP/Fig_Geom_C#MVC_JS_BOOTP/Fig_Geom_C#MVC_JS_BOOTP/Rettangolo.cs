namespace Fig_Geom_C_MVC_JS_BOOTP
{
    class Rettangolo : FiguraConLati
    {
        public Rettangolo() : base("Rettangolo")
        {
            _lati = new double[2];
        }
        public Rettangolo(double baseR, double altezzaR)
        : base("Rettangolo")

        {
            _lati = new double[2] { baseR, altezzaR };
        }
        public override double CalcoloPerimetro()
        {
            return (_lati[0] + _lati[1]) * 2;
        }
        public override double CalcoloArea()
        {
            // Giusto per vedere un'altra modalità.
            return this[0] * this[1];
        }
    }
}
