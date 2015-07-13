using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIMTechnical.Models
{
  [System.SerializableAttribute()]
  public class onAir
  {
    [System.Xml.Serialization.XmlElementAttribute("playoutItem")]
    public onAirPlayoutItem[] playoutItem { get; set; }
  }
}
