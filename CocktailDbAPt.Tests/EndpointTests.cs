using CocktailDbAPI;
using CocktailDbAPI.Models.Drink;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CocktailDbAPI.Tests
{
    [TestClass]
    public class EndpointTests
    {

        private CocktailAPI testApi;

        [TestInitialize]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public void InitializeTestEndpoints()
        {
            testApi = new CocktailAPI();
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinksByName()
        {
            var data = await testApi.GetDrinksByNameAsync("margarita");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinksByFirstLetter()
        {
            var data = await testApi.GetDrinksByFirstLetterAsync('a');
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetIngredientByName()
        {
            var data = await testApi.GetIngredientsByNameAsync("vodka");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinkById()
        {
            var data = await testApi.GetDrinkByIdAsync("11007");
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.DrinkId);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetIngredientById()
        {
            var data = await testApi.GetIngredientByIdAsync("552");
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.IngredientId);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetRandomCocktail()
        {
            var data = await testApi.GetRandomDrinkAsync();
            Assert.IsNotNull(data);
            Assert.IsNotNull(data.DrinkId);
        }


        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinksByIngredient()
        {
            var data = await testApi.GetDrinkSummariesByIngredientAsync("Gin");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinksByAlcoholic()
        {
            var data = await testApi.GetDrinkSummariesByAlcoholicAsync("Alcoholic");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinksByCategory()
        {
            var data = await testApi.GetDrinkSummariesByCategoryAsync("Ordinary_Drink");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinksByGlass()
        {
            var data = await testApi.GetDrinkSummariesByGlassAsync("Cocktail_glass");
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetCategoryFilters()
        {
            var data = await testApi.GetCategoryFiltersAsync();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetGlassesFilters()
        {
            var data = await testApi.GetGlassesFiltersAsync();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetIngredientsFilters()
        {
            var data = await testApi.GetIngredientsFiltersAsync();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetAlcoholicFilters()
        {
            var data = await testApi.GetAlcoholicFiltersAsync();
            Assert.IsNotNull(data);
            Assert.IsTrue(data.Count > 0);
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetTenRandomCocktailsNotSupportedException()
        {
            List<Drink> data;
            await Assert.ThrowsExceptionAsync<NotSupportedException>(async () => data = await testApi.GetTenRandomDrinksAsync());
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetPopularCocktailsNotSupportedException()
        {
            List<Drink> data;
            await Assert.ThrowsExceptionAsync<NotSupportedException>(async () => data = await testApi.GetPopularDrinksAsync());
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetLatestCocktailsNotSupportedException()
        {
            List<Drink> data;
            await Assert.ThrowsExceptionAsync<NotSupportedException>(async () => data = await testApi.GetLatestDrinksAsync());
        }

        [TestMethod]
        [TestCategory("CocktailAPI"), TestCategory("Async")]
        public async Task GetDrinksByFirstLetterArgumentException()
        {
            List<Drink> data;
            await Assert.ThrowsExceptionAsync<ArgumentException>(async () => data = await testApi.GetDrinksByFirstLetterAsync('1'));
        }
    }
}
