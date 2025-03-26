
   Console.WriteLine("Bienvenue aux commandes de Langagio.");

            Console.WriteLine("Voici les chapitres disponibles : 1 (pronom)");
            int numeroChapitre = obtenirUnNombreValide();

            Console.WriteLine("Merci de votre essai du logiciel. Achetez la version complète pour traiter plus d'une fois consécutive.");

            
        private static int obtenirUnNombreValide()
        {
            int entree;

            Console.WriteLine("Entrez un nombre.");

            bool estUnNombre = int.TryParse(Console.ReadLine(), out entree);

            while (estUnNombre == false)
            {
                Console.WriteLine("L'entrée n'est pas un nombre. Essayez à nouveau.");
                estUnNombre = int.TryParse(Console.ReadLine(), out entree);
            }

            return entree;
        }