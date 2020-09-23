using Microsoft.EntityFrameworkCore.Migrations;

namespace MaisonReve.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    OwnerFirstName = table.Column<string>(nullable: true),
                    OwnerLastName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "Description", "Name", "OwnerFirstName", "OwnerLastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, @"2340, Ashfield Road
                Coverdale (NB)
                E1J 7A1 
                Canada
                ", "Le Super Adrian est un immeuble extra, où il fait bon vivre!", "Le Super Adrian", "Krissy", "Reidcoln", "214-764-3816" },
                    { 127, @"2702, Swallow Close
                Pennfield (NB)
                E5H 1B2 
                Canada
                ", "Le Super Marcella est un immeuble extra, où il fait bon vivre!", "Le Super Marcella", "Sherlene", "Salkile", "115-655-7261" },
                    { 128, @"1200, Thomas Street
                Lakeside (NS)
                B3T 7K7 
                Canada
                ", "Le Super Sherlene est un immeuble extra, où il fait bon vivre!", "Le Super Sherlene", "Antonetta", "Rovanola", "532-884-3674" },
                    { 129, @"4687, The Ridgeway
                Coaldale (AB)
                T1M 0J0 
                Canada
                ", "Le Super Antonetta est un immeuble extra, où il fait bon vivre!", "Le Super Antonetta", "Tyson", "Balniai", "168-143-6287" },
                    { 130, @"3185, Mansfield Road
                Sainte-Rose (QC)
                H7L 6B9 
                Canada
                ", "Le Super Tyson est un immeuble extra, où il fait bon vivre!", "Le Super Tyson", "Derick", "Ísafholt", "686-382-2612" },
                    { 131, @"1683, Elizabeth Close
                Donnacona (QC)
                G3M 4N7 
                Canada
                ", "Le Super Derick est un immeuble extra, où il fait bon vivre!", "Le Super Derick", "Sheridan", "Hammervåg", "233-531-5225" },
                    { 132, @"181, Willow Road
                Maniwaki (QC)
                J9E 9C7 
                Canada
                ", "Le Super Sheridan est un immeuble extra, où il fait bon vivre!", "Le Super Sheridan", "Debi", "Jaunli", "651-678-1638" },
                    { 133, @"3669, Market Square
                Merritt (BC)
                V1K 5R6 
                Canada
                ", "Le Super Debi est un immeuble extra, où il fait bon vivre!", "Le Super Debi", "Johana", "Enbo", "276-837-4243" },
                    { 134, @"2167, Cedar Close
                Vancouver (BC)
                V5K 7H8 
                Canada
                ", "Le Super Johana est un immeuble extra, où il fait bon vivre!", "Le Super Johana", "Adrian", "Jonkruojis", "624-266-8656" },
                    { 135, @"665, Poppy Close
                St. Martins (NB)
                E5R 8H4 
                Canada
                ", "Le Super Adrian est un immeuble extra, où il fait bon vivre!", "Le Super Adrian", "Eugenie", "Reidcoln", "342-325-4261" },
                    { 136, @"4153, Willow Lane
                Belleville (ON)
                K8R 1K4 
                Canada
                ", "Le Super Eugenie est un immeuble extra, où il fait bon vivre!", "Le Super Eugenie", "Pat", "Steinstrand", "767-554-7674" },
                    { 137, @"2651, Rosemary Lane
                Petite-Bourgogne (QC)
                H3J 2L2 
                Canada
                ", "Le Super Pat est un immeuble extra, où il fait bon vivre!", "Le Super Pat", "Jamal", "Nuugaatrapaluk", "315-713-3287" },
                    { 138, @"1149, Coronation Avenue
                Kimberley (BC)
                V1A 8B8 
                Canada
                ", "Le Super Jamal est un immeuble extra, où il fait bon vivre!", "Le Super Jamal", "Ralph", "Vadtälje", "732-152-6612" },
                    { 139, @"4637, The Poplars
                Minto (NB)
                E4B 5G8 
                Canada
                ", "Le Super Ralph est un immeuble extra, où il fait bon vivre!", "Le Super Ralph", "Arielle", "Eqalunavik", "358-281-2225" },
                    { 140, @"3135, Cornwall Road
                Sylvan Lake (AB)
                T4S 3R1 
                Canada
                ", "Le Super Arielle est un immeuble extra, où il fait bon vivre!", "Le Super Arielle", "Steven", "Lystrup", "786-448-6638" },
                    { 141, @"1633, Walton Road
                Inner Nunavut (NU)
                X0C 9V4 
                Canada
                ", "Le Super Steven est un immeuble extra, où il fait bon vivre!", "Le Super Steven", "Marcell", "Apatcruz", "423-677-1243" },
                    { 142, @"131, Manor Gardens
                Kingsclear (NB)
                E3E 0G3 
                Canada
                ", "Le Super Marcell est un immeuble extra, où il fait bon vivre!", "Le Super Marcell", "Simonne", "Haapsa", "841-736-5656" },
                    { 143, @"3619, Henry Street
                Nackawic (NB)
                E6G 5P4 
                Canada
                ", "Le Super Simonne est un immeuble extra, où il fait bon vivre!", "Le Super Simonne", "Sherise", "Mensmere", "476-175-8261" },
                    { 144, @"2117, Swallow Close
                Smiths Creek (NB)
                E4G 6C4 
                Canada
                ", "Le Super Sherise est un immeuble extra, où il fait bon vivre!", "Le Super Sherise", "Angelina", "Kalatee", "814-324-4673" },
                    { 145, @"615, Adelaide Street
                La Baie (QC)
                G7B 6H9 
                Canada
                ", "Le Super Angelina est un immeuble extra, où il fait bon vivre!", "Le Super Angelina", "Magen", "Albro", "431-563-7286" },
                    { 146, @"4103, The Ridgeway
                Kincardine (ON)
                N2Z 6A2 
                Canada
                ", "Le Super Magen est un immeuble extra, où il fait bon vivre!", "Le Super Magen", "Sheryl", "Hókrókur", "167-612-3611" },
                    { 147, @"2601, Ruskin Avenue
                Saint-Constant (QC)
                J5A 2L4 
                Canada
                ", "Le Super Sheryl est un immeuble extra, où il fait bon vivre!", "Le Super Sheryl", "Tonita", "Dragstrup", "585-851-7224" },
                    { 126, @"4204, Henry Street
                Petite-Bourgogne (QC)
                H3J 9B1 
                Canada
                ", "Le Super Berniece est un immeuble extra, où il fait bon vivre!", "Le Super Berniece", "Marcella", "Kalvee", "577-416-3656" },
                    { 148, @"1099, The Lane
                Fabreville (QC)
                H7P 4S8 
                Canada
                ", "Le Super Tonita est un immeuble extra, où il fait bon vivre!", "Le Super Tonita", "Berniece", "Ketne", "122-218-2637" },
                    { 125, @"716, Grosvenor Road
                Port Moody (BC)
                V3H 0M6 
                Canada
                ", "Le Super Mariella est un immeuble extra, où il fait bon vivre!", "Le Super Mariella", "Berniece", "Ólafsholt", "142-267-8243" },
                    { 123, @"3720, Beech Grove
                Sturgeon Falls (ON)
                P2B 8K7 
                Canada
                ", "Le Super Liliana est un immeuble extra, où il fait bon vivre!", "Le Super Liliana", "Marcie", "Nittinen", "886-761-1226" },
                    { 102, @"333, Willow Drive
                High River (AB)
                T1V 3L7 
                Canada
                ", "Le Super Magen est un immeuble extra, où il fait bon vivre!", "Le Super Magen", "Jane", "Ólafsholt", "161-336-5558" },
                    { 103, @"3821, Chantry Close
                Midland (ON)
                L4R 4G4 
                Canada
                ", "Le Super Jane est un immeuble extra, où il fait bon vivre!", "Le Super Jane", "Tonita", "Loktu", "517-565-1163" },
                    { 104, @"2319, South Close
                Camrose (AB)
                T4V 4P8 
                Canada
                ", "Le Super Tonita est un immeuble extra, où il fait bon vivre!", "Le Super Tonita", "Dina", "Ketne", "134-724-5575" },
                    { 105, @"817, Church Walk
                Laval-des-Rapides (QC)
                H7N 2L5 
                Canada
                ", "Le Super Dina est un immeuble extra, où il fait bon vivre!", "Le Super Dina", "Antonetta", "Siukoski", "562-853-8188" },
                    { 106, @"4305, Brighton Road
                Ville-Marie (QC)
                J9V 1P6 
                Canada
                ", "Le Super Antonetta est un immeuble extra, où il fait bon vivre!", "Le Super Antonetta", "Adell", "Kedainkai", "187-212-4513" },
                    { 107, @"2803, South Drive
                Porters Lake (NS)
                B3E 4E8 
                Canada
                ", "Le Super Adell est un immeuble extra, où il fait bon vivre!", "Le Super Adell", "Pierre", "Akssandur", "625-451-7126" },
                    { 108, @"1301, Grosvenor Road
                St. Andrews (NB)
                E5B 0A3 
                Canada
                ", "Le Super Pierre est un immeuble extra, où il fait bon vivre!", "Le Super Pierre", "Bianca", "Brønnøyden", "253-588-3531" },
                    { 109, @"4788, Milton Close
                Bridgewater (NS)
                B4V 9R3 
                Canada
                ", "Le Super Bianca est un immeuble extra, où il fait bon vivre!", "Le Super Bianca", "Barbie", "Jaunli", "678-747-6244" },
                    { 110, @"3286, St John's Road
                Nackawic (NB)
                E6G 3E2 
                Canada
                ", "Le Super Barbie est un immeuble extra, où il fait bon vivre!", "Le Super Barbie", "Johana", "Kungstuna", "216-176-2657" },
                    { 111, @"1784, Thomas Street
                Gaspé (QC)
                G4X 8P5 
                Canada
                ", "Le Super Johana est un immeuble extra, où il fait bon vivre!", "Le Super Johana", "Rosetta", "Jonkruojis", "643-335-6262" },
                    { 112, @"282, Sutton Road
                Strathmore (AB)
                T1P 7N7 
                Canada
                ", "Le Super Rosetta est un immeuble extra, où il fait bon vivre!", "Le Super Rosetta", "Krissy", "Clarehurst", "261-474-1675" },
                    { 113, @"3770, Mansfield Road
                Parksville (BC)
                V9P 2B0 
                Canada
                ", "Le Super Krissy est un immeuble extra, où il fait bon vivre!", "Le Super Krissy", "Marlon", "Steinstrand", "787-623-5288" },
                    { 114, @"2268, Shaw Street
                Kedgwick (NB)
                E8B 7N9 
                Canada
                ", "Le Super Marlon est un immeuble extra, où il fait bon vivre!", "Le Super Marlon", "Palmira", "Flatwood", "334-862-8613" },
                    { 115, @"766, Bluebell Close
                Metchosin (BC)
                V9C 7R6 
                Canada
                ", "Le Super Palmira est un immeuble extra, où il fait bon vivre!", "Le Super Palmira", "Ralph", "Vadtälje", "752-121-4226" },
                    { 116, @"4254, Market Square
                Buena Vista (SK)
                S2V 1A1 
                Canada
                ", "Le Super Ralph est un immeuble extra, où il fait bon vivre!", "Le Super Ralph", "Eugenio", "Uummanqaq", "377-358-8631" },
                    { 117, @"2752, Eastern Avenue
                Port Alberni (BC)
                V9Y 2N8 
                Canada
                ", "Le Super Eugenio est un immeuble extra, où il fait bon vivre!", "Le Super Eugenio", "Troy", "Lystrup", "725-517-3244" },
                    { 118, @"1250, Poppy Close
                L'Épiphanie (QC)
                J5X 3K0 
                Canada
                ", "Le Super Troy est un immeuble extra, où il fait bon vivre!", "Le Super Troy", "Tad", "Ixtatla", "342-646-7657" },
                    { 119, @"4738, Willow Lane
                Richibucto (NB)
                E4W 3B2 
                Canada
                ", "Le Super Tad est un immeuble extra, où il fait bon vivre!", "Le Super Tad", "Vi", "Ulhus", "868-885-2262" },
                    { 120, @"3236, Chantry Close
                Apohaqui (NB)
                E5P 3X1 
                Canada
                ", "Le Super Vi est un immeuble extra, où il fait bon vivre!", "Le Super Vi", "Sherise", "Guasabaro", "416-244-6675" },
                    { 121, @"1734, Coronation Avenue
                Vegreville (AB)
                T9C 9P5 
                Canada
                ", "Le Super Sherise est un immeuble extra, où il fait bon vivre!", "Le Super Sherise", "Alejandro", "Mõisali", "833-473-1288" },
                    { 122, @"232, Church Walk
                Pintendre (QC)
                G6C 2B4 
                Canada
                ", "Le Super Alejandro est un immeuble extra, où il fait bon vivre!", "Le Super Alejandro", "Liliana", "Boswood", "451-532-5613" },
                    { 124, @"2218, Walton Road
                Sylvan Lake (AB)
                T4S 3T9 
                Canada
                ", "Le Super Marcie est un immeuble extra, où il fait bon vivre!", "Le Super Marcie", "Mariella", "Dragstrup", "524-128-4638" },
                    { 101, @"1835, Willow Close
                Alliston (ON)
                L9R 2X9 
                Canada
                ", "Le Super Marcie est un immeuble extra, où il fait bon vivre!", "Le Super Marcie", "Magen", "Albro", "443-177-2145" },
                    { 149, @"4586, Willow Road
                Yorkton (SK)
                S3N 3X1 
                Canada
                ", "Le Super Berniece est un immeuble extra, où il fait bon vivre!", "Le Super Berniece", "Conrad", "Kalvee", "558-347-6242" },
                    { 151, @"1582, Cedar Close
                Big Bras d'Or (NS)
                B1X 8S0 
                Canada
                ", "Le Super Adell est un immeuble extra, où il fait bon vivre!", "Le Super Adell", "Nicholas", "Rovanola", "513-745-5268" },
                    { 177, @"2449, Willow Drive
                Nackawic (NB)
                E6G 9J5 
                Canada
                ", "Le Super Barbie est un immeuble extra, où il fait bon vivre!", "Le Super Barbie", "Johana", "Kungstuna", "274-312-2285" },
                    { 178, @"947, West Road
                Gaspé (QC)
                G4X 8P5 
                Canada
                ", "Le Super Johana est un immeuble extra, où il fait bon vivre!", "Le Super Johana", "Rosetta", "Jonkruojis", "612-551-6688" },
                    { 179, @"4435, South Close
                Strathmore (AB)
                T1P 7N7 
                Canada
                ", "Le Super Rosetta est un immeuble extra, où il fait bon vivre!", "Le Super Rosetta", "Krissy", "Clarehurst", "238-718-1213" },
                    { 180, @"2933, Nelson Street
                Parksville (BC)
                V9P 2B0 
                Canada
                ", "Le Super Krissy est un immeuble extra, où il fait bon vivre!", "Le Super Krissy", "Marlon", "Steinstrand", "765-847-5626" },
                    { 181, @"1431, Brighton Road
                Kedgwick (NB)
                E8B 7N9 
                Canada
                ", "Le Super Marlon est un immeuble extra, où il fait bon vivre!", "Le Super Marlon", "Palmira", "Flatwood", "383-286-1231" },
                    { 182, @"4919, South Drive
                Ingersoll (ON)
                N5C 7V5 
                Canada
                ", "Le Super Palmira est un immeuble extra, où il fait bon vivre!", "Le Super Palmira", "Ralph", "Vadtälje", "728-445-4644" },
                    { 183, @"3417, Rydal Close
                Caledonia (ON)
                N3W 2S0 
                Canada
                ", "Le Super Ralph est un immeuble extra, où il fait bon vivre!", "Le Super Ralph", "Eugenio", "Uummanqaq", "356-574-8357" },
                    { 184, @"1915, Milton Close
                Port Alberni (BC)
                V9Y 2N8 
                Canada
                ", "Le Super Eugenio est un immeuble extra, où il fait bon vivre!", "Le Super Eugenio", "Troy", "Lystrup", "774-733-3761" },
                    { 185, @"413, St John's Road
                L'Épiphanie (QC)
                J5X 3K0 
                Canada
                ", "Le Super Troy est un immeuble extra, où il fait bon vivre!", "Le Super Troy", "Tad", "Ixtatla", "311-162-7374" },
                    { 186, @"3901, Cherry Close
                Richibucto (NB)
                E4W 3B2 
                Canada
                ", "Le Super Tad est un immeuble extra, où il fait bon vivre!", "Le Super Tad", "Vi", "Haapsa", "847-321-2787" },
                    { 187, @"2399, Sutton Road
                Apohaqui (NB)
                E5P 3X1 
                Canada
                ", "Le Super Vi est un immeuble extra, où il fait bon vivre!", "Le Super Vi", "Sherise", "Guasabaro", "464-468-6312" },
                    { 188, @"897, The Meadows
                Merritt (BC)
                V1K 2S6 
                Canada
                ", "Le Super Sherise est un immeuble extra, où il fait bon vivre!", "Le Super Sherise", "Alejandro", "Mõisali", "882-617-2725" },
                    { 189, @"4384, Shaw Street
                Laval-sur-le-Lac (QC)
                H7R 6L7 
                Canada
                ", "Le Super Alejandro est un immeuble extra, où il fait bon vivre!", "Le Super Alejandro", "Liliana", "Boswood", "438-856-5338" },
                    { 190, @"2882, Bluebell Close
                Sturgeon Falls (ON)
                P2B 8K7 
                Canada
                ", "Le Super Liliana est un immeuble extra, où il fait bon vivre!", "Le Super Liliana", "Marcie", "Nittinen", "855-185-1743" },
                    { 191, @"1380, Maple Grove
                Sylvan Lake (AB)
                T4S 3T9 
                Canada
                ", "Le Super Marcie est un immeuble extra, où il fait bon vivre!", "Le Super Marcie", "Mariella", "Dragstrup", "573-344-4356" },
                    { 192, @"4868, Eastern Avenue
                Port Moody (BC)
                V3H 0M6 
                Canada
                ", "Le Super Mariella est un immeuble extra, où il fait bon vivre!", "Le Super Mariella", "Berniece", "Ólafsholt", "128-583-8761" },
                    { 193, @"3366, Poppy Close
                Petite-Bourgogne (QC)
                H3J 9B1 
                Canada
                ", "Le Super Berniece est un immeuble extra, où il fait bon vivre!", "Le Super Berniece", "Marcella", "Kalvee", "546-732-4374" },
                    { 194, @"1864, Willow Drive
                Appalaches (QC)
                G0R 3R3 
                Canada
                ", "Le Super Marcella est un immeuble extra, où il fait bon vivre!", "Le Super Marcella", "Sherlene", "Salkile", "163-871-7787" },
                    { 195, @"362, Chantry Close
                Lakeside (NS)
                B3T 7K7 
                Canada
                ", "Le Super Sherlene est un immeuble extra, où il fait bon vivre!", "Le Super Sherlene", "Antonetta", "Rovanola", "511-228-3312" },
                    { 196, @"3850, South Close
                Coaldale (AB)
                T1M 0J0 
                Canada
                ", "Le Super Antonetta est un immeuble extra, où il fait bon vivre!", "Le Super Antonetta", "Tyson", "Balniai", "137-467-6725" },
                    { 197, @"2348, Church Walk
                Sainte-Rose (QC)
                H7L 6B9 
                Canada
                ", "Le Super Tyson est un immeuble extra, où il fait bon vivre!", "Le Super Tyson", "Derick", "Ísafholt", "654-526-2338" },
                    { 176, @"3951, Willow Close
                Saint-Henri (QC)
                H4C 0X1 
                Canada
                ", "Le Super Bianca est un immeuble extra, où il fait bon vivre!", "Le Super Bianca", "Barbie", "Jaunli", "647-163-7672" },
                    { 150, @"3084, Westgate
                Senneville (QC)
                H9K 6V8 
                Canada
                ", "Le Super Conrad est un immeuble extra, où il fait bon vivre!", "Le Super Conrad", "Adell", "Kedainkai", "175-586-1655" },
                    { 175, @"463, The Pastures
                St. Andrews (NB)
                E5B 0A3 
                Canada
                ", "Le Super Pierre est un immeuble extra, où il fait bon vivre!", "Le Super Pierre", "Bianca", "Brønnøyden", "221-824-3267" },
                    { 173, @"3467, Birch Avenue
                Ville-Marie (QC)
                J9V 1P6 
                Canada
                ", "Le Super Antonetta est un immeuble extra, où il fait bon vivre!", "Le Super Antonetta", "Adell", "Balniai", "156-436-4241" },
                    { 152, @"80, Hamilton Road
                Tecumseh Outskirts (ON)
                N8N 9C1 
                Canada
                ", "Le Super Nicholas est un immeuble extra, où il fait bon vivre!", "Le Super Nicholas", "Bianca", "Brønnøyden", "241-174-1673" },
                    { 153, @"3568, Woodfield Road
                Laurentides-Nord (QC)
                J0T 9R5 
                Canada
                ", "Le Super Bianca est un immeuble extra, où il fait bon vivre!", "Le Super Bianca", "Derick", "Ísafholt", "666-233-4286" },
                    { 154, @"2066, Rosemary Lane
                Arnprior (ON)
                K7S 8C9 
                Canada
                ", "Le Super Derick est un immeuble extra, où il fait bon vivre!", "Le Super Derick", "Leida", "Kungstuna", "214-462-8611" },
                    { 155, @"564, Cliff Road
                Pointe-Claire (QC)
                H9R 4R4 
                Canada
                ", "Le Super Leida est un immeuble extra, où il fait bon vivre!", "Le Super Leida", "Rosetta", "Kulli", "631-621-3224" },
                    { 156, @"4052, Birch Avenue
                Prince Rupert (BC)
                V8J 0C3 
                Canada
                ", "Le Super Rosetta est un immeuble extra, où il fait bon vivre!", "Le Super Rosetta", "Ernestine", "Clarehurst", "257-768-7637" },
                    { 157, @"2550, Cornwall Road
                Kingston (ON)
                K7K 6X8 
                Canada
                ", "Le Super Ernestine est un immeuble extra, où il fait bon vivre!", "Le Super Ernestine", "Marlon", "Lazmerge", "685-117-3242" },
                    { 158, @"1048, The Pastures
                Smiths Creek (NB)
                E4G 1N5 
                Canada
                ", "Le Super Marlon est un immeuble extra, où il fait bon vivre!", "Le Super Marlon", "Eugenie", "Flatwood", "322-356-6655" },
                    { 159, @"4536, Manor Gardens
                Boucherville (QC)
                J4B 8L3 
                Canada
                ", "Le Super Eugenie est un immeuble extra, où il fait bon vivre!", "Le Super Eugenie", "Cathryn", "Breksos", "748-485-2268" },
                    { 160, @"3034, The Broadway
                La Tuque (QC)
                G9X 2H4 
                Canada
                ", "Le Super Cathryn est un immeuble extra, où il fait bon vivre!", "Le Super Cathryn", "Jamal", "Nuugaatrapaluk", "375-644-5673" },
                    { 161, @"1532, West Road
                Petawawa (ON)
                K8H 2K5 
                Canada
                ", "Le Super Jamal est un immeuble extra, où il fait bon vivre!", "Le Super Jamal", "Emely", "Norrviken", "713-883-1286" },
                    { 162, @"30, Adelaide Street
                La Plaine (QC)
                J7M 1G8 
                Canada
                ", "Le Super Emely est un immeuble extra, où il fait bon vivre!", "Le Super Emely", "Tad", "Eqalunavik", "331-232-4611" },
                    { 163, @"3518, Nelson Street
                Saint-Hippolyte (QC)
                J8A 9B2 
                Canada
                ", "Le Super Tad est un immeuble extra, où il fait bon vivre!", "Le Super Tad", "Steven", "Ulhus", "866-371-8224" },
                    { 164, @"2016, Brighton Road
                Cochrane (AB)
                T4C 1M1 
                Canada
                ", "Le Super Steven est un immeuble extra, où il fait bon vivre!", "Le Super Steven", "Roma", "Apatcruz", "484-528-4636" },
                    { 165, @"514, The Lane
                Cedar (BC)
                V9X 9V4 
                Canada
                ", "Le Super Roma est un immeuble extra, où il fait bon vivre!", "Le Super Roma", "Simonne", "Mõisali", "821-767-7241" },
                    { 166, @"4002, Rydal Close
                Yorkton (SK)
                S3N 9B2 
                Canada
                ", "Le Super Simonne est un immeuble extra, où il fait bon vivre!", "Le Super Simonne", "Jeanetta", "Mensmere", "457-826-3654" },
                    { 167, @"2500, Westgate
                Maple (ON)
                L6A 2N0 
                Canada
                ", "Le Super Jeanetta est un immeuble extra, où il fait bon vivre!", "Le Super Jeanetta", "Marcie", "Nittinen", "874-254-6267" },
                    { 168, @"998, Ashfield Road
                Alliston (ON)
                L9R 2X9 
                Canada
                ", "Le Super Marcie est un immeuble extra, où il fait bon vivre!", "Le Super Marcie", "Magen", "Albro", "412-413-2672" },
                    { 169, @"4485, Cherry Close
                High River (AB)
                T1V 3L7 
                Canada
                ", "Le Super Magen est un immeuble extra, où il fait bon vivre!", "Le Super Magen", "Jane", "Ólafsholt", "148-652-6285" },
                    { 170, @"2983, Woodfield Road
                L'Île-Dorval (QC)
                H9S 1X6 
                Canada
                ", "Le Super Jane est un immeuble extra, où il fait bon vivre!", "Le Super Jane", "Tonita", "Loktu", "565-781-1618" },
                    { 171, @"1481, The Meadows
                Porters Lake (NS)
                B3E 2N6 
                Canada
                ", "Le Super Tonita est un immeuble extra, où il fait bon vivre!", "Le Super Tonita", "Dina", "Salkile", "183-148-5223" },
                    { 172, @"4969, Shaw Street
                Laval-des-Rapides (QC)
                H7N 2L5 
                Canada
                ", "Le Super Dina est un immeuble extra, où il fait bon vivre!", "Le Super Dina", "Antonetta", "Siukoski", "538-377-8636" },
                    { 174, @"1965, Maple Grove
                Porters Lake (NS)
                B3E 4E8 
                Canada
                ", "Le Super Adell est un immeuble extra, où il fait bon vivre!", "Le Super Adell", "Pierre", "Akssandur", "674-675-7654" },
                    { 198, @"846, Beech Grove
                Donnacona (QC)
                G3M 4N7 
                Canada
                ", "Le Super Derick est un immeuble extra, où il fait bon vivre!", "Le Super Derick", "Sheridan", "Hammervåg", "282-755-5743" },
                    { 100, @"3337, Eastern Avenue
                Maple (ON)
                L6A 2N0 
                Canada
                ", "Le Super Jeanetta est un immeuble extra, où il fait bon vivre!", "Le Super Jeanetta", "Marcie", "Nittinen", "826-838-6532" },
                    { 98, @"1351, Birch Avenue
                Cocagne (NB)
                E4R 0N2 
                Canada
                ", "Le Super Roma est un immeuble extra, où il fait bon vivre!", "Le Super Roma", "Simonne", "Mõisali", "853-442-7514" },
                    { 27, @"3207, Willow Drive
                Yarmouth (NS)
                B5A 0C4 
                Canada
                ", "Le Super Jamal est un immeuble extra, où il fait bon vivre!", "Le Super Jamal", "Emely", "Norrviken", "766-342-1832" },
                    { 28, @"1705, Chantry Close
                La Plaine (QC)
                J7M 1G8 
                Canada
                ", "Le Super Emely est un immeuble extra, où il fait bon vivre!", "Le Super Emely", "Arielle", "Eqalunavik", "313-571-4445" },
                    { 29, @"202, Coronation Avenue
                Saint-Hippolyte (QC)
                J8A 9B2 
                Canada
                ", "Le Super Arielle est un immeuble extra, où il fait bon vivre!", "Le Super Arielle", "Steven", "Ulhus", "831-638-8858" },
                    { 30, @"3690, Church Walk
                Qualicum Beach (BC)
                V9K 3H0 
                Canada
                ", "Le Super Steven est un immeuble extra, où il fait bon vivre!", "Le Super Steven", "Roma", "Apatcruz", "456-877-3463" },
                    { 31, @"2188, Beech Grove
                Cocagne (NB)
                E4R 0N2 
                Canada
                ", "Le Super Roma est un immeuble extra, où il fait bon vivre!", "Le Super Roma", "Simonne", "Mõisali", "884-226-7876" },
                    { 32, @"686, South Drive
                Norton (NB)
                E5T 9V1 
                Canada
                ", "Le Super Simonne est un immeuble extra, où il fait bon vivre!", "Le Super Simonne", "Jeanetta", "Mensmere", "422-465-2481" },
                    { 33, @"4174, Grosvenor Road
                St. Stephen (NB)
                E3L 5R9 
                Canada
                ", "Le Super Jeanetta est un immeuble extra, où il fait bon vivre!", "Le Super Jeanetta", "Angelina", "Nittinen", "857-514-6814" },
                    { 34, @"2672, Henry Street
                Alliston (ON)
                L9R 2X9 
                Canada
                ", "Le Super Angelina est un immeuble extra, où il fait bon vivre!", "Le Super Angelina", "Magen", "Albro", "475-753-2427" },
                    { 35, @"1170, St John's Road
                High River (AB)
                T1V 3L7 
                Canada
                ", "Le Super Magen est un immeuble extra, où il fait bon vivre!", "Le Super Magen", "Jane", "Hókrókur", "112-112-5132" },
                    { 36, @"4658, Thomas Street
                Midland (ON)
                L4R 4G4 
                Canada
                ", "Le Super Jane est un immeuble extra, où il fait bon vivre!", "Le Super Jane", "Tonita", "Loktu", "548-241-1545" },
                    { 37, @"3156, Sutton Road
                Camrose (AB)
                T4V 4P8 
                Canada
                ", "Le Super Tonita est un immeuble extra, où il fait bon vivre!", "Le Super Tonita", "Dina", "Ketne", "166-488-4158" },
                    { 38, @"1654, Mansfield Road
                Elizabethtown (ON)
                K6T 6L3 
                Canada
                ", "Le Super Dina est un immeuble extra, où il fait bon vivre!", "Le Super Dina", "Conrad", "Siukoski", "583-637-8563" },
                    { 39, @"152, Elizabeth Close
                Saint-Ambroise (QC)
                G7P 6A1 
                Canada
                ", "Le Super Conrad est un immeuble extra, où il fait bon vivre!", "Le Super Conrad", "Adell", "Kedainkai", "131-876-4176" },
                    { 40, @"3640, Bluebell Close
                Porters Lake (NS)
                B3E 4E8 
                Canada
                ", "Le Super Adell est un immeuble extra, où il fait bon vivre!", "Le Super Adell", "Pierre", "Akssandur", "556-135-7581" },
                    { 41, @"2138, Market Square
                St. Andrews (NB)
                E5B 0A3 
                Canada
                ", "Le Super Pierre est un immeuble extra, où il fait bon vivre!", "Le Super Pierre", "Bianca", "Brønnøyden", "274-364-3114" },
                    { 42, @"636, Cedar Close
                Bridgewater (NS)
                B4V 9R3 
                Canada
                ", "Le Super Bianca est un immeuble extra, où il fait bon vivre!", "Le Super Bianca", "Barbie", "Jaunli", "622-523-6527" },
                    { 43, @"4124, Poppy Close
                Nackawic (NB)
                E6G 3E2 
                Canada
                ", "Le Super Barbie est un immeuble extra, où il fait bon vivre!", "Le Super Barbie", "Leida", "Kungstuna", "247-652-2132" },
                    { 44, @"2622, Willow Lane
                Smiths Creek (NB)
                E4G 5A0 
                Canada
                ", "Le Super Leida est un immeuble extra, où il fait bon vivre!", "Le Super Leida", "Rosetta", "Jonkruojis", "665-811-5544" },
                    { 45, @"1120, Chantry Close
                Strathmore (AB)
                T1P 7N7 
                Canada
                ", "Le Super Rosetta est un immeuble extra, où il fait bon vivre!", "Le Super Rosetta", "Krissy", "Clarehurst", "212-258-1157" },
                    { 46, @"4608, Coronation Avenue
                Parksville (BC)
                V9P 2B0 
                Canada
                ", "Le Super Krissy est un immeuble extra, où il fait bon vivre!", "Le Super Krissy", "Marlon", "Steinstrand", "738-487-5562" },
                    { 47, @"3106, The Poplars
                Kedgwick (NB)
                E8B 7N9 
                Canada
                ", "Le Super Marlon est un immeuble extra, où il fait bon vivre!", "Le Super Marlon", "Palmira", "Flatwood", "355-546-8175" },
                    { 26, @"4709, Poppy Close
                Windsor (QC)
                J1S 5K1 
                Canada
                ", "Le Super Cathryn est un immeuble extra, où il fait bon vivre!", "Le Super Cathryn", "Jamal", "Nuugaatrapaluk", "348-183-5427" },
                    { 48, @"1604, Beech Grove
                Metchosin (BC)
                V9C 7R6 
                Canada
                ", "Le Super Palmira est un immeuble extra, où il fait bon vivre!", "Le Super Palmira", "Cathryn", "Breksos", "783-785-4588" },
                    { 25, @"1221, Eastern Avenue
                Cumberland (ON)
                K4C 2T3 
                Canada
                ", "Le Super Eugenie est un immeuble extra, où il fait bon vivre!", "Le Super Eugenie", "Cathryn", "Breksos", "722-844-1814" },
                    { 23, @"4225, Bluebell Close
                Kingston (ON)
                K7K 6X8 
                Canada
                ", "Le Super Ernestine est un immeuble extra, où il fait bon vivre!", "Le Super Ernestine", "Adrian", "Lazmerge", "657-456-2877" },
                    { 2, @"838, Cherry Close
                Inner Nunavut (NU)
                X0C 5X5 
                Canada
                ", "Le Super Krissy est un immeuble extra, où il fait bon vivre!", "Le Super Krissy", "Pat", "Steinstrand", "742-813-7421" },
                    { 3, @"4326, Woodfield Road
                Lambton (ON)
                N0N 8G8 
                Canada
                ", "Le Super Pat est un immeuble extra, où il fait bon vivre!", "Le Super Pat", "Palmira", "Nuugaatrapaluk", "367-252-3834" },
                    { 4, @"2824, The Meadows
                Kimberley (BC)
                V1A 8B8 
                Canada
                ", "Le Super Palmira est un immeuble extra, où il fait bon vivre!", "Le Super Palmira", "Ralph", "Vadtälje", "785-411-6446" },
                    { 5, @"1322, Shaw Street
                Minto (NB)
                E4B 5G8 
                Canada
                ", "Le Super Ralph est un immeuble extra, où il fait bon vivre!", "Le Super Ralph", "Arielle", "Eqalunavik", "333-648-2851" },
                    { 6, @"4810, Birch Avenue
                Saint-Isidore (NB)
                E8M 7K9 
                Canada
                ", "Le Super Arielle est un immeuble extra, où il fait bon vivre!", "Le Super Arielle", "Troy", "Lystrup", "758-787-5464" },
                    { 7, @"3308, Maple Grove
                Riverview (NB)
                E1B 4B8 
                Canada
                ", "Le Super Troy est un immeuble extra, où il fait bon vivre!", "Le Super Troy", "Marcell", "Ixtatla", "476-136-1877" },
                    { 8, @"1806, The Pastures
                Cochrane (AB)
                T4C 8H1 
                Canada
                ", "Le Super Marcell est un immeuble extra, où il fait bon vivre!", "Le Super Marcell", "Vi", "Haapsa", "823-375-4482" },
                    { 9, @"303, Willow Close
                High River (AB)
                T1V 2N2 
                Canada
                ", "Le Super Vi est un immeuble extra, où il fait bon vivre!", "Le Super Vi", "Sherise", "Guasabaro", "441-434-8815" },
                    { 10, @"3791, Willow Drive
                Smiths Creek (NB)
                E4G 6C4 
                Canada
                ", "Le Super Sherise est un immeuble extra, où il fait bon vivre!", "Le Super Sherise", "Angelina", "Kalatee", "877-663-4428" },
                    { 11, @"2289, West Road
                La Baie (QC)
                G7B 6H9 
                Canada
                ", "Le Super Angelina est un immeuble extra, où il fait bon vivre!", "Le Super Angelina", "Liliana", "Boswood", "414-822-7833" },
                    { 12, @"787, South Close
                Fort Frances (ON)
                P9A 9N0 
                Canada
                ", "Le Super Liliana est un immeuble extra, où il fait bon vivre!", "Le Super Liliana", "Sheryl", "Hókrókur", "832-151-3446" },
                    { 13, @"4275, Church Walk
                Chilcotin (BC)
                V0L 5K2 
                Canada
                ", "Le Super Sheryl est un immeuble extra, où il fait bon vivre!", "Le Super Sheryl", "Mariella", "Dragstrup", "567-318-6851" },
                    { 14, @"2773, Brighton Road
                Bolton (ON)
                L7E 6N2 
                Canada
                ", "Le Super Mariella est un immeuble extra, où il fait bon vivre!", "Le Super Mariella", "Berniece", "Ketne", "185-557-2464" },
                    { 15, @"1271, South Drive
                Port Hawkesbury (NS)
                B9A 6R1 
                Canada
                ", "Le Super Berniece est un immeuble extra, où il fait bon vivre!", "Le Super Berniece", "Conrad", "Kalvee", "523-786-6877" },
                    { 16, @"4759, Rydal Close
                Senneville (QC)
                H9K 6V8 
                Canada
                ", "Le Super Conrad est un immeuble extra, où il fait bon vivre!", "Le Super Conrad", "Sherlene", "Kedainkai", "158-845-1482" },
                    { 17, @"3257, Milton Close
                Big Bras d'Or (NS)
                B1X 8S0 
                Canada
                ", "Le Super Sherlene est un immeuble extra, où il fait bon vivre!", "Le Super Sherlene", "Nicholas", "Rovanola", "576-284-5815" },
                    { 18, @"1755, St John's Road
                Îles-Laval (QC)
                H7Y 5E1 
                Canada
                ", "Le Super Nicholas est un immeuble extra, où il fait bon vivre!", "Le Super Nicholas", "Tyson", "Brønnøyden", "213-433-8428" },
                    { 19, @"253, Cherry Close
                Kapuskasing (ON)
                P5N 1H3 
                Canada
                ", "Le Super Tyson est un immeuble extra, où il fait bon vivre!", "Le Super Tyson", "Derick", "Ísafholt", "641-572-4833" },
                    { 20, @"3741, Sutton Road
                Squamish (BC)
                V8B 6E0 
                Canada
                ", "Le Super Derick est un immeuble extra, où il fait bon vivre!", "Le Super Derick", "Leida", "Hammervåg", "266-721-7446" },
                    { 21, @"2239, Mansfield Road
                Greely (ON)
                K4P 2M8 
                Canada
                ", "Le Super Leida est un immeuble extra, où il fait bon vivre!", "Le Super Leida", "Debi", "Kulli", "684-168-3851" },
                    { 22, @"737, Shaw Street
                Prince Rupert (BC)
                V8J 0C3 
                Canada
                ", "Le Super Debi est un immeuble extra, où il fait bon vivre!", "Le Super Debi", "Ernestine", "Enbo", "232-327-7464" },
                    { 24, @"2723, Maple Grove
                Dundas (ON)
                L9H 3C0 
                Canada
                ", "Le Super Adrian est un immeuble extra, où il fait bon vivre!", "Le Super Adrian", "Eugenie", "Reidcoln", "375-615-6481" },
                    { 99, @"4839, Maple Grove
                Yorkton (SK)
                S3N 9B2 
                Canada
                ", "Le Super Simonne est un immeuble extra, où il fait bon vivre!", "Le Super Simonne", "Jeanetta", "Mensmere", "478-681-3127" },
                    { 49, @"101, Walton Road
                Buena Vista (SK)
                S2V 1A1 
                Canada
                ", "Le Super Cathryn est un immeuble extra, où il fait bon vivre!", "Le Super Cathryn", "Eugenio", "Uummanqaq", "321-134-7113" },
                    { 51, @"2087, Henry Street
                L'Épiphanie (QC)
                J5X 3K0 
                Canada
                ", "Le Super Troy est un immeuble extra, où il fait bon vivre!", "Le Super Troy", "Tad", "Ixtatla", "374-422-7131" },
                    { 77, @"2954, Hamilton Road
                Smiths Creek (NB)
                E4G 6C4 
                Canada
                ", "Le Super Sherise est un immeuble extra, où il fait bon vivre!", "Le Super Sherise", "Angelina", "Kalatee", "845-887-4156" },
                    { 78, @"1452, Woodfield Road
                La Baie (QC)
                G7B 6H9 
                Canada
                ", "Le Super Angelina est un immeuble extra, où il fait bon vivre!", "Le Super Angelina", "Liliana", "Boswood", "463-246-7561" },
                    { 79, @"4940, The Meadows
                Fort Frances (ON)
                P9A 9N0 
                Canada
                ", "Le Super Liliana est un immeuble extra, où il fait bon vivre!", "Le Super Liliana", "Sheryl", "Hókrókur", "888-475-3174" },
                    { 80, @"3438, Cliff Road
                Chilcotin (BC)
                V0L 5K2 
                Canada
                ", "Le Super Sheryl est un immeuble extra, où il fait bon vivre!", "Le Super Sheryl", "Tonita", "Dragstrup", "536-634-7577" },
                    { 81, @"1936, Birch Avenue
                Fabreville (QC)
                H7P 4S8 
                Canada
                ", "Le Super Tonita est un immeuble extra, où il fait bon vivre!", "Le Super Tonita", "Berniece", "Ketne", "154-773-2182" },
                    { 82, @"434, Cornwall Road
                Yorkton (SK)
                S3N 3X1 
                Canada
                ", "Le Super Berniece est un immeuble extra, où il fait bon vivre!", "Le Super Berniece", "Conrad", "Kalvee", "581-122-6515" },
                    { 83, @"3922, The Pastures
                Senneville (QC)
                H9K 6V8 
                Canada
                ", "Le Super Conrad est un immeuble extra, où il fait bon vivre!", "Le Super Conrad", "Sherlene", "Kedainkai", "127-361-1128" },
                    { 84, @"2420, Willow Close
                Big Bras d'Or (NS)
                B1X 8S0 
                Canada
                ", "Le Super Sherlene est un immeuble extra, où il fait bon vivre!", "Le Super Sherlene", "Nicholas", "Rovanola", "544-428-5532" },
                    { 85, @"918, The Broadway
                Îles-Laval (QC)
                H7Y 5E1 
                Canada
                ", "Le Super Nicholas est un immeuble extra, où il fait bon vivre!", "Le Super Nicholas", "Bianca", "Brønnøyden", "272-657-8145" },
                    { 86, @"4406, West Road
                Kapuskasing (ON)
                P5N 1H3 
                Canada
                ", "Le Super Bianca est un immeuble extra, où il fait bon vivre!", "Le Super Bianca", "Derick", "Ísafholt", "618-816-4558" },
                    { 87, @"2904, South Close
                Arnprior (ON)
                K7S 8C9 
                Canada
                ", "Le Super Derick est un immeuble extra, où il fait bon vivre!", "Le Super Derick", "Leida", "Kungstuna", "235-245-8163" },
                    { 88, @"1402, Nelson Street
                Pointe-Claire (QC)
                H9R 4R4 
                Canada
                ", "Le Super Leida est un immeuble extra, où il fait bon vivre!", "Le Super Leida", "Debi", "Kulli", "663-384-3576" },
                    { 89, @"4889, Brighton Road
                Prince Rupert (BC)
                V8J 0C3 
                Canada
                ", "Le Super Debi est un immeuble extra, où il fait bon vivre!", "Le Super Debi", "Ernestine", "Clarehurst", "288-543-7181" },
                    { 90, @"3387, The Lane
                Kingston (ON)
                K7K 6X8 
                Canada
                ", "Le Super Ernestine est un immeuble extra, où il fait bon vivre!", "Le Super Ernestine", "Marlon", "Lazmerge", "626-772-2514" },
                    { 91, @"1885, Rydal Close
                Dundas (ON)
                L9H 3C0 
                Canada
                ", "Le Super Marlon est un immeuble extra, où il fait bon vivre!", "Le Super Marlon", "Eugenie", "Reidcoln", "354-831-6127" },
                    { 92, @"383, Milton Close
                Cumberland (ON)
                K4C 2T3 
                Canada
                ", "Le Super Eugenie est un immeuble extra, où il fait bon vivre!", "Le Super Eugenie", "Cathryn", "Breksos", "771-268-2532" },
                    { 93, @"3871, Ashfield Road
                La Tuque (QC)
                G9X 2H4 
                Canada
                ", "Le Super Cathryn est un immeuble extra, où il fait bon vivre!", "Le Super Cathryn", "Jamal", "Nuugaatrapaluk", "317-427-5145" },
                    { 94, @"2369, Cherry Close
                Petawawa (ON)
                K8H 2K5 
                Canada
                ", "Le Super Jamal est un immeuble extra, où il fait bon vivre!", "Le Super Jamal", "Emely", "Norrviken", "744-566-1558" },
                    { 95, @"867, Sutton Road
                La Plaine (QC)
                J7M 1G8 
                Canada
                ", "Le Super Emely est un immeuble extra, où il fait bon vivre!", "Le Super Emely", "Tad", "Eqalunavik", "362-715-4163" },
                    { 96, @"4355, The Meadows
                Saint-Hippolyte (QC)
                J8A 9B2 
                Canada
                ", "Le Super Tad est un immeuble extra, où il fait bon vivre!", "Le Super Tad", "Steven", "Ulhus", "887-154-8576" },
                    { 97, @"2853, Shaw Street
                Qualicum Beach (BC)
                V9K 3H0 
                Canada
                ", "Le Super Steven est un immeuble extra, où il fait bon vivre!", "Le Super Steven", "Roma", "Apatcruz", "435-313-3181" },
                    { 76, @"4456, Ashfield Road
                Nackawic (NB)
                E6G 5P4 
                Canada
                ", "Le Super Simonne est un immeuble extra, où il fait bon vivre!", "Le Super Simonne", "Sherise", "Guasabaro", "418-758-8543" },
                    { 50, @"3589, Manor Gardens
                Morden (MB)
                R6M 4V4 
                Canada
                ", "Le Super Eugenio est un immeuble extra, où il fait bon vivre!", "Le Super Eugenio", "Troy", "Norrviken", "746-273-3526" },
                    { 75, @"968, Westgate
                Kingsclear (NB)
                E3E 0G3 
                Canada
                ", "Le Super Marcell est un immeuble extra, où il fait bon vivre!", "Le Super Marcell", "Simonne", "Haapsa", "872-511-5138" },
                    { 73, @"3972, The Lane
                Saint-Isidore (NB)
                E8M 7K9 
                Canada
                ", "Le Super Arielle est un immeuble extra, où il fait bon vivre!", "Le Super Arielle", "Troy", "Lystrup", "727-223-5112" },
                    { 52, @"585, Swallow Close
                Richibucto (NB)
                E4W 3B2 
                Canada
                ", "Le Super Tad est un immeuble extra, où il fait bon vivre!", "Le Super Tad", "Vi", "Ulhus", "811-661-2544" },
                    { 53, @"4073, Thomas Street
                Apohaqui (NB)
                E5P 3X1 
                Canada
                ", "Le Super Vi est un immeuble extra, où il fait bon vivre!", "Le Super Vi", "Roma", "Guasabaro", "437-728-6157" },
                    { 54, @"2571, The Ridgeway
                Vegreville (AB)
                T9C 9P5 
                Canada
                ", "Le Super Roma est un immeuble extra, où il fait bon vivre!", "Le Super Roma", "Alejandro", "Mõisali", "865-156-1562" },
                    { 55, @"1069, Ruskin Avenue
                Pintendre (QC)
                G6C 2B4 
                Canada
                ", "Le Super Alejandro est un immeuble extra, où il fait bon vivre!", "Le Super Alejandro", "Liliana", "Boswood", "482-315-5175" },
                    { 56, @"4557, Elizabeth Close
                Buena Vista (SK)
                S2V 8G7 
                Canada
                ", "Le Super Liliana est un immeuble extra, où il fait bon vivre!", "Le Super Liliana", "Marcie", "Nittinen", "828-544-8588" },
                    { 57, @"3055, Willow Road
                Sylvan Lake (AB)
                T4S 3T9 
                Canada
                ", "Le Super Marcie est un immeuble extra, où il fait bon vivre!", "Le Super Marcie", "Mariella", "Dragstrup", "555-683-4113" },
                    { 58, @"1553, Westgate
                Port Moody (BC)
                V3H 0M6 
                Canada
                ", "Le Super Mariella est un immeuble extra, où il fait bon vivre!", "Le Super Mariella", "Jane", "Ólafsholt", "173-842-8526" },
                    { 59, @"51, Cedar Close
                Petite-Bourgogne (QC)
                H3J 9B1 
                Canada
                ", "Le Super Jane est un immeuble extra, où il fait bon vivre!", "Le Super Jane", "Marcella", "Kalvee", "521-271-3131" },
                    { 60, @"3539, Hamilton Road
                Pennfield (NB)
                E5H 1B2 
                Canada
                ", "Le Super Marcella est un immeuble extra, où il fait bon vivre!", "Le Super Marcella", "Sherlene", "Salkile", "146-338-7544" },
                    { 61, @"2037, Willow Lane
                Powell River (BC)
                V8A 0N0 
                Canada
                ", "Le Super Sherlene est un immeuble extra, où il fait bon vivre!", "Le Super Sherlene", "Antonetta", "Rovanola", "564-567-2157" },
                    { 62, @"535, Rosemary Lane
                Saint-Jacques (NB)
                E7B 9B3 
                Canada
                ", "Le Super Antonetta est un immeuble extra, où il fait bon vivre!", "Le Super Antonetta", "Tyson", "Balniai", "111-726-6562" },
                    { 63, @"4023, Cliff Road
                Sainte-Rose (QC)
                H7L 6B9 
                Canada
                ", "Le Super Tyson est un immeuble extra, où il fait bon vivre!", "Le Super Tyson", "Pierre", "Akssandur", "637-165-2175" },
                    { 64, @"2521, The Poplars
                Donnacona (QC)
                G3M 4N7 
                Canada
                ", "Le Super Pierre est un immeuble extra, où il fait bon vivre!", "Le Super Pierre", "Sheridan", "Hammervåg", "255-214-5587" },
                    { 65, @"1019, Cornwall Road
                Maniwaki (QC)
                J9E 9C7 
                Canada
                ", "Le Super Sheridan est un immeuble extra, où il fait bon vivre!", "Le Super Sheridan", "Debi", "Jaunli", "682-453-1112" },
                    { 66, @"4507, The Pastures
                Merritt (BC)
                V1K 5R6 
                Canada
                ", "Le Super Debi est un immeuble extra, où il fait bon vivre!", "Le Super Debi", "Johana", "Enbo", "228-612-4525" },
                    { 67, @"3005, Manor Gardens
                Carbonear (LB)
                A1Y 1R6 
                Canada
                ", "Le Super Johana est un immeuble extra, où il fait bon vivre!", "Le Super Johana", "Adrian", "Jonkruojis", "645-741-8138" },
                    { 68, @"1503, The Broadway
                Coverdale (NB)
                E1J 7A1 
                Canada
                ", "Le Super Adrian est un immeuble extra, où il fait bon vivre!", "Le Super Adrian", "Krissy", "Reidcoln", "373-188-3543" },
                    { 69, @"4990, Swallow Close
                Belleville (ON)
                K8R 1K4 
                Canada
                ", "Le Super Krissy est un immeuble extra, où il fait bon vivre!", "Le Super Krissy", "Pat", "Steinstrand", "718-337-7156" },
                    { 70, @"3488, Adelaide Street
                Petite-Bourgogne (QC)
                H3J 2L2 
                Canada
                ", "Le Super Pat est un immeuble extra, où il fait bon vivre!", "Le Super Pat", "Jamal", "Nuugaatrapaluk", "336-476-3561" },
                    { 71, @"1986, Nelson Street
                Kimberley (BC)
                V1A 8B8 
                Canada
                ", "Le Super Jamal est un immeuble extra, où il fait bon vivre!", "Le Super Jamal", "Ralph", "Vadtälje", "764-635-6174" },
                    { 72, @"484, Ruskin Avenue
                Minto (NB)
                E4B 5G8 
                Canada
                ", "Le Super Ralph est un immeuble extra, où il fait bon vivre!", "Le Super Ralph", "Arielle", "Eqalunavik", "381-864-2587" },
                    { 74, @"2470, Rydal Close
                Riverview (NB)
                E1B 4B8 
                Canada
                ", "Le Super Troy est un immeuble extra, où il fait bon vivre!", "Le Super Troy", "Marcell", "Apatcruz", "454-352-1525" },
                    { 199, @"4334, South Drive
                Maniwaki (QC)
                J9E 9C7 
                Canada
                ", "Le Super Sheridan est un immeuble extra, où il fait bon vivre!", "Le Super Sheridan", "Debi", "Kulli", "627-114-1356" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
