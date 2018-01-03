using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreB.Models
{
    public class IdLessThenZeroException: Exception
    {
        public IdLessThenZeroException(string message): base(message)
        {

        }
    }
}