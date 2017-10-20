namespace SkiWorld.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        idCategory = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        fk_Shop = c.Int(),
                        shop_idShop = c.Int(),
                    })
                .PrimaryKey(t => t.idCategory)
                .ForeignKey("dbo.shops", t => t.shop_idShop)
                .Index(t => t.shop_idShop);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        idProduct = c.Int(nullable: false, identity: true),
                        isAvailable = c.Boolean(nullable: false),
                        name = c.String(unicode: false),
                        price = c.Single(nullable: false),
                        quantity = c.Int(nullable: false),
                        idCategory = c.Int(),
                    })
                .PrimaryKey(t => t.idProduct)
                .ForeignKey("dbo.categories", t => t.idCategory)
                .Index(t => t.idCategory);
            
            CreateTable(
                "dbo.purchasedetails",
                c => new
                    {
                        id_product = c.Int(nullable: false),
                        id_user = c.Int(nullable: false),
                        purchaseDate = c.DateTime(nullable: false, precision: 0),
                        quantity = c.Int(nullable: false),
                        product_idProduct = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.id_product, t.id_user })
                .ForeignKey("dbo.products", t => t.product_idProduct)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.product_idProduct)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Status = c.String(unicode: false),
                        adress = c.String(unicode: false),
                        file = c.String(unicode: false),
                        cin = c.String(unicode: false),
                        firstName = c.String(unicode: false),
                        lastName = c.String(unicode: false),
                        login = c.String(unicode: false),
                        phone = c.String(unicode: false),
                        experienceRes = c.Int(),
                        profilePicture = c.String(unicode: false),
                        VIP = c.Boolean(),
                        creditCardNumber = c.String(unicode: false),
                        numberVisits = c.Int(),
                        registrationNumbe = c.String(unicode: false),
                        age = c.Int(nullable: false),
                        experiencePlayer = c.Int(),
                        type = c.Int(),
                        experienceEvent = c.Int(),
                        registrationNumberEvent = c.String(unicode: false),
                        experienceIns = c.Int(),
                        evenement_idEvent = c.Int(),
                        Email = c.String(maxLength: 255, storeType: "nvarchar"),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(unicode: false),
                        SecurityStamp = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 0),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        ExperienceWorker = c.String(unicode: false),
                        Speciality = c.String(unicode: false),
                        RegistrationNumber = c.String(unicode: false),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.claims",
                c => new
                    {
                        idClaim = c.Int(nullable: false, identity: true),
                        description = c.String(unicode: false),
                        typeClaim = c.String(unicode: false),
                        user_idUser = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idClaim)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ClaimType = c.String(unicode: false),
                        ClaimValue = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.evenements",
                c => new
                    {
                        idEvent = c.Int(nullable: false, identity: true),
                        dateEvent = c.DateTime(nullable: false, precision: 0),
                        name = c.String(unicode: false),
                        numberGuests = c.Int(nullable: false),
                        place = c.String(unicode: false),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idEvent);
            
            CreateTable(
                "dbo.galleries",
                c => new
                    {
                        idGallery = c.Int(nullable: false, identity: true),
                        addedDate = c.DateTime(precision: 0),
                        description = c.String(unicode: false),
                        video = c.String(unicode: false),
                        picture = c.String(unicode: false),
                        user_idUser = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idGallery)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ProviderKey = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.menus",
                c => new
                    {
                        idMenu = c.Int(nullable: false, identity: true),
                        available = c.Boolean(nullable: false),
                        name = c.String(unicode: false),
                        orderNumber = c.Int(nullable: false),
                        price = c.Single(nullable: false),
                        user_idUser = c.Int(),
                        idRestaurant = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idMenu)
                .ForeignKey("dbo.restaurants", t => t.idRestaurant)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.idRestaurant)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.restaurants",
                c => new
                    {
                        idRestaurant = c.Int(nullable: false, identity: true),
                        closeDate = c.DateTime(nullable: false, precision: 0),
                        location = c.String(unicode: false),
                        name = c.String(unicode: false),
                        openDate = c.DateTime(nullable: false, precision: 0),
                        phone = c.String(unicode: false),
                        starRating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idRestaurant);
            
            CreateTable(
                "dbo.restotables",
                c => new
                    {
                        idTable = c.Int(nullable: false, identity: true),
                        available = c.Boolean(nullable: false),
                        chairsNumber = c.Int(nullable: false),
                        tablesNumber = c.Int(nullable: false),
                        restaurant_idRestaurant = c.Int(),
                        user_idUser = c.Int(),
                        restaurant_idRestaurant1 = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idTable)
                .ForeignKey("dbo.restaurants", t => t.restaurant_idRestaurant1)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.restaurant_idRestaurant1)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.restotablereservations",
                c => new
                    {
                        id_table = c.Int(nullable: false),
                        id_user = c.Int(nullable: false),
                        endTime = c.DateTime(nullable: false, precision: 0),
                        startTime = c.DateTime(nullable: false, precision: 0),
                        restotable_idTable = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.id_table, t.id_user })
                .ForeignKey("dbo.restotables", t => t.restotable_idTable)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.restotable_idTable)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.parkingreservations",
                c => new
                    {
                        id_parking = c.Int(nullable: false),
                        id_user = c.Int(nullable: false),
                        dateArrival = c.DateTime(nullable: false, precision: 0),
                        dateDeparture = c.DateTime(nullable: false, precision: 0),
                        price = c.Single(nullable: false),
                        parking_idParking = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.id_parking, t.id_user })
                .ForeignKey("dbo.parkings", t => t.parking_idParking)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.parking_idParking)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.parkings",
                c => new
                    {
                        idParking = c.Int(nullable: false, identity: true),
                        placeNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idParking);
            
            CreateTable(
                "dbo.planings",
                c => new
                    {
                        idPlaning = c.Int(nullable: false, identity: true),
                        date = c.DateTime(precision: 0),
                        description = c.String(unicode: false),
                        name = c.String(unicode: false),
                        instructor_idUser = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idPlaning)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        RoleId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.roomreservations",
                c => new
                    {
                        id_room = c.Int(nullable: false),
                        id_user = c.Int(nullable: false),
                        arrivalDate = c.DateTime(nullable: false, precision: 0),
                        departureDate = c.DateTime(nullable: false, precision: 0),
                        isCheck = c.Boolean(nullable: false),
                        price = c.Single(nullable: false),
                        roomReservationType = c.Int(),
                        room_idRoom = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.id_room, t.id_user })
                .ForeignKey("dbo.rooms", t => t.room_idRoom)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.room_idRoom)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.rooms",
                c => new
                    {
                        idRoom = c.Int(nullable: false, identity: true),
                        numberRoom = c.Int(nullable: false),
                        roomType = c.Int(),
                        hotel_idHotel = c.Int(),
                        hotel_idHotel1 = c.Int(),
                    })
                .PrimaryKey(t => t.idRoom)
                .ForeignKey("dbo.hotels", t => t.hotel_idHotel1)
                .Index(t => t.hotel_idHotel1);
            
            CreateTable(
                "dbo.hotels",
                c => new
                    {
                        idHotel = c.Int(nullable: false, identity: true),
                        address = c.String(unicode: false),
                        email = c.String(unicode: false),
                        name = c.String(unicode: false),
                        phone = c.Int(nullable: false),
                        rating = c.Single(nullable: false),
                        stars = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idHotel);
            
            CreateTable(
                "dbo.skiareareservations",
                c => new
                    {
                        id_skiArea = c.Int(nullable: false),
                        id_user = c.Int(nullable: false),
                        reservationDate = c.DateTime(nullable: false, precision: 0),
                        skiarea_idArea = c.Int(),
                        user_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.id_skiArea, t.id_user })
                .ForeignKey("dbo.skiareas", t => t.skiarea_idArea)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.skiarea_idArea)
                .Index(t => t.user_Id);
            
            CreateTable(
                "dbo.skiareas",
                c => new
                    {
                        idArea = c.Int(nullable: false, identity: true),
                        address = c.String(unicode: false),
                        available = c.Boolean(nullable: false),
                        image = c.String(unicode: false),
                        name = c.String(unicode: false),
                        spectatorNumber = c.Int(nullable: false),
                        skiAreaType_idType = c.Int(),
                        skiareatyp_idType = c.Int(),
                    })
                .PrimaryKey(t => t.idArea)
                .ForeignKey("dbo.skiareatypes", t => t.skiareatyp_idType)
                .Index(t => t.skiareatyp_idType);
            
            CreateTable(
                "dbo.skiareatypes",
                c => new
                    {
                        idType = c.Int(nullable: false, identity: true),
                        difficulty = c.Int(),
                        typeArea = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idType);
            
            CreateTable(
                "dbo.shops",
                c => new
                    {
                        idShop = c.Int(nullable: false, identity: true),
                        closeDate = c.DateTime(precision: 0),
                        email = c.String(unicode: false),
                        name = c.String(unicode: false),
                        openDate = c.DateTime(precision: 0),
                        phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idShop);
            
            CreateTable(
                "dbo.competitions",
                c => new
                    {
                        idComp = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        place = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idComp);
            
            CreateTable(
                "dbo.matches",
                c => new
                    {
                        idMatch = c.Int(nullable: false, identity: true),
                        player1 = c.String(unicode: false),
                        player2 = c.String(unicode: false),
                        dateMatch = c.DateTime(nullable: false, precision: 0),
                        idComp = c.Int(),
                    })
                .PrimaryKey(t => t.idMatch)
                .ForeignKey("dbo.competitions", t => t.idComp)
                .Index(t => t.idComp);
            
            CreateTable(
                "dbo.opportunities",
                c => new
                    {
                        idOpportunity = c.Int(nullable: false, identity: true),
                        description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idOpportunity);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.evenementusers",
                c => new
                    {
                        evenement_idEvent = c.Int(nullable: false),
                        user_Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.evenement_idEvent, t.user_Id })
                .ForeignKey("dbo.evenements", t => t.evenement_idEvent, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id, cascadeDelete: true)
                .Index(t => t.evenement_idEvent)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.matches", "idComp", "dbo.competitions");
            DropForeignKey("dbo.categories", "shop_idShop", "dbo.shops");
            DropForeignKey("dbo.skiareareservations", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.skiareas", "skiareatyp_idType", "dbo.skiareatypes");
            DropForeignKey("dbo.skiareareservations", "skiarea_idArea", "dbo.skiareas");
            DropForeignKey("dbo.roomreservations", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.roomreservations", "room_idRoom", "dbo.rooms");
            DropForeignKey("dbo.rooms", "hotel_idHotel1", "dbo.hotels");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.purchasedetails", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.planings", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.parkingreservations", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.parkingreservations", "parking_idParking", "dbo.parkings");
            DropForeignKey("dbo.menus", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.restotables", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.restotablereservations", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.restotablereservations", "restotable_idTable", "dbo.restotables");
            DropForeignKey("dbo.restotables", "restaurant_idRestaurant1", "dbo.restaurants");
            DropForeignKey("dbo.menus", "idRestaurant", "dbo.restaurants");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.galleries", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.evenementusers", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.evenementusers", "evenement_idEvent", "dbo.evenements");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.claims", "user_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.purchasedetails", "product_idProduct", "dbo.products");
            DropForeignKey("dbo.products", "idCategory", "dbo.categories");
            DropIndex("dbo.evenementusers", new[] { "user_Id" });
            DropIndex("dbo.evenementusers", new[] { "evenement_idEvent" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.matches", new[] { "idComp" });
            DropIndex("dbo.skiareas", new[] { "skiareatyp_idType" });
            DropIndex("dbo.skiareareservations", new[] { "user_Id" });
            DropIndex("dbo.skiareareservations", new[] { "skiarea_idArea" });
            DropIndex("dbo.rooms", new[] { "hotel_idHotel1" });
            DropIndex("dbo.roomreservations", new[] { "user_Id" });
            DropIndex("dbo.roomreservations", new[] { "room_idRoom" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.planings", new[] { "user_Id" });
            DropIndex("dbo.parkingreservations", new[] { "user_Id" });
            DropIndex("dbo.parkingreservations", new[] { "parking_idParking" });
            DropIndex("dbo.restotablereservations", new[] { "user_Id" });
            DropIndex("dbo.restotablereservations", new[] { "restotable_idTable" });
            DropIndex("dbo.restotables", new[] { "user_Id" });
            DropIndex("dbo.restotables", new[] { "restaurant_idRestaurant1" });
            DropIndex("dbo.menus", new[] { "user_Id" });
            DropIndex("dbo.menus", new[] { "idRestaurant" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.galleries", new[] { "user_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.claims", new[] { "user_Id" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.purchasedetails", new[] { "user_Id" });
            DropIndex("dbo.purchasedetails", new[] { "product_idProduct" });
            DropIndex("dbo.products", new[] { "idCategory" });
            DropIndex("dbo.categories", new[] { "shop_idShop" });
            DropTable("dbo.evenementusers");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.opportunities");
            DropTable("dbo.matches");
            DropTable("dbo.competitions");
            DropTable("dbo.shops");
            DropTable("dbo.skiareatypes");
            DropTable("dbo.skiareas");
            DropTable("dbo.skiareareservations");
            DropTable("dbo.hotels");
            DropTable("dbo.rooms");
            DropTable("dbo.roomreservations");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.planings");
            DropTable("dbo.parkings");
            DropTable("dbo.parkingreservations");
            DropTable("dbo.restotablereservations");
            DropTable("dbo.restotables");
            DropTable("dbo.restaurants");
            DropTable("dbo.menus");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.galleries");
            DropTable("dbo.evenements");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.claims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.purchasedetails");
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}
