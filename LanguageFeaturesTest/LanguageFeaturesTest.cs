using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp6
{
    [TestClass]
    public class LanguageFeaturesTest
    {
        LanguageFeatures lf = new LanguageFeatures();

        [TestMethod]
        public void immutableGetter()
        {
            //lf.immutable = "foo"; - Shouldn't be allowed
            String value = lf.immutable;
        }


        /// <summary>
        /// Tests String interpolation feature inside of an 'expression body method'
        /// </summary>
        [TestMethod]
        public void inlineWithStringFormat()
        {
            String value = lf.inlineWithStringFormat("testing rocks");
            Assert.AreEqual("Hello testing rocks world", value);
        }

    }
}
