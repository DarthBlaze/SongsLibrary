using SongsLibrary_Rules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance.Contracts
{
    public interface IAlbumRepository
    {
        Album GetAlbum(int Id);
        ICollection<Song> GetSongs(int AlbumId);
    }
}
