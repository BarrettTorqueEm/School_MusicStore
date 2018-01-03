using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreB.Models
{
    public class Genre
    {
        #region//Initializing Variables
        private int genreId = 0;
        private string genreName = "N/A";
        private string description = "N/A";
        #endregion

        #region//Gets and Sets
        public int GenreId
        {
            get
            {
                return this.genreId;
            }

            set
            {
                if (value < 0)
                {
                    throw (new IdLessThenZeroException("ID must be greater then 0"));
                }
                else
                {
                    this.genreId = value;
                }
            }
        }

        public string GenreName
        {
            get
            {
                return this.genreName;
            }

            set
            {
                if (value.Length < 1)
                {
                    this.genreName = "N/A";
                }
                else
                {
                    this.genreName = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (value.Length < 1)
                {
                    this.description = "N/A";
                }
                else
                {
                    this.description = value;
                }
            }
        }
        #endregion

        #region//Constructors
        public Genre() : this(0, "N/A", "N/A")
        {
            //Empty construtor
        }

        public Genre(int anId) : this(anId, "N/A", "N/A")
        {

        }

        public Genre(int anId, string aName) : this(anId, aName, "N/A")
        {

        }


        public Genre(int anId, string aName, string aDescription)
        {
            this.GenreId = anId;
            this.GenreName = aName;
            this.Description = aDescription;
        }
        #endregion

        //ToString Method
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "GenreId: " + GenreId + "\n";
            aMessage = aMessage + "Name: " + GenreName + "\n";
            aMessage = aMessage + "Description: " + Description + "\n";
            return aMessage;
        }
    }
}