// Programme de démonstration
class Program
{
    static void Main(string[] args)
    {
        GestionnaireContrats gestionnaire = new GestionnaireContrats();

        // Création et personnalisation d'un contrat habitation
        Contrat contratHabitation = gestionnaire.CreerContrat("Habitation");
        contratHabitation.Personnaliser(new Dictionary<string, string>
        {
            {"Nom", "Dupont"},
            {"Adresse", "123 rue de la Paix"},
            {"Franchise", "500€"}
        });

        // Création d'une variante du même contrat
        Contrat contratHabitationVariante = contratHabitation.Clone();
        contratHabitationVariante.Personnaliser(new Dictionary<string, string>
        {
            {"Franchise", "1000€"}
        });

        Console.WriteLine("Contrat original:");
        Console.WriteLine(contratHabitation);
        Console.WriteLine("\nVariante du contrat:");
        Console.WriteLine(contratHabitationVariante);
    }
}