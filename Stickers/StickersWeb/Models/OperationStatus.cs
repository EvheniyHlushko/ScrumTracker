using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StickersWeb.Models
{
    public class OperationStatus
    {
        public bool Status { get; set; }
        public Guid InsertedId { get; set; }
    }
}