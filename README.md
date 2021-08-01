# TheCocktailDbAPI
C# wrapper for [the Cocktail DB API](https://www.thecocktaildb.com/api.php).

## Installation
To install CocktailDbAPI using [NuGet](https://www.nuget.org/), run the following command in the [Package Manager Console](http://docs.nuget.org/consume/package-manager-console):
```powershell
PM> Install-Package CocktailDbAPI
```
or
1. Clone the repo (https://github.com/cooperbrenneman/cocktaildbapi.git).
2. Build the CocktailDbAPI project and add the library to your application.

## Usage
### API Creation and Key
To use this API, you will need an API Key. You can find the information around getting an API Key [here](https://www.thecocktaildb.com/api.php). The default API Key is the Test API Key ("1"), which can be used during development of your app or for educational use.

To create a new instance, just pass your API Key into the CocktailAPI constructor:
```csharp
var api = new CocktailAPI("YOUR_API_KEY_HERE");
```

If you want to use the test API Key, you can leave the constructor empty:
```csharp
var api = new CocktailAPI();
```

Then you are able to call the various methods to return CocktailDB data. For example, to get a list of drinks by name:
```csharp
try
{
    var drinks = await api.GetDrinksByNameAsync("margarita");
    foreach(Drink drink in drinks)
    {
        Console.WriteLine($"Drink Name: {drink.DrinkName}");
    }
}
catch (CocktailAPIException ex)
{
    // Handle the exception.
}
```

If for whatever reason you need to update the API Key after creating an instance of a CocktailAPI, you can call the `UpdateApiKey` method and pass in the new `apiKey` as the argument.

### Methods
#### Drinks
| Method Name                   	| Parameter          	| Description                               	| Return Type   	| Allows Test API Key 	|
|-------------------------------	|--------------------	|-------------------------------------------	|---------------	|---------------------	|
| `GetDrinkByIdAsync`           	| `string` id        	| Lookup full cocktail details by id        	| `Drink`       	| `true`              	|
| `GetLatestDrinksAsync`        	|                    	| List most latest cocktails                	| `List<Drink>` 	| `false`             	|
| `GetPopularDrinksAsync`       	|                    	| List Popular cocktails                    	| `List<Drink>` 	| `false`             	|
| `GetRandomDrinkAsync`         	|                    	| Lookup a random cocktail                  	| `Drink`       	| `true`              	|
| `GetTenRandomDrinksAsync`     	|                    	| Lookup a selection of 10 random cocktails 	| `List<Drink>` 	| `true`              	|
| `GetDrinksByNameAsync`        	| `string` name      	| Search cocktail by name                   	| `List<Drink>` 	| `true`              	|
| `GetDrinksByFirstLetterAsync` 	| `char` firstLetter 	| List all cocktails by first letter        	| `List<Drink>` 	| `true`              	|

<details>

<summary><code>GetDrinkByIdAsync(string id)</code></summary>

This method takes a string as the id of the drink and returns a `Drink` details. 

```csharp
var drink = await api.GetDrinkByIdAsync("11007");
var drinkName = drink.DrinkName;
var glass = drink.Glass;
var alcoholic = drink.Alcoholic;
```

</details>

<details>

<summary><code>GetLatestDrinksAsync()</code></summary>

This method lists the most latest cocktails and returns a `List<Drinks>`. Note that the Test API key will not work for this endpoint and will return a `NotSupportedException`.

```csharp
var drinks = await api.GetLatestDrinksAsync();
foreach(Drink drink in drinks)
{
    Console.WriteLine($"Drink Name: {drink.DrinkName}");
}
```

</details>

<details>

<summary><code>GetPopularDrinksAsync()</code></summary>

This method lists the popular cocktails and returns a `List<Drinks>`. Note that the Test API key will not work for this endpoint and will return a `NotSupportedException`.

```csharp
var drinks = await api.GetPopularDrinksAsync();
foreach(Drink drink in drinks)
{
    Console.WriteLine($"Drink Name: {drink.DrinkName}");
}
```

</details>

<details>

<summary><code>GetRandomDrinkAsync()</code></summary>

This method returns a random drink `Drink` details. 

```csharp
var drink = await api.GetRandomDrinkAsync();
var drinkName = drink.DrinkName;
var glass = drink.Glass;
var alcoholic = drink.Alcoholic;
```

</details>

<details>

<summary><code>GetTenRandomDrinksAsync()</code></summary>

This method lists ten random drinks and returns a `List<Drinks>`.

```csharp
var drinks = await api.GetTenRandomDrinksAsync();
foreach(Drink drink in drinks)
{
    Console.WriteLine($"Drink Name: {drink.DrinkName}");
}
```

</details>

<details>

<summary><code>GetDrinksByNameAsync(string name)</code></summary>

This method takes a string as the name of the drink and returns a `List<Drink>` details. 

```csharp
var drinks = await api.GetDrinksByNameAsync("margarita");
foreach(Drink drink in drinks)
{
    Console.WriteLine($"Drink Name: {drink.DrinkName}");
}
```

</details>

<details>

<summary><code>GetDrinksByFirstLetterAsync(char firstLetter)</code></summary>

This method takes a char as the first letter of the drink name and returns a `List<Drink>` details. 

```csharp
var drinks = await api.GetDrinksByFirstLetterAsync('a');
foreach(Drink drink in drinks)
{
    Console.WriteLine($"Drink Name: {drink.DrinkName}");
}
```

</details>

<br/>

#### Drink Summaries
| Method Name                          	| Parameter     	| Description          	| Return Type          	| Allows Test API Key 	|
|--------------------------------------	|---------------	|----------------------	|----------------------	|---------------------	|
| `GetDrinkSummariesByAlcoholicAsync`  	| `string` name 	| Filter by alcoholic  	| `List<DrinkSummary>` 	| `true`              	|
| `GetDrinkSummariesByCategoryAsync`   	| `string` name 	| Filter by Category   	| `List<DrinkSummary>` 	| `true`              	|
| `GetDrinkSummariesByGlassAsync`      	| `string` name 	| Filter by Glass      	| `List<DrinkSummary>` 	| `true`              	|
| `GetDrinkSummariesByIngredientAsync` 	| `string` name 	| Search by ingredient 	| `List<DrinkSummary>` 	| `true`*             	|

*This allows the Test API key for single ingredients. The Test API Key will not work for multiple ingredients (separated by a `,` in the `name` argument).
<details>

<summary><code>GetDrinkSummariesByAlcoholicAsync(string name)</code></summary>

This method takes a string as the name of the alcoholic name and returns a `List<DrinkSummary>`. 

```csharp
var drinksAlcoholic = await api.GetDrinkSummariesByAlcoholicAsync("Alcoholic");
foreach(DrinkSummary drinkSummary in drinksAlcoholic)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}

var drinksNonAlcoholic = await api.GetDrinkSummariesByAlcoholicAsync("Non_Alcoholic");
foreach(DrinkSummary drinkSummary in drinksNonAlcoholic)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
```

</details>

<details>

<summary><code>GetDrinkSummariesByCategoryAsync(string name)</code></summary>

This method takes a string as the name of the category name and returns a `List<DrinkSummary>`. 

```csharp
var drinksOrdinary = await api.GetDrinkSummariesByCategoryAsync("Ordinary_Drink");
foreach(DrinkSummary drinkSummary in drinksOrdinary)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
var drinksCocktail = await api.GetDrinkSummariesByCategoryAsync("Cocktail");
foreach(DrinkSummary drinkSummary in drinksCocktail)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
```

</details>

<details>

<summary><code>GetDrinkSummariesByGlassAsync(string name)</code></summary>

This method takes a string as the name of the glass name and returns a `List<DrinkSummary>`. 

```csharp
var drinksCocktailGlass = await api.GetDrinkSummariesByGlassAsync("Cocktail_glass");
foreach(DrinkSummary drinkSummary in drinksCocktailGlass)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
var drinksChampageFlute = await api.GetDrinkSummariesByGlassAsync("Champagne_flute");
foreach(DrinkSummary drinkSummary in drinksChampageFlute)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
```

</details>

<details>

<summary><code>GetDrinkSummariesByIngredientAsync(string name)</code></summary>

This method takes a string as the name of the ingredient name and returns a `List<DrinkSummary>`. 

```csharp
var drinksGin = await api.GetDrinkSummariesByIngredientAsync("Gin");
foreach(DrinkSummary drinkSummary in drinksGin)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
var drinksVodka = await api.GetDrinkSummariesByIngredientAsync("Vodka");
foreach(DrinkSummary drinkSummary in drinksVodka)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
```

This method can also take a multi-ingredient string as an argument as well. However, the Test API Key cannot be used. If the Test API Key is used, it will return a `NotSupportedException`.

```csharp
var drinksMultiFilter = await api.GetDrinkSummariesByIngredientAsync("Dry_Vermouth,Gin,Anis");
foreach(DrinkSummary drinkSummary in drinksMultiFilter)
{
    Console.WriteLine($"Drink Name: {drinkSummary.DrinkName}");
}
```

</details>

<br/>  


#### Ingredients
| Method Name                 	| Parameter     	| Description               	| Return Type        	| Allows Test API Key 	|
|-----------------------------	|---------------	|---------------------------	|--------------------	|---------------------	|
| `GetIngredientByIdAsync`    	| `string` id   	| Lookup ingredient by ID   	| `Ingredient`       	| `true`              	|
| `GetIngredientsByNameAsync` 	| `string` name 	| Search ingredient by name 	| `List<Ingredient>` 	| `true`              	|

<details>

<summary><code>GetIngredientByIdAsync(string id)</code></summary>

This method takes a string as the name of the ingredient and returns an `Ingredient`. 

```csharp
var ingredient = await api.GetIngredientByIdAsync("552");
var ingredientName = ingredient.IngredientName;
var ingredientDescription = ingredient.Description;
var ingredientType = ingredient.Type;
```

</details>

<details>

<summary><code>GetIngredientsByNameAsync(string name)</code></summary>

This method takes a string as the name of the ingredients and returns a `List<Ingredient>`. 

```csharp
var ingredientsVodka = await api.GetIngredientsByNameAsync("vodka");
foreach(Ingredient ingredient in ingredientsVodka)
{
    Console.WriteLine($"Ingredient Name: {ingredient.IngredientName}");
}
```

</details>

<br/>


#### Filters
| Method Name                  	| Parameter 	| Description                  	| Return Type              	| Allows Test API Key 	|
|------------------------------	|-----------	|------------------------------	|--------------------------	|---------------------	|
| `GetAlcoholicFiltersAsync`   	|           	| List the alcoholic filters   	| `List<AlcoholicFilter>`  	| `true`              	|
| `GetCategoryFiltersAsync`    	|           	| List the categories filters  	| `List<CategoryFilter>`   	| `true`              	|
| `GetGlassesFiltersAsync`     	|           	| List the glasses filters     	| `List<GlassFilter>`      	| `true`              	|
| `GetIngredientsFiltersAsync` 	|           	| List the ingredients filters 	| `List<IngredientFilter>` 	| `true`              	|

<details>

<summary><code>GetAlcoholicFiltersAsync()</code></summary>

This method lists all of the alcoholic filters and returns a `List<AlcoholicFilter>`.

```csharp
var alcoholicFilters = await api.GetAlcoholicFiltersAsync();
foreach(AlcoholicFilter alcoholicFilter in alcoholicFilters)
{
    Console.WriteLine($"Alcoholic Filter: {alcoholicFilter.Alcoholic}");
}
```

</details>

<details>

<summary><code>GetCategoryFiltersAsync()</code></summary>

This method lists all of the category filters and returns a `List<CategoryFilter>`.

```csharp
var categoryFilters = await api.GetCategoryFiltersAsync();
foreach(CategoryFilter categoryFilter in categoryFilters)
{
    Console.WriteLine($"Category Filter: {categoryFilter.Category}");
}
```

</details>

<details>

<summary><code>GetGlassesFiltersAsync()</code></summary>

This method lists all of the glass filters and returns a `List<GlassFilter>`.

```csharp
var glassFilters = await api.GetGlassesFiltersAsync();
foreach(GlassFilter glassFilter in glassFilters)
{
    Console.WriteLine($"Glass Filter: {glassFilter.Glass}");
}
```

</details>

<details>

<summary><code>GetIngredientsFiltersAsync()</code></summary>

This method lists all of the ingredients filters and returns a `List<IngredientFilter>`.

```csharp
var ingredientsFilters = await api.GetIngredientsFiltersAsync();
foreach(IngredientFilter ingredientFilter in ingredientsFilters)
{
    Console.WriteLine($"Ingredient Filter: {ingredientFilter.Ingredient}");
}
```

</details>

<br/>

### Exceptions
The `CocktailAPIException` provides an exception for any HTTP error code returned by the CocktailAPI. This exception will be thrown if the HTTP response message does not contain a success status code (through `IsSucessStatusCode` of the `HttpResponseMessage`). The message is parsed from the response and the HttpStatusCode is added. This allows you to handle any errors as you see fit.

## Contribution
If you are interested in contributing to this library, please submit a pull request!

## Dependencies
This libary uses [Json.Net](https://www.newtonsoft.com/json) version 13.*.

## License
This library is under the [MIT License](LICENSE).