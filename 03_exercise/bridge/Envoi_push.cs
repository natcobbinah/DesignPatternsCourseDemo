public class EnvoiPush : IPlateformeEnvoi
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"Push: {message}");
    }
}