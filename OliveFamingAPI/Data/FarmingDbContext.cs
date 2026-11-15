using Microsoft.EntityFrameworkCore;
using OliveFarmingAPI.Models;

namespace OliveFarmingAPI.Data;

public class FarmingDbContext: DbContext
{
    // Constructor
    public FarmingDbContext(DbContextOptions<FarmingDbContext> options) : base(options)
    {
    }

    // Tables at database
    public DbSet<Season> Seasons { get; set; }
    public DbSet<RainLog> RainLogs { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Plot> Plots { get; set; }
    public DbSet<PhytosanitaryTreatment> PhytosanitaryTreatments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed the season
        modelBuilder.Entity<Season>().HasData(
            new Season { Id = 100, Name = "20/21" }
        );

        // Seed rainlogs
        modelBuilder.Entity<RainLog>().HasData(
            new RainLog { Id = -1001, SeasonId = 100, Date = new DateTime(2020, 10, 23), Liters = 18 },
            new RainLog { Id = -1002, SeasonId = 100, Date = new DateTime(2020, 11, 4), Liters = 18 },
            new RainLog { Id = -1003, SeasonId = 100, Date = new DateTime(2020, 11, 5), Liters = 3.5 },
            new RainLog { Id = -1004, SeasonId = 100, Date = new DateTime(2020, 11, 8), Liters = 12 },
            new RainLog { Id = -1005, SeasonId = 100, Date = new DateTime(2020, 11, 26), Liters = 32 },
            new RainLog { Id = -1006, SeasonId = 100, Date = new DateTime(2020, 11, 29), Liters = 31 },
            new RainLog { Id = -1007, SeasonId = 100, Date = new DateTime(2020, 12, 5), Liters = 10 },
            new RainLog { Id = -1008, SeasonId = 100, Date = new DateTime(2020, 12, 12), Liters = 11 },
            new RainLog { Id = -1009, SeasonId = 100, Date = new DateTime(2020, 12, 19), Liters = 8 },
            new RainLog { Id = -1010, SeasonId = 100, Date = new DateTime(2020, 12, 20), Liters = 9.5 },
            new RainLog { Id = -1011, SeasonId = 100, Date = new DateTime(2021, 1, 1), Liters = 6.5 },
            new RainLog { Id = -1012, SeasonId = 100, Date = new DateTime(2021, 1, 3), Liters = 5 },
            new RainLog { Id = -1013, SeasonId = 100, Date = new DateTime(2021, 1, 7), Liters = 19 },
            new RainLog { Id = -1014, SeasonId = 100, Date = new DateTime(2021, 1, 8), Liters = 15 },
            new RainLog { Id = -1015, SeasonId = 100, Date = new DateTime(2021, 1, 20), Liters = 5 },
            new RainLog { Id = -1016, SeasonId = 100, Date = new DateTime(2021, 1, 23), Liters = 6 },
            new RainLog { Id = -1017, SeasonId = 100, Date = new DateTime(2021, 2, 6), Liters = 4 },
            new RainLog { Id = -1018, SeasonId = 100, Date = new DateTime(2021, 2, 14), Liters = 43 },
            new RainLog { Id = -1019, SeasonId = 100, Date = new DateTime(2021, 2, 28), Liters = 10 },
            new RainLog { Id = -1020, SeasonId = 100, Date = new DateTime(2021, 3, 9), Liters = 9 },
            new RainLog { Id = -1021, SeasonId = 100, Date = new DateTime(2021, 4, 11), Liters = 14 },
            new RainLog { Id = -1022, SeasonId = 100, Date = new DateTime(2021, 4, 17), Liters = 20 },
            new RainLog { Id = -1023, SeasonId = 100, Date = new DateTime(2021, 4, 25), Liters = 22 },
            new RainLog { Id = -1024, SeasonId = 100, Date = new DateTime(2021, 4, 29), Liters = 30 },
            new RainLog { Id = -1025, SeasonId = 100, Date = new DateTime(2021, 6, 6), Liters = 25 },
            new RainLog { Id = -1026, SeasonId = 100, Date = new DateTime(2021, 6, 17), Liters = 6 }
        );


        // Seed season 21/22
        modelBuilder.Entity<Season>().HasData(
            new Season { Id = 101, Name = "21/22" }
        );

        // Seed rain logs
        modelBuilder.Entity<RainLog>().HasData(
            new RainLog { Id = -2001, SeasonId = 101, Date = new DateTime(2021, 9, 18), Liters = 15 },
            new RainLog { Id = -2002, SeasonId = 101, Date = new DateTime(2021, 9, 26), Liters = 3 },
            new RainLog { Id = -2003, SeasonId = 101, Date = new DateTime(2021, 10, 2), Liters = 50 },
            new RainLog { Id = -2004, SeasonId = 101, Date = new DateTime(2021, 11, 23), Liters = 9 },
            new RainLog { Id = -2005, SeasonId = 101, Date = new DateTime(2021, 12, 8), Liters = 3 },
            new RainLog { Id = -2006, SeasonId = 101, Date = new DateTime(2021, 12, 25), Liters = 48 },
            new RainLog { Id = -2007, SeasonId = 101, Date = new DateTime(2021, 12, 26), Liters = 4 },
            new RainLog { Id = -2008, SeasonId = 101, Date = new DateTime(2022, 1, 6), Liters = 11 },
            new RainLog { Id = -2009, SeasonId = 101, Date = new DateTime(2022, 3, 12), Liters = 25 },
            new RainLog { Id = -2010, SeasonId = 101, Date = new DateTime(2022, 3, 13), Liters = 8 },
            new RainLog { Id = -2011, SeasonId = 101, Date = new DateTime(2022, 3, 19), Liters = 39 },
            new RainLog { Id = -2012, SeasonId = 101, Date = new DateTime(2022, 3, 23), Liters = 17 },
            new RainLog { Id = -2013, SeasonId = 101, Date = new DateTime(2022, 3, 26), Liters = 6 },
            new RainLog { Id = -2014, SeasonId = 101, Date = new DateTime(2022, 3, 30), Liters = 23 },
            new RainLog { Id = -2015, SeasonId = 101, Date = new DateTime(2022, 4, 2), Liters = 4 },
            new RainLog { Id = -2016, SeasonId = 101, Date = new DateTime(2022, 4, 9), Liters = 22 },
            new RainLog { Id = -2017, SeasonId = 101, Date = new DateTime(2022, 4, 16), Liters = 15 },
            new RainLog { Id = -2018, SeasonId = 101, Date = new DateTime(2022, 4, 23), Liters = 25 },
            new RainLog { Id = -2019, SeasonId = 101, Date = new DateTime(2022, 4, 27), Liters = 4 },
            new RainLog { Id = -2020, SeasonId = 101, Date = new DateTime(2022, 5, 4), Liters = 13 }
        );


        // Seed season 22/23
        modelBuilder.Entity<Season>().HasData(
            new Season { Id = 102, Name = "22/23" }
        );

        // Seed rain logs
        modelBuilder.Entity<RainLog>().HasData(
            new RainLog { Id = -3001, SeasonId = 102, Date = new DateTime(2022, 9, 14), Liters = 3 },
            new RainLog { Id = -3002, SeasonId = 102, Date = new DateTime(2022, 9, 30), Liters = 5 },
            new RainLog { Id = -3003, SeasonId = 102, Date = new DateTime(2022, 10, 11), Liters = 6 },
            new RainLog { Id = -3004, SeasonId = 102, Date = new DateTime(2022, 10, 21), Liters = 4 },
            new RainLog { Id = -3005, SeasonId = 102, Date = new DateTime(2022, 11, 17), Liters = 11 },
            new RainLog { Id = -3006, SeasonId = 102, Date = new DateTime(2022, 11, 18), Liters = 4 },
            new RainLog { Id = -3007, SeasonId = 102, Date = new DateTime(2022, 11, 24), Liters = 8 },
            new RainLog { Id = -3008, SeasonId = 102, Date = new DateTime(2022, 12, 10), Liters = 33 },
            new RainLog { Id = -3009, SeasonId = 102, Date = new DateTime(2022, 12, 14), Liters = 27 },
            new RainLog { Id = -3010, SeasonId = 102, Date = new DateTime(2022, 12, 15), Liters = 40 },
            new RainLog { Id = -3011, SeasonId = 102, Date = new DateTime(2022, 12, 16), Liters = 23 },
            new RainLog { Id = -3012, SeasonId = 102, Date = new DateTime(2023, 1, 3), Liters = 4 },
            new RainLog { Id = -3013, SeasonId = 102, Date = new DateTime(2023, 1, 8), Liters = 12 },
            new RainLog { Id = -3014, SeasonId = 102, Date = new DateTime(2023, 1, 18), Liters = 6 },
            new RainLog { Id = -3015, SeasonId = 102, Date = new DateTime(2023, 2, 7), Liters = 4 },
            new RainLog { Id = -3016, SeasonId = 102, Date = new DateTime(2023, 3, 6), Liters = 7 },
            new RainLog { Id = -3017, SeasonId = 102, Date = new DateTime(2023, 3, 9), Liters = 3 },
            new RainLog { Id = -3018, SeasonId = 102, Date = new DateTime(2023, 5, 20), Liters = 3 },
            new RainLog { Id = -3019, SeasonId = 102, Date = new DateTime(2023, 5, 22), Liters = 20 },
            new RainLog { Id = -3020, SeasonId = 102, Date = new DateTime(2023, 5, 23), Liters = 7 },
            new RainLog { Id = -3021, SeasonId = 102, Date = new DateTime(2023, 5, 27), Liters = 15 },
            new RainLog { Id = -3022, SeasonId = 102, Date = new DateTime(2023, 5, 29), Liters = 7 },
            new RainLog { Id = -3023, SeasonId = 102, Date = new DateTime(2023, 6, 4), Liters = 3 },
            new RainLog { Id = -3024, SeasonId = 102, Date = new DateTime(2023, 6, 8), Liters = 10 },
            new RainLog { Id = -3025, SeasonId = 102, Date = new DateTime(2023, 6, 19), Liters = 4 }
        );

        // Seed season 23/24
        modelBuilder.Entity<Season>().HasData(
            new Season { Id = 103, Name = "23/24" }
        );

        // Seed rain logs
        modelBuilder.Entity<RainLog>().HasData(
            new RainLog { Id = -4001, SeasonId = 103, Date = new DateTime(2023, 9, 3), Liters = 30 },
            new RainLog { Id = -4002, SeasonId = 103, Date = new DateTime(2023, 9, 15), Liters = 6 },
            new RainLog { Id = -4003, SeasonId = 103, Date = new DateTime(2023, 9, 18), Liters = 2 },
            new RainLog { Id = -4004, SeasonId = 103, Date = new DateTime(2023, 9, 22), Liters = 6 },
            new RainLog { Id = -4005, SeasonId = 103, Date = new DateTime(2023, 10, 14), Liters = 6 },
            new RainLog { Id = -4006, SeasonId = 103, Date = new DateTime(2023, 10, 18), Liters = 6 },
            new RainLog { Id = -4007, SeasonId = 103, Date = new DateTime(2023, 10, 20), Liters = 40 },
            new RainLog { Id = -4008, SeasonId = 103, Date = new DateTime(2023, 10, 23), Liters = 7 },
            new RainLog { Id = -4009, SeasonId = 103, Date = new DateTime(2023, 10, 24), Liters = 3 },
            new RainLog { Id = -4010, SeasonId = 103, Date = new DateTime(2023, 10, 25), Liters = 3 },
            new RainLog { Id = -4011, SeasonId = 103, Date = new DateTime(2023, 10, 27), Liters = 5 },
            new RainLog { Id = -4012, SeasonId = 103, Date = new DateTime(2023, 10, 30), Liters = 5 },
            new RainLog { Id = -4013, SeasonId = 103, Date = new DateTime(2023, 11, 2), Liters = 4 },
            new RainLog { Id = -4014, SeasonId = 103, Date = new DateTime(2023, 11, 4), Liters = 2 },
            new RainLog { Id = -4015, SeasonId = 103, Date = new DateTime(2023, 12, 1), Liters = 22 },
            new RainLog { Id = -4016, SeasonId = 103, Date = new DateTime(2023, 12, 6), Liters = 16 },
            new RainLog { Id = -4017, SeasonId = 103, Date = new DateTime(2023, 12, 7), Liters = 6 },
            new RainLog { Id = -4018, SeasonId = 103, Date = new DateTime(2023, 12, 9), Liters = 3 },
            new RainLog { Id = -4019, SeasonId = 103, Date = new DateTime(2024, 1, 5), Liters = 10 },
            new RainLog { Id = -4020, SeasonId = 103, Date = new DateTime(2024, 1, 10), Liters = 5 },
            new RainLog { Id = -4021, SeasonId = 103, Date = new DateTime(2024, 1, 19), Liters = 19 },
            new RainLog { Id = -4022, SeasonId = 103, Date = new DateTime(2024, 1, 20), Liters = 3 },
            new RainLog { Id = -4023, SeasonId = 103, Date = new DateTime(2024, 2, 9), Liters = 31 },
            new RainLog { Id = -4024, SeasonId = 103, Date = new DateTime(2024, 2, 10), Liters = 9 },
            new RainLog { Id = -4025, SeasonId = 103, Date = new DateTime(2024, 2, 12), Liters = 14 },
            new RainLog { Id = -4026, SeasonId = 103, Date = new DateTime(2024, 2, 16), Liters = 9 },
            new RainLog { Id = -4027, SeasonId = 103, Date = new DateTime(2024, 2, 26), Liters = 18 },
            new RainLog { Id = -4028, SeasonId = 103, Date = new DateTime(2024, 3, 2), Liters = 7 },
            new RainLog { Id = -4029, SeasonId = 103, Date = new DateTime(2024, 3, 8), Liters = 11 },
            new RainLog { Id = -4030, SeasonId = 103, Date = new DateTime(2024, 3, 9), Liters = 24 },
            new RainLog { Id = -4031, SeasonId = 103, Date = new DateTime(2024, 3, 10), Liters = 5 },
            new RainLog { Id = -4032, SeasonId = 103, Date = new DateTime(2024, 3, 21), Liters = 1 },
            new RainLog { Id = -4033, SeasonId = 103, Date = new DateTime(2024, 3, 25), Liters = 9 },
            new RainLog { Id = -4034, SeasonId = 103, Date = new DateTime(2024, 3, 26), Liters = 10 },
            new RainLog { Id = -4035, SeasonId = 103, Date = new DateTime(2024, 3, 27), Liters = 28 },
            new RainLog { Id = -4036, SeasonId = 103, Date = new DateTime(2024, 3, 29), Liters = 12 },
            new RainLog { Id = -4037, SeasonId = 103, Date = new DateTime(2024, 3, 30), Liters = 21 },
            new RainLog { Id = -4038, SeasonId = 103, Date = new DateTime(2024, 3, 31), Liters = 31 },
            new RainLog { Id = -4039, SeasonId = 103, Date = new DateTime(2024, 4, 1), Liters = 3 },
            new RainLog { Id = -4040, SeasonId = 103, Date = new DateTime(2024, 4, 20), Liters = 11 },
            new RainLog { Id = -4041, SeasonId = 103, Date = new DateTime(2024, 4, 27), Liters = 3 },
            new RainLog { Id = -4042, SeasonId = 103, Date = new DateTime(2024, 5, 1), Liters = 12 },
            new RainLog { Id = -4043, SeasonId = 103, Date = new DateTime(2024, 6, 27), Liters = 4 },
            new RainLog { Id = -4044, SeasonId = 103, Date = new DateTime(2024, 8, 29), Liters = 2 }
        );


        // Seed season 24/25
        modelBuilder.Entity<Season>().HasData(
            new Season { Id = 104, Name = "24/25" }
        );

        // Seed rain logs
        modelBuilder.Entity<RainLog>().HasData(
            new RainLog { Id = -5001, SeasonId = 104, Date = new DateTime(2024, 9, 7), Liters = 8 },
            new RainLog { Id = -5002, SeasonId = 104, Date = new DateTime(2024, 10, 8), Liters = 11 },
            new RainLog { Id = -5003, SeasonId = 104, Date = new DateTime(2024, 10, 1), Liters = 1 },
            new RainLog { Id = -5004, SeasonId = 104, Date = new DateTime(2024, 10, 12), Liters = 9 },
            new RainLog { Id = -5005, SeasonId = 104, Date = new DateTime(2024, 10, 13), Liters = 6 },
            new RainLog { Id = -5006, SeasonId = 104, Date = new DateTime(2024, 10, 14), Liters = 13 },
            new RainLog { Id = -5007, SeasonId = 104, Date = new DateTime(2024, 10, 16), Liters = 6 },
            new RainLog { Id = -5008, SeasonId = 104, Date = new DateTime(2024, 10, 26), Liters = 7 },
            new RainLog { Id = -5009, SeasonId = 104, Date = new DateTime(2024, 10, 29), Liters = 23 },
            new RainLog { Id = -5010, SeasonId = 104, Date = new DateTime(2024, 10, 30), Liters = 3 },
            new RainLog { Id = -5011, SeasonId = 104, Date = new DateTime(2024, 10, 31), Liters = 3 },
            new RainLog { Id = -5012, SeasonId = 104, Date = new DateTime(2024, 11, 13), Liters = 48 },
            new RainLog { Id = -5013, SeasonId = 104, Date = new DateTime(2024, 11, 25), Liters = 3 },
            new RainLog { Id = -5014, SeasonId = 104, Date = new DateTime(2025, 1, 6), Liters = 9 },
            new RainLog { Id = -5015, SeasonId = 104, Date = new DateTime(2025, 1, 20), Liters = 17 },
            new RainLog { Id = -5016, SeasonId = 104, Date = new DateTime(2025, 1, 25), Liters = 6 },
            new RainLog { Id = -5017, SeasonId = 104, Date = new DateTime(2025, 1, 27), Liters = 11 },
            new RainLog { Id = -5018, SeasonId = 104, Date = new DateTime(2025, 1, 28), Liters = 10 },
            new RainLog { Id = -5019, SeasonId = 104, Date = new DateTime(2025, 2, 3), Liters = 35 },
            new RainLog { Id = -5020, SeasonId = 104, Date = new DateTime(2025, 2, 22), Liters = 4 },
            new RainLog { Id = -5021, SeasonId = 104, Date = new DateTime(2025, 2, 28), Liters = 11 },
            new RainLog { Id = -5022, SeasonId = 104, Date = new DateTime(2025, 3, 1), Liters = 2 },
            new RainLog { Id = -5023, SeasonId = 104, Date = new DateTime(2025, 3, 3), Liters = 7 },
            new RainLog { Id = -5024, SeasonId = 104, Date = new DateTime(2025, 3, 6), Liters = 9 },
            new RainLog { Id = -5025, SeasonId = 104, Date = new DateTime(2025, 3, 8), Liters = 27 },
            new RainLog { Id = -5026, SeasonId = 104, Date = new DateTime(2025, 3, 9), Liters = 5 },
            new RainLog { Id = -5027, SeasonId = 104, Date = new DateTime(2025, 3, 10), Liters = 23 },
            new RainLog { Id = -5028, SeasonId = 104, Date = new DateTime(2025, 3, 11), Liters = 21 },
            new RainLog { Id = -5029, SeasonId = 104, Date = new DateTime(2025, 3, 12), Liters = 4 },
            new RainLog { Id = -5030, SeasonId = 104, Date = new DateTime(2025, 3, 14), Liters = 11 },
            new RainLog { Id = -5031, SeasonId = 104, Date = new DateTime(2025, 3, 16), Liters = 3 },
            new RainLog { Id = -5032, SeasonId = 104, Date = new DateTime(2025, 3, 17), Liters = 40 },
            new RainLog { Id = -5033, SeasonId = 104, Date = new DateTime(2025, 3, 18), Liters = 6 },
            new RainLog { Id = -5034, SeasonId = 104, Date = new DateTime(2025, 3, 20), Liters = 10 },
            new RainLog { Id = -5035, SeasonId = 104, Date = new DateTime(2025, 3, 21), Liters = 7 },
            new RainLog { Id = -5036, SeasonId = 104, Date = new DateTime(2025, 3, 23), Liters = 15 },
            new RainLog { Id = -5037, SeasonId = 104, Date = new DateTime(2025, 4, 3), Liters = 37 },
            new RainLog { Id = -5038, SeasonId = 104, Date = new DateTime(2025, 4, 4), Liters = 10 },
            new RainLog { Id = -5039, SeasonId = 104, Date = new DateTime(2025, 4, 14), Liters = 4 },
            new RainLog { Id = -5040, SeasonId = 104, Date = new DateTime(2025, 4, 15), Liters = 17 },
            new RainLog { Id = -5041, SeasonId = 104, Date = new DateTime(2025, 5, 2), Liters = 18 },
            new RainLog { Id = -5042, SeasonId = 104, Date = new DateTime(2025, 5, 3), Liters = 3 },
            new RainLog { Id = -5043, SeasonId = 104, Date = new DateTime(2025, 5, 24), Liters = 18 }
        );


        // Seed season 25/26
        modelBuilder.Entity<Season>().HasData(
            new Season { Id = 105, Name = "25/26" }
        );

        // Seed rain logs
        modelBuilder.Entity<RainLog>().HasData(
            new RainLog { Id = -6001, SeasonId = 105, Date = new DateTime(2025, 9, 29), Liters = 1 },
            new RainLog { Id = -6002, SeasonId = 105, Date = new DateTime(2025, 10, 10), Liters = 5 },
            new RainLog { Id = -6003, SeasonId = 105, Date = new DateTime(2025, 10, 18), Liters = 3 },
            new RainLog { Id = -6004, SeasonId = 105, Date = new DateTime(2025, 10, 26), Liters = 6 },
            new RainLog { Id = -6005, SeasonId = 105, Date = new DateTime(2025, 10, 29), Liters = 40 },
            new RainLog { Id = -6006, SeasonId = 105, Date = new DateTime(2025, 11, 6), Liters = 3 },
            new RainLog { Id = -6007, SeasonId = 105, Date = new DateTime(2025, 11, 8), Liters = 2 },
            new RainLog { Id = -6008, SeasonId = 105, Date = new DateTime(2025, 11, 13), Liters = 21 },
            new RainLog { Id = -6009, SeasonId = 105, Date = new DateTime(2025, 11, 14), Liters = 18 },
            new RainLog { Id = -6010, SeasonId = 105, Date = new DateTime(2025, 11, 15), Liters = 25 },
            new RainLog { Id = -6011, SeasonId = 105, Date = new DateTime(2025, 11, 16), Liters = 15 },
            new RainLog { Id = -6012, SeasonId = 105, Date = new DateTime(2025, 11, 17), Liters = 22 },
            new RainLog { Id = -6013, SeasonId = 105, Date = new DateTime(2025, 12, 2), Liters = 15 },
            new RainLog { Id = -6014, SeasonId = 105, Date = new DateTime(2025, 12, 5), Liters = 6 },
            new RainLog { Id = -6015, SeasonId = 105, Date = new DateTime(2025, 12, 8), Liters = 2 },
            new RainLog { Id = -6016, SeasonId = 105, Date = new DateTime(2025, 12, 16), Liters = 21 },
            new RainLog { Id = -6017, SeasonId = 105, Date = new DateTime(2025, 12, 22), Liters = 25 },
            new RainLog { Id = -6018, SeasonId = 105, Date = new DateTime(2025, 12, 23), Liters = 12 },
            new RainLog { Id = -6019, SeasonId = 105, Date = new DateTime(2025, 12, 28), Liters = 7 },
            new RainLog { Id = -6020, SeasonId = 105, Date = new DateTime(2026, 1, 4), Liters = 8 },
            new RainLog { Id = -6021, SeasonId = 105, Date = new DateTime(2026, 1, 5), Liters = 8 },
            new RainLog { Id = -6022, SeasonId = 105, Date = new DateTime(2026, 1, 14), Liters = 2 },
            new RainLog { Id = -6023, SeasonId = 105, Date = new DateTime(2026, 1, 16), Liters = 5 },
            new RainLog { Id = -6024, SeasonId = 105, Date = new DateTime(2026, 1, 21), Liters = 10 },
            new RainLog { Id = -6025, SeasonId = 105, Date = new DateTime(2026, 1, 22), Liters = 18 },
            new RainLog { Id = -6026, SeasonId = 105, Date = new DateTime(2026, 1, 23), Liters = 18 },
            new RainLog { Id = -6027, SeasonId = 105, Date = new DateTime(2026, 1, 25), Liters = 14 },
            new RainLog { Id = -6028, SeasonId = 105, Date = new DateTime(2026, 1, 26), Liters = 10 },
            new RainLog { Id = -6029, SeasonId = 105, Date = new DateTime(2026, 1, 27), Liters = 41 },
            new RainLog { Id = -6030, SeasonId = 105, Date = new DateTime(2026, 1, 28), Liters = 26 },
            new RainLog { Id = -6031, SeasonId = 105, Date = new DateTime(2026, 1, 29), Liters = 9 },
            new RainLog { Id = -6032, SeasonId = 105, Date = new DateTime(2026, 1, 30), Liters = 2 },
            new RainLog { Id = -6033, SeasonId = 105, Date = new DateTime(2026, 2, 2), Liters = 10 },
            new RainLog { Id = -6034, SeasonId = 105, Date = new DateTime(2026, 2, 4), Liters = 50 },
            new RainLog { Id = -6035, SeasonId = 105, Date = new DateTime(2026, 2, 5), Liters = 6 },
            new RainLog { Id = -6036, SeasonId = 105, Date = new DateTime(2026, 2, 6), Liters = 16 },
            new RainLog { Id = -6037, SeasonId = 105, Date = new DateTime(2026, 2, 7), Liters = 25 },
            new RainLog { Id = -6038, SeasonId = 105, Date = new DateTime(2026, 2, 8), Liters = 6 },
            new RainLog { Id = -6039, SeasonId = 105, Date = new DateTime(2026, 2, 9), Liters = 3 },
            new RainLog { Id = -6040, SeasonId = 105, Date = new DateTime(2026, 2, 10), Liters = 3 },
            new RainLog { Id = -6041, SeasonId = 105, Date = new DateTime(2026, 2, 11), Liters = 8 },
            new RainLog { Id = -6042, SeasonId = 105, Date = new DateTime(2026, 2, 13), Liters = 11 },
            new RainLog { Id = -6043, SeasonId = 105, Date = new DateTime(2026, 3, 4), Liters = 11 },
            new RainLog { Id = -6044, SeasonId = 105, Date = new DateTime(2026, 3, 7), Liters = 7 },
            new RainLog { Id = -6045, SeasonId = 105, Date = new DateTime(2026, 3, 9), Liters = 28 },
            new RainLog { Id = -6046, SeasonId = 105, Date = new DateTime(2026, 3, 20), Liters = 7 },
            new RainLog { Id = -6047, SeasonId = 105, Date = new DateTime(2026, 4, 8), Liters = 45 },
            new RainLog { Id = -6048, SeasonId = 105, Date = new DateTime(2026, 4, 11), Liters = 11 },
            new RainLog { Id = -6049, SeasonId = 105, Date = new DateTime(2026, 5, 9), Liters = 2 },
            new RainLog { Id = -6050, SeasonId = 105, Date = new DateTime(2026, 5, 10), Liters = 13 }
        );
    }
}