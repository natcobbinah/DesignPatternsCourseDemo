// Programme de démonstration
class Program
{
    static void Main(string[] args)
    {
        // Création des plateformes d'envoi
        IPlateformeEnvoi email = new EnvoiEmail();
        IPlateformeEnvoi sms = new EnvoiSMS();
        IPlateformeEnvoi push = new EnvoiPush();

        // Création et utilisation des notifications
        Notification commande = new NotificationCommande(email);
        commande.Notifier("Votre commande est confirmée");

        Notification livraison = new NotificationLivraison(sms);
        livraison.Notifier("Votre colis est en route");

        Notification support = new NotificationSupport(push);
        support.Notifier("Un agent va vous contacter");

        // Démonstration de la flexibilité : même notification, différentes plateformes
        Notification commandeSMS = new NotificationCommande(sms);
        commandeSMS.Notifier("Votre commande est confirmée");
    }
}