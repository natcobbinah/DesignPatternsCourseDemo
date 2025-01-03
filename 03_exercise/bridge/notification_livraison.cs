public class NotificationLivraison : Notification
{
    public NotificationLivraison(IPlateformeEnvoi plateforme) : base(plateforme) { }

    protected override void EnvoyerNotification(string message)
    {
        plateformeEnvoi.Envoyer($"Livraison: {message}");
    }
}