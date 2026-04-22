using Fig_Geom_C_MVC_JS_BOOTP;
using Fig_Geom_C_MVC_JS_BOOTP.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public JsonResult Calcola(string tipo, double dato1, double dato2)
    {
        // Validazione lato Server: protezione contro dati negativi o nulli
        if (dato1 <= 0 || (tipo.ToLower() == "rettangolo" && dato2 <= 0))
        {
            return Json(new
            {
                nome = "Errore",
                area = "0.00",
                perimetro = "0.00",
                messaggio = "Inserire solo valori positivi."
            });
        }

        IFiguraPiana figura = null;

        switch (tipo.ToLower())
        {
            case "quadrato": figura = new Quadrato(dato1); break;
            case "rettangolo": figura = new Rettangolo(dato1, dato2); break;
            case "cerchio": figura = new Cerchio(dato1); break;
            case "pentagono": figura = new Pentagono(dato1); break;
        }

        if (figura == null) return Json(new { error = "Figura non valida" });

        return Json(new
        {
            nome = figura.Nome,
            area = figura.CalcoloArea().ToString("F2"),
            perimetro = figura.CalcoloPerimetro().ToString("F2")
        });
    }
}