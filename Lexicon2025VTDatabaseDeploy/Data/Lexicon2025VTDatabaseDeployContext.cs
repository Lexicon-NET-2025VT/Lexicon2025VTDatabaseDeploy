using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lexicon2025VTDatabaseDeploy.Models;

namespace Lexicon2025VTDatabaseDeploy.Data
{
    public class Lexicon2025VTDatabaseDeployContext : DbContext
    {
        public Lexicon2025VTDatabaseDeployContext (DbContextOptions<Lexicon2025VTDatabaseDeployContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; } = default!;
        public DbSet<VehicleType> VehicleTypes { get; set; } = default!;
    }

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lexicon2025VTDatabaseDeployContext(
                serviceProvider.GetRequiredService<DbContextOptions<Lexicon2025VTDatabaseDeployContext>>()))
            {
                if (context == null || context.VehicleTypes == null)
                {
                    throw new ArgumentNullException("Null ProjectContext");
                }

                if (!context.VehicleTypes.Any())
                {
                    context.VehicleTypes.AddRange(
                         new VehicleType
                         {
                             Name = "Car"
                         },
                         new VehicleType
                         {
                             Name = "Bike"
                         },
                         new VehicleType
                         {
                             Name = "MC"
                         },
                         new VehicleType
                         {
                             Name = "Boat"
                         }
                     );

                    context.SaveChanges();


                    var vehicleType = context.VehicleTypes
                            .Where(t => t.Name == "Car").FirstOrDefault();

                    context.Vehicles.AddRange(
                        new Vehicle
                        {
                            Description = "Car 1",
                            VehicleTypeId = 1,
                            Year = 2019
                        },
                        new Vehicle
                        {
                            Description = "Bike 1",
                            VehicleTypeId = 2,
                            Year = 2025
                        },
                        new Vehicle
                        {
                            Description = "Boat 1",
                            VehicleTypeId = 4,
                            Year = 1998
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
