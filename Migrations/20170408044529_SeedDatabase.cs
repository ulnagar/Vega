using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Ford');");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Holden');");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota');");

            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Bronco')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Corsair')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Falcon')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Fairlane')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Fairmont')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Futura')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Maverick')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Meteor')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Landau')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Laser')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Telstar')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Ford'), 'Territory')");

            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Adventura')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Apollo')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Astra')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Barina')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Belmont')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Berlina')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Brougham')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Business')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Calais')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Calibra')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Camira')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Caprice')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Captiva')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Cascada')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Colorado')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Combo')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Commodore')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Crewman')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Cruze')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Drover')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Epica')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Frontera')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Gemini')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'GTS')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Jackaroo')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Kingswood')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Limited Edition')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Malibu')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Monaro')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Monterey')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Nova')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'One Tonner')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Piazza')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Premier')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Rodeo')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Scurry')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Shuttle')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Special')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Standard')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Statesman')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Suburban')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Sunbird')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Tigra')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Torana')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Ute')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Vectra')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Viva')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Holden'), 'Zafira')");

            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Aurion')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Camry')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Corolla')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Prius')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Tarago')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Pruis V')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Prius C')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Yaris')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), '86')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Fortuner')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Kluger')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Land Cruiser 200')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Land Cruiser Prado')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'RAV4')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Coaster')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Hiace')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Hilux')");
            migrationBuilder.Sql("INSERT INTO Models (MakeId, Name) VALUES ((SELECT Id FROM Makes WHERE Name = 'Toyota'), 'Land Cruiser 78')");
            
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Emergency Braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Higher Speed Auto Emergency Braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Pedestrian Auto Emergency Braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Electronic Stability Control')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Driver Attention Detection')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Thorax Airbags with Head')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Antilock Braking System')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Adjustable Steering Column')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Daytime Running Lights')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Fog Lamps')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Front Airbags Passenger')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Headup Display')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Passenger Knee Airbag')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Reversing Camera')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Seatbelt Pretensioner')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Tyre Pressure Monitor')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Forward Collision Warning')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Low Speed Auto Emergency Braking')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Active Braking Systems')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Curtain Airbags')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Intelligent Speed Assist')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Active Cruise Control')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Traction Control')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Brake Assist System')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Blindspot Warning System')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Drivers Knee Airbag')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Front Airbags Driver')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Head Restraints All')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Lanekeeping Assist')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Precrash Safety System')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Seatbelt Rear 3 Point')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
            migrationBuilder.Sql("DELETE FROM Models");
            migrationBuilder.Sql("DELETE FROM Features");
        }
    }
}
