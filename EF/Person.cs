using System;
using System.Collections.Generic;
using static Bogus.DataSets.Name;

namespace Expo.Api.EF
{
    public partial class Person
    {


        public Gender Gender { get; set; }
        public string NameTitle { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string LocationStreetNumber { get; set; }
        public string LocationStreetName { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public string LocationCountry { get; set; }
        public string LocationPostcode { get; set; }
        public double LocationCoordinatesLatitude { get; set; }
        public double LocationCoordinatesLongitude { get; set; }
        public string LocationTimezoneOffset { get; set; }
        public string LocationTimezoneDescription { get; set; }
        public string Email { get; set; }
        public Guid? LoginUuid { get; set; }
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
        public string LoginSalt { get; set; }
        public string LoginMd5 { get; set; }
        public string LoginSha1 { get; set; }
        public string LoginSha256 { get; set; }
        public DateTime DobDate { get; set; }
        public int? DobAge { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public int? RegisteredAge { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string IdName { get; set; }
        public Guid IdValue { get; set; }
        public string PictureLarge { get; set; }
        public string PictureMedium { get; set; }
        public string PictureThumbnail { get; set; }
        public string Nat { get; set; }
    }
}
