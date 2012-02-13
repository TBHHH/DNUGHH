// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="">
//   
// </copyright>
// <summary>
//   The location.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using EventManager.Contract.BaseClasses;

namespace EventManager.Entities
{
    /// <summary>
    /// The location.
    /// </summary>
    public class Location : BaseEntity
    {
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        public virtual Address Address { get; set; }
    }
}