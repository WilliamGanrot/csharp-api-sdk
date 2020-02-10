using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public class CurrencyConnector : EntityConnector<Currency, EntityCollection<CurrencySubset>, Sort.By.Currency?>
	{
	    /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter("filter")]
		public Filter.Currency FilterBy { get; set; }


		/// <remarks/>
		public CurrencyConnector()
		{
			Resource = "currencies";
		}

		/// <summary>
		/// Find a currency based on currencynumber
		/// </summary>
		/// <param name="currencyNumber">The currencynumber to find</param>
		/// <returns>The found currency</returns>
		public Currency Get(string currencyNumber)
		{
			return BaseGet(currencyNumber);
		}

		/// <summary>
		/// Updates a currency
		/// </summary>
		/// <param name="currency">The currency to update</param>
		/// <returns>The updated currency</returns>
		public Currency Update(Currency currency)
		{
			return BaseUpdate(currency, currency.CurrencyNumber);
		}

		/// <summary>
		/// Create a new currency
		/// </summary>
		/// <param name="currency">The currency to create</param>
		/// <returns>The created currency</returns>
		public Currency Create(Currency currency)
		{
			return BaseCreate(currency);
		}

		/// <summary>
		/// Deletes a currency
		/// </summary>
		/// <param name="currencyNumber">The currencynumber to delete</param>
		public void Delete(string currencyNumber)
		{
			BaseDelete(currencyNumber);
		}

		/// <summary>
		/// Gets a list of currencys
		/// </summary>
		/// <returns>A list of currencys</returns>
		public EntityCollection<CurrencySubset> Find()
		{
			return BaseFind();
		}
	}
}
