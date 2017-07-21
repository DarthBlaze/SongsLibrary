using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance.Tables
{
    internal class Artist
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
