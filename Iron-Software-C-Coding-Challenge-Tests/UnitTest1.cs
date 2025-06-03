using Iron_Software_C_Coding_Challenge;
using NUnit.Framework;


namespace Iron_Software_C_Coding_Challenge_Tests
{
    public class Tests
    {
        private OldPhoneLogica logic;

        [SetUp]
        public void Setup()
        {
            logic = new OldPhoneLogica();
        }

        [TestCase("33#", "E")]
        [TestCase("227*#", "B")]
        [TestCase("4433555 555666#", "HELLO")]
        [TestCase("8 88777444666*664#", "TUNN")] 
        [TestCase("999 33 7777#", "YES")]
        [TestCase("66 666#", "NO")]
        [TestCase("222 666 3 33#", "CODE")]
        [TestCase("22 9999 33#", "BYE")]
        [TestCase("555 666 888 33#", "LOVE")]
        [TestCase("666 55#", "OK")]
        [TestCase("44 444#", "HI")]
        [TestCase("22 2 *#", "B")]
        [TestCase("4433555 555666 *2#", "HELLA")]
        public void OldPhonePad_ReturnsExpected(string input, string expected)
        {
            string result = logic.OldPhonePad(input);
            Assert.AreEqual(expected, result);
        }
    }
}