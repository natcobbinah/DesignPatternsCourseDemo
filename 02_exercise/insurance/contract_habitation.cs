// Implémentations concrètes des contrats
public class ContratHabitation : Contrat
{
    public ContratHabitation() : base("Clauses standard habitation") { }

    public override Contrat Clone()
    {
        ContratHabitation clone = new ContratHabitation();
        clone.informationsClient = new Dictionary<string, string>(this.informationsClient);
        clone.annexes = new List<string>(this.annexes);
        return clone;
    }
}