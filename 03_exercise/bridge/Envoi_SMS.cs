public class EnvoiSMS : IPlateformeEnvoi
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }

}
