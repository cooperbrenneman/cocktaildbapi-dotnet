using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CocktailDbAPI.Models.Drink
{
    /// <summary>
    /// Class representing a Drink
    /// </summary>
    public class Drink
    {
        /// <summary>
        /// Drink id
        /// </summary>
        [JsonProperty("idDrink")]
        public string DrinkId { get; set; }

        /// <summary>
        /// Drink name
        /// </summary>
        [JsonProperty("strDrink")]
        public string DrinkName { get; set; }

        /// <summary>
        /// Drink alternative name
        /// </summary>
        [JsonProperty("strDrinkAlternate")]
        public string DrinkNameAlternate { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [JsonProperty("strTags")]
        public string Tags { get; set; }

        /// <summary>
        /// Video link
        /// </summary>
        [JsonProperty("strVideo")]
        public string Video { get; set; }

        /// <summary>
        /// Drink category
        /// </summary>
        [JsonProperty("strCategory")]
        public string Category { get; set; }

        /// <summary>
        /// Drink IBA category
        /// </summary>
        [JsonProperty("strIBA")]
        public string IBA { get; set; }

        /// <summary>
        /// Drink alcoholic category
        /// </summary>
        [JsonProperty("strAlcoholic")]
        public string Alcoholic { get; set; }

        /// <summary>
        /// Drink glass type
        /// </summary>
        [JsonProperty("strGlass")]
        public string Glass { get; set; }

        /// <summary>
        /// Drink instructions
        /// </summary>
        [JsonProperty("strInstructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// Drink instructions in English
        /// </summary>
        [JsonProperty("strInstructionsES")]
        public string InstructionsES { get; set; }

        /// <summary>
        /// Drink instructions in German
        /// </summary>
        [JsonProperty("strInstructionsDE")]
        public string InstructionsDE { get; set; }

        /// <summary>
        /// Drink instructions in French
        /// </summary>
        [JsonProperty("strInstructionsFR")]
        public string InstructionsFR { get; set; }

        /// <summary>
        /// Drink instructions in Italian
        /// </summary>
        [JsonProperty("strInstructionsIT")]
        public string InstructionsIT { get; set; }

        /// <summary>
        /// Drink instructions in Chinese simplified
        /// </summary>
        [JsonProperty("strInstructionsZH-HANS")]
        public string InstructionsZHHANS { get; set; }

        /// <summary>
        /// Drink instructions in Chinese traditional
        /// </summary>
        [JsonProperty("strInstructionsZH-HANT")]
        public string InstructionsZHHANT { get; set; }

        /// <summary>
        /// Drink thumbnail url
        /// </summary>
        [JsonProperty("strDrinkThumb")]
        public string DrinkThumb { get; set; }

        /// <summary>
        /// Ingredient1 mapped to <see cref="Measure1"/>
        /// </summary>
        [JsonProperty("strIngredient1")]
        public string Ingredient1 { get; set; }

        /// <summary>
        /// Ingredient2 mapped to <see cref="Measure2"/>
        /// </summary>
        [JsonProperty("strIngredient2")]
        public string Ingredient2 { get; set; }

        /// <summary>
        /// Ingredient3 mapped to <see cref="Measure3"/>
        /// </summary>
        [JsonProperty("strIngredient3")]
        public string Ingredient3 { get; set; }

        /// <summary>
        /// Ingredient4 mapped to <see cref="Measure4"/>
        /// </summary>
        [JsonProperty("strIngredient4")]
        public string Ingredient4 { get; set; }

        /// <summary>
        /// Ingredient5 mapped to <see cref="Measure5"/>
        /// </summary>
        [JsonProperty("strIngredient5")]
        public string Ingredient5 { get; set; }

        /// <summary>
        /// Ingredient6 mapped to <see cref="Measure6"/>
        /// </summary>
        [JsonProperty("strIngredient6")]
        public string Ingredient6 { get; set; }

        /// <summary>
        /// Ingredient7 mapped to <see cref="Measure7"/>
        /// </summary>
        [JsonProperty("strIngredient7")]
        public string Ingredient7 { get; set; }

        /// <summary>
        /// Ingredient8 mapped to <see cref="Measure8"/>
        /// </summary>
        [JsonProperty("strIngredient8")]
        public string Ingredient8 { get; set; }

        /// <summary>
        /// Ingredient9 mapped to <see cref="Measure9"/>
        /// </summary>
        [JsonProperty("strIngredient9")]
        public string Ingredient9 { get; set; }

        /// <summary>
        /// Ingredient10 mapped to <see cref="Measure10"/>
        /// </summary>
        [JsonProperty("strIngredient10")]
        public string Ingredient10 { get; set; }

        /// <summary>
        /// Ingredient11 mapped to <see cref="Measure11"/>
        /// </summary>
        [JsonProperty("strIngredient11")]
        public string Ingredient11 { get; set; }

        /// <summary>
        /// Ingredient12 mapped to <see cref="Measure12"/>
        /// </summary>
        [JsonProperty("strIngredient12")]
        public string Ingredient12 { get; set; }

        /// <summary>
        /// Ingredient13 mapped to <see cref="Measure13"/>
        /// </summary>
        [JsonProperty("strIngredient13")]
        public string Ingredient13 { get; set; }

        /// <summary>
        /// Ingredient14 mapped to <see cref="Measure14"/>
        /// </summary>
        [JsonProperty("strIngredient14")]
        public string Ingredient14 { get; set; }

        /// <summary>
        /// Ingredient15 mapped to <see cref="Measure15"/>
        /// </summary>
        [JsonProperty("strIngredient15")]
        public string Ingredient15 { get; set; }

        /// <summary>
        /// Measure1 mapped to <see cref="Ingredient1"/>
        /// </summary>
        [JsonProperty("strMeasure1")]
        public string Measure1 { get; set; }

        /// <summary>
        /// Measure2 mapped to <see cref="Ingredient2"/>
        /// </summary>
        [JsonProperty("strMeasure2")]
        public string Measure2 { get; set; }

        /// <summary>
        /// Measure3 mapped to <see cref="Ingredient3"/>
        /// </summary>
        [JsonProperty("strMeasure3")]
        public string Measure3 { get; set; }

        /// <summary>
        /// Measure4 mapped to <see cref="Ingredient4"/>
        /// </summary>
        [JsonProperty("strMeasure4")]
        public string Measure4 { get; set; }

        /// <summary>
        /// Measure5 mapped to <see cref="Ingredient5"/>
        /// </summary>
        [JsonProperty("strMeasure5")]
        public string Measure5 { get; set; }

        /// <summary>
        /// Measure6 mapped to <see cref="Ingredient6"/>
        /// </summary>
        [JsonProperty("strMeasure6")]
        public string Measure6 { get; set; }

        /// <summary>
        /// Measure7 mapped to <see cref="Ingredient7"/>
        /// </summary>
        [JsonProperty("strMeasure7")]
        public string Measure7 { get; set; }

        /// <summary>
        /// Measure8 mapped to <see cref="Ingredient8"/>
        /// </summary>
        [JsonProperty("strMeasure8")]
        public string Measure8 { get; set; }

        /// <summary>
        /// Measure9 mapped to <see cref="Ingredient9"/>
        /// </summary>
        [JsonProperty("strMeasure9")]
        public string Measure9 { get; set; }

        /// <summary>
        /// Measure10 mapped to <see cref="Ingredient10"/>
        /// </summary>
        [JsonProperty("strMeasure10")]
        public string Measure10 { get; set; }

        /// <summary>
        /// Measure11 mapped to <see cref="Ingredient11"/>
        /// </summary>
        [JsonProperty("strMeasure11")]
        public string Measure11 { get; set; }

        /// <summary>
        /// Measure12 mapped to <see cref="Ingredient12"/>
        /// </summary>
        [JsonProperty("strMeasure12")]
        public string Measure12 { get; set; }

        /// <summary>
        /// Measure13 mapped to <see cref="Ingredient13"/>
        /// </summary>
        [JsonProperty("strMeasure13")]
        public string Measure13 { get; set; }

        /// <summary>
        /// Measure14 mapped to <see cref="Ingredient14"/>
        /// </summary>
        [JsonProperty("strMeasure14")]
        public string Measure14 { get; set; }

        /// <summary>
        /// Measure15 mapped to <see cref="Ingredient15"/>
        /// </summary>
        [JsonProperty("strMeasure15")]
        public string Measure15 { get; set; }

        /// <summary>
        /// Drink image source url
        /// </summary>
        [JsonProperty("strImageSource")]
        public string ImageSource { get; set; }

        /// <summary>
        /// Drink image attribution
        /// </summary>
        [JsonProperty("strImageAttribution")]
        public string ImageAttribution { get; set; }

        /// <summary>
        /// Is confirmed to be creative commons for <see cref="ImageSource"/>
        /// </summary>
        [JsonProperty("strCreativeCommonsConfirmed")]
        public string CreativeCommonsConfirmed { get; set; }

        /// <summary>
        /// Date last modified
        /// </summary>
        [JsonProperty("dateModified")]
        public DateTime DateModified { get; set; }
    }

    /// <summary>
    /// Class representing a List of <see cref="Drink"/>
    /// </summary>
    public class Drinks
    {
        /// <summary>
        /// List of <see cref="Drink"/>
        /// </summary>
        [JsonProperty("drinks")]
        public List<Drink> DrinkList { get; set; }
    }

    /// <summary>
    /// Class representing a Drink Summary
    /// </summary>
    public class DrinkSummary
    {
        /// <summary>
        /// Drink id
        /// </summary>
        [JsonProperty("idDrink")]
        public string DrinkId { get; set; }

        /// <summary>
        /// Drink name
        /// </summary>
        [JsonProperty("strDrink")]
        public string DrinkName { get; set; }

        /// <summary>
        /// Drink image thumbnail url
        /// </summary>
        [JsonProperty("strDrinkThumb")]
        public string DrinkThumb { get; set; }
    }

    /// <summary>
    /// Class representing a List of <see cref="DrinkSummary"/>
    /// </summary>
    public class DrinkSummaries
    {
        /// <summary>
        /// List of <see cref="DrinkSummary"/>
        /// </summary>
        [JsonProperty("drinks")]
        public List<DrinkSummary> DrinkSummariesList { get; set; }
    }
}
