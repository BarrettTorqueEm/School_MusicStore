using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreB.Models
{
    public class Cart
    {
        #region//Initializing Variables
        private int recordId = 0;
        private int cartId = 0;
        private int albumId = 0;
        private int count = 0;
        private string dateCreated = "N/A";
        #endregion

        #region //Gets and Sets
        public int RecordId
        {
            get
            {
                return this.recordId;
            }
            set
            {
                if (value > 0)
                {
                    this.recordId = value;
                }
            }
        }

        public int CartId
        {
            get
            {
                return this.cartId;
            }
            set
            {
                if (value > 0)
                {
                    this.cartId = value;
                }
            }
        }

        public int AlbumId
        {
            get
            {
                return this.albumId;
            }
            set
            {
                if (value > 0)
                {
                    this.albumId = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                if (value > 0)
                {
                    this.count = value;
                }
            }
        }

        public string DateCreated
        {
            get
            {
                return this.dateCreated;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.dateCreated = null;
                }
                else
                {
                    this.dateCreated = value;
                }
            }
        }
        #endregion

        #region//Constructors
        public Cart() : this(0, 0, 0, 0, "N/A")
        {

        }

        public Cart(int aRecordId) : this(aRecordId, 0, 0, 0, "N/A")
        {

        }

        public Cart(int aRecordId, int aCartId) : this(aRecordId, aCartId, 0, 0, "N/A")
        {

        }

        public Cart(int aRecordId, int aCartId, int anAlbumId) : this(aRecordId, aCartId, anAlbumId, 0, "N/A")
        {

        }

        public Cart(int aRecordId, int aCartId, int anAlbumId, int aCount) : this(aRecordId, aCartId, anAlbumId,aCount, "N/A")
        {
           
        }

        public Cart(int aRecordId, int aCartId, int anAlbumId, int aCount, string aDateCreated)
        {
            this.RecordId = aRecordId;
            this.CartId = aCartId;
            this.AlbumId = anAlbumId;
            this.Count = aCount;
            this.DateCreated = aDateCreated;
        }
        #endregion
    }
}