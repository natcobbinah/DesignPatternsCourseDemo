public class ContratAutomobile : Contrat
{
    public ContratAutomobile() : base("Clauses standard automobile") { }

    public override Contrat Clone()
    {
        ContratAutomobile clone = new ContratAutomobile();
        clone.informationsClient = new Dictionary<string, string>(this.informationsClient);
        clone.annexes = new List<string>(this.annexes);
        return clone;
    }
}