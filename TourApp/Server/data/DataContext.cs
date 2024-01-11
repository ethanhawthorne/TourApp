using Microsoft.EntityFrameworkCore;
using TourApp.Client.Pages;
using Microsoft.AspNetCore.Identity;
using TourApp.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TourApp.Server.data
{
    public class DataContext: IdentityDbContext<Users>
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) { 
        }
        public DbSet<BookHotel> BHotels { get; set; }
        public DbSet<BookTour> BTours { get; set; }
        public DbSet<HotelAvailability> HotelAvailabilities { get; set; }
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<TourAvailability> TourAvailabilities { get; set; }
        public DbSet<Tours>Tours { get; set; }
       
		public DbSet<Users> AppUsers { get; set; }
        public DbSet<Package> Packages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Tours>().HasKey(t => t.TourID);
			modelBuilder.Entity<Hotels>().HasKey(h => h.HotelID);
			modelBuilder.Entity<BookHotel>().HasKey(bh => bh.BookHotelID);
			modelBuilder.Entity<BookTour>().HasKey(bt => bt.BookTourID);
			modelBuilder.Entity<HotelAvailability>().HasKey(ha => ha.HotelAvailabilityID);
			modelBuilder.Entity<TourAvailability>().HasKey(ta => ta.TourAvailabilityID);
            modelBuilder.Entity<Package>().HasKey(p => p.PackageID);
			modelBuilder.Entity<Users>().HasKey(u => u.UserID);

            modelBuilder.Entity<Package>()
                .HasOne(p => p.Tours)
                .WithMany()
                .HasForeignKey(p => p.TourID);

            modelBuilder.Entity<Package>()
                .HasOne(p => p.Hotels)
                .WithMany()
                .HasForeignKey(p => p.HotelID);

			modelBuilder.Entity<HotelAvailability>()
	            .HasOne(p => p.Hotels)
	            .WithMany()
	            .HasForeignKey(p => p.HotelID);

			modelBuilder.Entity<TourAvailability>()
	            .HasOne(p => p.Tours)
	            .WithMany()
	            .HasForeignKey(p => p.TourID);
			
            modelBuilder.Entity<BookHotel>()
	            .HasOne(p => p.Hotels)
	            .WithMany()
	            .HasForeignKey(p => p.HotelID);

			modelBuilder.Entity<BookTour>()
				.HasOne(p => p.Tours)
				.WithMany()
				.HasForeignKey(p => p.TourID);

			modelBuilder.Entity<BookTour>()
				.HasOne(p => p.Users)
				.WithMany()
				.HasForeignKey(p => p.UserID);

			base.OnModelCreating(modelBuilder);


		}
	}

}
