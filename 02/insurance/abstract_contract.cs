// Classe abstraite de base pour les contrats
public abstract class Contrat
{
    protected string clausesStandard;
    protected Dictionary<string, string> informationsClient;
    protected List<string> annexes;

    protected Contrat(string clauses)
    {
        this.clausesStandard = clauses;
        this.informationsClient = new Dictionary<string, string>();
        this.annexes = new List<string>();
    }

    // Méthode de clonage à implémenter par les sous-classes
    public abstract Contrat Clone();

    // Méthode pour personnaliser le contrat
    public virtual void Personnaliser(Dictionary<string, string> infos)
    {
        foreach (var info in infos)
        {
            informationsClient[info.Key] = info.Value;
        }
    }

    public override string ToString()
    {
        return $"Contrat avec clauses: {clausesStandard}\nInformations client: {string.Join(", ", informationsClient)}";
    }
}