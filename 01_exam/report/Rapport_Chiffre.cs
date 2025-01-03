class RapportChiffre : RapportDecorator
{
    public RapportChiffre(IRapport irapport) : base(irapport)
    {
    }

    public virtual string GetAuteur(string auteur)
    {
        return base.GetAuteur(auteur) + "chiffre";
    }

    public virtual string GetContenu(string contenu)
    {
        return base.GetContenu(contenu) + "chiffre";
    }
}