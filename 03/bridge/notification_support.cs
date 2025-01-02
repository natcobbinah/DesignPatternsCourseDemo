public class NotificationSupport : Notification
{
    public NotificationSupport(IPlateformeEnvoi plateforme) : base(plateforme) { }

    protected override void EnvoyerNotification(string message)
    {
        plateformeEnvoi.Envoyer($"Support: {message}");
    }
}