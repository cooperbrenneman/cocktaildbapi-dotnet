using System;
using System.Net;

namespace CocktailDbAPI
{
    public class CocktailAPIException: Exception
    {
        /// <summary>
        /// HTTP error code returned by CocktailAPI, which caused this exception.
        /// </summary>
        public readonly HttpStatusCode HttpStatusCode;

        /// <summary>
        /// Cocktail API exception.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="httpStatusCode">HttpStatusCode of request.</param>
        public CocktailAPIException(string message, HttpStatusCode httpStatusCode) : base(message)
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
