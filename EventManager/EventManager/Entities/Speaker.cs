// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Speaker.cs" company="">
//   
// </copyright>
// <summary>
//   The speaker.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventManager.Entities
{
    /// <summary>
    /// The speaker.
    /// </summary>
    public class Speaker : Participant
    {
        /// <summary>
        /// Gets or sets Biography.
        /// </summary>
        public string Biography { get; set; }

        public Speaker()
        {
            base.Availability = Availability.Attend;
        }

        /// <summary>
        /// Gets or sets Availability.
        /// Speakers always attend
        /// </summary>
        public override Availability Availability
        {
            get
            {
                return base.Availability;
            }
            set
            {
                base.Availability = Availability.Attend;
            }
        }
    }
}