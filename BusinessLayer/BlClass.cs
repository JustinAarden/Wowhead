// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlClass.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace BusinessLayer
{
    using DataAccessLayer;

    /// <summary>
    /// The bl class.
    /// </summary>
    public class BlClass
    {
        public static List<Classes> gridviewclasses(string name)
        {
            var dalclass = new DalClasses();
            return dalclass.ClassesGridview(name);
        }
        /// <summary>
        /// The get class by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Classes"/>.
        /// </returns>
        public Classes GetClassById(int id)
        {
            DalClasses dalclass = new DataAccessLayer.DalClasses();
            return dalclass.GetClassById(id);
        }

        /// <summary>
        /// The get class by name.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="Classes"/>.
        /// </returns>
        public Classes GetClassByName(string name)
        {
            DalClasses dalclass = new DataAccessLayer.DalClasses();
            return dalclass.GetClassByName(name);
        }
    }
}