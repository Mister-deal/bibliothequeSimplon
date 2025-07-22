namespace bibliothequeSimplon.Models;

public class Emprunt
{
    public ICollection<EmpruntLivre> LivresEmpruntes { get; set; }
}