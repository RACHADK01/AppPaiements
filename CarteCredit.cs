using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Reflection.Metadata;
>>>>>>> dev-cartecredit
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
<<<<<<< HEAD
    internal class CarteCredit
    {
=======
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(double montant, string description, int numeroCarte): base(montant, description)
        {
            NumeroCarte = numeroCarte;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Carte de crédit - Montant: {Montant}, Description: {Description}, Numéro de carte: {NumeroCarte}");
        }
>>>>>>> dev-cartecredit
    }
}
