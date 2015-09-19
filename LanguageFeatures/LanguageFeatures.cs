using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp6
{
    public class LanguageFeatures
    {
        public String immutable { get; }

        /// <summary>
        /// Tests an inline method that concatenates the token in Hello World
        /// </summary>
        /// <param name="token">This will get printed between "Hello" and "world"</param>
        /// <returns></returns>
        public string inlineWithStringFormat(String token) => $"Hello {token} world";

    }
}
