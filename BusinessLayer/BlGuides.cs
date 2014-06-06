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
        public static List<Guide> gridviewguide(string name)
        {
            var dalguide = new DalGuide();
            return dalguide.GuideGridview(name);
        }

    }
}