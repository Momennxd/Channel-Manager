﻿using Core_Layer.Entities.Hotels;
using DataAccess_Layer.Entities;
using DataAccess_Layer.Entities.Accommodation;
using DataAccess_Layer.Entities.Facilities;
using DataAccess_Layer.Entities.Hotels;
using DataAccess_Layer.Entities.Language.cs;
using DataAccess_Layer.Entities.People;
using Microsoft.EntityFrameworkCore;

namespace Core_Layer.AppDbContext
{
    public partial class AppDbContext
    {
        public DbSet<eCountryDA> Countries { get; set; }

        public DbSet<ePersonDA> People { get; set; }
        public DbSet<eUserDA> Users { get; set; }

        public DbSet<eHotelDA> Hotels { get; set; }

        public DbSet<eHotelsPicsDA> HotelsPics { get; set; }


        public DbSet<eFacilitiesCategoriesDA> FacilitiesCategories { get; set; }

        public DbSet<eFacilitiesDA> Facilities { get; set; }

        public DbSet<eHotelFacilitiesDA> HotelFacilities { get; set; }

        public DbSet<eLanguageDA> Languages { get; set; }

        public DbSet<ePreferedPeopleLanguagesDA> PreferedPeopleLanguages { get; set; }

        public DbSet<eAccommodationDiscountDA> AccommodationsDiscounts { get; set; }

        public DbSet<eAccommodationPatmentsMethodDA> AccommationsPaymentsMethods { get; set; }

        public DbSet<eAccommdoationBasesDA> AccommodationsBases { get; set; }

        public DbSet<eAccommodationFacilitiesDA> AccommodationsFacilities { get; set; }

        public DbSet<eAccommodationPricesDA> AccommadationsPrices { get; set; }

        public DbSet<eAccommodatioPicsDA> AccommodationsPics { get; set; }

        public DbSet<ePaymentsTypeDA> PaymentsTypes { get; set; }


     
    }
}
