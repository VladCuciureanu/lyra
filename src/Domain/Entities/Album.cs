﻿using System;
using System.Collections.Generic;
using Lyra.Domain.Common;
using Lyra.Domain.Enums;

namespace Lyra.Domain.Entities
{
    public class Album : AuditableEntity, IHasDomainEvent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AlbumType AlbumType { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int Popularity { get; set; }

        public IList<Artist> Artists { get; } = new List<Artist>();

        public IList<Genre> Genres { get; } = new List<Genre>();

        public IList<Image> Images { get; } = new List<Image>();

        public IList<Track> Tracks { get; } = new List<Track>();

        public List<DomainEvent> DomainEvents { get; set; } = new List<DomainEvent>();
    }
}