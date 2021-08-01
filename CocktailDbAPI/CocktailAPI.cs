using CocktailDbAPI.Http;
using CocktailDbAPI.Models.Drink;
using CocktailDbAPI.Models.Ingredient;
using CocktailDbAPI.Models.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CocktailDbAPI
{
    public class CocktailAPI
    {
        private static readonly string BaseUrl = "https://www.thecocktaildb.com/api/json/v1/";
        private static string _apiKey;
        private readonly HttpRequester _httpRequester;

        /// <summary>
        /// Constructor of the CocktailAPI, with the test api key by default.
        /// </summary>
        /// <param name="apiKey">The api key. "1" by default.</param>
        /// <returns>
        /// A new CocktailAPI instance.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when apiKey is null or empty.</exception>
        public CocktailAPI(string apiKey = "1")
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException(nameof(apiKey));
            }

            _httpRequester = new HttpRequester(BaseUrl);
            _apiKey = apiKey;
        }

        /// <summary>
        /// Updates the api key.
        /// </summary>
        /// <param name="apiKey">The api key.</param>
        /// <exception cref="ArgumentException">Thrown when apiKey is null or empty.</exception>
        public void UpdateApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException(nameof(apiKey));
            }

            _apiKey = apiKey;
        }

        #region Drinks

        /// <summary>
        /// Get a drink asynchronously.
        /// </summary>
        /// <param name="id">The drink id.</param>
        /// <returns>A <see cref="Drink" /> which contains the details of a specific drink.</returns>
        public async Task<Drink> GetDrinkByIdAsync(string id)
        {
            var drinkByNameUrl = string.Concat(_apiKey + "/lookup.php?i=" + id);
            Drinks drinkList = await _httpRequester.GetAsync<Drinks>(drinkByNameUrl).ConfigureAwait(false);

            return drinkList?.DrinkList?[0];
        }

        /// <summary>
        /// Get a list of latest drinks asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="Drink" />s.</returns>
        /// <exception cref="NotSupportedException">Thrown when the test api key is used.</exception>
        public async Task<List<Drink>> GetLatestDrinksAsync()
        {
            if (_apiKey == "1")
            {
                throw new NotSupportedException("Operation is not valid for using the test API key");
            }

            Drinks drinks = await _httpRequester.GetAsync<Drinks>(_apiKey + "/latest.php").ConfigureAwait(false);

            return drinks?.DrinkList;
        }

        /// <summary>
        /// Get a list of popular drinks asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="Drink" />s.</returns>
        /// <exception cref="NotSupportedException">Thrown when the test api key is used.</exception>
        public async Task<List<Drink>> GetPopularDrinksAsync()
        {
            if (_apiKey == "1")
            {
                throw new NotSupportedException("Operation is not valid for using the test API key");
            }

            Drinks drinks = await _httpRequester.GetAsync<Drinks>(_apiKey + "/popular.php").ConfigureAwait(false);

            return drinks?.DrinkList;
        }

        /// <summary>
        /// Get a random drink asynchronously.
        /// </summary>
        /// <returns>A <see cref="Drink" /> which contains the details of a specific drink.</returns>
        public async Task<Drink> GetRandomDrinkAsync()
        {
            Drinks drinkList = await _httpRequester.GetAsync<Drinks>(_apiKey + "/random.php").ConfigureAwait(false);

            return drinkList?.DrinkList?[0];
        }

        /// <summary>
        /// Get a list of ten random drinks asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="Drink" />s.</returns>
        /// <exception cref="NotSupportedException">Thrown when the test api key is used.</exception>
        public async Task<List<Drink>> GetTenRandomDrinksAsync()
        {
            if (_apiKey == "1")
            {
                throw new NotSupportedException("Operation is not valid for using the test API key");
            }

            Drinks drinks = await _httpRequester.GetAsync<Drinks>(_apiKey + "/randomselection.php").ConfigureAwait(false);

            return drinks?.DrinkList;
        }

        /// <summary>
        /// Get the list of drinks asynchronously.
        /// </summary>
        /// <param name="name">Search term for the name of the drink.</param>
        /// <returns>A list of <see cref="Drink" />s which contains drinks based on the search.</returns>
        public async Task<List<Drink>> GetDrinksByNameAsync(string name)
        {
            var drinksByNameUrl = string.Concat(_apiKey + "/search.php?s=" + name);
            Drinks drinks = await _httpRequester.GetAsync<Drinks>(drinksByNameUrl).ConfigureAwait(false);

            return drinks?.DrinkList;
        }

        /// <summary>
        /// Get the list of drinks asynchronously.
        /// </summary>
        /// <param name="firstLetter">First letter of the name of the drink to search.</param>
        /// <returns>A list of <see cref="Drink" />s which contains drinks based on the search.</returns>
        /// <exception cref="ArgumentException">Thrown when firstLetter is not a letter a-zA-Z</exception>
        public async Task<List<Drink>> GetDrinksByFirstLetterAsync(char firstLetter)
        {
            if (!char.IsLetter(firstLetter))
            {
                throw new ArgumentException(nameof(firstLetter));
            }

            var drinksByFirstLetterUrl = string.Concat(_apiKey + "/search.php?f=" + firstLetter);
            Drinks drinks = await _httpRequester.GetAsync<Drinks>(drinksByFirstLetterUrl).ConfigureAwait(false);

            return drinks?.DrinkList;
        }

        #endregion

        #region DrinkSummaries

        /// <summary>
        /// Get a list of drink summaries asynchronously.
        /// </summary>
        /// <param name="name">Search term for the name of the alcoholic filter.</param>
        /// <returns>A list of <see cref="DrinkSummary" />.</returns>
        public async Task<List<DrinkSummary>> GetDrinkSummariesByAlcoholicAsync(string name)
        {
            var drinkSummariesByAlcoholic = string.Concat(_apiKey + "/filter.php?a=" + name);
            DrinkSummaries drinkSummaries = await _httpRequester.GetAsync<DrinkSummaries>(drinkSummariesByAlcoholic).ConfigureAwait(false);

            return drinkSummaries?.DrinkSummariesList;
        }

        /// <summary>
        /// Get a list of drink summaries asynchronously.
        /// </summary>
        /// <param name="name">Search term for the name of the category filter.</param>
        /// <returns>A list of <see cref="DrinkSummary" />.</returns>
        public async Task<List<DrinkSummary>> GetDrinkSummariesByCategoryAsync(string name)
        {
            var drinkSummariesByCategoryUrl = string.Concat(_apiKey + "/filter.php?c=" + name);
            DrinkSummaries drinkSummaries = await _httpRequester.GetAsync<DrinkSummaries>(drinkSummariesByCategoryUrl).ConfigureAwait(false);

            return drinkSummaries?.DrinkSummariesList;
        }

        /// <summary>
        /// Get a list of drink summaries asynchronously.
        /// </summary>
        /// <param name="name">Search term for the name of the glass filter.</param>
        /// <returns>A list of <see cref="DrinkSummary" />.</returns>
        public async Task<List<DrinkSummary>> GetDrinkSummariesByGlassAsync(string name)
        {
            var drinkSummariesByGlassUrl = string.Concat(_apiKey + "/filter.php?g=" + name);
            DrinkSummaries drinkSummaries = await _httpRequester.GetAsync<DrinkSummaries>(drinkSummariesByGlassUrl).ConfigureAwait(false);

            return drinkSummaries?.DrinkSummariesList;
        }

        /// <summary>
        /// Get a list of drink summaries asynchronously.
        /// </summary>
        /// <param name="name">Search term for the name of the ingredient filter.</param>
        /// <returns>A list of <see cref="DrinkSummary" />.</returns>
        /// <exception cref="NotSupportedException">Thrown when the test api key is used and using multiple ingredients.</exception>
        public async Task<List<DrinkSummary>> GetDrinkSummariesByIngredientAsync(string name)
        {
            if (name.Contains(",") && _apiKey == "1")
            {
                throw new NotSupportedException("Operation is not valid for using the test API key");
            }

            var drinkSummariesByIngredient = string.Concat(_apiKey + "/filter.php?i=" + name);
            DrinkSummaries drinkSummaries = await _httpRequester.GetAsync<DrinkSummaries>(drinkSummariesByIngredient).ConfigureAwait(false);

            return drinkSummaries?.DrinkSummariesList;
        }

        #endregion

        #region Ingredients

        /// <summary>
        /// Get an ingredient asynchronously.
        /// </summary>
        /// <param name="id">The ingredient id.</param>
        /// <returns>An <see cref="Ingredient" /> which contains the details of a specific ingredient.</returns>
        public async Task<Ingredient> GetIngredientByIdAsync(string id)
        {
            var ingredientByNameUrl = string.Concat(_apiKey + "/lookup.php?iid=" + id);
            Ingredients ingredientList = await _httpRequester.GetAsync<Ingredients>(ingredientByNameUrl).ConfigureAwait(false);

            return ingredientList?.IngredientList?[0];
        }

        /// <summary>
        /// Get the list of ingredients asynchronously.
        /// </summary>
        /// <param name="name">Search term for the name of the ingredient.</param>
        /// <returns>A list of <see cref="Ingredient" /> which contains ingredients based on the search.</returns>
        public async Task<List<Ingredient>> GetIngredientsByNameAsync(string name)
        {
            var ingredientByNameUrl = string.Concat(_apiKey, "/search.php?i=" + name);
            Ingredients ingredients = await _httpRequester.GetAsync<Ingredients>(ingredientByNameUrl).ConfigureAwait(false);

            return ingredients?.IngredientList;
        }

        #endregion

        #region Filters

        /// <summary>
        /// Get a list of alcoholic filters asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="AlcoholicFilter" />.</returns>
        public async Task<List<AlcoholicFilter>> GetAlcoholicFiltersAsync()
        {
            AlcoholicFilters alcholicFilters = await _httpRequester.GetAsync<AlcoholicFilters>(_apiKey + "/list.php?a=list").ConfigureAwait(false);

            return alcholicFilters?.AlcoholicFilterList;
        }

        /// <summary>
        /// Get a list of category filters asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="CategoryFilter" />.</returns>
        public async Task<List<CategoryFilter>> GetCategoryFiltersAsync()
        {
            CategoryFilters categoryFilters = await _httpRequester.GetAsync<CategoryFilters>(_apiKey + "/list.php?c=list").ConfigureAwait(false);

            return categoryFilters?.CategoryFilterList;
        }

        /// <summary>
        /// Get a list of glass filters asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="GlassFilter" />.</returns>
        public async Task<List<GlassFilter>> GetGlassesFiltersAsync()
        {
            GlassFilters glassFilters = await _httpRequester.GetAsync<GlassFilters>(_apiKey + "/list.php?g=list").ConfigureAwait(false);

            return glassFilters?.GlassFilterList;
        }

        /// <summary>
        /// Get a list of ingredient filters asynchronously.
        /// </summary>
        /// <returns>A list of <see cref="IngredientFilter" />.</returns>
        public async Task<List<IngredientFilter>> GetIngredientsFiltersAsync()
        {
            IngredientFilters ingredientFilters = await _httpRequester.GetAsync<IngredientFilters>(_apiKey + "/list.php?i=list").ConfigureAwait(false);

            return ingredientFilters?.IngredientFilterList;
        }

        #endregion

    }
}
