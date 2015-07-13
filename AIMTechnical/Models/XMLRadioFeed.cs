using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIMTechnical.Models
{
  public class XMLRadioFeed
  {
    public Exception Error { get; set; }
    public Uri FeedURI { get; set; }
    public onAir onAir { get; set; }
  }
}