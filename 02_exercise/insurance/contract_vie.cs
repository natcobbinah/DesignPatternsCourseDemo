public class ContratVie : Contrat
{
    public ContratVie() : base("Clauses standard assurance vie") { }

    public override Contrat Clone()
    {
        ContratVie clone = new ContratVie();
        clone.informationsClient = new Dictionary<string, string>(this.informationsClient);
        clone.annexes = new List<string>(this.annexes);
        return clone;
    }
}