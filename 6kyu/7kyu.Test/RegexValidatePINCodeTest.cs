using NUnit.Framework;

namespace _7kyu.Test
{
    [TestFixture]
    public class RegexValidatePINCodeTest
    {
        [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("1"), "Wrong output for \"1\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("12"), "Wrong output for \"12\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("123"), "Wrong output for \"123\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("12345"), "Wrong output for \"12345\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("1234567"), "Wrong output for \"1234567\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("-1234"), "Wrong output for \"-1234\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("1.234"), "Wrong output for \"1.234\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
                        Assert.AreEqual(false, RegexValidatePINCode
            .ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }

        [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, RegexValidatePINCode
.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, RegexValidatePINCode
.ValidatePin(".234"), "Wrong output for \".234\"");

            Assert.AreEqual(false, RegexValidatePINCode
.ValidatePin("1234\n"), "Wrong output for \"1234 newLine\"");
        }

        [Test, Description("ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
            Assert.AreEqual(true, RegexValidatePINCode
.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, RegexValidatePINCode
.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, RegexValidatePINCode
.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, RegexValidatePINCode
.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, RegexValidatePINCode
.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, RegexValidatePINCode
.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, RegexValidatePINCode
.ValidatePin("090909"), "Wrong output for \"090909\"");
        }
    }
}