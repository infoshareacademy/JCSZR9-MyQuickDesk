using Microsoft.EntityFrameworkCore;
using MyQuickDesk.Entities;

namespace MyQuickDesk.DatabaseContext
{
    public class MyQuickDeskContext : DbContext
    {
        public MyQuickDeskContext(DbContextOptions<MyQuickDeskContext> options) : base(options) { }

        public DbSet<Space> Spaces { get; set; }


        public DbSet<Desk> Desks { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set;}


        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Reservation>( mb =>
            {
                mb.HasOne(r => r.Desk).
                    WithMany(d => d.Reservations).
                    HasForeignKey(r => r.DeskId);
                mb.HasOne(r => r.Room).
                    WithMany(rm => rm.Reservations).
                    HasForeignKey(r => r.RoomId);
                mb.HasOne(r => r.ParkingSpot).
                    WithMany(ps => ps.Reservations).
                    HasForeignKey(r => r.ParkingSpotId);

                mb.HasOne(r => r.User).
                    WithMany(u => u.Reservations).
                    HasForeignKey(r => r.UserId);
            });



            modelBuilder.Entity<Room>().HasData
            (
               new Room
               {
                   Id = 1,
                   Name = "Mariacka",
                   MaxCapacity = 8,
                   IsAvaible = true

               },
               new Room
               {
                   Id = 2,
                   Name = "Neptun",
                   MaxCapacity = 10,
                   IsAvaible = true
               },
               new Room
               {
                   Id = 3,
                   Name = "Polityczna",
                   MaxCapacity = 12,
                   IsAvaible = true
               }

            );
            modelBuilder.Entity<Desk>().HasData
            (
                new Desk
                {
                    Id = 4,
                    Name = "Biurko A1",
                    IsAvaible = true
                },
                new Desk
                {
                    Id = 5,
                    Name = "Biurko A2",
                    IsAvaible = true
                },
                new Desk
                {
                    Id = 6,
                    Name = "Biurko A3",
                    IsAvaible = true
                },
                new Desk
                {
                    Id = 7,
                    Name = "Biurko B1",
                    IsAvaible = true
                },
                new Desk
                {
                    Id = 8,
                    Name = "Biurko B2",
                    IsAvaible = true
                }
            );
            modelBuilder.Entity<ParkingSpot>().HasData
            (
                new ParkingSpot
                {
                    Id = 9,
                    Name = "P1A1",
                    HandicappedSpot = true,
                    Charger = true
                },
                new ParkingSpot
                {
                    Id = 10,
                    Name = "P1A2",
                    HandicappedSpot = true,
                    Charger = true
                },
                new ParkingSpot
                {
                    Id = 11,
                    Name = "P1A3",
                    HandicappedSpot = true,
                    Charger = true
                },
                new ParkingSpot
                {
                    Id = 12,
                    Name = "P1B1",
                    HandicappedSpot = true,
                    Charger = true
                }
            );
        }



    }
}
