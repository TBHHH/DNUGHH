// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Meeting.cs" company="Dotnet Usergroup Hamburg">
//   2012
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using EventManager.Contract.BaseClasses;
using EventManager.Contract.BaseClasses.BusinessRules;
using EventManager.Entities;

namespace EventManager.Aggregates
{
    /// <summary>
    /// The meeting.
    /// </summary>
    public class Meeting : BaseEntity
    {
        public Meeting()
        {
            AddRule(new ValidateStringLength("Title"));
            AddRule(new ValidateStringLength("Description"));   
        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets StartPointinTime.
        /// </summary>
        public virtual DateTime? StartPointinTime { get; set; }

        /// <summary>
        /// Gets or sets EndPointinTime.
        /// </summary>
        public virtual DateTime? EndPointinTime { get; set; }

        /// <summary>
        /// Gets or sets DBPicture.
        /// </summary>
        protected virtual byte[] DBPicture { get; set; }

        /// <summary>
        /// Gets or sets Picture.
        /// </summary>
        public Image Picture
        {
            get { return new Bitmap(new MemoryStream(DBPicture)); }
            set
            {
                // tbd Picture 
            }
        }

        /// <summary>
        /// Gets or sets Location.
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        /// Gets or sets Participants.
        /// </summary>
        public virtual IEnumerable<Participant> Participants { get; set; }


        /// <summary>
        /// Gets or sets Speaker.
        /// </summary>
        public virtual Speaker Speaker { get; set; }
    }
}