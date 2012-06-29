﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Database.Sample
{
	/// <summary>
	/// Defines a repository interface.
	/// </summary>
	/// <remarks>Generated by InsightRepository.snippet. Extend this with methods in a separate partial interface.</remarks>
    partial interface IBeerRepository
	{
        #region Single Sync CRUD Methods
		/// <summary>
		/// Selects a single Receipt from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		/// <returns>The selected Receipt.</returns>
		Receipt SelectReceipt(int id);

		/// <summary>
		/// Inserts a single Receipt into the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to insert.</param>
		void InsertReceipt(Receipt receipt);

		/// <summary>
		/// Updates a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to update.</param>
		void UpdateReceipt(Receipt receipt);

		/// <summary>
		/// Upserts a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to upsert.</param>
		void UpsertReceipt(Receipt receipt);

		/// <summary>
		/// Deletes a Receipt in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		void DeleteReceipt(int id);
        #endregion

        #region Multiple Sync CRUD Methods
		/// <summary>
		/// Selects multiple Receipts from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		/// <returns>The selected Receipt.</returns>
		IList<Receipt> SelectReceipts(IEnumerable<int> id);

		/// <summary>
		/// Inserts multiple Receipts into the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to insert.</param>
		void InsertReceipts(IEnumerable<Receipt> receipt);

		/// <summary>
		/// Updates multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to update.</param>
		void UpdateReceipts(IEnumerable<Receipt> receipt);

		/// <summary>
		/// Upserts multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to upsert.</param>
		void UpsertReceipts(IEnumerable<Receipt> receipt);

		/// <summary>
		/// Deletes multiple Receipts in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		void DeleteReceipts(IEnumerable<int> id);
        #endregion

        #region Find Sync Methods
		/// <summary>
		/// Finds Receipts matching a filter object.
		/// </summary>
		/// <param name="filter">The filter to use.</param>
		/// <returns>The selected Receipts.</returns>
        IList<Receipt> FindReceipts(object filter);
        #endregion

        #region Single Async CRUD Methods
		/// <summary>
		/// Asynchronously selects a single Receipt from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		/// <returns>A task returning the selected Receipt.</returns>
		Task<Receipt> SelectReceiptAsync(int id);

		/// <summary>
		/// Asynchronously Inserts a single Receipt into the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to insert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task InsertReceiptAsync(Receipt receipt);

		/// <summary>
		/// Asynchronously updates a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to update.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpdateReceiptAsync(Receipt receipt);

		/// <summary>
		/// Asynchronously updates a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to upsert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpsertReceiptAsync(Receipt receipt);

		/// <summary>
		/// Asynchronously deletes a Receipt in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task DeleteReceiptAsync(int id);
        #endregion

        #region Multiple Async CRUD Methods
		/// <summary>
		/// Asynchronously selects multiple Receipts from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		/// <returns>A task returning the selected Receipts.</returns>
		Task<IList<Receipt>> SelectReceiptsAsync(IEnumerable<int> id);

		/// <summary>
		/// Asynchronously Inserts multiple Receipts into the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to insert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task InsertReceiptsAsync(IEnumerable<Receipt> receipt);

		/// <summary>
		/// Asynchronously updates multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to update.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpdateReceiptsAsync(IEnumerable<Receipt> receipt);

		/// <summary>
		/// Asynchronously updates multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to upsert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task UpsertReceiptsAsync(IEnumerable<Receipt> receipt);

		/// <summary>
		/// Asynchronously deletes multiple Receipts in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		Task DeleteReceiptsAsync(IEnumerable<int> id);
        #endregion

        #region Find Async Methods
		/// <summary>
		/// Asynchronously finds Receipts matching a filter object.
		/// </summary>
		/// <param name="filter">The filter to use.</param>
		/// <returns>The selected Receipt.</returns>
        Task<IList<Receipt>> FindReceiptsAsync(object filter);
        #endregion
	}

	/// <summary>
	/// Implements a repository interface.
	/// </summary>
	/// <remarks>Generated by InsightRepository.snippet. Extend this with methods in a separate partial interface.</remarks>
	partial class BeerRepository : IBeerRepository
	{
        #region Single Sync CRUD Methods
		/// <summary>
		/// Selects a single Receipt from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		/// <returns>The selected Receipt.</returns>
		public Receipt SelectReceipt(int id)
		{
			return _connectionFactory().Query<Receipt>("SelectReceipt", new { id = id }).FirstOrDefault();
		}

		/// <summary>
		/// Inserts a single Receipt into the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to insert.</param>
		public void InsertReceipt(Receipt receipt)
		{
			_connectionFactory().Insert("InsertReceipt", receipt);
		}

		/// <summary>
		/// Updates a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to update.</param>
		public void UpdateReceipt(Receipt receipt)
		{
			_connectionFactory().Execute("UpdateReceipt", receipt);
		}

		/// <summary>
		/// Upserts a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to update.</param>
		public void UpsertReceipt(Receipt receipt)
		{
			_connectionFactory().Insert("UpsertReceipt", receipt);
		}

		/// <summary>
		/// Deletes a Receipt in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		public void DeleteReceipt(int id)
		{
			_connectionFactory().Execute("DeleteReceipt", new { id = id });
		}
        #endregion

        #region Multiple Sync CRUD Methods
		/// <summary>
		/// Selects multiple Receipts from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		/// <returns>The selected Receipt.</returns>
		public IList<Receipt> SelectReceipts(IEnumerable<int> id)
        {
            return _connectionFactory().Query<Receipt>("SelectReceipts", id);
        }

		/// <summary>
		/// Inserts multiple Receipts into the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to insert.</param>
		public void InsertReceipts(IEnumerable<Receipt> receipt)
		{
			_connectionFactory().InsertList("InsertReceipts", receipt);
		}

		/// <summary>
		/// Updates multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to update.</param>
		public void UpdateReceipts(IEnumerable<Receipt> receipt)
		{
			_connectionFactory().Execute("UpdateReceipts", receipt);
		}

		/// <summary>
		/// Upserts multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to upsert.</param>
		public void UpsertReceipts(IEnumerable<Receipt> receipt)
		{
			_connectionFactory().InsertList("UpsertReceipts", receipt);
		}

		/// <summary>
		/// Deletes multiple Receipts in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		public void DeleteReceipts(IEnumerable<int> id)
		{
			_connectionFactory().Execute("DeleteReceipts", new { id = id });
		}
        #endregion

        #region Find Sync Methods
		/// <summary>
		/// Finds Receipts matching a filter object.
		/// </summary>
		/// <param name="filter">The filter to use.</param>
		/// <returns>The selected Receipts.</returns>
        public IList<Receipt> FindReceipts(object filter)
        {
            return _connectionFactory().Query<Receipt>("FindReceipts", filter);
        }
        #endregion

        #region Single Async CRUD Methods
		/// <summary>
		/// Asynchronously selects a single Receipt from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		/// <returns>A task returning the selected Receipt.</returns>
		public Task<Receipt> SelectReceiptAsync(int id)
		{
			return _connectionFactory().QueryAsync<Receipt>("SelectReceipt", new { id = id }).ContinueWith(t => t.Result.FirstOrDefault());
		}

		/// <summary>
		/// Asynchronously Inserts a single Receipt into the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to insert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task InsertReceiptAsync(Receipt receipt)
		{
			return _connectionFactory().InsertAsync("InsertReceipt", receipt);
		}

		/// <summary>
		/// Asynchronously updates a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to update.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task UpdateReceiptAsync(Receipt receipt)
		{
			return _connectionFactory().ExecuteAsync("UpdateReceipt", receipt);
		}

		/// <summary>
		/// Asynchronously updates a single Receipt in the repository.
		/// </summary>
		/// <param name="receipt">The Receipt to upsert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task UpsertReceiptAsync(Receipt receipt)
		{
			return _connectionFactory().InsertAsync("UpsertReceipt", receipt);
		}

		/// <summary>
		/// Asynchronously deletes a Receipt in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipt.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task DeleteReceiptAsync(int id)
		{
			return _connectionFactory().ExecuteAsync("DeleteReceipt", new { id = id });
		}
        #endregion

        #region Multiple Async CRUD Methods
		/// <summary>
		/// Asynchronously selects multiple Receipts from the repository by identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		/// <returns>A task returning the selected Receipts.</returns>
		public Task<IList<Receipt>> SelectReceiptsAsync(IEnumerable<int> id)
		{
			return _connectionFactory().QueryAsync<Receipt>("SelectReceipts", id);
		}

		/// <summary>
		/// Asynchronously Inserts multiple Receipts into the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to insert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task InsertReceiptsAsync(IEnumerable<Receipt> receipt)
		{
			return _connectionFactory().InsertListAsync("InsertReceipts", receipt);
		}

		/// <summary>
		/// Asynchronously updates multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to update.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task UpdateReceiptsAsync(IEnumerable<Receipt> receipt)
		{
			return _connectionFactory().ExecuteAsync("UpdateReceipts", receipt);
		}

		/// <summary>
		/// Asynchronously updates multiple Receipts in the repository.
		/// </summary>
		/// <param name="receipt">The Receipts to upsert.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task UpsertReceiptsAsync(IEnumerable<Receipt> receipt)
		{
			return _connectionFactory().InsertListAsync("UpsertReceipts", receipt);
		}

		/// <summary>
		/// Asynchronously deletes multiple Receipts in the repository matching the given identifier.
		/// </summary>
		/// <param name="id">The id of the Receipts.</param>
		/// <returns>A task representing the completion of the operation.</returns>
		public Task DeleteReceiptsAsync(IEnumerable<int> id)
 		{
			return _connectionFactory().ExecuteAsync("DeleteReceipts", id);
		}
        #endregion

        #region Find Async Methods
		/// <summary>
		/// Asynchronously finds Receipts matching a filter object.
		/// </summary>
		/// <param name="filter">The filter to use.</param>
		/// <returns>The selected Receipts.</returns>
        public Task<IList<Receipt>> FindReceiptsAsync(object filter)
        {
            return _connectionFactory().QueryAsync<Receipt>("FindReceipts", filter);
        }
        #endregion
	}

}