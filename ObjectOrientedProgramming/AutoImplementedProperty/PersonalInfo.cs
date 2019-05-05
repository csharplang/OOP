using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OOP.AutoImplementedProperty
{
    public class PersonalInfo 
    {
        public long ID { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [DisplayName("Mobile No")]
        public string MobileNo { get; set; }
        public string NID { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreationUser { get; set; }
        public string LastUpdateUser { get; set; }
        public byte Status { get; set; }
    }
}
