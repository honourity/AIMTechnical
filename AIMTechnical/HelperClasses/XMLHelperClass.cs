using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using AIMTechnical.Models;
using System.Net;

namespace AIMTechnical.HelperClasses
{
  public static class XMlHelperClass
  {
    public static XMLRadioFeed GetXMLData(String path)
    {
      XMLRadioFeed feed = new XMLRadioFeed();

      Uri uriResult;
      try
      {
        //adding protocol (default http) to requested uri path if its not present
        path = new UriBuilder(path).ToString();

        bool uriIsValid = Uri.TryCreate(path, UriKind.Absolute, out uriResult);
        if (uriIsValid)
        {
          feed.FeedURI = uriResult;
        }
      }
      catch
      {
        feed.Error = new Exception("Malformed Feed URL String");
        return feed;
      }

      try
      {
        using (XmlReader reader = XmlReader.Create(feed.FeedURI.ToString()))
        {
          XmlSerializer serializer = new XmlSerializer(typeof(onAir));
          feed.onAir = (onAir)serializer.Deserialize(reader);
        }
      }
      catch (Exception e)
      {
        feed.Error = e;
      }

      return feed;
    }

    public static Boolean IsValidFilePath(String path)
    {
      Boolean result = false;

      WebRequest webRequest = WebRequest.Create(path);
      webRequest.Timeout = 5000;
      webRequest.Method = "HEAD";
      HttpWebResponse response = null;

      try
      {
        response = (HttpWebResponse)webRequest.GetResponse();
        result = true;
      }
      catch
      {
        //doing nothing here, since something went wrong, given url will be marked invalid
      }
      finally
      {
        if (response != null)
        {
          response.Close();
        }
      }

      return result;
    }

    public static Boolean IsTimespanCurrent(DateTime time, DateTime duration)
    {
      Boolean result = false;

      TimeSpan durationSpan = duration.Subtract(DateTime.MinValue);

      if (time.Add(durationSpan).CompareTo(DateTime.UtcNow) > 0)
      {
        result = true;
      }

      return result;
    }
  }
}