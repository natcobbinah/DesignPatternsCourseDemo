public abstract class RapportDecorator : IRapport
{
    protected IRapport irapport;
    public RapportDecorator(IRapport irapport)
    {
        this.irapport = irapport;
    }
    public string GetAuteur(string auteur)
    {
        return irapport.GetAuteur(auteur);
    }

    public string GetContenu(string contenu)
    {
        return irapport.GetContenu(contenu);
    }
}