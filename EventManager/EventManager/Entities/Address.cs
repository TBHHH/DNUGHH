// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="">
//   
// </copyright>
// <summary>
//   The address.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using EventManager.Contract.BaseClasses;

namespace EventManager.Entities
{
    /// <summary>
    /// The address.
    /// </summary>
    public class Address : BaseEntity
    {
        /// <summary>
        /// Gets or sets Street.
        /// </summary>
        public virtual string Street { get; set; }

        /// <summary>
        /// Gets or sets Zip.
        /// </summary>
        public virtual string Zip { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        public virtual string City { get; set; }
    }
}