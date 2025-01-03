// Classe abstraite de base pour les notifications
public abstract class Notification
{
    protected IPlateformeEnvoi plateformeEnvoi;

    protected Notification(IPlateformeEnvoi plateforme)
    {
        plateformeEnvoi = plateforme;
    }

    public void Notifier(string message)
    {
        EnvoyerNotification(message);
    }

    protected abstract void EnvoyerNotification(string message);
}