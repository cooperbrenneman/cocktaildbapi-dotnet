using Newtonsoft.Json;
using System.Collections.Generic;


namespace CocktailDbAPI.Models.Ingredient
{
    /// <summary>
    /// Class representing an Ingredient
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Ingredient id
        /// </summary>
        [JsonProperty("idIngredient")]
        public string IngredientId { get; set; }

        /// <summary>
        /// Ingredient name
        /// </summary>
        [JsonProperty("strIngredient")]
        public string IngredientName { get; set; }

        /// <summary>
        /// Ingredient description
        /// </summary>
        [JsonProperty("strDescription")]
        public string Description { get; set; }

        /// <summary>
        /// Ingredient type
        /// </summary>
        [JsonProperty("strType")]
        public string Type { get; set; }

        /// <summary>
        /// Ingredient alcohol
        /// </summary>
        [JsonProperty("strAlcohol")]
        public string Alcohol { get; set; }

        /// <summary>
        /// Ingredient ABV
        /// </summary>
        [JsonProperty("strABV")]
        public string ABV { get; set; }
    }

    /// <summary>
    /// Class representing an Ingredients
    /// </summary>
    public class Ingredients
    {
        /// <summary>
        /// List of <see cref="Ingredient"/>
        /// </summary>
        [JsonProperty("ingredients")]
        public List<Ingredient> IngredientList { get; set; }
    }
}
