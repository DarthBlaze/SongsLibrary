using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SongsLibrary_Rules.Models
{
    /// <summary>
    /// This is an Artist's/Band's.
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// Artist's/Band's Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Artist's/Band's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Artist's/Band's foundation date.
        /// </summary>
        public DateTime FoundationDate { get; set; }

        /// <summary>
        /// Artist's/Band's released albums.
        /// </summary>
        public ICollection<Album> Albums { get; set; }
    }
}