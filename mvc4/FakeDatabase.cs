using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using musicshop.Models;

namespace musicshop
{
    public class FakeDatabase
    {
        private List<Genre> _genres;
        private List<Album> _albums;
        private List<Artist> _artists;

        public List<Genre> Genres
        {
            get { return _genres; }
        }
        public List<Album> Albums
        {
            get { return _albums; }
        }
        public List<Artist> Artists

        {
            get { return _artists; }
        }
        public FakeDatabase()
        {
            InitializeArtists();
            InitializeGenres();
            InitializeAlbums();
        }
        private void InitializeArtists()
        {
            _artists = new List<Artist>();
            _artists.Add(new Artist() { Name = "Daft Punk", ArtImgUrl = "dfurl", ArtistId = 1 });
            _artists.Add(new Artist() { Name = "Michael Jackson", ArtImgUrl = "dfurl", ArtistId = 2 });
            _artists.Add(new Artist() { Name = "Pink Floyd", ArtImgUrl = "dfurl", ArtistId = 3 });
            _artists.Add(new Artist() { Name = "Led Zeppelin", ArtImgUrl = "dfurl", ArtistId = 4 });
            _artists.Add(new Artist() { Name = "New Order", ArtImgUrl = "dfurl", ArtistId = 5 });
            _artists.Add(new Artist() { Name = "Moby", ArtImgUrl = "dfurl", ArtistId = 5 });
            _artists.Add(new Artist() { Name = "Queen", ArtImgUrl = "dfurl", ArtistId = 7 });
            _artists.Add(new Artist() { Name = "Sia", ArtImgUrl = "dfurl", ArtistId = 8 });
            _artists.Add(new Artist() { Name = "Dr. Dre", ArtImgUrl = "dfurl", ArtistId = 9 });
            _artists.Add(new Artist() { Name = "Metallica", ArtImgUrl = "dfurl", ArtistId = 10 });
            _artists.Add(new Artist() { Name = "Notorious Big", ArtImgUrl = "dfurl", ArtistId = 11 });
            _artists.Add(new Artist() { Name = "Eminem", ArtImgUrl = "dfurl", ArtistId = 12 });
            _artists.Add(new Artist() { Name = "Rammstein", ArtImgUrl = "dfurl", ArtistId = 13 });
            _artists.Add(new Artist() { Name = "Mac Miller", ArtImgUrl = "dfurl", ArtistId = 14 });
        }
        private void InitializeGenres()
        {
            _genres = new List<Genre>();
            _genres.Add(new Genre() { Name = "Rap", GenreId = 1 });
            _genres.Add(new Genre() { Name = "Electronic", GenreId = 2 });
            _genres.Add(new Genre() { Name = "R&B", GenreId = 3 });
            _genres.Add(new Genre() { Name = "Hip-Hop", GenreId = 4 });
            _genres.Add(new Genre() { Name = "Alternative Rock", GenreId = 5 });
            _genres.Add(new Genre() { Name = "Pop", GenreId = 6 });
            _genres.Add(new Genre() { Name = "Classic", GenreId = 7 });
            _genres.Add(new Genre() { Name = "Progressive Rock", GenreId = 8 });
            _genres.Add(new Genre() { Name = "Rock", GenreId = 9 });
            _genres.Add(new Genre() { Name = "Metal", GenreId = 10 });
        }
        private void InitializeAlbums()
        {
            _albums = new List<Album>();
            _albums.Add(new Album()
            {
                AlbumId = 1,
                Title = "Random Access Memories",
                Price = 21,
                AlbumUrl = "fw",
                ReleaseYear = 2013,
                Artist = _artists.Where(x => x.Name == "Daft Punk").FirstOrDefault(),
                Genre = _genres.Where(x => x.Name == "Electronic").FirstOrDefault()
            });
            _albums.Add(new Album()
            {
                AlbumId = 2,
                Title = "Master Of Puppets",
                Price = 15,
                AlbumUrl = "fw",
                ReleaseYear = 1986,
                Artist = _artists.Where(x => x.Name == "Metallica").FirstOrDefault(),
                Genre = _genres.Where(x => x.Name == "Metal").FirstOrDefault()
            });
            _albums.Add(new Album()
            {
                AlbumId = 3,
                Title = "The Chronic",
                Price = 17,
                AlbumUrl = "fw",
                ReleaseYear = 1992,
                Artist = _artists.Where(x => x.Name == "Dr. Dre").FirstOrDefault(),
                Genre = _genres.Where(x => x.Name == "Rap").FirstOrDefault()
            });
            _albums.Add(new Album()
            {
                AlbumId = 3,
                Title = "Queen II",
                Price = 20,
                AlbumUrl = "fw",
                ReleaseYear = 1974,
                Artist = _artists.Where(x => x.Name == "Queen").FirstOrDefault(),
                Genre = _genres.Where(x => x.Name == "Rock").FirstOrDefault()
            });
        }
        public void Update(Album editedalbum)
        {
            _albums[editedalbum.AlbumId - 1] = editedalbum;
        }
        public void AddAlbum(Album newalbum)
        {
            newalbum.AlbumId = _albums.Count + 1;
            _albums.Add(newalbum);
        }
    }

}
        