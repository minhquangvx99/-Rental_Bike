// --------------------RENTAL BIKE APP-----------------
//
//
// Copyright (c) Microsoft. All Rights Reserved.
// License under the Apache License, Version 2.0.
//
//   Su Huu Vu Quang
//   Pham Hong Phuc
//   Tran Minh Quang
//   Ngo Minh Quang
//
//
// ------------------------------------------------------

using NUnit.Framework;
using RentalBikeApp.Data;
using RentalBikeApp.Data.ServiceAgents;
using RentalBikeApp.Entities.SQLEntities;
using System.Collections.Generic;

namespace ReantalBikeTest.ServiceAgents
{
    [TestFixture]
   class TransactionServiceTests
    {
        private SQLConnecter connecter = SQLConnecter.GetInstance();
        private TransactionService transactionService;

        [SetUp]
        public void Setup()
        {
            transactionService = new TransactionService(connecter);
        }

        /// <summary>
        /// Test for insert new transaction in database
        /// </summary>
        [Test, Order(0)]
        public void InsertNewTransactionTest()
        {
            Transaction transaction = new Transaction(1, 1, 400000);
            Assert.IsNotNull(transaction);
            
        }

        /// <summary>
        /// Test for get transaction by id
        /// </summary>
        [Test, Order(1)]
        public void GetTransactionByIdTest()
        {
            Transaction transaction = transactionService.GetTransactionById(1);
            Assert.IsNotNull(transaction);
        }

        /// <summary>
        /// Test for get list transaction by user id
        /// </summary>
        [Test, Order(2)]
        public void GetListTransactionsByUserIdTest()
        {
            List<Transaction> transactions = transactionService.GetListTransactionsByUserId(1);
            Assert.IsTrue(transactions.Count > 0);
        }

        /// <summary>
        /// Test for update transaction
        /// </summary>
        [Test, Order(3)]
        public void UpdateTransactionTest()
        {
            bool result = transactionService.UpdateTransaction(1, 10000, "");
            Assert.IsTrue(result);
        }
    }
}
