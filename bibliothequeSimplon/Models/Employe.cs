namespace bibliothequeSimplon.Models;

public class Employe
{
    public Role Role { get; set; }
    public ICollection<Emprunt> empruntsValides { get; set; }
}