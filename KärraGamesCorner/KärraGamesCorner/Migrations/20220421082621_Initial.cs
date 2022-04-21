using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPhysical = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderOfDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameToken = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Token_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Token_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => new { x.ApplicationUserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CartProduct_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProduct_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c34bf244-0174-4d78-8996-17da8bb59119", "c34bf244-0174-4d78-8996-17da8bb59119", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProductId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7ede46ae-1952-4ff1-bd77-f497ccb3fad1", 0, "fc8e4d90-0543-410c-8cda-a8d8e4d0c79a", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGhwJoY7acsVOR9LdnA0r2dNNQ4P33ctf3LfTz6tUScarbwNjwFfqxu4PViFpiCjZA==", null, false, null, "fc86aad0-c687-4614-b262-0e0064d7ce35", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rollspel" },
                    { 2, "Pussel" },
                    { 3, "Sällskapsspel" },
                    { 4, "Actionrollspel" },
                    { 5, "Kortspel" },
                    { 6, "Skräck" },
                    { 7, "Äventyr" },
                    { 8, "Strategi" },
                    { 9, "FPS" },
                    { 10, "Överlevnad" },
                    { 11, "MMORPG" },
                    { 12, "Racing" },
                    { 13, "Simulator" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "IsPhysical", "Name", "Price", "Producer" },
                values: new object[,]
                {
                    { 51, "Huntsman med analoga och optiska switchar", null, "/Resources/Images/Products/All_Images/Product_51.jpg", true, "Razer Huntsman V2 Analog", 2990m, "Razor" },
                    { 52, "Trådlös mus med utbytbar sidopanel", null, "/Resources/Images/Products/All_Images/Product_52.jpg", true, "Razer Naga Pro MOBA/MMO", 1749m, "Razor" },
                    { 53, "Musmatta med RGB-belysning", null, "/Resources/Images/Products/All_Images/Product_53.jpg", true, "Razer Firefly V2", 649m, "Razor" },
                    { 54, "Trådlöst haptiskt spelheadset för ultimat spelinlevelse", null, "/Resources/Images/Products/All_Images/Product_54.jpg", true, "Razer Kraken V3 Pro", 2199m, "Razor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c34bf244-0174-4d78-8996-17da8bb59119", "7ede46ae-1952-4ff1-bd77-f497ccb3fad1" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "IsPhysical", "Name", "Price", "Producer" },
                values: new object[,]
                {
                    { 1, "Battlefield 2042 är en förstapersonsskjutare som återvänder till seriens ikoniska totala krigföring.", 9, "/Resources/Images/Products/All_Images/Product_1.png", false, "Battlefield 2042", 500m, "EA DICE" },
                    { 2, "Skapa din egen gård och låt glädjen växa fram!", 13, "/Resources/Images/Products/All_Images/Product_2.png", false, "Farming Simulator 22", 300m, "Giants Software" },
                    { 3, "Frakta gods med din lastbil runt om i europa.", 13, "/Resources/Images/Products/All_Images/Product_3.jpg", false, "Euro Truck Simulator 2", 100m, "SCS Software" },
                    { 4, "Hur länge överlever du i en postapokalyptisk värld? I ett land översvämmat av infekterade “zombier”, där du konkurrerar med andra överlevare om tunnsådda resurser.", 10, "/Resources/Images/Products/All_Images/Product_4.jpg", false, "DayZ", 300m, "Bohemia Interactive" },
                    { 5, "Var delaktig i ett stort äventyr tillsammans med människor från hela världen.", 11, "/Resources/Images/Products/All_Images/Product_5.jpg", false, "Final Fantasy XIV Online", 100m, "Square Enix" },
                    { 6, "Lag Spel", 9, "/Resources/Images/Products/All_Images/Product_6.png", false, "Counter Strike", 200m, "Valve" },
                    { 7, "Stig upp,Tarnished, och låt försynen leda dig att använda kraften hos elden ring och bli Elden Lord i Lands Between.", 4, "/Resources/Images/Products/All_Images/Product_7.png", false, "Elden Ring", 600m, "From Software" },
                    { 8, "Tokyos befolkning är försvunnen, och dödliga övernaturliga krafter stryker runt på gatorna.Med din arsenal av elementärkrafter är det bara du som kan uppdaga sanningen och rädda Tokyo", 4, "/Resources/Images/Products/All_Images/Product_8.jpg", false, "Ghostwire Tokyo", 600m, "Bethesda Softworks" },
                    { 9, "Spyro är eld och lågor över att vara tillbaka i Spyro Reignited Trilogy,nu snyggare än någonsin i otrolig HD!Gå tillbaka till din gamla flamma i remastrade versioner av de tre ursprungliga spelen: Spyro the dragon, Spyro2:Ripto’s Rage! och Spyro:Year of the Dragon.", 7, "/Resources/Images/Products/All_Images/Product_9.png", false, "Spyro Reignited Trilogy", 400m, "Activision" },
                    { 10, "Det här är den autentiska CTR-upplevelsen plus mycket mer - helt remastrad och nitroboostad till max: Dra igång motorn med originalets spellägen, karaktärer, banor, boostar, vapen och kontroller. Slira hela vägen till seger med nya gokarter, banor och arenor från Crash™ Nitro Kart.", 12, "/Resources/Images/Products/All_Images/Product_10.jpg", false, "Crash Team Racing Nitro-Fueled", 400m, "Activision" },
                    { 11, "Här kan använda sin egna fantasi för att bygga och skapa nya världar.", 7, "/Resources/Images/Products/All_Images/Product_11.png", false, "MineCraft", 499m, "Mojang" },
                    { 12, "Spela det orginella harpanspelet med en twist nu finns det ännu mer kort", 5, "/Resources/Images/Products/All_Images/Product_12.jpg", false, "Spindelharpan", 99m, "Microsoft" },
                    { 13, "No Man's Sky är ett spel om utforskning och överlevnad i ett oändligt procedurgenererat universum.", 7, "/Resources/Images/Products/All_Images/Product_13.jpg", false, "No Man's Sky", 550m, "Hello Games" },
                    { 14, "Jobba tillsammans med alla andra för att ta reda på vem som är förrädaren i gruppen genom slutledningsförmåga", 3, "/Resources/Images/Products/All_Images/Product_14.png", false, "Among Us", 349m, "Innersloth" },
                    { 15, "Ta dig an utmanande boss-strider och skryt för dina vänner när du klarat av dom.", 4, "/Resources/Images/Products/All_Images/Product_15.png", false, "Dark Souls", 599m, "From Software" },
                    { 16, "Använda dina trupper för att ta över världens nationer genom strategi och paktning", 8, "/Resources/Images/Products/All_Images/Product_16.jpg", false, "Total War: THREE KINGDOMS", 399m, "Sega" },
                    { 17, "Använd geometri för att placera de fallande formerna på det mest optimala sätt och samla poäng", 2, "/Resources/Images/Products/All_Images/Product_17.jpg", false, "Tetris", 49m, "The Tetris Company" },
                    { 18, "Civilization är ett turbaserat strategispel som går ut på att bygga ett imperium som står sig genom tiderna.", 8, "/Resources/Images/Products/All_Images/Product_18.jpg", false, "Civilization VI", 600m, "2K" },
                    { 19, "Utforska ett öppet Mexiko som ständigt utvecklas, med gränslös och rolig körning i hundratals av världens bästa bilar.", 12, "/Resources/Images/Products/All_Images/Product_19.jpg", false, "Forza Horizon 5", 599m, "Xbox Game Studios" },
                    { 20, "Kör race, uppgradera och anpassa varenda bil i den största GRID-uppställningen någonsin, från klassiska touringbilar till ensitsbilar och stora kärror.", 12, "/Resources/Images/Products/All_Images/Product_20.jpg", false, "Grid Legends", 449m, "Electronic Arts" },
                    { 21, "RIDE 4 tar fram vinnarskallen i dig med hundratals motorcyklar, dussintals banor och realism på en helt ny nivå.", 12, "/Resources/Images/Products/All_Images/Product_21.png", false, "Ride 4", 599m, "Milestone S.r.l" },
                    { 22, "Jobba hårt om dagarna och riskera allt under natthimlen. Need for Speed Heat är ett nervkittlande streetrace-spel där lagar och regler suddas ut när solen går ner.", 12, "/Resources/Images/Products/All_Images/Product_22.png", false, "Need for speed", 599m, "Electronic Arts" },
                    { 23, "Känn spänningen i jakten och adrenalinrushen i flykten i The Crew 2.", 12, "/Resources/Images/Products/All_Images/Product_23.png", false, "The Crew 2", 299m, "Ubisoft" },
                    { 24, "Starta motorerna: Sätt igång den mest autentiska säsongen av MotoGP som någonsin skapats!", 12, "/Resources/Images/Products/All_Images/Product_24.png", false, "MotoGP22", 599m, "Milestone S.r.l" },
                    { 25, "Dead by Daylight är ett skräckspel för flera spelare (4vs1) där en spelare tar på sig rollen som den vilde mördaren, och de andra fyra spelarna spelar som överlevare och försöker fly mördaren och undvika att bli fångad och dödad.", 6, "/Resources/Images/Products/All_Images/Product_25.png", false, "Dead by Daylight", 200m, "Behaviour Interactive Inc." },
                    { 26, "Ett brutalt överlevnadsspel för 1-10 spelare, som utspelar sig i en processuellt genererad värld inspirerad av vikingakulturen.", 10, "/Resources/Images/Products/All_Images/Product_26.jpg", false, "Valheim", 180m, "Iron Gate" },
                    { 27, "Cyberpunk är ett actionfyllt öppen-värld rollspel där du kan utföra uppdrag och röra dig runt i den futuristiska staden 'Night City'. Forma historien genom de val du gör och se handlingen utvecklas.", 4, "/Resources/Images/Products/All_Images/Product_27.jpg", false, "Cyberpunk 2077", 630m, "CD PROJEKT RED" },
                    { 28, "Kampen mellan de goda och onda har redan avgjorts - härskaren Kyros har vunnit, och håller nu på att lägga de sista provinserna under sitt styre. Du är en “Fatebinder”, i Kyros tjänst. Spela en avgörande roll för hur handlingen utvecklar sig samt välj vilken sida du allierar dig med.", 1, "/Resources/Images/Products/All_Images/Product_28.jpg", false, "Tyranny", 300m, "Paradox Interactive" },
                    { 29, "Spela antingen ensam med två karaktärer du själv skapar eller spela med en vän som spelar den ena karaktären. Utforska en spännande fantasy-värld som ett par “source-hunters”, med ett uppdrag som börjar med att utforska ett mord. Under spelets gång kommer du stöta på många spännande karaktärer, vilka du kan rekrytera till din grupp av hjältar. Världens öde ligger i dina händer.", 1, "/Resources/Images/Products/All_Images/Product_29.png", false, "Divinity: Original Sin - Enhanced Edition", 430m, "Paradox Interactive" },
                    { 30, "Du är Shepard, medlem i den mänskliga rymdflottan. Du håller på at scoutas som en potentiell Spectre, en agent för alliansen av olika raser av folkslag som befolkar vår galax, exempelvis salarians, krogans, asari och människor. Mänskligheten håller på att göra framsteg på det galaktiska planet och nu har du möjligheten att bli en av rådets agenter, mycket prestigefyllt. Men saker går inte som förväntat, och snart måste du som Spectre jaga runt i galaxen för att stoppa en total utrotning av allt liv i den. Spela denna samling på tre spel, denna mästerliga rymdsaga, nu med bättre uppdaterad grafik än någonsin.", 4, "/Resources/Images/Products/All_Images/Product_30.png", false, "Mass Effect Legendary Edition", 620m, "Electronic Arts" },
                    { 31, "Återupplev ett rollspel i samma stil som de gamla klassikerna, ett spel i samma stil som storheter såsom Baldur’s Gate och Icewind Dale. Skapa din egna hjälte och utforska en spännande fantasy-värld fylld av quests och äventyr. Upptäck de hemligheter detta spel döljer, möt karaktärer som kan ansluta sig till din grupp och döda monster samt samla på dig gold, utrustning och andra skatter.", 1, "/Resources/Images/Products/All_Images/Product_31.png", false, "Pillars of Eternity", 299m, "Paradox Interactive" },
                    { 32, "Börja spela med en historisk karaktär från någonstans i Europa under medeltiden. Etablera en ätt som klarar att förbli stark under flera generationer. Om du så väljer att börja spela som en baron eller som härskaren för ett helt imperium, välj fritt bland alla olika baroner/furstar/kungar/drottningar i hela Europa och få din ätt, din familj, att överleva allt från storskaliga krig till lönnmord. Hur vill du att just din valda karaktär skall utforma sitt liv? Blir personen djupt religiös? Dedikerar du dig åt att skapa ett handelsimperium? Blir personen bokstavligt talat galen och börjar dyrka onda makter? Du väljer. Det viktiga är att hålla ätten vid liv.", 8, "/Resources/Images/Products/All_Images/Product_32.jpg", false, "Crusader Kings 3", 518m, "Paradox Interactive" },
                    { 33, "Den välkända legendariska Age of Empires serien får efter många års väntan ytterligare en uppföljare. Det fjärde spelet i serien lånar mycket från föregångarna samtidigt som det har en ny förbättrad grafik. Aldrig har det varit lika skoj att gå i krig med helt olika nationer, alla med sina egna styrkor och svagheter! Bygg upp dina styrkor och sänd iväg dem för att slåss och bränna ner fiendens städer! Spela ensam eller tävla online med dina kompisar i multiplayer läge.", 8, "/Resources/Images/Products/All_Images/Product_33.png", false, "Age of Empires IV", 620m, "Xbox Game Studios" },
                    { 34, "Din far har just dött i en tragisk olycka och den store ledaren har valt ut dig till att bli anställd hos ministeriet. Som en trogen medborgare dedikerad till att, som oss alla, göra allt som vi kan för att fullgöra vår store ledares vision kommer du att inställa dig på ministeriet för att arbeta dagligen från och med nu. Länge leve vår store ledare! Detta spel innehåller även möjligheten att utforska din döde fars död.", 8, "/Resources/Images/Products/All_Images/Product_34.jpg", false, "Beholder 2", 155m, "Alawar Premimum" },
                    { 35, "Escape from Tarkov är ett realistiskt, hardcore FPS spel som utspelar sig i den fiktiva regionen Norvinsk.", 9, "/Resources/Images/Products/All_Images/Product_35.jpg", false, "Escape from Tarkov", 399m, "Battlestate Games" },
                    { 36, "Spelet spelas ur ett tredjepersonsperspektiv där spelaren tar kontrollen över huvudpersonen Geralt of Rivia, en Witcher som ger sig ut på en lång resa genom det stora landet The Northern Kingdoms.", 1, "/Resources/Images/Products/All_Images/Product_36.png", false, "Witcher 3 Wild Hunt", 300m, "CD PROJEKT RED" },
                    { 37, "Spela med dina vänner för första gången på den legendariska kontinenten Tamriel. I detta MMO kan du besöka allt från Morrowind till High-Rock, med massvis av quests och detaljrika berättelser finns det inget slut för ditt äventyr.", 11, "/Resources/Images/Products/All_Images/Product_37.png", false, "The Elder Scrolls Online", 200m, "Bethesda Software" },
                    { 38, "Gå ner i djupet av en främmande undervattensvärld fylld av förundran och fara.", 10, "/Resources/Images/Products/All_Images/Product_38.jpg", false, "Subnautica", 300m, "Unknown Worlds Entertainment" },
                    { 39, "Spelet utspelar sig i mitten av 2030-talet under den fiktiva militäroperationen Operation Magnitude som inleddes av NATO-styrkor, vilka är i krig mot 'Östeuropeiska arméer' under det gemensamma namnet CSAT (Canton-Protocol Strategic Alliance Treaty) som leds av Iran ihop med en koalition av andra asiatiska länder.", 9, "/Resources/Images/Products/All_Images/Product_39.png", false, "ARMA 3", 300m, "Bohemia Interactive" },
                    { 40, "X-COM 2 är ett turordningsbaserat taktiskt strategispel som utspelar sig på jorden, som har ockuperats av utomjordingar.  Ta på dig rollen som ledaren för X-COM organisationen och ta tillbaka ditt hem.", 8, "/Resources/Images/Products/All_Images/Product_40.png", false, "XCOM 2", 500m, "2K" },
                    { 41, "I Dying Light 2 kan du ta dig runt i parkourstil i en öppen värld där zombieapokalypsen brytit ut. Varje val du gör har en konsekvens under spelets gång.", 4, "/Resources/Images/Products/All_Images/Product_41.jpg", false, "Dying Light 2 Stay Human", 600m, "Techland" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "IsPhysical", "Name", "Price", "Producer" },
                values: new object[,]
                {
                    { 42, "Skapa ditt egna kungarike och erövra världen i detta spel!", 1, "/Resources/Images/Products/All_Images/Product_42.png", false, "Mount & Blade 2: Bannerlord", 400m, "TaleWorlds Entertainment" },
                    { 43, "Du är den senaste rekryten av Outer Wilds Ventures, ett nystartat rymdprogram som söker efter svar i ett märkligt, ständigt utvecklande solsystem.", 7, "/Resources/Images/Products/All_Images/Product_43.jpg", false, "Outer Wilds", 200m, "Annapurna Interactive" },
                    { 44, "Upplev överlevnadsskräck som aldrig förr i den åttonde delen i den berömda Resident Evil-serien.", 6, "/Resources/Images/Products/All_Images/Product_44.jpg", false, "Resident Evil Village", 600m, "CAPCOM" },
                    { 45, "I Slay the Spire försöker spelaren, genom en av fyra karaktärer, bestiga en spira på flera våningar, skapad genom procedurgenerering, slåss genom fiender och bossar. Samla på dig kort från vunna strider och bygg din egna kortlek för att ta dig genom nivåerna.", 5, "/Resources/Images/Products/All_Images/Product_45.png", false, "Slay the Spire", 200m, "Mega Crit Games" },
                    { 46, "Du är den 'enarmade vargen', en vanärad och vanställd krigare som räddas från dödens rand. För att skydda en ung härskare som är ättling till ett uråldrigt släktskap, blir du måltavla för många fiender, inklusive den farliga Ashina-klanen. När den unge härskaren blir tillfångatagen kommer ingenting att stoppa dig i en farlig strävan att återvinna din ära, inte ens döden.", 4, "/Resources/Images/Products/All_Images/Product_46.jpg", false, "Sekiro: Shadows Die Twice", 600m, "From Software" },
                    { 47, "Utspelar sig i den fiktiva, pestdrabbade industristaden Dunwall, och följer historien om Corvo Attano, livvakt till Kejsarinnan av Öarna. Han är anklagad för hennes mord och tvingad att bli en lönnmördare, som söker hämnd på dem som konspirerat mot honom.", 4, "/Resources/Images/Products/All_Images/Product_47.png", false, "Dishonored", 100m, "Bethesda Software" },
                    { 48, "Ett spel för 4-8 personer. Tävla om att förstöra vänskap i den underhållande samlingen av minispel.", 3, "/Resources/Images/Products/All_Images/Product_48.jpg", false, "Pummel Party", 120m, "Rebuilt Games" },
                    { 49, "Följ ett spår av kryptiska bokstäver och lös många unika pussel på allt mer extraordinära platser, på en tidsspännande resa där maskiner möter myter.", 2, "/Resources/Images/Products/All_Images/Product_49.jpg", false, "The Room", 50m, "Fireproof Games" },
                    { 50, "NieR_Automata berättar historien om androiderna 2B, 9S och A2 och deras kamp för att återta den maskindrivna dystopin som är invaderad av kraftfulla maskiner.", 4, "/Resources/Images/Products/All_Images/Product_50.jpg", false, "NieR:Automata", 400m, "Square Enix" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProductId",
                table: "AspNetUsers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_OrderId",
                table: "CartProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductId",
                table: "CartProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_GenreId",
                table: "Product",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Token_ApplicationUserId",
                table: "Token",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Token_ProductId",
                table: "Token",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropTable(
                name: "Token");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
