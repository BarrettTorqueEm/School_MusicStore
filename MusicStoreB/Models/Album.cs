using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreB.Models
{
    public class Album
    {
        #region//Initializing Variables
        private int albumId = 0;
        private int genreId = 0;
        private int artistId = 0;
        private string title = "N/A";
        private int price = 0;
        private string albumArtUrl = "N/A";
        #endregion

        #region//Gets and Sets
        public int AlbumId
        {
            get
            {
                return this.albumId;
            }
            set
            {
                if(value > 0)
                {
                    this.albumId = value;
                }
            }
        }

        public int GenreId
        {
            get
            {
                return this.genreId;
            }
            set
            {
                if (value > 0)
                {
                    this.genreId = value;
                }
            }
        }

        public int ArtistId
        {
            get
            {
                return this.artistId;
            }
            set
            {
                if(value > 0)
                {
                    this.artistId = value;
                }
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.title = "N/A";
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value > 0)
                {
                    this.price = value;
                }
            }
        }

        public string AlbumArtUrl
        {
            get
            {
                return this.albumArtUrl;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.albumArtUrl = "N/A";
                }
                else
                {
                    this.albumArtUrl = value;
                }
            }
        }
        #endregion

        #region//Constructors
        public Album() : this(0, 0, 0, "N/A", 0, "N/A")
        {

        }

        public Album(int anAlbumId) : this(anAlbumId, 0, 0, "N/A", 0, "N/A")
        {

        }

        public Album(int anAlbumId, int aGenreId) : this(anAlbumId, aGenreId, 0, "N/A", 0, "N/A")
        {

        }

        public Album(int anAlbumId, int aGenreId, int anArtistId) : this(anAlbumId, aGenreId, anArtistId, "N/A", 0, "N/A")
        {

        }

        public Album(int anAlbumId, int aGenreId, int anArtistId, string aTitle) : this(anAlbumId, aGenreId, anArtistId, aTitle, 0, "N/A")
        {

        }

        public Album(int anAlbumId, int aGenreId, int anArtistId, string aTitle, int aPrice) : this(anAlbumId, aGenreId, anArtistId, aTitle, aPrice, "N/A")
        {
            
        }

        public Album(int anAlbumId, int aGenreId, int anArtistId, string aTitle, int aPrice, string anAlbumArtUrl)
        {
            this.AlbumId = anAlbumId;
            this.GenreId = aGenreId;
            this.ArtistId = anArtistId;
            this.Title = aTitle;
            this.Price = aPrice;
            this.AlbumArtUrl = anAlbumArtUrl;
        }
        #endregion

        //ToString method
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "Album Id: " + AlbumId + "\n";
            aMessage = aMessage + "Genre Id: " + GenreId + "\n";
            aMessage = aMessage + "Artist Id: " + ArtistId + "\n";
            aMessage = aMessage + "Title: " + Title + "\n";
            aMessage = aMessage + "Price: " + Price + "\n";
            aMessage = aMessage + "Album Art Url: " + AlbumArtUrl + "\n";
            return aMessage;
        }

        //Testing
        public int ToString2()
        {
            int aMessage2 = 0;
            aMessage2 = AlbumId;
            return aMessage2;
        }

        public int ToString3()
        {
            int aMessage2 = 0;
            aMessage2 = GenreId;
            return aMessage2;
        }

        public int ToString4()
        {
            int aMessage2 = 0;
            aMessage2 = ArtistId;
            return aMessage2;
        }

        public string ToString5()
        {
            string aMessage2 = "";
            aMessage2 = aMessage2 + Title + "\n";
            return aMessage2;
        }

        public int ToString6()
        {
            int aMessage2 = 0;
            aMessage2 = Price;
            return aMessage2;
        }

        public string ToString7()
        {
            string aMessage2 = "";
            aMessage2 = aMessage2 + AlbumArtUrl + "\n";
            return aMessage2;
        }
        
    }
}