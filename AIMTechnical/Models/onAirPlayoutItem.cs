using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIMTechnical.Models
{
  [System.SerializableAttribute()]
  public class onAirPlayoutItem
  {
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string artist { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
    public System.DateTime duration { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string imageUrl { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime time { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string title { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type { get; set; }
  }
}