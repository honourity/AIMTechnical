using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIMTechnical.Models;
using AIMTechnical.HelperClasses;

namespace AIMTechnical.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    public ActionResult Index()
    {
      //XMLRadioFeed data = XMlHelperClass.GetXMLData(@"file://C:\Users\Grey-Fox\Desktop\sample feed data.xml");
      //XMLRadioFeed data = XMlHelperClass.GetXMLData(@"http://harry.radioapi.io/services/nowplaying/utv/fm104/onair");

      XMLRadioFeed data = new XMLRadioFeed();

      return View(data);
    }

    [HttpPost]
    public ActionResult Index(XMLRadioFeed feed)
    {
      XMLRadioFeed data;
      if (feed.FeedURI != null)
      {
        data = XMlHelperClass.GetXMLData(feed.FeedURI.ToString());
      }
      else
      {
        data = new XMLRadioFeed();
      }
      return View(data);
    }

    public PartialViewResult FeedItem(onAirPlayoutItem feedItem)
    {
      return PartialView(feedItem);
    }
  }
}