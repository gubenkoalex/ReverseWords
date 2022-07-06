using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseWords.Tests
{
    [TestClass()]
    public class ReversTest
    {    
        [DataTestMethod]
        [DataRow("Wh1@at h*av#e yo%_u b&&&een u$p to?", "ta1@hW e*va#h uo%_y n&&&eeb p$u ot?")]
        [DataRow("B@@@etter a n^ew frien*d tha(n an ol_d foe!", "r@@@etteB a w^en dneir*f nah(t na dl_o eof!")]
        [DataRow("","")]
        [DataRow(null, "")]
        [DataRow("1234567890", "1234567890")]
        [DataRow("!@#$%^&*()_+=?", "!@#$%^&*()_+=?")]
        [DataRow("qwertyuiopASDFGHJKLzxcvbNM", "MNbvcxzLKJHGFDSApoiuytrewq")]
        [DataRow("!Do !not !give !up, !the !beginning !is !always !the !hardest", "!oD !ton !evig !pu, !eht !gninnigeb !si !syawla !eht !tsedrah")]
        [DataRow("The@ future@ belongs@ to@ those@, who@ believe@ in@ beauty@ of@ their@ dreams@", "ehT@ erutuf@ sgnoleb@ ot@ esoht@, ohw@ eveileb@ ni@ ytuaeb@ fo@ rieht@ smaerd@")]
        public void ReversePhraseTest(string word, string expect)
        {
            // Arrange
            
            // Act
            Anagram c = new Anagram();
            string actual = c.ReversePhrase(word);

            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}