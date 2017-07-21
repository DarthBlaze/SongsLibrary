using SongsLibrary_Rules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance.Contracts
{
    public interface IArtistRepository
    {
        Artist GetArtist(int Id);
        ICollection<Album> GetAlbums(int ArtistId);

    }
}
