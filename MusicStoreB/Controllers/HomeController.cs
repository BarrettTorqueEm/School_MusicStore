//Created by Michael Girard

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using System.Data.Odbc;
using MusicStoreB.Models;

namespace MusicStoreB.Controllers
{
    public class HomeController : Controller
    { 
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        #region //Add form empty constructors
        public ActionResult AddGenreForm()
        {
            return View();
        }

        public ActionResult AddAlbumForm()
        {
            return View();
        }

        public ActionResult AddArtistForm()
        {
            return View();
        }

        public ActionResult AddCartForm()
        {
            return View();
        }

        public ActionResult AddOrderForm()
        {
            return View();
        }

        public ActionResult AddOrderDetailForm()
        {
            return View();
        }

        public ActionResult UpdateSelectionForm()
        {
            return View();
        }
        #endregion

        #region //List Database contents
        public ActionResult ListGenres()
        {
            DbConnection aConnection = new DbConnection();

            List<Genre> aListOfGenre = null;

            aListOfGenre = aConnection.GetGenres();

            ViewBag.AListOfGenre = aListOfGenre;

            return View();
        }

        public ActionResult ListAlbums()
        {
            DbConnection aConnection = new DbConnection();

            List<Album> aListOfAlbums = null;

            aListOfAlbums = aConnection.GetAlbums();

            ViewBag.AListOfALbums = aListOfAlbums;

            return View();
        }

        public ActionResult ListArtist()
        {
            DbConnection aConnection = new DbConnection();

            List<Artist> aListOfArtist = null;

            aListOfArtist = aConnection.GetArtist();

            ViewBag.AListOfArtist = aListOfArtist;

            return View();
        }

        public ActionResult ListOrders()
        {
            DbConnection aConnection = new DbConnection();

            List<Order> aListOfOrders = null;

            aListOfOrders = aConnection.GetOrder();

            ViewBag.AListOfOrders = aListOfOrders;

            return View();
        }

        public ActionResult ListOrderDetail()
        {
            DbConnection aConnection = new DbConnection();

            List<OrderDetail> aListOfOrderDetail = null;

            aListOfOrderDetail = aConnection.GetOrderDetail();

            ViewBag.AListOfOrderDetail = aListOfOrderDetail;

            return View();
        }
        #endregion

        #region //Add form Database connections
        public ActionResult AddGenre(string aName, string aDescription)
        {
            ViewBag.Name = aName;
            ViewBag.Description = aDescription;

            DbConnection aConnection = new DbConnection();

            aConnection.InsertGenres(aName, aDescription);

            string aSQL = "INSERT INTO Genre (GenreName, Description) VALUES('" + aName + "','" + aDescription + "')";

            ViewBag.Sql = aSQL;
            return View();
        }

        public ActionResult AddAlbum(int aGenreId, int aArtistId, string aTitle, int aPrice, string aAlbumArtUrl)
        {
            ViewBag.GenreId = aGenreId;
            ViewBag.ArtistId = aArtistId;
            ViewBag.Title = aTitle;
            ViewBag.Price = aPrice;
            ViewBag.AlbumArtUrl = aAlbumArtUrl;

            DbConnection aConnection = new DbConnection();

            aConnection.InsertAlbums(aGenreId, aArtistId, aTitle, aPrice, aAlbumArtUrl);

            string aSQL = "INSERT INTO Album (GenreId, ArtistId, Title, Price, AlbumArtUrl) Values('" + aGenreId + "','" + aArtistId + "','" + aTitle + "','" + aPrice + "','" + aAlbumArtUrl + "')";

            ViewBag.Sql = aSQL;
            return View();
        }

        public ActionResult AddArtist(string aName)
        {
            ViewBag.Name = aName;

            DbConnection aConnection = new DbConnection();

            aConnection.InsertArtist(aName);

            string aSQL = "INSERT INTO Artist (Name) VALUES('" + aName + "')";

            ViewBag.Sql = aSQL;
            return View();
        }

        public ActionResult AddCart(int aCartId, int aAlbumId, int aCount, string aDateCreated)
        {
            ViewBag.CartId = aCartId;
            ViewBag.AlbumId = aAlbumId;
            ViewBag.Count = aCount;
            ViewBag.DateCreated = aDateCreated;

            DbConnection aConnection = new DbConnection();

            aConnection.InsertCart(aCartId, aAlbumId, aCount, aDateCreated);

            string aSQL = "INSERT INTO Cart (CartId, AlbumId, Count, DateCreated) VALUES('" + aCartId + "','" + aAlbumId + "','" + aCount + "','" + aDateCreated + "')";

            ViewBag.Sql = aSQL;
            return View();
        }

        public ActionResult AddOrder(string aOrderDate, string aUserName, string aFirstName, string aLastName, string aAddress, string aCity, string aState, string aPostalCode, string aCountry, string aPhone, string aEmail, int aTotal)
        {
            ViewBag.OrderDate = aOrderDate;
            ViewBag.UserName = aUserName;
            ViewBag.FirstName = aFirstName;
            ViewBag.LastName = aLastName;
            ViewBag.Address = aAddress;
            ViewBag.City = aCity;
            ViewBag.State = aState;
            ViewBag.PostalCode = aPostalCode;
            ViewBag.Country = aCountry;
            ViewBag.Phone = aPhone;
            ViewBag.Email = aEmail;
            ViewBag.Total = aTotal;

            DbConnection aConnection = new DbConnection();

            aConnection.InsertOrder(aOrderDate, aUserName, aFirstName, aLastName, aAddress, aCity, aState, aPostalCode, aCountry, aPhone, aEmail, aTotal);

            string aSQL = "INSERT INTO [Order] (OrderDate, UserName, FirstName, LastName, Address, City, State, PostalCode, Country, Phone, Email, Total) VALUES('" +
                 aOrderDate + "','" + aUserName + "','" + aFirstName + "','" + aLastName + "','" + aAddress + "','" + aCity + "','" + aState + "','" + aPostalCode + "','" + aCountry + "','" + aPhone + "','" + aEmail + "','" + aTotal + "')";

            ViewBag.Sql = aSQL;
            return View();
        }

        public ActionResult AddOrderDetail(int aOrderId, int aAlbumId, int aQuantity, int aUnitPrice)
        {
            ViewBag.OrderId = aOrderId;
            ViewBag.AlbumId = aAlbumId;
            ViewBag.Quantity = aQuantity;
            ViewBag.UnitPrice = aUnitPrice;

            DbConnection aConnection = new DbConnection();

            aConnection.InsertOrderDetail(aOrderId, aAlbumId, aQuantity, aUnitPrice);

            string aSQL = "INSERT INTO OrderDetails (OrderId, AlbumId, Quantity, UnitPrice) VALUES('" + aOrderId + "','" + aAlbumId + "','" + aQuantity + "','" + aUnitPrice + "')";

            ViewBag.Sql = aSQL;
            return View();
        }
        #endregion

        #region //Search by *
        public ActionResult ListAlbumsByGenreId(int GenreId)
        {
            DbConnection aConnection = new DbConnection();

            List<Album> aListOfAlbum = null;

            aListOfAlbum = aConnection.GetAlbumByGenreId(GenreId);

            ViewBag.AListOfAlbums = aListOfAlbum;

            return View();
        }
        #endregion

        #region//Update Form
        public ActionResult UpdateSelection()
        {
            DbConnection aConnection = new DbConnection();

            List<Album> aListOfAlbum = null;

            aListOfAlbum = aConnection.GetAlbums();

            ViewBag.AListOfAlbum = aListOfAlbum;

            return View();
        }

        public ActionResult UpdateForm(int AlbumId)
        {
            DbConnection aConnection = new DbConnection();

            List<Album> aListOfAlbum = null;

            aListOfAlbum = aConnection.GetAlbumById(AlbumId);

            ViewBag.AListOfAlbumsById = aListOfAlbum;

            ViewBag.AnAblumId = AlbumId;

            return View();
        }

        public ActionResult UpdatedInfo(int aAlbumId, int aGenreId, int aArtistId, string aTitle, int aPrice, string aAlbumArtUrl)
        {
            ViewBag.AlbumId = aAlbumId;
            ViewBag.GenreId = aGenreId;
            ViewBag.ArtistId = aArtistId;
            ViewBag.Title = aTitle;
            ViewBag.Price = aPrice;
            ViewBag.AlbumArtUrl = aAlbumArtUrl;

            DbConnection aConnection = new DbConnection();

            aConnection.UpdateAlbum(aAlbumId, aGenreId, aArtistId, aTitle, aPrice, aAlbumArtUrl);

            string aSQL = "UPDATE Album SET AlbumId='" + aAlbumId + "', GenreId='" + aGenreId + "', ArtistId='" +
                aArtistId + "', Title='" + aTitle + "', Price='" + aPrice + "', AlbumArtUrl='" + aAlbumArtUrl + "' WHERE AlbumId='" + aAlbumId + "';";

            ViewBag.Sql = aSQL;
            return View(); 
        }
        #endregion


    }
}