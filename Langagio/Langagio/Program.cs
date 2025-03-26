
   Console.WriteLine("Bienvenue aux commandes de Langagio.");


            Console.WriteLine("Voici les chapitres disponibles : 1 (pronom) 2 (verbe)");
            int numeroChapitre = obtenirUnNombreValide();

            Console.WriteLine("Voici le rappel:");
            switch (numeroChapitre)
            {
                case 1:
                    Console.WriteLine("Dans ce chapitre sur le pronom, il faut se souvenir que la deuxième personne du singulier possède une terminaison particulière.");
                    break;
                case 2:
                    Console.WriteLine("Dans ce chapitre sur les verbes, il faut se souvenir que certains verbes sont irréguliers.");
                    break;
                default:
                    Console.WriteLine("Choix invalide. Aucun rappel affiché.");
                    break;
            }

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