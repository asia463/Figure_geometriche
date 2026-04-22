namespace Fig_Geom_C_MVC_JS_BOOTP
{
    class Cerchio : FiguraCurvilinea
    {
        public Cerchio() : base("Cerchio")
        {
            _dimensionali = new double[1];
        }
        public Cerchio(double raggio) : base("Cerchio")
        {
            _dimensionali = new double[1] { raggio };
        }

    public override double CalcoloPerimetro()
        {
            return 2 * Math.PI * _dimensionali[0];
        }
        public override double CalcoloArea()
        {
            return this[0] * this[0] * Math.PI;
        }
    }
}
