using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance.Tables
{
    class Song
    {
        /// <summary>
        /// Song's Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Albums's Id.
        /// </summary>
        public int AlbumId { get; set; }

        /// <summary>
        /// Song's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Song's length in seconds.
        /// </summary>
        public int Length { get; set; }
    }
}
