namespace Fig_Geom_C_MVC_JS_BOOTP.Models
{
    class Pentagono : FiguraConLati
    {
        public Pentagono() : base("Pentagono")
        {
            _lati = new double[1];
        }

        public Pentagono(double lato) : base("Pentagono")
        {
            _lati = new double[1] { lato };
        }

        public override double CalcoloPerimetro()
        {
            // Il perimetro del pentagono regolare è lato * 5
            return _lati[0] * 5;
        }

        public override double CalcoloArea()
        {
            // Formula area pentagono regolare: (Lato * Lato) * costante 1.720
            // Usiamo l'indicizzatore this[0] come suggerito nelle tue dispense
            return (this[0] * this[0]) * 1.720;
        }
    }
}
