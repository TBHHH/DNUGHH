// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Participant.cs" company="">
//   
// </copyright>
// <summary>
//   The participant.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventManager.Entities
{
    /// <summary>
    /// The participant.
    /// </summary>
    public class Participant : User
    {
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets Availability.
        /// </summary>
        public virtual Availability Availability { get; set; }
    }

    /// <summary>
    /// The availability.
    /// </summary>
    public enum Availability
    {
        /// <summary>
        /// The attempt.
        /// </summary>
        Attend, 

        /// <summary>
        /// The not attampt.
        /// </summary>
        NotAttend, 

        /// <summary>
        /// The dont know.
        /// </summary>
        DontKnow
    }
}