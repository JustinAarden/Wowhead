// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WowheadUnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Security.AccessControl;

    using BusinessLayer;

    using Entities;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetItem()
        {
            List<Item> itemList = BLItem.Gridviewitem("%war%");
             foreach (Item item in itemList)
            {
                 Debug.WriteLine(item.Name);
            }
        }
    }
}