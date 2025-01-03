class RapportSigne : RapportDecorator
{
    public RapportSigne(IRapport irapport) : base(irapport)
    {
    }

    public virtual string GetAuteur(string auteur)
    {
        return base.GetAuteur(auteur) + "signe";
    }

    public virtual string GetContenu(string contenu)
    {
        return base.GetContenu(contenu) + "signe";
    }
}