using SongsLibrary_Persistance.Contracts;
using SongsLibrary_Persistance.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance.Repositories
{
    public class ArtistRepository : BaseRepository, IArtistRepository
    {
        private readonly SongsLibraryContext _dbContext;

        public ArtistRepository()
        {
            _dbContext = new SongsLibraryContext();
        }        

        public SongsLibrary_Rules.Models.Artist GetArtist(int Id)
        {
            Artist artist = _dbContext.Artist.FirstOrDefault(p =>  p.Id == Id );
            var result = Mapper.Map<SongsLibrary_Rules.Models.Artist>(artist);

            return result;
        }
        public ICollection<Album> GetAlbums(int ArtistId)
        {
            throw new NotImplementedException();
        }
    }
}
