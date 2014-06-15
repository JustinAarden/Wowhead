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
        ///     The Gridviewitem
        /// </summary>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public static List<Item> Gridviewitem(string name)
        {
            var itemfactory = new DalItem();
            return itemfactory.ItemsGridview(name);
        }

        #endregion
    }
}