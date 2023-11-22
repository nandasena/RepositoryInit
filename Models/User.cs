namespace RepositoryInit.Models
{
    public class User
    {
		public Guid USERID{get; set;}

		public string? USERNAME{get; set;}

		public string? SALUTATION{get; set;}

		public byte[]? SHA1PASSWORD{get; set;}

		public Guid? MD5PASSWORD{get; set;}

		public int? TOTALLOGINS{get; set;}

		public bool ACTIVE{get; set;}

		public DateTime? LASTCHANGE{get; set;}

		public Guid? MODIFEDBY{get; set;}

		public Guid? CURRENTSYSTEMPERIODID{get; set;}

		public string? APPLICATIONSETTINGS {get; set;}

		public bool RESTRICTEDACCESSACCOUNT{get; set;}

		public string? EMPLOYEENO {get; set;}

		public bool ISCURRENTUSERLOGGEDIN{get; set;}

		public DateTime USERLASTLOGGEDINTIME{get; set;}

		public bool ISPORTALUSER{get; set;}

		public int Id{get; set;}

		public bool ISADDCOLLABDISCUSSIONGROUP{get; set;}

		public byte[]? SHA512PASSWORD{get; set;}

		public byte[]? SHA512PASSWORDSALT{get; set;}

		public bool PasswordChanged{get; set;}
	}
}
