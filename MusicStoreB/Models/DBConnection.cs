using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;

namespace MusicStoreB.Models
{
    public class DbConnection
    {
        #region //Creating things
        OleDbConnection aConnection = new OleDbConnection();

        private List<Genre> aListOfGenres = new List<Genre>();

        private List<Album> aListOfAlbums = new List<Album>();

        private List<Artist> aListOfArtist = new List<Artist>();

        private List<Order> aListOfOrders = new List<Order>();

        private List<OrderDetail> aListOfOrderDetail = new List<OrderDetail>();
        #endregion

        #region //Database connections for List *
        public List<Genre> GetGenres()
        {
            string aSQL = "SELECT * FROM Genre;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aGenreId = (int)aReader["GenreId"];
                string aGenreName = (string)aReader["GenreName"];
                string aDescription = (string)aReader["Description"];

                Genre aGenre = new Genre();

                aGenre.GenreId = aGenreId;
                aGenre.GenreName = aGenreName;
                aGenre.Description = aDescription;

                aListOfGenres.Add(aGenre);
            }
            aConnection.Close();

            return aListOfGenres;
        }

        public List<Album> GetAlbums()
        {
            string aSQL = "SELECT * FROM Album;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int anAlbumId = (int)aReader["AlbumId"];
                int aGenreId = (int)aReader["GenreId"];
                int anArtistId = (int)aReader["ArtistId"];
                string aTitle = (string)aReader["Title"];
                int aPrice = (int)aReader["Price"];
                string anAlbumArtUrl = (string)aReader["AlbumArtUrl"];

                Album aAlbum = new Album();

                aAlbum.AlbumId = anAlbumId;
                aAlbum.GenreId = aGenreId;
                aAlbum.ArtistId = anArtistId;
                aAlbum.Title = aTitle;
                aAlbum.Price = aPrice;
                aAlbum.AlbumArtUrl = anAlbumArtUrl;

                aListOfAlbums.Add(aAlbum);
            }
            aConnection.Close();

            return aListOfAlbums;
        }

        public List<Artist> GetArtist()
        {
            string aSQL = "SELECT * FROM Artist;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int anArtistId = (int)aReader["ArtistId"];
                string aName = (string)aReader["Name"];

                Artist aArtist = new Artist();

                aArtist.ArtistId = anArtistId;
                aArtist.Name = aName;

                aListOfArtist.Add(aArtist);
            }
            aConnection.Close();

            return aListOfArtist;
        }

        public List<Order> GetOrder()
        {
            string aSQL = "SELECT * FROM [Order];";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aOrderId = (int)aReader["OrderId"];
                string aOrderDate = (string)aReader["OrderDate"];
                string aUserName = (string)aReader["UserName"];
                string aFirstName = (string)aReader["FirstName"];
                string aLastName = (string)aReader["LastName"];
                string aAddress = (string)aReader["Address"];
                string aCity = (string)aReader["City"];
                string aState = (string)aReader["State"];
                string aPostalCode = (string)aReader["PostalCode"];
                string aCountry = (string)aReader["Country"];
                string aPhone = (string)aReader["Phone"];
                string aEmail = (string)aReader["Email"];
                int aTotal = (int)aReader["Total"];

                Order aOrder = new Order();

                aOrder.OrderId = aOrderId;
                aOrder.OrderDate = aOrderDate;
                aOrder.UserName = aUserName;
                aOrder.FirstName = aFirstName;
                aOrder.LastName = aLastName;
                aOrder.Address = aAddress;
                aOrder.City = aCity;
                aOrder.State = aState;
                aOrder.PostalCode = aPostalCode;
                aOrder.Country = aCountry;
                aOrder.Phone = aPhone;
                aOrder.Email = aEmail;
                aOrder.Total = aTotal;

                aListOfOrders.Add(aOrder);
            }
            aConnection.Close();

            return aListOfOrders;
        }

        public List<OrderDetail> GetOrderDetail()
        {
            string aSQL = "SELECT * FROM OrderDetails;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aOrderDetailId = (int)aReader["OrderDetailId"];
                int aOrderId = (int)aReader["OrderId"];
                int aAlbumId = (int)aReader["AlbumId"];
                int aQuantity = (int)aReader["Quantity"];
                int aUnitPrice = (int)aReader["UnitPrice"];

                OrderDetail aOrderDetail = new OrderDetail();

                aOrderDetail.OrderDetailId = aOrderDetailId;
                aOrderDetail.OrderId = aOrderId;
                aOrderDetail.AlbumId = aAlbumId;
                aOrderDetail.Quantity = aQuantity;
                aOrderDetail.UnitPrice = aUnitPrice;

                aListOfOrderDetail.Add(aOrderDetail);
            }
            aConnection.Close();

            return aListOfOrderDetail;
        }
        #endregion

        #region //Database connections for Add *
        public bool InsertGenres(string aName, string aDescription) //true = success false = failed
        {
            bool aFlag = false;

            string aSQL = "INSERT INTO Genre (GenreName, Description) VALUES('" + aName + "','" + aDescription + "')";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();

            aFlag = true;

            aConnection.Close();

            return aFlag;
        }

        public bool InsertAlbums(int aGenreId, int aArtistId, string aTitle, int aPrice , string aAlbumArtUrl) //true = success false = failed
        {
            bool aFlag = false;

            string aSQL = "INSERT INTO Album (GenreId, ArtistId, Title, Price, AlbumArtUrl) VALUES('" + aGenreId + "','" + aArtistId + "','" + aTitle + "','" + aPrice + "','" + aAlbumArtUrl + "')";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();

            aFlag = true;

            aConnection.Close();

            return aFlag;
        }

        public bool InsertArtist(string aName) //true = success false = failed
        {
            bool aFlag = false;

            string aSQL = "INSERT INTO Artist (Name) VALUES('" + aName + "')";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();

            aFlag = true;

            aConnection.Close();

            return aFlag;
        }

        public bool InsertCart(int aCartId, int aAlbumId, int aCount, string aDateCreated) //true = success false = failed
        {
            bool aFlag = false;

            string aSQL = "INSERT INTO Cart (CartId, AlbumId, [Count], DateCreated) VALUES('" + aCartId + "','" + aAlbumId + "','" + aCount + "','" + aDateCreated + "')";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();

            aFlag = true;

            aConnection.Close();

            return aFlag;
        }

        public bool InsertOrder(string aOrderDate, string aUserName, string aFirstName, string aLastName, string aAddress, string aCity, string aState, string aPostalCode, string aCountry, string aPhone, string aEmail, int aTotal) //true = success false = failed
        {
            bool aFlag = false;

            string aSQL = "INSERT INTO [Order] (OrderDate, UserName, FirstName, LastName, Address, City, State, PostalCode, Country, Phone, Email, Total) VALUES('" + 
                aOrderDate + "','" + aUserName + "','" + aFirstName + "','" + aLastName + "','" + aAddress + "','" + aCity + "','" + aState + "','" + aPostalCode + "','" + aCountry + "','" + aPhone + "','" + aEmail + "','" + aTotal + "')";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();

            aFlag = true;

            aConnection.Close();

            return aFlag;
        }

        public bool InsertOrderDetail(int aOrderId, int aAlbumId, int aQuantity, int aUnitPrice) //true = success false = failed
        {
            bool aFlag = false;

            string aSQL = "INSERT INTO OrderDetails (OrderId, AlbumId, Quantity, UnitPrice) VALUES('" + aOrderId + "','" + aAlbumId + "','" + aQuantity + "','" + aUnitPrice + "')";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();

            aFlag = true;

            aConnection.Close();

            return aFlag;
        }
        #endregion

        #region //Database connections for search *
        public List<Album> GetAlbumByGenreId(int aGenreId)
        {
            string aSQL = "SELECT ALbumId, GenreId, ArtistId, Title, Price, ALbumArtUrl FROM Album WHERE GenreId = " + aGenreId + ";";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int anAlbumId = (int)aReader["AlbumId"];
                int aGenreId2 = (int)aReader["GenreId"];
                int anArtistId = (int)aReader["ArtistId"];
                string aTitle = (string)aReader["Title"];
                int aPrice = (int)aReader["Price"];
                string anAlbumArtUrl = (string)aReader["AlbumArtUrl"];


                Album anAlbum = new Album();

                anAlbum.AlbumId = anAlbumId;
                anAlbum.GenreId = aGenreId2;
                anAlbum.ArtistId = anArtistId;
                anAlbum.Title = aTitle;
                anAlbum.Price = aPrice;
                anAlbum.AlbumArtUrl = anAlbumArtUrl;

                aListOfAlbums.Add(anAlbum);
            }
            aConnection.Close();

            return aListOfAlbums;
        }

        public List<Album> GetAlbumById(int aAlbumId)
        {
            string aSQL = "SELECT * FROM Album WHERE AlbumId = " + aAlbumId + ";";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int anAlbumId = (int)aReader["AlbumId"];
                int aGenreId2 = (int)aReader["GenreId"];
                int anArtistId = (int)aReader["ArtistId"];
                string aTitle = (string)aReader["Title"];
                int aPrice = (int)aReader["Price"];
                string anAlbumArtUrl = (string)aReader["AlbumArtUrl"];


                Album anAlbum = new Album();

                anAlbum.AlbumId = anAlbumId;
                anAlbum.GenreId = aGenreId2;
                anAlbum.ArtistId = anArtistId;
                anAlbum.Title = aTitle;
                anAlbum.Price = aPrice;
                anAlbum.AlbumArtUrl = anAlbumArtUrl;

                aListOfAlbums.Add(anAlbum);
            }
            aConnection.Close();

            return aListOfAlbums;
        }
        #endregion

        #region//Database connections for Update *
        public bool UpdateAlbum(int aAlbumId, int aGenreId, int aArtistId, string aTitle, int aPrice, string aAlbumArtUrl) //true = success fales = failed
        {

            bool aFlag = false;

            string aSQL = "UPDATE Album SET GenreId='" + aGenreId + "', ArtistId='" + aArtistId + "', Title='" + aTitle + "', Price='" + aPrice + "', AlbumArtUrl='" + aAlbumArtUrl +"' WHERE AlbumId='" + aAlbumId +"';";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\MusicStoreB.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();

            aFlag = true;

            aConnection.Close();

            return aFlag;
        }
        #endregion
    }
}