// Gestionnaire des prototypes de contrats
public class GestionnaireContrats
{
    private Dictionary<string, Contrat> prototypes;

    public GestionnaireContrats()
    {
        prototypes = new Dictionary<string, Contrat>();

        // Initialisation des prototypes
        prototypes.Add("Habitation", new ContratHabitation());
        prototypes.Add("Automobile", new ContratAutomobile());
        prototypes.Add("Vie", new ContratVie());
    }

    public Contrat CreerContrat(string type)
    {
        if (!prototypes.ContainsKey(type))
            throw new ArgumentException($"Type de contrat inconnu : {type}");

        return prototypes[type].Clone();
    }
}
