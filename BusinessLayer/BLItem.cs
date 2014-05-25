// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlItem.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BusinessLayer
{
    using System.Collections.Generic;

    using DataAccessLayer;

    using Entities;

    /// <summary>
    ///     The bl item.
    /// </summary>
    public class BLItem
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The gridviewitem.
        /// </summary>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public static List<Item> gridviewitem(string name)
        {
            var itemfactory = new DalItem();
            return itemfactory.ItemsGridview(name);
        }

        /// <summary>
        ///     The get item by id.
        /// </summary>
        /// <param name="id">
        ///     The id.
        /// </param>
        /// <returns>
        ///     The <see cref="Item" />.
        /// </returns>
        public Item GetItemById(int id)
        {
            var itemFactory = new DalItem();
            return itemFactory.GetItemById(id);
        }

        /// <summary>
        ///     The get item by name.
        /// </summary>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <returns>
        ///     The <see cref="Item" />.
        /// </returns>
        public Item GetItemByName(string name)
        {
            var itemFactory = new DalItem();
            return itemFactory.GetItemByName(name);
        }

        #endregion
    }
}