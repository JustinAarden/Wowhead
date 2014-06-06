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

    }
}