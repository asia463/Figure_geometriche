namespace Fig_Geom_C_MVC_JS_BOOTP
{
    interface IFiguraPiana
    {
        double this[int i] { get; set; }
        int NDati { get; }

        /// Qui non è inseribile private, ad esempio, per set,
        /// la scelta spetta all'implementazione.
        /// Dalla versione 8 del C# invece è possibile.
 
        string Nome { get; }
        double CalcoloPerimetro();
        double CalcoloArea();
    }
}
