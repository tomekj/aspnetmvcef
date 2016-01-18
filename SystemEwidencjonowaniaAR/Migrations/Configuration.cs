namespace SystemEwidencjonowaniaAR.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SystemEwidencjonowaniaAR.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SystemEwidencjonowaniaAR.Models.ApplicationDbContext context)
        {
            var items = new List<Item>
            {
            new Item {ID=10001000,CategoryID=1,Nazwa="Alsen i7 4GB nVidia 8100",Producent="Alsen",Model="Model~1",Opis="Komputer stacjonarny. Fikcyjny",NrSeryjny="DS18-01-16/22",NrInw="4-491-001",Status="wolny",DataWrpowadzenia=DateTime.Parse("2002-09-01") },
            new Item {ID=10001001,CategoryID=1,Nazwa="Alsen i7 4GB nVidia 8100",Producent="Alsen",Model="Model~1",Opis="Komputer stacjonarny. Fikcyjny",NrSeryjny="DS18-01-16/22",NrInw="4-491-001",Status="wolny",DataWrpowadzenia=DateTime.Parse("2002-09-01") },
            new Item {ID=10001002,CategoryID=2,Nazwa="Lenovo Edge E5400",Producent="Lenovo",Model="Model~1",Opis="Komputer stacjonarny. Fikcyjny",NrSeryjny="DS18-01-16/22",NrInw="4-491-001",Status="wolny",DataWrpowadzenia=DateTime.Parse("2002-09-01") },
            new Item {ID=10001003,CategoryID=2,Nazwa="Lenovo ThinkPad B551",Producent="Lenovo",Model="Model~1",Opis="Komputer stacjonarny. Fikcyjny",NrSeryjny="DS18-01-16/22",NrInw="4-491-001",Status="wolny",DataWrpowadzenia=DateTime.Parse("2002-09-01") },
            new Item {ID=10001004,CategoryID=3,Nazwa="Nokia 3310",Producent="Nokia",Model="3310",Opis="Telefon komórkowy - stary",NrSeryjny="350990104976574",NrInw="4-491-101",Status="wolny",DataWrpowadzenia=DateTime.Parse("2012-09-01") }
            };
        }
    }
}
