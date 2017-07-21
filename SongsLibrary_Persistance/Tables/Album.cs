using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance.Tables
{
    internal class Album
    {
        /// <summary>
        /// Album's id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Artist's id.
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        /// Album's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Album's release date.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Album's songs.
        /// </summary>
        public ICollection<Song> Songs { get; set; }

    }
}
