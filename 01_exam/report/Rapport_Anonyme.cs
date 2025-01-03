class RapportAnonyme : RapportDecorator
{
    public RapportAnonyme(IRapport irapport) : base(irapport)
    {
    }

    public virtual string GetAuteur(string auteur)
    {
        return base.GetAuteur(auteur) + "anonyme";
    }

    public virtual string GetContenu(string contenu)
    {
        return base.GetContenu(contenu) + "anonyme";
    }
}