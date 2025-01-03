class RapportJournalise : RapportDecorator
{
    public RapportJournalise(IRapport irapport) : base(irapport)
    {
    }

    public virtual string GetAuteur(string auteur)
    {
        return base.GetAuteur(auteur) + "journalise";
    }

    public virtual string GetContenu(string contenu)
    {
        return base.GetContenu(contenu) + "journalise";
    }
}