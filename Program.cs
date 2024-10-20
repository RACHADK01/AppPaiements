using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        // Instances de Carte de Credit
        CarteCredit paiement1 = new CarteCredit(150.00, "Achat de livres", 123456789);
        CarteCredit paiement2 = new CarteCredit(200.00, "Achat d'équipement", 987654321);
        CarteCredit paiement3 = new CarteCredit(50.00, "Repas au restaurant", 456789123);

        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
        paiement3.AfficherDetails();

        // Instances de Paypal
        Paypal paiementPaypal1 = new Paypal(300.00, "Abonnement en ligne", "jean@example.com");
        Paypal paiementPaypal2 = new Paypal(100.00, "Donation", "sophie@example.com");

        paiementPaypal1.AfficherDetails();
        paiementPaypal2.AfficherDetails();
    }
}