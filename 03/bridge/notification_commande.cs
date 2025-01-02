// Types concrets de notifications
public class NotificationCommande : Notification
{
    public NotificationCommande(IPlateformeEnvoi plateforme) : base(plateforme) { }

    protected override void EnvoyerNotification(string message)
    {
        plateformeEnvoi.Envoyer($"Commande: {message}");
    }
}