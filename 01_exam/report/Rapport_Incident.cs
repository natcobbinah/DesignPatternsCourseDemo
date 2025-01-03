class RapportIncident : IRapport
{
    public string GetAuteur(string auteur)
    {
        return $"{auteur}  incident";
    }

    public string GetContenu(string contenu)
    {
        return $"{contenu}  incident";
    }
}