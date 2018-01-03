using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreB.Models
{
    public class OrderDetail
    {
        #region//Initializing Variables
        private int orderDetailId = 0;
        private int orderId = 0;
        private int albumId = 0;
        private int quantity = 0;
        private int unitPrice = 0;
        #endregion

        #region//Gets and Sets
        public int OrderDetailId
        {
            get
            {
                return this.orderDetailId;
            }
            set
            {
                if (value > 0)
                {
                    this.orderDetailId = value;
                }
            }
        }

        public int OrderId
        {
            get
            {
                return this.orderId;
            }
            set
            {
                if (value > 0)
                {
                    this.orderId = value;
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

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value > 0)
                {
                    this.quantity = value;
                }
            }
        }

        public int UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                if (value > 0.0)
                {
                    this.unitPrice = value;
                }
            }
        }
        #endregion

        #region//Constructors
        public OrderDetail() : this(0, 0, 0, 0, 0)
        {
            //Empty constructor
        }

        public OrderDetail(int anDetailId) : this(anDetailId, 0, 0, 0, 0)
        {

        }

        public OrderDetail(int anDetailId, int anOrderId) : this(anDetailId, anOrderId, 0, 0, 0)
        {

        }

        public OrderDetail(int anDetailId, int anOrderId, int anAlbumId):this(anDetailId, anOrderId, anAlbumId, 0, 0)
        {

        }

        public OrderDetail(int anDetailId, int anOrderId, int anAlbumId, int aQuantity):this(anDetailId, anOrderId, anAlbumId, aQuantity, 0)
        {
            
        } 

        public OrderDetail(int anDetailId, int anOrderId, int anAlbumId, int aQuantity, int aPrice)
        {
            this.OrderDetailId = anDetailId;
            this.OrderId = anOrderId;
            this.AlbumId = anAlbumId;
            this.Quantity = aQuantity;
            this.UnitPrice = aPrice;
        }
        #endregion

        //ToString method
        public override string ToString()
        {
            string aMessage = "";
            aMessage = aMessage + "Order Detail Id: " + OrderDetailId + "\n";
            aMessage = aMessage + "Order Id: " + OrderId + "\n";
            aMessage = aMessage + "Album Id: " + AlbumId + "\n";
            aMessage = aMessage + "Quantity: " + Quantity + "\n";
            aMessage = aMessage + "Unit Price: " + UnitPrice + "\n";
            return aMessage;
        }
    }
}