using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApartmentsScaffolding.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Rooms { get; set; }
        public string SizeInM { get; set; }
        public string Price { get; set; }
        public int RentalPeriodInMounth { get; set; }
        public string OwnersPhone { get; set; }
        public bool isRenovation { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PostedOnSite { get; set; }


    }

    public class RentContext : DbContext
    {
        public DbSet<Rent> Rents { get; set; }
    }
}