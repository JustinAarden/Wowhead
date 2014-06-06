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

    }
}