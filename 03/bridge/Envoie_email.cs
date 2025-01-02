// Implémentations concrètes des plateformes d'envoi
public class EnvoiEmail : IPlateformeEnvoi
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}
