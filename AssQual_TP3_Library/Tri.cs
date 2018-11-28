using System;

namespace AssQual_TP3_Library
{
    public class Tri
    {
        public static void Tri_a_bulle(int[] t, int n)
        {
            if (t == null)
                return;

            int tmp = 0;                    // Variable de stockage temporaire        
            bool en_desordre = true;       // Booléen marquant l'arrêt du tri si le tableau est ordonné

            if (t.Length < n)
                n = t.Length;

            while (en_desordre)             // Boucle de répétition du tri et le test qui arrête le tri dès que le tableau est ordonné (en_desordre=false)
            {
                en_desordre = false;        // Supposons le tableau ordonné
                for (int j = 0; j < n - 1; j++)
                {  
                    if (t[j] > t[j + 1])    // Si les 2 éléments sont mal triés
                    {  
                        tmp = t[j + 1];     /* Inversion des 2 éléments */
                        t[j + 1] = t[j];
                        t[j] = tmp;
                        
                        en_desordre = true; // Le tableau n'est toujours pas trié
                    }
                }
            }
        }
    }
}
