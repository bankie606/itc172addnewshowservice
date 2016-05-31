using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShowTrackerService" in code, svc and config file together.
public class ShowTrackerService : IShowTrackerService
{
    ShowTrackerEntities db = new ShowTrackerEntities();

    public bool AddArtist(Artist a)
    {
            Artist artist = new Artist();
        artist.ArtistName = a.ArtistName;
        artist.ArtistEmail = a.ArtistEmail;
        artist.ArtistWebPage = a.ArtistWebPage;
        bool result = true;
        try
        {
            db.Artists.Add(a);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }

    public bool AddShow(Show s, ShowDetail sd)
    {
        Show show = new Show();
        show.ShowName = s.ShowName;
        bool result = true;
        try
        {
            db.Shows.Add(s);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }
        return result;
    }


    public bool RegisterVenue(Venue v, VenueLogin vl)
    {
        bool result = true;
        int pass = db.usp_RegisterVenue(v.VenueName, v.VenueAddress, v.VenueCity, v.VenueState, v.VenueZipCode, v.VenuePhone, v.VenueEmail, v.VenueWebPage, v.VenueAgeRestriction, vl.VenueLoginUserName, vl.VenueLoginPasswordPlain);
        if (pass == -1)
        {
            result = false;
        }

        return result;
    }

    public int VenueLogin(string userName, string password)
    {
        int venueLoginKey = 0;
        int result = db.usp_venueLogin(userName, password);
        if (result != -1)
        {
            var key = (from r in db.VenueLogins
                       where r.VenueLoginUserName.Equals(userName)
                       select new { r.VenueLoginKey}).FirstOrDefault();

            venueLoginKey = key.VenueLoginKey;

        }

        return venueLoginKey;
    }
}
