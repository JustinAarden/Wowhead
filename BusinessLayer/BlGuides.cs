// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlGuides.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BusinessLayer
{
    using System.Collections.Generic;

    using DataAccessLayer;

    using Entities;

    /// <summary>
    ///     The bl guides.
    /// </summary>
    public class BlGuides
    {
        #region Public Methods and Operators
        public static List<Guide> gridviewguide(string name)
        {
            var dalguide = new DalGuide();
            return dalguide.GuideGridview(name);
        }
        /// <summary>
        ///     The get guide by id.
        /// </summary>
        /// <param name="id">
        ///     The id.
        /// </param>
        /// <returns>
        ///     The <see cref="Guide" />.
        /// </returns>
        public Guide GetGuideById(int id)
        {
            var dalguide = new DalGuide();
            return dalguide.GetGuideById(id);
        }

        /// <summary>
        ///     The get guide by name.
        /// </summary>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <returns>
        ///     The <see cref="Guide" />.
        /// </returns>
        public Guide GetGuideByName(string name)
        {
            var dalguide = new DalGuide();
            return dalguide.GetGuideByName(name);
        }

        #endregion
    }
}