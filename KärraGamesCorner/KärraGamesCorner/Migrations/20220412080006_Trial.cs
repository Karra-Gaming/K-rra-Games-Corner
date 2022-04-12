using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KärraGamesCorner.Migrations
{
    public partial class Trial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ff92b11-d124-4993-9c56-7e59caede9a8", "c9146dcb-33dd-486f-a474-89f3350e3968" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ff92b11-d124-4993-9c56-7e59caede9a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9146dcb-33dd-486f-a474-89f3350e3968");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb45565e-76a4-44c5-b848-959d58881b02", 0, "d58a4574-424e-4c64-b796-dcee55cf877c", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDqCqzZoCEkoOVqVe3oZ7kA2zJfEodgtNeaxDlU6PPBOsgZAeITbIPxfVMhsaMVxoQ==", null, false, "979679f5-f29b-4a93-8382-8a0cb44ace0a", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "GenreId", "ImageUrl", "Name", "Price", "Producer" },
                values: new object[] { "Skapa din egen gård och låt glädjen växa fram!", 13, "~/Resources/Images/Products/All_Images/Product_2.png", "Farming Simulator 22", 300m, "Giants Software" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "Name", "Price", "Producer" },
                values: new object[,]
                {
                    { 1, "Battlefield 2042 är en förstapersonsskjutare som återvänder till seriens ikoniska totala krigföring.", 9, "~/Resources/Images/Products/All_Images/Product_1.png", "Battlefield 2042", 500m, "EA DICE" },
                    { 3, "Frakta gods med din lastbil runt om i europa.", 13, "~/Resources/Images/Products/All_Images/Product_3.png", "Euro Truck Simulator 2", 100m, "SCS Software" },
                    { 4, "Hur länge överlever du i en postapokalyptisk värld? I ett land översvämmat av infekterade “zombier”, där du konkurrerar med andra överlevare om tunnsådda resurser.", 10, "~/Resources/Images/Products/All_Images/Product_4.png", "DayZ", 300m, "Bohemia Interactive" },
                    { 5, "Var delaktig i ett stort äventyr tillsammans med människor från hela världen.", 11, "~/Resources/Images/Products/All_Images/Product_5.png", "Final Fantasy XIV Online", 100m, "Square Enix" },
                    { 6, "Lag Spel", 9, "~/Resources/Images/Products/All_Images/Product_6.png", "Counter Strike", 200m, "Valve" },
                    { 7, "Stig upp,Tarnished, och låt försynen leda dig att använda kraften hos elden ring och bli Elden Lord i Lands Between.", 4, "", "Elden Ring", 600m, "From Software" },
                    { 8, "Tokyos befolkning är försvunnen, och dödliga övernaturliga krafter stryker runt på gatorna.Med din arsenal av elementärkrafter är det bara du som kan uppdaga sanningen och rädda Tokyo", 4, "", "Ghostwire Tokyo", 600m, "Bethesda Softworks" },
                    { 9, "Spyro är eld och lågor över att vara tillbaka i Spyro Reignited Trilogy,nu snyggare än någonsin i otrolig HD!Gå tillbaka till din gamla flamma i remastrade versioner av de tre ursprungliga spelen: Spyro the dragon, Spyro2:Ripto’s Rage! och Spyro:Year of the Dragon.", 7, "", "Spyro Reignited Trilogy", 400m, "Activision" },
                    { 10, "Det här är den autentiska CTR-upplevelsen plus mycket mer - helt remastrad och nitroboostad till max: Dra igång motorn med originalets spellägen, karaktärer, banor, boostar, vapen och kontroller. Slira hela vägen till seger med nya gokarter, banor och arenor från Crash™ Nitro Kart.", 12, "", "Crash Team Racing Nitro-Fueled", 400m, "Activision" },
                    { 11, "Här kan använda sin egna fantasi för att bygga och skapa nya världar.", 7, "", "MineCraft", 499m, "Mojang" },
                    { 12, "Spela det orginella harpanspelet med en twist nu finns det ännu mer kort", 5, "", "Spindelharpan", 99m, "Microsoft" },
                    { 13, "No Man's Sky är ett spel om utforskning och överlevnad i ett oändligt procedurgenererat universum.", 7, "", "No Man's Sky", 550m, "Hello Games" },
                    { 14, "Jobba tillsammans med alla andra för att ta reda på vem som är förrädaren i gruppen genom slutledningsförmåga", 3, "", "Among Us", 349m, "Innersloth" },
                    { 15, "Ta dig an utmanande boss-strider och skryt för dina vänner när du klarat av dom.", 4, "", "Dark Souls", 599m, "From Software" },
                    { 16, "Använda dina trupper för att ta över världens nationer genom strategi och paktning", 8, "", "Total War: THREE KINGDOMS", 399m, "Sega" },
                    { 17, "Använd geometri för att placera de fallande formerna på det mest optimala sätt och samla poäng", 2, "", "Tetris", 49m, "The Tetris Company" },
                    { 18, "Civilization är ett turbaserat strategispel som går ut på att bygga ett imperium som står sig genom tiderna.", 8, "", "Civilization VI", 600m, "2K" },
                    { 19, "Utforska ett öppet Mexiko som ständigt utvecklas, med gränslös och rolig körning i hundratals av världens bästa bilar.", 12, "", "Forza Horizon 5", 599m, "Xbox Game Studios" },
                    { 20, "Kör race, uppgradera och anpassa varenda bil i den största GRID-uppställningen någonsin, från klassiska touringbilar till ensitsbilar och stora kärror.", 12, "", "Grid Legends", 449m, "Electronic Arts" },
                    { 21, "RIDE 4 tar fram vinnarskallen i dig med hundratals motorcyklar, dussintals banor och realism på en helt ny nivå.", 12, "", "Ride 4", 599m, "Milestone S.r.l" },
                    { 22, "Jobba hårt om dagarna och riskera allt under natthimlen. Need for Speed Heat är ett nervkittlande streetrace-spel där lagar och regler suddas ut när solen går ner.", 12, "", "Need for speed", 599m, "Electronic Arts" },
                    { 23, "Känn spänningen i jakten och adrenalinrushen i flykten i The Crew 2.", 12, "", "The Crew 2", 299m, "Ubisoft" },
                    { 24, "Starta motorerna: Sätt igång den mest autentiska säsongen av MotoGP som någonsin skapats!", 12, "", "MotoGP22", 599m, "Milestone S.r.l" },
                    { 25, "Dead by Daylight är ett skräckspel för flera spelare (4vs1) där en spelare tar på sig rollen som den vilde mördaren, och de andra fyra spelarna spelar som överlevare och försöker fly mördaren och undvika att bli fångad och dödad.", 6, "", "Dead by Daylight", 200m, "Behaviour Interactive Inc." },
                    { 26, "Ett brutalt överlevnadsspel för 1-10 spelare, som utspelar sig i en processuellt genererad värld inspirerad av vikingakulturen.", 10, "", "Valheim", 180m, "Iron Gate" },
                    { 27, "Cyberpunk är ett actionfyllt öppen-värld rollspel där du kan utföra uppdrag och röra dig runt i den futuristiska staden 'Night City'. Forma historien genom de val du gör och se handlingen utvecklas.", 4, "", "Cyberpunk 2077", 630m, "CD PROJEKT RED" },
                    { 28, "Kampen mellan de goda och onda har redan avgjorts - härskaren Kyros har vunnit, och håller nu på att lägga de sista provinserna under sitt styre. Du är en “Fatebinder”, i Kyros tjänst. Spela en avgörande roll för hur handlingen utvecklar sig samt välj vilken sida du allierar dig med.", 1, "", "Tyranny", 300m, "Paradox Interactive" },
                    { 29, "Spela antingen ensam med två karaktärer du själv skapar eller spela med en vän som spelar den ena karaktären. Utforska en spännande fantasy-värld som ett par “source-hunters”, med ett uppdrag som börjar med att utforska ett mord. Under spelets gång kommer du stöta på många spännande karaktärer, vilka du kan rekrytera till din grupp av hjältar. Världens öde ligger i dina händer.", 1, "", "Divinity: Original Sin - Enhanced Edition", 430m, "Paradox Interactive" },
                    { 30, "Du är Shepard, medlem i den mänskliga rymdflottan. Du håller på at scoutas som en potentiell Spectre, en agent för alliansen av olika raser av folkslag som befolkar vår galax, exempelvis salarians, krogans, asari och människor. Mänskligheten håller på att göra framsteg på det galaktiska planet och nu har du möjligheten att bli en av rådets agenter, mycket prestigefyllt. Men saker går inte som förväntat, och snart måste du som Spectre jaga runt i galaxen för att stoppa en total utrotning av allt liv i den. Spela denna samling på tre spel, denna mästerliga rymdsaga, nu med bättre uppdaterad grafik än någonsin.", 4, "", "Mass Effect Legendary Edition", 620m, "Electronic Arts" },
                    { 31, "Återupplev ett rollspel i samma stil som de gamla klassikerna, ett spel i samma stil som storheter såsom Baldur’s Gate och Icewind Dale. Skapa din egna hjälte och utforska en spännande fantasy-värld fylld av quests och äventyr. Upptäck de hemligheter detta spel döljer, möt karaktärer som kan ansluta sig till din grupp och döda monster samt samla på dig gold, utrustning och andra skatter.", 1, "", "Pillars of Eternity", 299m, "Paradox Interactive" },
                    { 32, "Börja spela med en historisk karaktär från någonstans i Europa under medeltiden. Etablera en ätt som klarar att förbli stark under flera generationer. Om du så väljer att börja spela som en baron eller som härskaren för ett helt imperium, välj fritt bland alla olika baroner/furstar/kungar/drottningar i hela Europa och få din ätt, din familj, att överleva allt från storskaliga krig till lönnmord. Hur vill du att just din valda karaktär skall utforma sitt liv? Blir personen djupt religiös? Dedikerar du dig åt att skapa ett handelsimperium? Blir personen bokstavligt talat galen och börjar dyrka onda makter? Du väljer. Det viktiga är att hålla ätten vid liv.", 8, "", "Crusader Kings 3", 518m, "Paradox Interactive" },
                    { 33, "Den välkända legendariska Age of Empires serien får efter många års väntan ytterligare en uppföljare. Det fjärde spelet i serien lånar mycket från föregångarna samtidigt som det har en ny förbättrad grafik. Aldrig har det varit lika skoj att gå i krig med helt olika nationer, alla med sina egna styrkor och svagheter! Bygg upp dina styrkor och sänd iväg dem för att slåss och bränna ner fiendens städer! Spela ensam eller tävla online med dina kompisar i multiplayer läge.", 8, "", "Age of Empires IV", 620m, "Xbox Game Studios" },
                    { 34, "Din far har just dött i en tragisk olycka och den store ledaren har valt ut dig till att bli anställd hos ministeriet. Som en trogen medborgare dedikerad till att, som oss alla, göra allt som vi kan för att fullgöra vår store ledares vision kommer du att inställa dig på ministeriet för att arbeta dagligen från och med nu. Länge leve vår store ledare! Detta spel innehåller även möjligheten att utforska din döde fars död.", 8, "", "Beholder 2", 155m, "Alawar Premimum" },
                    { 35, "Escape from Tarkov är ett realistiskt, hardcore FPS spel som utspelar sig i den fiktiva regionen Norvinsk.", 9, "", "Escape from Tarkov", 399m, "Battlestate Games" },
                    { 36, "Spelet spelas ur ett tredjepersonsperspektiv där spelaren tar kontrollen över huvudpersonen Geralt of Rivia, en Witcher som ger sig ut på en lång resa genom det stora landet The Northern Kingdoms.", 1, "", "Witcher 3 Wild Hunt", 300m, "CD PROJEKT RED" },
                    { 37, "Spela med dina vänner för första gången på den legendariska kontinenten Tamriel. I detta MMO kan du besöka allt från Morrowind till High-Rock, med massvis av quests och detaljrika berättelser finns det inget slut för ditt äventyr.", 11, "", "The Elder Scrolls Online", 200m, "Bethesda Software" },
                    { 38, "Gå ner i djupet av en främmande undervattensvärld fylld av förundran och fara.", 10, "", "Subnautica", 300m, "Unknown Worlds Entertainment" },
                    { 39, "Spelet utspelar sig i mitten av 2030-talet under den fiktiva militäroperationen Operation Magnitude som inleddes av NATO-styrkor, vilka är i krig mot 'Östeuropeiska arméer' under det gemensamma namnet CSAT (Canton-Protocol Strategic Alliance Treaty) som leds av Iran ihop med en koalition av andra asiatiska länder.", 9, "", "ARMA 3", 300m, "Bohemia Interactive" },
                    { 40, "X-COM 2 är ett turordningsbaserat taktiskt strategispel som utspelar sig på jorden, som har ockuperats av utomjordingar.  Ta på dig rollen som ledaren för X-COM organisationen och ta tillbaka ditt hem.", 8, "", "XCOM 2", 500m, "2K" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "GenreId", "ImageUrl", "Name", "Price", "Producer" },
                values: new object[,]
                {
                    { 41, "I Dying Light 2 kan du ta dig runt i parkourstil i en öppen värld där zombieapokalypsen brytit ut. Varje val du gör har en konsekvens under spelets gång.", 4, "", "Dying Light 2 Stay Human", 600m, "Techland" },
                    { 42, "Skapa ditt egna kungarike och erövra världen i detta spel!", 1, "", "Mount & Blade 2: Bannerlord", 400m, "TaleWorlds Entertainment" },
                    { 43, "Du är den senaste rekryten av Outer Wilds Ventures, ett nystartat rymdprogram som söker efter svar i ett märkligt, ständigt utvecklande solsystem.", 7, "", "Outer Wilds", 200m, "Annapurna Interactive" },
                    { 44, "Upplev överlevnadsskräck som aldrig förr i den åttonde delen i den berömda Resident Evil-serien.", 6, "", "Resident Evil Village", 600m, "CAPCOM" },
                    { 45, "I Slay the Spire försöker spelaren, genom en av fyra karaktärer, bestiga en spira på flera våningar, skapad genom procedurgenerering, slåss genom fiender och bossar. Samla på dig kort från vunna strider och bygg din egna kortlek för att ta dig genom nivåerna.", 5, "", "Slay the Spire", 200m, "Mega Crit Games" },
                    { 46, "Du är den 'enarmade vargen', en vanärad och vanställd krigare som räddas från dödens rand. För att skydda en ung härskare som är ättling till ett uråldrigt släktskap, blir du måltavla för många fiender, inklusive den farliga Ashina-klanen. När den unge härskaren blir tillfångatagen kommer ingenting att stoppa dig i en farlig strävan att återvinna din ära, inte ens döden.", 4, "", "Sekiro: Shadows Die Twice", 600m, "From Software" },
                    { 47, "Utspelar sig i den fiktiva, pestdrabbade industristaden Dunwall, och följer historien om Corvo Attano, livvakt till Kejsarinnan av Öarna. Han är anklagad för hennes mord och tvingad att bli en lönnmördare, som söker hämnd på dem som konspirerat mot honom.", 4, "", "Dishonored", 100m, "Bethesda Software" },
                    { 48, "Ett spel för 4-8 personer. Tävla om att förstöra vänskap i den underhållande samlingen av minispel.", 3, "", "Pummel Party", 120m, "Rebuilt Games" },
                    { 49, "Följ ett spår av kryptiska bokstäver och lös många unika pussel på allt mer extraordinära platser, på en tidsspännande resa där maskiner möter myter.", 2, "", "The Room", 50m, "Fireproof Games" },
                    { 50, "NieR_Automata berättar historien om androiderna 2B, 9S och A2 och deras kamp för att återta den maskindrivna dystopin som är invaderad av kraftfulla maskiner.", 4, "", "NieR:Automata", 400m, "Square Enix" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "bb45565e-76a4-44c5-b848-959d58881b02" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6b40a84-e697-4391-ab3b-7c23ce7cb413", "bb45565e-76a4-44c5-b848-959d58881b02" });

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6b40a84-e697-4391-ab3b-7c23ce7cb413");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb45565e-76a4-44c5-b848-959d58881b02");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ff92b11-d124-4993-9c56-7e59caede9a8", "5ff92b11-d124-4993-9c56-7e59caede9a8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9146dcb-33dd-486f-a474-89f3350e3968", 0, "fd096154-eac0-4651-844a-2e7fe21f3565", "admin@gmail.com", true, "", false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPNBL+0yDA6PdynS4qw6Eku74nfzjknzsGj0F/1x1nSe855kKFefFc0UwGfJ5tcinQ==", null, false, "032e8cc0-01c0-4da4-a7f3-502eef5978b6", false, "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "GenreId", "ImageUrl", "Name", "Price", "Producer" },
                values: new object[] { "bla", 2, "", "bla", 20m, "" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ff92b11-d124-4993-9c56-7e59caede9a8", "c9146dcb-33dd-486f-a474-89f3350e3968" });
        }
    }
}
