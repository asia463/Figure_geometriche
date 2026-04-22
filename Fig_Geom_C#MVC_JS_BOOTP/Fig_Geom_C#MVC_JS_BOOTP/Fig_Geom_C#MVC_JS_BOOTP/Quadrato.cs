namespace Fig_Geom_C_MVC_JS_BOOTP
{
    class Quadrato : FiguraConLati
    {
        public Quadrato() : base("Quadrato")
        {
            _lati = new double[1];
        }

        // Come usare, invece, : this()? Idem poi ...
        public Quadrato(double lato) : base("Quadrato")
        {
            _lati = new double[1] { lato };
        }
        public override double CalcoloPerimetro()
        {
            return _lati[0] * 4;
        }
        public override double CalcoloArea()
        {
            // Giusto per vedere un'altra modalità utilizzando
            // l’indicizzatore dall’interno della classe in cui risiede
            // (in questo caso è ereditato).
            return this[0] * this[0];
        }
    }
}
