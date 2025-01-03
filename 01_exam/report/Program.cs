class Program
{
    static void Main(string[] args)
    {
        // Création d'un rapport de base
        IRapport rapport = new RapportIncident(
            "test . identifiant :test,password:test ",
            "John Doe"
        );

        // Application des décorateurs
        rapport = new RapportAnonyme(rapport);
        rapport = new RapportChiffre(rapport);
        rapport = new RapportJournalise(rapport);

        // Affichage des résultats
        Console.WriteLine($"Auteur : {rapport.GetAuteur()}");
        Console.WriteLine($"Contenu : {rapport.GetContenu()}");
    }
}