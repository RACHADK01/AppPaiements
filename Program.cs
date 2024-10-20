using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit paiement1 = new CarteCredit(150.00, "Achat de livres", 123456789);
        CarteCredit paiement2 = new CarteCredit(200.00, "Achat d'équipement", 987654321);
        CarteCredit paiement3 = new CarteCredit(50.00, "Repas au restaurant", 456789123);

        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
        paiement3.AfficherDetails();
    }
}