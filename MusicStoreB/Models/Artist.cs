using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreB.Models
{
    public class Artist
    {
        #region//Initializing Variables
        private int artistId = 0;
        private string name = "N/A";
        #endregion

        #region//Gets and Sets
        public int ArtistId
        {
            get
            {
                return this.artistId;
            }

            set
            {
                if ( value > 0)
                {
                    this.artistId = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if ( value.Length < 1)
                {
                    this.name = "N/A";
                }
                else
                {
                    this.name = value;
                }
            }
        }
        #endregion

        #region//Constructors
        public Artist() : this(0, "N/A")
        {

        }

        public Artist(int anArtistId) : this(anArtistId, "N/A")
        {
            
        }

        public Artist(int anArtistId, string aName)
        {
            this.ArtistId = anArtistId;
            this.Name = aName;
        }
        #endregion

        //ToString method
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "Artist Id: " + ArtistId + "\n";
            aMessage = aMessage + "Name: " + Name + "\n";
            return aMessage;
        }
    }
}