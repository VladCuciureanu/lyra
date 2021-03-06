﻿using System;
using System.Collections.Generic;
using Lyra.Application.Artists;
using Lyra.Application.Common.Mappings;
using Lyra.Application.Tracks;
using Lyra.Domain.Entities;

namespace Lyra.Application.Albums
{
    public class AlbumDto : IMapFrom<Album>
    {
        public AlbumDto()
        {
            Artists = new List<SimplifiedArtistDto>();
            Genres = new List<Genre>();
            Images = new List<Image>();
            Tracks = new List<SimplifiedTrackDto>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int AlbumType { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int Popularity { get; set; }

        public IList<SimplifiedArtistDto> Artists { get; }

        public IList<Genre> Genres { get; }

        public IList<Image> Images { get; }

        public IList<SimplifiedTrackDto> Tracks { get; }
    }
}