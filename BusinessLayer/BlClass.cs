// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlClass.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BusinessLayer
{
    using System.Collections.Generic;

    using DataAccessLayer;

    using Entities;

    /// <summary>
    ///     The BussinessLayer: BlClass.
    /// </summary>
    public class BlClass
    {
        #region Public Methods and Operators

        public static List<Classes> Gridviewclasses(string name)
        {
            var dalclass = new DalClasses();
            return dalclass.ClassesGridview(name);
        }

        #endregion
    }
}