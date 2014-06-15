// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Item.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Entities
{
    public class Item : WowObject
    {
        #region Public Properties

        public int Level { get; set; }

        public string Quality { get; set; }

        public int ReqLevel { get; set; }

        #endregion
    }
}