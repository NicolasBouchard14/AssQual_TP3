
using System;
using AssQual_TP3_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AssQual_TP3_UnitTests
{
    [TestClass]
    public class TriTest
    {
        public int _arrayLength;

        [TestInitialize]
        public void TriTestInitialization()
        {
            _arrayLength = new Random().Next(10,1000);
        }

        /// <summary>
        /// Le deuxième paramètre est 0, donc le code à l'intérieur du "for" n'est pas éxécuté.
        /// </summary>
        [TestMethod]
        public void Chemin1()
        {
            int[] tabRandom = Util.GetRandomIntArray(_arrayLength);
            int[] tabReference = tabRandom.ToArray();

            Tri.Tri_a_bulle(tabRandom, 0);

            CollectionAssert.AreEqual(tabRandom, tabReference);
        }

        /// <summary>
        /// Le tableau est vide, le code à l'intérieur du "for" n'est pas éxécuté. N > 1
        /// </summary>
        [TestMethod]
        public void Chemin1_V2()
        {
            int[] tabVide = new int[0];

            Tri.Tri_a_bulle(tabVide, _arrayLength);

            CollectionAssert.AreEqual(new int[0], tabVide);
        }

        /// <summary>
        /// Le tableau est déjà trié, il revient trié. Aucune permutation.
        /// </summary>
        [TestMethod]
        public void Chemin2()
        {
            int[] tabTrié1 = Util.GetOrderedIntArray(_arrayLength);
            int[] tabReference = tabTrié1.ToArray();

            Tri.Tri_a_bulle(tabTrié1, _arrayLength);

            CollectionAssert.AreEqual(tabTrié1, tabReference);
        }

        /// <summary>
        /// Le tableau se fait trié à moitié.
        /// </summary>
        [TestMethod]
        public void Chemin3()
        {
            // Arranger
            int[] tabRandom = Util.GetRandomIntArray(_arrayLength);
            int firstHalf = _arrayLength / 2;
            int[] firstHalfTabRandom = tabRandom.Take(firstHalf).ToArray();
            int[] secondHalfTabRandom = tabRandom.Skip(firstHalf).ToArray();
            int[] orderedFirstHalfTabRandom = firstHalfTabRandom.OrderBy(n => n).ToArray();

            // Agir
            Tri.Tri_a_bulle(tabRandom, firstHalf);
            int[] moitiéTrié = tabRandom.Take(firstHalf).ToArray();
            int[] moitiéNonTrié = tabRandom.Skip(firstHalf).ToArray();

            //Assertions
            CollectionAssert.AreEqual(moitiéTrié, orderedFirstHalfTabRandom);
            CollectionAssert.AreEqual(secondHalfTabRandom, moitiéNonTrié);
        }

        /// <summary>
        /// Le tableau se fait trier en entier.
        /// </summary>
        [TestMethod]
        public void Chemin3_V2()
        {
            // Arranger
            int[] tabRandom = Util.GetRandomIntArray(_arrayLength);
            int[] orderedTabRandom = tabRandom.OrderBy(n => n).ToArray();

            // Agir
            Tri.Tri_a_bulle(tabRandom, _arrayLength);

            //Assertions
            CollectionAssert.AreEqual(tabRandom, orderedTabRandom);
        }

        /// <summary>
        /// Passer une valeur nulle en paramètre à la méthode.
        /// </summary>
        [TestMethod]
        public void NullTabParam()
        {
            // Arranger
            int[] tabRandom = null;

            // Agir
            Tri.Tri_a_bulle(tabRandom, _arrayLength);

            //Assertions
            Assert.IsNull(tabRandom);
        }
    }
}
