using System;

namespace RaidManager.Domain.Dto
{
    /// <summary>
    /// Model for the user
    /// </summary>
    public class User : DtoBase
    {
        /// <summary>
        /// User name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        /// <value></value>
        public string Password {get;set;}
        /// <summary>
        /// Creation date
        /// </summary>
        /// <value></value>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Last connection date
        /// </summary>
        /// <value></value>
        public DateTime LastConnectionDate {get;set;}
    }
}