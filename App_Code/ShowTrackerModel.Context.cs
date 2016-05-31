﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class ShowTrackerEntities : DbContext
{
    public ShowTrackerEntities()
        : base("name=ShowTrackerEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Venue> Venues { get; set; }
    public virtual DbSet<VenueLogin> VenueLogins { get; set; }
    public virtual DbSet<Artist> Artists { get; set; }
    public virtual DbSet<Show> Shows { get; set; }
    public virtual DbSet<ShowDetail> ShowDetails { get; set; }

    public virtual int usp_RegisterVenue(string venueName, string venueAddress, string venueCity, string venueState, string venueZipCode, string venuePhone, string venueEmail, string venueWebPage, Nullable<int> venueAgeRestriction, string venueLoginUserName, string venueLoginPasswordPlain)
    {
        var venueNameParameter = venueName != null ?
            new ObjectParameter("VenueName", venueName) :
            new ObjectParameter("VenueName", typeof(string));

        var venueAddressParameter = venueAddress != null ?
            new ObjectParameter("VenueAddress", venueAddress) :
            new ObjectParameter("VenueAddress", typeof(string));

        var venueCityParameter = venueCity != null ?
            new ObjectParameter("VenueCity", venueCity) :
            new ObjectParameter("VenueCity", typeof(string));

        var venueStateParameter = venueState != null ?
            new ObjectParameter("VenueState", venueState) :
            new ObjectParameter("VenueState", typeof(string));

        var venueZipCodeParameter = venueZipCode != null ?
            new ObjectParameter("VenueZipCode", venueZipCode) :
            new ObjectParameter("VenueZipCode", typeof(string));

        var venuePhoneParameter = venuePhone != null ?
            new ObjectParameter("VenuePhone", venuePhone) :
            new ObjectParameter("VenuePhone", typeof(string));

        var venueEmailParameter = venueEmail != null ?
            new ObjectParameter("VenueEmail", venueEmail) :
            new ObjectParameter("VenueEmail", typeof(string));

        var venueWebPageParameter = venueWebPage != null ?
            new ObjectParameter("VenueWebPage", venueWebPage) :
            new ObjectParameter("VenueWebPage", typeof(string));

        var venueAgeRestrictionParameter = venueAgeRestriction.HasValue ?
            new ObjectParameter("VenueAgeRestriction", venueAgeRestriction) :
            new ObjectParameter("VenueAgeRestriction", typeof(int));

        var venueLoginUserNameParameter = venueLoginUserName != null ?
            new ObjectParameter("VenueLoginUserName", venueLoginUserName) :
            new ObjectParameter("VenueLoginUserName", typeof(string));

        var venueLoginPasswordPlainParameter = venueLoginPasswordPlain != null ?
            new ObjectParameter("VenueLoginPasswordPlain", venueLoginPasswordPlain) :
            new ObjectParameter("VenueLoginPasswordPlain", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_RegisterVenue", venueNameParameter, venueAddressParameter, venueCityParameter, venueStateParameter, venueZipCodeParameter, venuePhoneParameter, venueEmailParameter, venueWebPageParameter, venueAgeRestrictionParameter, venueLoginUserNameParameter, venueLoginPasswordPlainParameter);
    }

    public virtual int usp_venueLogin(string username, string password)
    {
        var usernameParameter = username != null ?
            new ObjectParameter("username", username) :
            new ObjectParameter("username", typeof(string));

        var passwordParameter = password != null ?
            new ObjectParameter("password", password) :
            new ObjectParameter("password", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_venueLogin", usernameParameter, passwordParameter);
    }
}
