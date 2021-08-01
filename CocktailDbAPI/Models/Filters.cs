using Newtonsoft.Json;
using System.Collections.Generic;

namespace CocktailDbAPI.Models.Filters
{
    /// <summary>
    /// Class representing an AlcoholicFilter
    /// </summary>
    public class AlcoholicFilter
    {
        /// <summary>
        /// Alcohol type
        /// </summary>
        [JsonProperty("strAlcoholic")]
        public string Alcoholic { get; set; }
    }

    /// <summary>
    /// Class representing an AlcoholicFilters
    /// </summary>
    public class AlcoholicFilters
    {
        /// <summary>
        /// List of <see cref="AlcoholicFilter"/>
        /// </summary>
        [JsonProperty("drinks")]
        public List<AlcoholicFilter> AlcoholicFilterList { get; set; }
    }

    /// <summary>
    /// Class representing an CategoryFilter
    /// </summary>
    public class CategoryFilter
    {
        /// <summary>
        /// Category type
        /// </summary>
        [JsonProperty("strCategory")]
        public string Category { get; set; }
    }

    /// <summary>
    /// Class representing a CategoryFilters
    /// </summary>
    public class CategoryFilters
    {
        /// <summary>
        /// List of <see cref="CategoryFilter"/>
        /// </summary>
        [JsonProperty("drinks")]
        public List<CategoryFilter> CategoryFilterList { get; set; }
    }

    /// <summary>
    /// Class representing a GlassFilter
    /// </summary>
    public class GlassFilter
    {
        /// <summary>
        /// Glass type
        /// </summary>
        [JsonProperty("strGlass")]
        public string Glass { get; set; }
    }

    /// <summary>
    /// Class representing a GlassFilters
    /// </summary>
    public class GlassFilters
    {
        /// <summary>
        /// List of <see cref="GlassFilter"/>
        /// </summary>
        [JsonProperty("drinks")]
        public List<GlassFilter> GlassFilterList { get; set; }
    }

    /// <summary>
    /// Class representing an IngredientFilter
    /// </summary>
    public class IngredientFilter
    {
        /// <summary>
        /// Ingredient
        /// </summary>
        [JsonProperty("strIngredient1")]
        public string Ingredient { get; set; }
    }

    /// <summary>
    /// Class representing an IngredientFilters
    /// </summary>
    public class IngredientFilters
    {
        /// <summary>
        /// List of <see cref="IngredientFilter"/>
        /// </summary>
        [JsonProperty("drinks")]
        public List<IngredientFilter> IngredientFilterList { get; set; }
    }
}
