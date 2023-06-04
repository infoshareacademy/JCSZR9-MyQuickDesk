﻿using MyQuickDesk.Models;


namespace MyQuickDesk.Services
{
    public class ParkingService
    {
        private static List<ParkingSpot> _parkingspots =
            new List<ParkingSpot>
            {
                new ParkingSpot
                {
                    Id = 1,
                    OwnerId= 2,
                    Description ="First floor",
                    Name= "A",
                    HandicappedSpot = false,
                    Charger = false,
                    IsAvaible = true,
                   
                    
                }
            };

                public List <ParkingSpot> GetAllAvaible()
                 {
                    return _parkingspots.Where(p=> p.IsAvaible).ToList();
                 }
                public ParkingSpot GetById(int id)
                {
                    return _parkingspots.FirstOrDefault(p => p.Id == id);
                }

    }
}
