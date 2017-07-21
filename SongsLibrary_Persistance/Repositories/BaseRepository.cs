using AutoMapper;
using SongsLibrary_Persistance.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsLibrary_Persistance.Repositories
{
    public class BaseRepository
    {
        private readonly MapperConfiguration _config;
        public BaseRepository()
        {
            _config = new MapperConfiguration(SetMapperConfiguration);
        }

        private void SetMapperConfiguration(IMapperConfigurationExpression mapperConfigurationExpression)
        {
            mapperConfigurationExpression.CreateMap<Song, SongsLibrary_Rules.Models.Song>();
            mapperConfigurationExpression.CreateMap<Album, SongsLibrary_Rules.Models.Album>();
            mapperConfigurationExpression.CreateMap<Artist, SongsLibrary_Rules.Models.Artist>();
        }

        public IMapper Mapper
        {
            get { return _config.CreateMapper(); }
        }
    }
}
