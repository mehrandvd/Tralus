using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("Country", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class Country : FixedEntityBase<Country>
    {
        public Country()
            : this("")
        {

        }

        public Country(string fixedName)
            : base(fixedName)
        {
        }

        [StringLength(3)]
        public string IsoAlpha3 { get; set; }

        [StringLength(2)]
        public string IsoAlpha2 { get; set; }

        public string IataCode { get; set; }

        [StringLength(200)]
        public string NameEn { get; set; }

        [StringLength(3)]
        public string UnNumeric3 { get; set; }

        [StringLength(2)]
        public string Fips104 { get; set; }

        public virtual IataRegionCode IataRegionCode { get; set; }
        public Guid? IataRegionCodeId { get; set; }

        public virtual Currency Currency { get; set; }
        public Guid? CurrencyId { get; set; }

        public virtual Continent Continent { get; set; }
        public Guid? ContinentId { get; set; }

        public static Country Afghanistan
        {
            get { return GetFixedEntity(); }
        }

        public static Country AlandIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country Albania
        {
            get { return GetFixedEntity(); }
        }

        public static Country Algeria
        {
            get { return GetFixedEntity(); }
        }

        public static Country AmericanSamoa
        {
            get { return GetFixedEntity(); }
        }

        public static Country Andorra
        {
            get { return GetFixedEntity(); }
        }

        public static Country Angola
        {
            get { return GetFixedEntity(); }
        }

        public static Country Anguilla
        {
            get { return GetFixedEntity(); }
        }

        public static Country Antarctica
        {
            get { return GetFixedEntity(); }
        }

        public static Country AntiguaandBarbuda
        {
            get { return GetFixedEntity(); }
        }

        public static Country Argentina
        {
            get { return GetFixedEntity(); }
        }

        public static Country Armenia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Aruba
        {
            get { return GetFixedEntity(); }
        }

        public static Country Australia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Austria
        {
            get { return GetFixedEntity(); }
        }

        public static Country Azerbaijan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Bahamas
        {
            get { return GetFixedEntity(); }
        }

        public static Country Bahrain
        {
            get { return GetFixedEntity(); }
        }

        public static Country Bangladesh
        {
            get { return GetFixedEntity(); }
        }

        public static Country Barbados
        {
            get { return GetFixedEntity(); }
        }

        public static Country Belarus
        {
            get { return GetFixedEntity(); }
        }

        public static Country Belgium
        {
            get { return GetFixedEntity(); }
        }

        public static Country Belize
        {
            get { return GetFixedEntity(); }
        }

        public static Country Benin
        {
            get { return GetFixedEntity(); }
        }

        public static Country Bermuda
        {
            get { return GetFixedEntity(); }
        }

        public static Country Bhutan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Bolivia
        {
            get { return GetFixedEntity(); }
        }

        public static Country BosniaandHerzegovina
        {
            get { return GetFixedEntity(); }
        }

        public static Country Botswana
        {
            get { return GetFixedEntity(); }
        }

        public static Country Brazil
        {
            get { return GetFixedEntity(); }
        }

        public static Country BruneiDarussalam
        {
            get { return GetFixedEntity(); }
        }

        public static Country Bulgaria
        {
            get { return GetFixedEntity(); }
        }

        public static Country BurkinaFaso
        {
            get { return GetFixedEntity(); }
        }

        public static Country Burundi
        {
            get { return GetFixedEntity(); }
        }

        public static Country Cambodia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Cameroon
        {
            get { return GetFixedEntity(); }
        }

        public static Country Canada
        {
            get { return GetFixedEntity(); }
        }

        public static Country CapeVerde
        {
            get { return GetFixedEntity(); }
        }

        public static Country CaymanIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country CentralAfricanRepublic
        {
            get { return GetFixedEntity(); }
        }

        public static Country Chad
        {
            get { return GetFixedEntity(); }
        }

        public static Country Chile
        {
            get { return GetFixedEntity(); }
        }

        public static Country China
        {
            get { return GetFixedEntity(); }
        }

        public static Country ChristmasIsland
        {
            get { return GetFixedEntity(); }
        }

        public static Country Cocos_Keeling_Islands
        {
            get { return GetFixedEntity(); }
        }

        public static Country Colombia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Comoros
        {
            get { return GetFixedEntity(); }
        }

        public static Country Congo_DemocraticRepublicofthe
        {
            get { return GetFixedEntity(); }
        }

        public static Country Congo_Republicof
        {
            get { return GetFixedEntity(); }
        }

        public static Country CookIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country CostaRica
        {
            get { return GetFixedEntity(); }
        }

        public static Country CoteD_Ivoire
        {
            get { return GetFixedEntity(); }
        }

        public static Country Croatia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Cuba
        {
            get { return GetFixedEntity(); }
        }

        public static Country Cyprus
        {
            get { return GetFixedEntity(); }
        }

        public static Country CzechRepublic
        {
            get { return GetFixedEntity(); }
        }

        public static Country Denmark
        {
            get { return GetFixedEntity(); }
        }

        public static Country Djibouti
        {
            get { return GetFixedEntity(); }
        }

        public static Country Dominica
        {
            get { return GetFixedEntity(); }
        }

        public static Country DominicanRepublic
        {
            get { return GetFixedEntity(); }
        }

        public static Country Ecuador
        {
            get { return GetFixedEntity(); }
        }

        public static Country Egypt
        {
            get { return GetFixedEntity(); }
        }

        public static Country ElSalvador
        {
            get { return GetFixedEntity(); }
        }

        public static Country EquatorialGuinea
        {
            get { return GetFixedEntity(); }
        }

        public static Country Eritrea
        {
            get { return GetFixedEntity(); }
        }

        public static Country Estonia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Ethiopia
        {
            get { return GetFixedEntity(); }
        }

        public static Country FalklandIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country FaroeIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country Fiji
        {
            get { return GetFixedEntity(); }
        }

        public static Country Finland
        {
            get { return GetFixedEntity(); }
        }

        public static Country France
        {
            get { return GetFixedEntity(); }
        }

        public static Country FrenchGuiana
        {
            get { return GetFixedEntity(); }
        }

        public static Country FrenchPolynesia
        {
            get { return GetFixedEntity(); }
        }

        public static Country FrenchSouthernTerritories
        {
            get { return GetFixedEntity(); }
        }

        public static Country Gabon
        {
            get { return GetFixedEntity(); }
        }

        public static Country Gambia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Georgia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Germany
        {
            get { return GetFixedEntity(); }
        }

        public static Country Ghana
        {
            get { return GetFixedEntity(); }
        }

        public static Country Gibraltar
        {
            get { return GetFixedEntity(); }
        }

        public static Country Greece
        {
            get { return GetFixedEntity(); }
        }

        public static Country Greenland
        {
            get { return GetFixedEntity(); }
        }

        public static Country Grenada
        {
            get { return GetFixedEntity(); }
        }

        public static Country Guadeloupe
        {
            get { return GetFixedEntity(); }
        }

        public static Country Guam
        {
            get { return GetFixedEntity(); }
        }

        public static Country Guatemala
        {
            get { return GetFixedEntity(); }
        }

        public static Country Guinea
        {
            get { return GetFixedEntity(); }
        }

        public static Country Guinea_Bissau
        {
            get { return GetFixedEntity(); }
        }

        public static Country Guyana
        {
            get { return GetFixedEntity(); }
        }

        public static Country Haiti
        {
            get { return GetFixedEntity(); }
        }

        public static Country Honduras
        {
            get { return GetFixedEntity(); }
        }

        public static Country HongKong
        {
            get { return GetFixedEntity(); }
        }

        public static Country Hungary
        {
            get { return GetFixedEntity(); }
        }

        public static Country Iceland
        {
            get { return GetFixedEntity(); }
        }

        public static Country India
        {
            get { return GetFixedEntity(); }
        }

        public static Country Indonesia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Iran
        {
            get { return GetFixedEntity(); }
        }

        public static Country Iraq
        {
            get { return GetFixedEntity(); }
        }

        public static Country Ireland
        {
            get { return GetFixedEntity(); }
        }

        public static Country Israel
        {
            get { return GetFixedEntity(); }
        }

        public static Country Italy
        {
            get { return GetFixedEntity(); }
        }

        public static Country Jamaica
        {
            get { return GetFixedEntity(); }
        }

        public static Country Japan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Jordan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Kazakhstan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Kenya
        {
            get { return GetFixedEntity(); }
        }

        public static Country Kiribati
        {
            get { return GetFixedEntity(); }
        }

        public static Country NorthKorea
        {
            get { return GetFixedEntity(); }
        }

        public static Country SouthKorea
        {
            get { return GetFixedEntity(); }
        }

        public static Country Kuwait
        {
            get { return GetFixedEntity(); }
        }

        public static Country Kyrgyzstan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Lao_PDR
        {
            get { return GetFixedEntity(); }
        }

        public static Country Latvia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Lebanon
        {
            get { return GetFixedEntity(); }
        }

        public static Country Lesotho
        {
            get { return GetFixedEntity(); }
        }

        public static Country Liberia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Libya
        {
            get { return GetFixedEntity(); }
        }

        public static Country Liechtenstein
        {
            get { return GetFixedEntity(); }
        }

        public static Country Lithuania
        {
            get { return GetFixedEntity(); }
        }

        public static Country Luxembourg
        {
            get { return GetFixedEntity(); }
        }

        public static Country Macau
        {
            get { return GetFixedEntity(); }
        }

        public static Country Macedonia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Madagascar
        {
            get { return GetFixedEntity(); }
        }

        public static Country Malawi
        {
            get { return GetFixedEntity(); }
        }

        public static Country Malaysia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Maldives
        {
            get { return GetFixedEntity(); }
        }

        public static Country Mali
        {
            get { return GetFixedEntity(); }
        }

        public static Country Malta
        {
            get { return GetFixedEntity(); }
        }

        public static Country MarshallIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country Martinique
        {
            get { return GetFixedEntity(); }
        }

        public static Country Mauritania
        {
            get { return GetFixedEntity(); }
        }

        public static Country Mauritius
        {
            get { return GetFixedEntity(); }
        }

        public static Country Mayotte
        {
            get { return GetFixedEntity(); }
        }

        public static Country Mexico
        {
            get { return GetFixedEntity(); }
        }

        public static Country Micronesia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Moldova
        {
            get { return GetFixedEntity(); }
        }

        public static Country Monaco
        {
            get { return GetFixedEntity(); }
        }

        public static Country Mongolia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Montenegro
        {
            get { return GetFixedEntity(); }
        }

        public static Country Montserrat
        {
            get { return GetFixedEntity(); }
        }

        public static Country Morocco
        {
            get { return GetFixedEntity(); }
        }

        public static Country Mozambique
        {
            get { return GetFixedEntity(); }
        }

        public static Country Myanmar
        {
            get { return GetFixedEntity(); }
        }

        public static Country Namibia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Nauru
        {
            get { return GetFixedEntity(); }
        }

        public static Country Nepal
        {
            get { return GetFixedEntity(); }
        }

        public static Country Netherlands
        {
            get { return GetFixedEntity(); }
        }

        public static Country NetherlandsAntilles
        {
            get { return GetFixedEntity(); }
        }

        public static Country NewCaledonia
        {
            get { return GetFixedEntity(); }
        }

        public static Country NewZealand
        {
            get { return GetFixedEntity(); }
        }

        public static Country Nicaragua
        {
            get { return GetFixedEntity(); }
        }

        public static Country Niger
        {
            get { return GetFixedEntity(); }
        }

        public static Country Nigeria
        {
            get { return GetFixedEntity(); }
        }

        public static Country Niue
        {
            get { return GetFixedEntity(); }
        }

        public static Country NorfolkIsland
        {
            get { return GetFixedEntity(); }
        }

        public static Country NorthernMarianaIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country Norway
        {
            get { return GetFixedEntity(); }
        }

        public static Country Oman
        {
            get { return GetFixedEntity(); }
        }

        public static Country Pakistan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Palau
        {
            get { return GetFixedEntity(); }
        }

        public static Country PalestinianTerritories
        {
            get { return GetFixedEntity(); }
        }

        public static Country Panama
        {
            get { return GetFixedEntity(); }
        }

        public static Country PapuaNewGuinea
        {
            get { return GetFixedEntity(); }
        }

        public static Country Paraguay
        {
            get { return GetFixedEntity(); }
        }

        public static Country Peru
        {
            get { return GetFixedEntity(); }
        }

        public static Country Philippines
        {
            get { return GetFixedEntity(); }
        }

        public static Country PitcairnIsland
        {
            get { return GetFixedEntity(); }
        }

        public static Country Poland
        {
            get { return GetFixedEntity(); }
        }

        public static Country Portugal
        {
            get { return GetFixedEntity(); }
        }

        public static Country PuertoRico
        {
            get { return GetFixedEntity(); }
        }

        public static Country Qatar
        {
            get { return GetFixedEntity(); }
        }

        public static Country Reunion
        {
            get { return GetFixedEntity(); }
        }

        public static Country Romania
        {
            get { return GetFixedEntity(); }
        }

        public static Country Russia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Rwanda
        {
            get { return GetFixedEntity(); }
        }

        public static Country St_Helena
        {
            get { return GetFixedEntity(); }
        }

        public static Country St_KittsandNevis
        {
            get { return GetFixedEntity(); }
        }

        public static Country St_Lucia
        {
            get { return GetFixedEntity(); }
        }

        public static Country St_PierreandMiquelon
        {
            get { return GetFixedEntity(); }
        }

        public static Country St_VincentandtheGrenadines
        {
            get { return GetFixedEntity(); }
        }

        public static Country Samoa
        {
            get { return GetFixedEntity(); }
        }

        public static Country SanMarino
        {
            get { return GetFixedEntity(); }
        }

        public static Country SaoTomeandPrincipe
        {
            get { return GetFixedEntity(); }
        }

        public static Country SaudiArabia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Senegal
        {
            get { return GetFixedEntity(); }
        }

        public static Country Serbia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Seychelles
        {
            get { return GetFixedEntity(); }
        }

        public static Country SierraLeone
        {
            get { return GetFixedEntity(); }
        }

        public static Country Singapore
        {
            get { return GetFixedEntity(); }
        }

        public static Country Slovakia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Slovenia
        {
            get { return GetFixedEntity(); }
        }

        public static Country SolomonIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country Somalia
        {
            get { return GetFixedEntity(); }
        }

        public static Country SouthAfrica
        {
            get { return GetFixedEntity(); }
        }

        public static Country SouthGeorgiaandSouthSandwichIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country SouthSudan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Spain
        {
            get { return GetFixedEntity(); }
        }

        public static Country SriLanka
        {
            get { return GetFixedEntity(); }
        }

        public static Country Sudan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Suriname
        {
            get { return GetFixedEntity(); }
        }

        public static Country SvalbardandJanMayen
        {
            get { return GetFixedEntity(); }
        }

        public static Country Swaziland
        {
            get { return GetFixedEntity(); }
        }

        public static Country Sweden
        {
            get { return GetFixedEntity(); }
        }

        public static Country Switzerland
        {
            get { return GetFixedEntity(); }
        }

        public static Country Syria
        {
            get { return GetFixedEntity(); }
        }

        public static Country Taiwan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Tajikistan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Tanzania
        {
            get { return GetFixedEntity(); }
        }

        public static Country Thailand
        {
            get { return GetFixedEntity(); }
        }

        public static Country EastTimor
        {
            get { return GetFixedEntity(); }
        }

        public static Country Togo
        {
            get { return GetFixedEntity(); }
        }

        public static Country Tokelau
        {
            get { return GetFixedEntity(); }
        }

        public static Country Tonga
        {
            get { return GetFixedEntity(); }
        }

        public static Country TrinidadandTobago
        {
            get { return GetFixedEntity(); }
        }

        public static Country Tunisia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Turkey
        {
            get { return GetFixedEntity(); }
        }

        public static Country Turkmenistan
        {
            get { return GetFixedEntity(); }
        }

        public static Country TurksandCaicosIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country Tuvalu
        {
            get { return GetFixedEntity(); }
        }

        public static Country Uganda
        {
            get { return GetFixedEntity(); }
        }

        public static Country Ukraine
        {
            get { return GetFixedEntity(); }
        }

        public static Country UnitedArabEmirates
        {
            get { return GetFixedEntity(); }
        }

        public static Country UnitedKingdom
        {
            get { return GetFixedEntity(); }
        }

        public static Country UnitedStates
        {
            get { return GetFixedEntity(); }
        }

        public static Country Uruguay
        {
            get { return GetFixedEntity(); }
        }

        public static Country Uzbekistan
        {
            get { return GetFixedEntity(); }
        }

        public static Country Vanuatu
        {
            get { return GetFixedEntity(); }
        }

        public static Country VaticanCityState
        {
            get { return GetFixedEntity(); }
        }

        public static Country Venezuela
        {
            get { return GetFixedEntity(); }
        }

        public static Country VietNam
        {
            get { return GetFixedEntity(); }
        }

        public static Country BritishVirginIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country U_S_VirginIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country WallisandFutunaIslands
        {
            get { return GetFixedEntity(); }
        }

        public static Country WesternSahara
        {
            get { return GetFixedEntity(); }
        }

        public static Country Yemen
        {
            get { return GetFixedEntity(); }
        }

        public static Country Zambia
        {
            get { return GetFixedEntity(); }
        }

        public static Country Zimbabwe
        {
            get { return GetFixedEntity(); }
        }
		
        /*OrderBy NameEn*/
        public override List<Country> PredefinedValues()
        {
            var result = new List<Country>();

            result.Add(new Country("Afghanistan")
            {
                Id = new Guid("0E009FC6-B102-4EE1-8519-FF9FF3B6B2B4"),
                Name = "افغانستان",
                IsoAlpha3 = "AFG",
                IsoAlpha2 = "AF",
                NameEn = "Afghanistan",
                UnNumeric3 = "4",
                Fips104 = "AF",
                CurrencyId = Currency.Afghanafghani.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("AlandIslands")
            {
                Id = new Guid("D73C65D7-6942-4865-84CE-1730F6A50860"),
                Name = "جزاير آلند",
                IsoAlpha3 = "ALA",
                IsoAlpha2 = "AX",
                NameEn = "Aland Islands",
                UnNumeric3 = "248",
                Fips104 = "",
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Albania")
            {
                Id = new Guid("41D5C468-94A3-419C-8AB3-6E569E81D1BD"),
                Name = "آلباني",
                IsoAlpha3 = "ALB",
                IsoAlpha2 = "AL",
                NameEn = "Albania",
                UnNumeric3 = "8",
                Fips104 = "AL",
                CurrencyId = Currency.Albanianlek.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Algeria")
            {
                Id = new Guid("E0087880-DF36-4F5B-826B-5423D980DD81"),
                Name = "الجزاير",
                IsoAlpha3 = "DZA",
                IsoAlpha2 = "DZ",
                NameEn = "Algeria",
                UnNumeric3 = "12",
                Fips104 = "AG",
                CurrencyId = Currency.Algeriandinar.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("AmericanSamoa")
            {
                Id = new Guid("6E11C403-7628-4E9F-AF32-1353A3DEB727"),
                Name = "سامواي آمريكايي",
                IsoAlpha3 = "ASM",
                IsoAlpha2 = "AS",
                NameEn = "American Samoa",
                UnNumeric3 = "16",
                Fips104 = "AQ",
                CurrencyId = Currency.Samoantālā.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Andorra")
            {
                Id = new Guid("35CC65ED-7691-4E4F-928D-5032E10CF562"),
                Name = "آندورا",
                IsoAlpha3 = "AND",
                IsoAlpha2 = "AD",
                NameEn = "Andorra",
                UnNumeric3 = "20",
                Fips104 = "AN",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Angola")
            {
                Id = new Guid("23C2A7B8-4552-4241-9720-7DC0E41D1EEB"),
                Name = "آنگولا",
                IsoAlpha3 = "AGO",
                IsoAlpha2 = "AO",
                NameEn = "Angola",
                UnNumeric3 = "24",
                Fips104 = "AO",
                CurrencyId = Currency.Angolankwanza.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Anguilla")
            {
                Id = new Guid("B41DA676-1436-490B-BB31-E08D6A2621C5"),
                Name = "انگوئيلا",
                IsoAlpha3 = "AIA",
                IsoAlpha2 = "AI",
                NameEn = "Anguilla",
                UnNumeric3 = "660",
                Fips104 = "AV",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Antarctica")
            {
                Id = new Guid("679310C3-F615-4C04-AF91-080F3954AC1B"),
                Name = "قطب جنوب",
                IsoAlpha3 = "ATA",
                IsoAlpha2 = "AQ",
                NameEn = "Antarctica",
                UnNumeric3 = "10",
                Fips104 = "AY",
                ContinentId = Continent.Antarctica.Id
            });

            result.Add(new Country("AntiguaandBarbuda")
            {
                Id = new Guid("D0220980-1828-4522-B311-052424797F81"),
                Name = "آنتيگوته و باربودا",
                IsoAlpha3 = "ATG",
                IsoAlpha2 = "AG",
                NameEn = "Antigua and Barbuda",
                UnNumeric3 = "28",
                Fips104 = "AC",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Argentina")
            {
                Id = new Guid("EB9BCB4E-D2F8-4360-BB0B-2EF782A31153"),
                Name = "آرژانتين",
                IsoAlpha3 = "ARG",
                IsoAlpha2 = "AR",
                NameEn = "Argentina",
                UnNumeric3 = "32",
                Fips104 = "AR",
                CurrencyId = Currency.Argentinepeso.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("Armenia")
            {
                Id = new Guid("1AE7EC4D-40AD-4A99-8D0D-1FCAA7B8E863"),
                Name = "ارمنستان",
                IsoAlpha3 = "ARM",
                IsoAlpha2 = "AM",
                NameEn = "Armenia",
                UnNumeric3 = "51",
                Fips104 = "AM",
                CurrencyId = Currency.Armeniandram.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Aruba")
            {
                Id = new Guid("18B77808-1790-40CF-AC3E-C14B2562914F"),
                Name = "آروبا",
                IsoAlpha3 = "ABW",
                IsoAlpha2 = "AW",
                NameEn = "Aruba",
                UnNumeric3 = "533",
                Fips104 = "AA",
                CurrencyId = Currency.Arubanflorin.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Australia")
            {
                Id = new Guid("890D1A47-B1D7-44C9-952D-124C0E9D971E"),
                Name = "استراليا",
                IsoAlpha3 = "AUS",
                IsoAlpha2 = "AU",
                NameEn = "Australia",
                UnNumeric3 = "36",
                Fips104 = "AS",
                CurrencyId = Currency.Australiandollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Austria")
            {
                Id = new Guid("6D759552-6BEA-4EC1-8340-6D2FEF3BAFCD"),
                Name = "اتريش",
                IsoAlpha3 = "AUT",
                IsoAlpha2 = "AT",
                NameEn = "Austria",
                UnNumeric3 = "40",
                Fips104 = "AU",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Azerbaijan")
            {
                Id = new Guid("382715B9-E554-411B-B770-3C8228185C60"),
                Name = "آذربايجان",
                IsoAlpha3 = "AZE",
                IsoAlpha2 = "AZ",
                NameEn = "Azerbaijan",
                UnNumeric3 = "31",
                Fips104 = "AJ",
                CurrencyId = Currency.Azerbaijanimanat.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Bahamas")
            {
                Id = new Guid("D72AA346-C1C9-4151-B71E-27971FC5CD09"),
                Name = "باهاماس",
                IsoAlpha3 = "BHS",
                IsoAlpha2 = "BS",
                NameEn = "Bahamas",
                UnNumeric3 = "44",
                Fips104 = "BF",
                CurrencyId = Currency.Bahamiandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Bahrain")
            {
                Id = new Guid("CDC5DA31-4EF8-46F3-90D2-704F9F34B1F0"),
                Name = "بحرين",
                IsoAlpha3 = "BHR",
                IsoAlpha2 = "BH",
                NameEn = "Bahrain",
                UnNumeric3 = "48",
                Fips104 = "BA",
                CurrencyId = Currency.Bahrainidinar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Bangladesh")
            {
                Id = new Guid("6A2946C1-977A-4918-B97D-0C092E210119"),
                Name = "بنگلادش",
                IsoAlpha3 = "BGD",
                IsoAlpha2 = "BD",
                NameEn = "Bangladesh",
                UnNumeric3 = "50",
                Fips104 = "BG",
                CurrencyId = Currency.Bangladeshitaka.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Barbados")
            {
                Id = new Guid("EB198BD9-1290-4A5D-90F5-4373F39FFF25"),
                Name = "باربادوس",
                IsoAlpha3 = "BRB",
                IsoAlpha2 = "BB",
                NameEn = "Barbados",
                UnNumeric3 = "52",
                Fips104 = "BB",
                CurrencyId = Currency.Barbadiandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Belarus")
            {
                Id = new Guid("D1473AF8-2396-484A-A11C-77801165D943"),
                Name = "بلاروس",
                IsoAlpha3 = "BLR",
                IsoAlpha2 = "BY",
                NameEn = "Belarus",
                UnNumeric3 = "112",
                Fips104 = "BO",
                CurrencyId = Currency.Belarusianruble.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Belgium")
            {
                Id = new Guid("3C21FD67-C6D3-4F39-AC01-A1F0351CC233"),
                Name = "بلژيك",
                IsoAlpha3 = "BEL",
                IsoAlpha2 = "BE",
                NameEn = "Belgium",
                UnNumeric3 = "56",
                Fips104 = "BE",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Belize")
            {
                Id = new Guid("FE877635-D24B-485A-9B59-066AC2020957"),
                Name = "بليز",
                IsoAlpha3 = "BLZ",
                IsoAlpha2 = "BZ",
                NameEn = "Belize",
                UnNumeric3 = "84",
                Fips104 = "BH",
                CurrencyId = Currency.Belizedollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Benin")
            {
                Id = new Guid("79CD3D3A-7DD3-4949-A539-B2770D3AE3FA"),
                Name = "بنين",
                IsoAlpha3 = "BEN",
                IsoAlpha2 = "BJ",
                NameEn = "Benin",
                UnNumeric3 = "204",
                Fips104 = "BN",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Bermuda")
            {
                Id = new Guid("DA7887D0-167C-46F3-B5C6-9CA2522BB297"),
                Name = "برمودا",
                IsoAlpha3 = "BMU",
                IsoAlpha2 = "BM",
                NameEn = "Bermuda",
                UnNumeric3 = "60",
                Fips104 = "BD",
                CurrencyId = Currency.Bermudiandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Bhutan")
            {
                Id = new Guid("A57CC65A-60B1-4B83-990E-FA4D8F7BFE5D"),
                Name = "بوتان",
                IsoAlpha3 = "BTN",
                IsoAlpha2 = "BT",
                NameEn = "Bhutan",
                UnNumeric3 = "64",
                Fips104 = "BT",
                CurrencyId = Currency.Bhutanesengultrum.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Bolivia")
            {
                Id = new Guid("B68EC510-BC0F-4372-8588-F850C864C1B7"),
                Name = "بليويه",
                IsoAlpha3 = "BOL",
                IsoAlpha2 = "BO",
                NameEn = "Bolivia",
                UnNumeric3 = "68",
                Fips104 = "BL",
                CurrencyId = Currency.Bolivianboliviano.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("BosniaandHerzegovina")
            {
                Id = new Guid("08FE2180-B155-4A87-A35F-DA1DD58BE25A"),
                Name = "بسني و هرزگوين",
                IsoAlpha3 = "BIH",
                IsoAlpha2 = "BA",
                NameEn = "Bosnia and Herzegovina",
                UnNumeric3 = "70",
                Fips104 = "BK",
                CurrencyId = Currency.BosniaandHerzegovinaconvertiblemark.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Botswana")
            {
                Id = new Guid("81F1DC71-8287-45CD-9CF2-19B99EB29CDD"),
                Name = "بوتسونا",
                IsoAlpha3 = "BWA",
                IsoAlpha2 = "BW",
                NameEn = "Botswana",
                UnNumeric3 = "72",
                Fips104 = "BC",
                CurrencyId = Currency.Botswanapula.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Brazil")
            {
                Id = new Guid("F1D72832-0ED3-4CDB-B5BB-45A85007240C"),
                Name = "برزيل",
                IsoAlpha3 = "BRA",
                IsoAlpha2 = "BR",
                NameEn = "Brazil",
                UnNumeric3 = "76",
                Fips104 = "BR",
                CurrencyId = Currency.Brazilianreal.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("BritishVirginIslands")
            {
                Id = new Guid("499B39D3-A735-437D-8094-6E914455D26A"),
                Name = "جزاير ورجن بريتانيا",
                IsoAlpha3 = "VGB",
                IsoAlpha2 = "VG",
                NameEn = "British Virgin Islands",
                UnNumeric3 = "92",
                Fips104 = "VI",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("BruneiDarussalam")
            {
                Id = new Guid("2D0439DF-D44A-4BE7-A1CB-360ED3D577CD"),
                Name = "بروني دارالسلام",
                IsoAlpha3 = "BRN",
                IsoAlpha2 = "BN",
                NameEn = "Brunei Darussalam",
                UnNumeric3 = "96",
                Fips104 = "BX",
                CurrencyId = Currency.Bruneidollar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Bulgaria")
            {
                Id = new Guid("268A5C08-E30E-4DE5-A953-90F0244F0F67"),
                Name = "بلغارستان",
                IsoAlpha3 = "BGR",
                IsoAlpha2 = "BG",
                NameEn = "Bulgaria",
                UnNumeric3 = "100",
                Fips104 = "BU",
                CurrencyId = Currency.Bulgarianlev.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("BurkinaFaso")
            {
                Id = new Guid("7BCDB8D1-ED67-483F-9023-272C841A4B70"),
                Name = "بوركينو فاسو",
                IsoAlpha3 = "BFA",
                IsoAlpha2 = "BF",
                NameEn = "Burkina Faso",
                UnNumeric3 = "854",
                Fips104 = "UV",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Burundi")
            {
                Id = new Guid("937ED01C-A1BA-4354-81D6-6A938A13BCB1"),
                Name = "بوروندي",
                IsoAlpha3 = "BDI",
                IsoAlpha2 = "BI",
                NameEn = "Burundi",
                UnNumeric3 = "108",
                Fips104 = "BY",
                CurrencyId = Currency.Burundianfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Cambodia")
            {
                Id = new Guid("D3DD30D0-5B03-4D2C-9AFE-66C10740167A"),
                Name = "كامبوج",
                IsoAlpha3 = "KHM",
                IsoAlpha2 = "KH",
                NameEn = "Cambodia",
                UnNumeric3 = "116",
                Fips104 = "CB",
                CurrencyId = Currency.Cambodianriel.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Cameroon")
            {
                Id = new Guid("B6A07971-8ABE-4C48-AE0E-28D0279AB8AA"),
                Name = "كامرون",
                IsoAlpha3 = "CMR",
                IsoAlpha2 = "CM",
                NameEn = "Cameroon",
                UnNumeric3 = "120",
                Fips104 = "CM",
                CurrencyId = Currency.CentralAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Canada")
            {
                Id = new Guid("D733F817-C0A0-4BD4-A36B-BE82425A3047"),
                Name = "كانادا",
                IsoAlpha3 = "CAN",
                IsoAlpha2 = "CA",
                NameEn = "Canada",
                UnNumeric3 = "124",
                Fips104 = "CA",
                CurrencyId = Currency.Canadiandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("CapeVerde")
            {
                Id = new Guid("CB6F2863-100A-4B59-BF4A-8691C0E576A8"),
                Name = "كيپ ورده",
                IsoAlpha3 = "CPV",
                IsoAlpha2 = "CV",
                NameEn = "Cape Verde",
                UnNumeric3 = "132",
                Fips104 = "CV",
                CurrencyId = Currency.CapeVerdeanescudo.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("CaymanIslands")
            {
                Id = new Guid("EA1C50AC-30D9-42A8-B576-7748E1A6976A"),
                Name = "جزاير كايمن",
                IsoAlpha3 = "CYM",
                IsoAlpha2 = "KY",
                NameEn = "Cayman Islands",
                UnNumeric3 = "136",
                Fips104 = "CJ",
                CurrencyId = Currency.CaymanIslandsdollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("CentralAfricanRepublic")
            {
                Id = new Guid("A06B8DE6-BB24-4867-B2A2-24536F93620C"),
                Name = "جمهوري آفريقاي مركزي",
                IsoAlpha3 = "CAF",
                IsoAlpha2 = "CF",
                NameEn = "Central African Republic",
                UnNumeric3 = "140",
                Fips104 = "CT",
                CurrencyId = Currency.CentralAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Chad")
            {
                Id = new Guid("EB59F320-46CC-454B-A161-6D867E8DA081"),
                Name = "چاد",
                IsoAlpha3 = "TCD",
                IsoAlpha2 = "TD",
                NameEn = "Chad",
                UnNumeric3 = "148",
                Fips104 = "CD",
                CurrencyId = Currency.CentralAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Chile")
            {
                Id = new Guid("4C81C52F-FB3E-44D2-994E-60701F61816E"),
                Name = "شيلي",
                IsoAlpha3 = "CHL",
                IsoAlpha2 = "CL",
                NameEn = "Chile",
                UnNumeric3 = "152",
                Fips104 = "CI",
                CurrencyId = Currency.Chileanpeso.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("China")
            {
                Id = new Guid("1DAC251B-44F0-40FF-ABCE-AAC76A2414FE"),
                Name = "چين",
                IsoAlpha3 = "CHN",
                IsoAlpha2 = "CN",
                NameEn = "China",
                UnNumeric3 = "156",
                Fips104 = "CH",
                CurrencyId = Currency.Chineseyuan.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("ChristmasIsland")
            {
                Id = new Guid("0942E6CF-A80C-4A2B-8AF8-0295C64A7910"),
                Name = "جزاير كريسمس",
                IsoAlpha3 = "CXR",
                IsoAlpha2 = "CX",
                NameEn = "Christmas Island",
                UnNumeric3 = "162",
                Fips104 = "KT",
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Cocos_Keeling_Islands")
            {
                Id = new Guid("4EF882E3-FE0E-4A36-804E-496F24C6AF14"),
                Name = "جزاير كوكوس",
                IsoAlpha3 = "CCK",
                IsoAlpha2 = "CC",
                NameEn = "Cocos (Keeling) Islands",
                UnNumeric3 = "166",
                Fips104 = "CK",
                CurrencyId = Currency.Australiandollar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Colombia")
            {
                Id = new Guid("1CB5743B-7886-41DE-AF9F-56852CBB8404"),
                Name = "كلمبيا",
                IsoAlpha3 = "COL",
                IsoAlpha2 = "CO",
                NameEn = "Colombia",
                UnNumeric3 = "170",
                Fips104 = "CO",
                CurrencyId = Currency.Colombianpeso.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("Comoros")
            {
                Id = new Guid("27B7F218-920C-497A-BC2A-9725BDF4EE4F"),
                Name = "كوموروس",
                IsoAlpha3 = "COM",
                IsoAlpha2 = "KM",
                NameEn = "Comoros",
                UnNumeric3 = "174",
                Fips104 = "CN",
                CurrencyId = Currency.Comorianfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Congo_DemocraticRepublicofthe")
            {
                Id = new Guid("3B18D1B0-8001-4737-AB04-3696A55B3187"),
                Name = "جموري دموكراتيك كنگو",
                IsoAlpha3 = "COD",
                IsoAlpha2 = "CD",
                NameEn = "Congo, Democratic Republic of the",
                UnNumeric3 = "180",
                Fips104 = "CG",
                CurrencyId = Currency.Congolesefranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Congo_Republicof")
            {
                Id = new Guid("01960900-AE3E-48A2-BBB7-582F5436DFD9"),
                Name = "جموري كنگو",
                IsoAlpha3 = "COG",
                IsoAlpha2 = "CG",
                NameEn = "Congo, Republic of",
                UnNumeric3 = "178",
                Fips104 = "CF",
                CurrencyId = Currency.CentralAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("CookIslands")
            {
                Id = new Guid("07E96325-1C92-4632-9C91-4F71FAFFDB37"),
                Name = "جزاير كوك",
                IsoAlpha3 = "COK",
                IsoAlpha2 = "CK",
                NameEn = "Cook Islands",
                UnNumeric3 = "184",
                Fips104 = "CW",
                CurrencyId = Currency.NewZealanddollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("CostaRica")
            {
                Id = new Guid("B3931BDD-8A7F-46A9-9550-0EC147C4E4A6"),
                Name = "كستاريكا",
                IsoAlpha3 = "CRI",
                IsoAlpha2 = "CR",
                NameEn = "Costa Rica",
                UnNumeric3 = "188",
                Fips104 = "CS",
                CurrencyId = Currency.CostaRicancolón.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("CoteD_Ivoire")
            {
                Id = new Guid("6745C9F5-381F-4846-9BF6-D54A726B384B"),
                Name = "ساحل عاج",
                IsoAlpha3 = "CIV",
                IsoAlpha2 = "CI",
                NameEn = "Cote D'Ivoire",
                UnNumeric3 = "384",
                Fips104 = "IV",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Croatia")
            {
                Id = new Guid("9BDF6556-0D56-4062-AE91-C2D0AB596693"),
                Name = "كرواسي",
                IsoAlpha3 = "HRV",
                IsoAlpha2 = "HR",
                NameEn = "Croatia",
                UnNumeric3 = "191",
                Fips104 = "HR",
                CurrencyId = Currency.Croatiankuna.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Cuba")
            {
                Id = new Guid("C0C4DD90-8C99-4CC3-A1C7-625D076EE38F"),
                Name = "كوبا",
                IsoAlpha3 = "CUB",
                IsoAlpha2 = "CU",
                NameEn = "Cuba",
                UnNumeric3 = "192",
                Fips104 = "CU",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Cyprus")
            {
                Id = new Guid("AF0B207A-E372-4C82-B1C7-898BC2A4DC28"),
                Name = "قبرس",
                IsoAlpha3 = "CYP",
                IsoAlpha2 = "CY",
                NameEn = "Cyprus",
                UnNumeric3 = "196",
                Fips104 = "CY",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("CzechRepublic")
            {
                Id = new Guid("24F313E5-C2F5-4487-B229-06E0278319F2"),
                Name = "جمهوري جك",
                IsoAlpha3 = "CZE",
                IsoAlpha2 = "CZ",
                NameEn = "Czech Republic",
                UnNumeric3 = "203",
                Fips104 = "EZ",
                CurrencyId = Currency.Czechkoruna.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Denmark")
            {
                Id = new Guid("77F79176-2F09-402D-98AD-5224364006CA"),
                Name = "دانمارك",
                IsoAlpha3 = "DNK",
                IsoAlpha2 = "DK",
                NameEn = "Denmark",
                UnNumeric3 = "208",
                Fips104 = "DA",
                CurrencyId = Currency.Danishkrone.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Djibouti")
            {
                Id = new Guid("BE85BDD9-B533-4799-A253-6DF145FA3355"),
                Name = "جيبوتي",
                IsoAlpha3 = "DJI",
                IsoAlpha2 = "DJ",
                NameEn = "Djibouti",
                UnNumeric3 = "262",
                Fips104 = "DJ",
                CurrencyId = Currency.Djiboutianfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Dominica")
            {
                Id = new Guid("25C9B6DA-6BE0-4BCD-919A-F2ABA461D092"),
                Name = "دومينيكا",
                IsoAlpha3 = "DMA",
                IsoAlpha2 = "DM",
                NameEn = "Dominica",
                UnNumeric3 = "212",
                Fips104 = "DO",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("DominicanRepublic")
            {
                Id = new Guid("14476B00-AC5D-4788-8A82-E7E0D8F14A03"),
                Name = "جمهوري دومينيك",
                IsoAlpha3 = "DOM",
                IsoAlpha2 = "DO",
                NameEn = "Dominican Republic",
                UnNumeric3 = "214",
                Fips104 = "DR",
                CurrencyId = Currency.Dominicanpeso.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("EastTimor")
            {
                Id = new Guid("525B0DD2-7511-483E-AA6D-3BC5FB2CCFFA"),
                Name = "تيمور شرقي",
                IsoAlpha3 = "TLS",
                IsoAlpha2 = "TL",
                NameEn = "East Timor",
                UnNumeric3 = "626",
                Fips104 = "TT",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Ecuador")
            {
                Id = new Guid("D89846E1-FBB3-4698-A65E-31F890AA115C"),
                Name = "اكوادور",
                IsoAlpha3 = "ECU",
                IsoAlpha2 = "EC",
                NameEn = "Ecuador",
                UnNumeric3 = "218",
                Fips104 = "EC",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("Egypt")
            {
                Id = new Guid("ACA8438B-0C56-4607-8FCD-CDB98B57798D"),
                Name = "مصر",
                IsoAlpha3 = "EGY",
                IsoAlpha2 = "EG",
                NameEn = "Egypt",
                UnNumeric3 = "818",
                Fips104 = "EG",
                CurrencyId = Currency.Egyptianpound.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("ElSalvador")
            {
                Id = new Guid("3AB729A7-BFFD-4352-8FC3-49C81C004CFC"),
                Name = "السالوادر",
                IsoAlpha3 = "SLV",
                IsoAlpha2 = "SV",
                NameEn = "El Salvador",
                UnNumeric3 = "222",
                Fips104 = "ES",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("EquatorialGuinea")
            {
                Id = new Guid("71273C75-4D7F-4E02-A8DB-6426E18BDBD8"),
                Name = "گينه استوايي",
                IsoAlpha3 = "GNQ",
                IsoAlpha2 = "GQ",
                NameEn = "Equatorial Guinea",
                UnNumeric3 = "226",
                Fips104 = "EK",
                CurrencyId = Currency.CentralAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Eritrea")
            {
                Id = new Guid("13A75217-082E-48FD-951A-44DBD18E7960"),
                Name = "اريتره",
                IsoAlpha3 = "ERI",
                IsoAlpha2 = "ER",
                NameEn = "Eritrea",
                UnNumeric3 = "232",
                Fips104 = "ER",
                CurrencyId = Currency.Eritreannakfa.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Estonia")
            {
                Id = new Guid("F7B7B843-6E12-4089-AC4D-6696688B3929"),
                Name = "استوني",
                IsoAlpha3 = "EST",
                IsoAlpha2 = "EE",
                NameEn = "Estonia",
                UnNumeric3 = "233",
                Fips104 = "EN",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Ethiopia")
            {
                Id = new Guid("A52C6AC1-97E6-4F95-8A35-8588CF44E742"),
                Name = "اتيوپي",
                IsoAlpha3 = "ETH",
                IsoAlpha2 = "ET",
                NameEn = "Ethiopia",
                UnNumeric3 = "231",
                Fips104 = "ET",
                CurrencyId = Currency.Ethiopianbirr.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("FalklandIslands")
            {
                Id = new Guid("94265538-B38D-4F78-80DD-2CB4FD6F6929"),
                Name = "جزاير مالويناس",
                IsoAlpha3 = "FLK",
                IsoAlpha2 = "FK",
                NameEn = "Falkland Islands",
                UnNumeric3 = "238",
                Fips104 = "FK",
                CurrencyId = Currency.FalklandIslandspound.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("FaroeIslands")
            {
                Id = new Guid("24758E69-A769-471D-B7F8-C8979CB4A3B9"),
                Name = "جزاير فارو",
                IsoAlpha3 = "FRO",
                IsoAlpha2 = "FO",
                NameEn = "Faroe Islands",
                UnNumeric3 = "234",
                Fips104 = "FO",
                CurrencyId = Currency.Danishkrone.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Fiji")
            {
                Id = new Guid("3020FBEF-D62C-4D58-8D9B-915CEC7CEEC4"),
                Name = "قيجي",
                IsoAlpha3 = "FJI",
                IsoAlpha2 = "FJ",
                NameEn = "Fiji",
                UnNumeric3 = "242",
                Fips104 = "FJ",
                CurrencyId = Currency.Fijiandollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Finland")
            {
                Id = new Guid("9B0B8F09-93CB-4883-92C3-E01DB55DB4D4"),
                Name = "فنلاند",
                IsoAlpha3 = "FIN",
                IsoAlpha2 = "FI",
                NameEn = "Finland",
                UnNumeric3 = "246",
                Fips104 = "FI",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("France")
            {
                Id = new Guid("620345B0-E0BC-4EF7-8958-316616DA593E"),
                Name = "فرانسه",
                IsoAlpha3 = "FRA",
                IsoAlpha2 = "FR",
                NameEn = "France",
                UnNumeric3 = "250",
                Fips104 = "FR",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("FrenchGuiana")
            {
                Id = new Guid("02A9B6B2-781B-4ED9-97C1-0ED1AEAEB05F"),
                Name = "گينه فرانسوي",
                IsoAlpha3 = "GUF",
                IsoAlpha2 = "GF",
                NameEn = "French Guiana",
                UnNumeric3 = "254",
                Fips104 = "FG",
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("FrenchPolynesia")
            {
                Id = new Guid("F1A2DCD0-2F68-4430-B500-4B108E657E02"),
                Name = "پلينيژاي فرانسوي",
                IsoAlpha3 = "PYF",
                IsoAlpha2 = "PF",
                NameEn = "French Polynesia",
                UnNumeric3 = "258",
                Fips104 = "FP",
                CurrencyId = Currency.CFPfranc.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("FrenchSouthernTerritories")
            {
                Id = new Guid("97B8F7D0-963A-4BD5-8896-78F6BD944239"),
                Name = "سرزمين هاي جنوبي فرانسوي",
                IsoAlpha3 = "ATF",
                IsoAlpha2 = "TF",
                NameEn = "French Southern Territories",
                UnNumeric3 = "260",
                Fips104 = "FS",
                ContinentId = Continent.Antarctica.Id
            });

            result.Add(new Country("Gabon")
            {
                Id = new Guid("F685ED77-E443-4692-8D75-4DE2854FF8D6"),
                Name = "گابون",
                IsoAlpha3 = "GAB",
                IsoAlpha2 = "GA",
                NameEn = "Gabon",
                UnNumeric3 = "266",
                Fips104 = "GB",
                CurrencyId = Currency.CentralAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Gambia")
            {
                Id = new Guid("ABFFCE9D-F4DF-4577-881A-5DAD3235ED19"),
                Name = "گامبيا",
                IsoAlpha3 = "GMB",
                IsoAlpha2 = "GM",
                NameEn = "Gambia",
                UnNumeric3 = "270",
                Fips104 = "GA",
                CurrencyId = Currency.Gambiandalasi.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Georgia")
            {
                Id = new Guid("DE4A1FF4-988E-4C94-BF5B-3AFF20FCB1B0"),
                Name = "گرجستان",
                IsoAlpha3 = "GEO",
                IsoAlpha2 = "GE",
                NameEn = "Georgia",
                UnNumeric3 = "268",
                Fips104 = "GG",
                CurrencyId = Currency.Georgianlari.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Germany")
            {
                Id = new Guid("D1106FA4-B782-4534-94A5-DB15270B9F58"),
                Name = "آلمان",
                IsoAlpha3 = "DEU",
                IsoAlpha2 = "DE",
                NameEn = "Germany",
                UnNumeric3 = "276",
                Fips104 = "GM",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Ghana")
            {
                Id = new Guid("8EFEE7F6-DA06-4B8A-923D-F6961CA511AD"),
                Name = "غنا",
                IsoAlpha3 = "GHA",
                IsoAlpha2 = "GH",
                NameEn = "Ghana",
                UnNumeric3 = "288",
                Fips104 = "GH",
                CurrencyId = Currency.Ghanacedi.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Gibraltar")
            {
                Id = new Guid("8918AF5A-A8CF-4C73-AC8F-63502F211B96"),
                Name = "جبل الطارق",
                IsoAlpha3 = "GIB",
                IsoAlpha2 = "GI",
                NameEn = "Gibraltar",
                UnNumeric3 = "292",
                Fips104 = "GI",
                CurrencyId = Currency.Gibraltarpound.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Greece")
            {
                Id = new Guid("E725A514-3DE4-4EE4-8CC5-DDC648754368"),
                Name = "يونان",
                IsoAlpha3 = "GRC",
                IsoAlpha2 = "GR",
                NameEn = "Greece",
                UnNumeric3 = "300",
                Fips104 = "GR",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Greenland")
            {
                Id = new Guid("EA1E4475-8433-4FD5-988E-D3DCF535CC45"),
                Name = "گروئنلند",
                IsoAlpha3 = "GRL",
                IsoAlpha2 = "GL",
                NameEn = "Greenland",
                UnNumeric3 = "304",
                Fips104 = "GL",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Grenada")
            {
                Id = new Guid("F01BA047-6899-420D-A239-4933E0A08E9B"),
                Name = "گرانادا",
                IsoAlpha3 = "GRD",
                IsoAlpha2 = "GD",
                NameEn = "Grenada",
                UnNumeric3 = "308",
                Fips104 = "GJ",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Guadeloupe")
            {
                Id = new Guid("8DB522E2-9430-4E70-A5A0-0A05B8595C6E"),
                Name = "گوادالوپ",
                IsoAlpha3 = "GLP",
                IsoAlpha2 = "GP",
                NameEn = "Guadeloupe",
                UnNumeric3 = "312",
                Fips104 = "GP",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Guam")
            {
                Id = new Guid("CF6083F8-2A55-4311-B9D9-4FB09A4099F1"),
                Name = "گوام",
                IsoAlpha3 = "GUM",
                IsoAlpha2 = "GU",
                NameEn = "Guam",
                UnNumeric3 = "316",
                Fips104 = "GQ",
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Guatemala")
            {
                Id = new Guid("6056C63A-EA96-4651-A27C-0E454BF14575"),
                Name = "گواتمالا",
                IsoAlpha3 = "GTM",
                IsoAlpha2 = "GT",
                NameEn = "Guatemala",
                UnNumeric3 = "320",
                Fips104 = "GT",
                CurrencyId = Currency.Guatemalanquetzal.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Guinea")
            {
                Id = new Guid("BFE6A14B-A1C5-4A93-B51C-E861C64C8EF8"),
                Name = "گينه",
                IsoAlpha3 = "GIN",
                IsoAlpha2 = "GN",
                NameEn = "Guinea",
                UnNumeric3 = "324",
                Fips104 = "GV",
                CurrencyId = Currency.Guineanfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Guinea_Bissau")
            {
                Id = new Guid("E829BE3E-38CD-4890-8DC8-2781C12C8973"),
                Name = "گينه بيسائو",
                IsoAlpha3 = "GNB",
                IsoAlpha2 = "GW",
                NameEn = "Guinea-Bissau",
                UnNumeric3 = "624",
                Fips104 = "PU",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Guyana")
            {
                Id = new Guid("D7FEC700-AF66-4684-936A-8272A53B90EC"),
                Name = "گايانا",
                IsoAlpha3 = "GUY",
                IsoAlpha2 = "GY",
                NameEn = "Guyana",
                UnNumeric3 = "328",
                Fips104 = "GY",
                CurrencyId = Currency.Guyanesedollar.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("Haiti")
            {
                Id = new Guid("5D19A73E-F348-4F45-A70A-28BDC46B0BF0"),
                Name = "هائيتي",
                IsoAlpha3 = "HTI",
                IsoAlpha2 = "HT",
                NameEn = "Haiti",
                UnNumeric3 = "332",
                Fips104 = "HA",
                CurrencyId = Currency.Haitiangourde.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Honduras")
            {
                Id = new Guid("92445ABA-AC7B-4B02-BD90-90D2EEEE5CD4"),
                Name = "هاندوراس",
                IsoAlpha3 = "HND",
                IsoAlpha2 = "HN",
                NameEn = "Honduras",
                UnNumeric3 = "340",
                Fips104 = "HO",
                CurrencyId = Currency.Honduranlempira.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("HongKong")
            {
                Id = new Guid("EDF8EFBA-6AEC-43B3-8531-C3DDD6658DD3"),
                Name = "هنگ كنگ",
                IsoAlpha3 = "HKG",
                IsoAlpha2 = "HK",
                NameEn = "Hong Kong",
                UnNumeric3 = "344",
                Fips104 = "HK",
                CurrencyId = Currency.HongKongdollar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Hungary")
            {
                Id = new Guid("FE1C90F7-EE82-455D-B661-75190F0C2276"),
                Name = "مجارستان",
                IsoAlpha3 = "HUN",
                IsoAlpha2 = "HU",
                NameEn = "Hungary",
                UnNumeric3 = "348",
                Fips104 = "HU",
                CurrencyId = Currency.Hungarianforint.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Iceland")
            {
                Id = new Guid("2EBB794A-C5D1-47A8-8BFE-926D5C7F7114"),
                Name = "ايسلند",
                IsoAlpha3 = "ISL",
                IsoAlpha2 = "IS",
                NameEn = "Iceland",
                UnNumeric3 = "352",
                Fips104 = "IC",
                CurrencyId = Currency.Icelandickróna.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("India")
            {
                Id = new Guid("EC3916C6-E6BC-4A85-831E-7AB8FD8B8455"),
                Name = "هند",
                IsoAlpha3 = "IND",
                IsoAlpha2 = "IN",
                NameEn = "India",
                UnNumeric3 = "356",
                Fips104 = "IN",
                CurrencyId = Currency.Indianrupee.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Indonesia")
            {
                Id = new Guid("77296AB5-C97B-443E-81D0-6E8B6E6A2F91"),
                Name = "اندونزي",
                IsoAlpha3 = "IDN",
                IsoAlpha2 = "ID",
                NameEn = "Indonesia",
                UnNumeric3 = "360",
                Fips104 = "ID",
                CurrencyId = Currency.Indonesianrupiah.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Iran")
            {
                Id = new Guid("47C7D858-08DF-4632-9FC7-2E34B56EDC6E"),
                Name = "ايران",
                IsoAlpha3 = "IRN",
                IsoAlpha2 = "IR",
                NameEn = "Iran",
                UnNumeric3 = "364",
                Fips104 = "IR",
                CurrencyId = Currency.Iranianrial.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Iraq")
            {
                Id = new Guid("CE8D9075-0325-44C2-BCFF-F02A66CB04B5"),
                Name = "عراق",
                IsoAlpha3 = "IRQ",
                IsoAlpha2 = "IQ",
                NameEn = "Iraq",
                UnNumeric3 = "368",
                Fips104 = "IZ",
                CurrencyId = Currency.Iraqidinar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Ireland")
            {
                Id = new Guid("EC8843B8-6243-46D2-9C8E-2E7C921DAECD"),
                Name = "ايرلند",
                IsoAlpha3 = "IRL",
                IsoAlpha2 = "IE",
                NameEn = "Ireland",
                UnNumeric3 = "372",
                Fips104 = "EI",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Israel")
            {
                Id = new Guid("62AFB942-4648-43BF-8A55-A4E228B97BFB"),
                Name = "رژيم اشغالگر قدس",
                IsoAlpha3 = "ISR",
                IsoAlpha2 = "IL",
                NameEn = "Israel",
                UnNumeric3 = "376",
                Fips104 = "IS",
                CurrencyId = Currency.Israelinewshekel.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Italy")
            {
                Id = new Guid("C0CBDADD-5A02-4173-BAB9-582697960A20"),
                Name = "ايتاليا",
                IsoAlpha3 = "ITA",
                IsoAlpha2 = "IT",
                NameEn = "Italy",
                UnNumeric3 = "380",
                Fips104 = "IT",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Jamaica")
            {
                Id = new Guid("3C8CE926-A3D0-4A6F-8ABF-47FFFC798A31"),
                Name = "جامائيكا",
                IsoAlpha3 = "JAM",
                IsoAlpha2 = "JM",
                NameEn = "Jamaica",
                UnNumeric3 = "388",
                Fips104 = "JM",
                CurrencyId = Currency.Jamaicandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Japan")
            {
                Id = new Guid("DAA2B9B7-F23F-4002-AB7E-CB5B44B25B3A"),
                Name = "ژاپن",
                IsoAlpha3 = "JPN",
                IsoAlpha2 = "JP",
                NameEn = "Japan",
                UnNumeric3 = "392",
                Fips104 = "JA",
                CurrencyId = Currency.Japaneseyen.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Jordan")
            {
                Id = new Guid("D11C8B8F-5D47-42A1-AC68-6A22093A4940"),
                Name = "اردن",
                IsoAlpha3 = "JOR",
                IsoAlpha2 = "JO",
                NameEn = "Jordan",
                UnNumeric3 = "400",
                Fips104 = "JO",
                CurrencyId = Currency.Jordaniandinar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Kazakhstan")
            {
                Id = new Guid("AFCAAA83-EBE4-4707-8D9D-7C45B62A4864"),
                Name = "قزاقستان",
                IsoAlpha3 = "KAZ",
                IsoAlpha2 = "KZ",
                NameEn = "Kazakhstan",
                UnNumeric3 = "398",
                Fips104 = "KZ",
                CurrencyId = Currency.Kazakhstanitenge.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Kenya")
            {
                Id = new Guid("50003D9A-3107-4A4E-B9CE-B894FD2A0608"),
                Name = "كنيا",
                IsoAlpha3 = "KEN",
                IsoAlpha2 = "KE",
                NameEn = "Kenya",
                UnNumeric3 = "404",
                Fips104 = "KE",
                CurrencyId = Currency.Kenyanshilling.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Kiribati")
            {
                Id = new Guid("3C1FE175-F82A-457F-8286-80EA17B58855"),
                Name = "كريباتي",
                IsoAlpha3 = "KIR",
                IsoAlpha2 = "KI",
                NameEn = "Kiribati",
                UnNumeric3 = "296",
                Fips104 = "KR",
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Kuwait")
            {
                Id = new Guid("7D1D88D2-476F-4BC9-A168-20A01F9F1643"),
                Name = "كويت",
                IsoAlpha3 = "KWT",
                IsoAlpha2 = "KW",
                NameEn = "Kuwait",
                UnNumeric3 = "414",
                Fips104 = "KU",
                CurrencyId = Currency.Kuwaitidinar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Kyrgyzstan")
            {
                Id = new Guid("12EBA123-C5A7-433E-A425-A627BE69A22B"),
                Name = "قرقيزستان",
                IsoAlpha3 = "KGZ",
                IsoAlpha2 = "KG",
                NameEn = "Kyrgyzstan",
                UnNumeric3 = "417",
                Fips104 = "KG",
                CurrencyId = Currency.Kyrgyzstanisom.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Lao_PDR")
            {
                Id = new Guid("F30B72F3-6AFF-488C-B9EC-BEFB4C34836C"),
                Name = "لائوس",
                IsoAlpha3 = "LAO",
                IsoAlpha2 = "LA",
                NameEn = "Lao, PDR",
                UnNumeric3 = "418",
                Fips104 = "LA",
                CurrencyId = Currency.Laokip.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Latvia")
            {
                Id = new Guid("0177BB33-2645-40FD-B798-B61C2CB0C7D0"),
                Name = "لاتويا",
                IsoAlpha3 = "LVA",
                IsoAlpha2 = "LV",
                NameEn = "Latvia",
                UnNumeric3 = "428",
                Fips104 = "LG",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Lebanon")
            {
                Id = new Guid("4D7BBB7D-8AF2-4DDE-8CB4-AA4839197210"),
                Name = "لبنان",
                IsoAlpha3 = "LBN",
                IsoAlpha2 = "LB",
                NameEn = "Lebanon",
                UnNumeric3 = "422",
                Fips104 = "LE",
                CurrencyId = Currency.Lebanesepound.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Lesotho")
            {
                Id = new Guid("D7CBBC5E-1615-4834-9F58-20190FC7E4A2"),
                Name = "لسوتو",
                IsoAlpha3 = "LSO",
                IsoAlpha2 = "LS",
                NameEn = "Lesotho",
                UnNumeric3 = "426",
                Fips104 = "LT",
                CurrencyId = Currency.Lesotholoti.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Liberia")
            {
                Id = new Guid("57579E44-BDB8-4F1F-95EF-5DD2F3FC5368"),
                Name = "ليبريا",
                IsoAlpha3 = "LBR",
                IsoAlpha2 = "LR",
                NameEn = "Liberia",
                UnNumeric3 = "430",
                Fips104 = "LI",
                CurrencyId = Currency.Liberiandollar.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Libya")
            {
                Id = new Guid("002111A0-EAB3-4C30-A356-DE405688F0E7"),
                Name = "ليبي",
                IsoAlpha3 = "LBY",
                IsoAlpha2 = "LY",
                NameEn = "Libya",
                UnNumeric3 = "434",
                Fips104 = "LY",
                CurrencyId = Currency.Libyandinar.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Liechtenstein")
            {
                Id = new Guid("1EE3974D-3CAF-4282-A47B-0ABC377F41A9"),
                Name = "ليختنشتاين",
                IsoAlpha3 = "LIE",
                IsoAlpha2 = "LI",
                NameEn = "Liechtenstein",
                UnNumeric3 = "438",
                Fips104 = "LS",
                CurrencyId = Currency.Swissfranc.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Lithuania")
            {
                Id = new Guid("8E48082B-E39F-4A5A-AEBE-133E1EC04783"),
                Name = "ليتواني",
                IsoAlpha3 = "LTU",
                IsoAlpha2 = "LT",
                NameEn = "Lithuania",
                UnNumeric3 = "440",
                Fips104 = "LH",
                CurrencyId = Currency.Lithuanianlitas.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Luxembourg")
            {
                Id = new Guid("9BB3676D-BDD9-4DC5-ACA4-393834A2BFBB"),
                Name = "لاكسمبورگ",
                IsoAlpha3 = "LUX",
                IsoAlpha2 = "LU",
                NameEn = "Luxembourg",
                UnNumeric3 = "442",
                Fips104 = "LU",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Macau")
            {
                Id = new Guid("2D4A8170-01F5-42CB-BE3A-C5C9BD3457E0"),
                Name = "ماكوا",
                IsoAlpha3 = "MAC",
                IsoAlpha2 = "MO",
                NameEn = "Macau",
                UnNumeric3 = "446",
                Fips104 = "MC",
                CurrencyId = Currency.Macanesepataca.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Macedonia")
            {
                Id = new Guid("8A3B61F4-4EF7-4016-A5C4-EE5303030699"),
                Name = "مقدونيه",
                IsoAlpha3 = "MKD",
                IsoAlpha2 = "MK",
                NameEn = "Macedonia",
                UnNumeric3 = "807",
                Fips104 = "MK",
                CurrencyId = Currency.Macedoniandenar.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Madagascar")
            {
                Id = new Guid("44B23D20-CEA3-48EB-9963-38C0B512025E"),
                Name = "ماداگاسكار",
                IsoAlpha3 = "MDG",
                IsoAlpha2 = "MG",
                NameEn = "Madagascar",
                UnNumeric3 = "450",
                Fips104 = "MA",
                CurrencyId = Currency.Malagasyariary.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Malawi")
            {
                Id = new Guid("317F1D0E-3363-43E1-8286-9C0C9D80BA84"),
                Name = "مالاوي",
                IsoAlpha3 = "MWI",
                IsoAlpha2 = "MW",
                NameEn = "Malawi",
                UnNumeric3 = "454",
                Fips104 = "MI",
                CurrencyId = Currency.Malawiankwacha.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Malaysia")
            {
                Id = new Guid("434C340F-AF4C-47D6-B0CB-B124051B923C"),
                Name = "مالزي",
                IsoAlpha3 = "MYS",
                IsoAlpha2 = "MY",
                NameEn = "Malaysia",
                UnNumeric3 = "458",
                Fips104 = "MY",
                CurrencyId = Currency.Malaysianringgit.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Maldives")
            {
                Id = new Guid("EA8C4C07-E512-4669-A014-54902529BE36"),
                Name = "مالديو",
                IsoAlpha3 = "MDV",
                IsoAlpha2 = "MV",
                NameEn = "Maldives",
                UnNumeric3 = "462",
                Fips104 = "MV",
                CurrencyId = Currency.Maldivianrufiyaa.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Mali")
            {
                Id = new Guid("90E44F65-F280-4F31-89DF-78F104F6EBCA"),
                Name = "مالي",
                IsoAlpha3 = "MLI",
                IsoAlpha2 = "ML",
                NameEn = "Mali",
                UnNumeric3 = "466",
                Fips104 = "ML",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Malta")
            {
                Id = new Guid("3213C299-27C9-455A-AD09-CE81514FA158"),
                Name = "مالتا",
                IsoAlpha3 = "MLT",
                IsoAlpha2 = "MT",
                NameEn = "Malta",
                UnNumeric3 = "470",
                Fips104 = "MT",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("MarshallIslands")
            {
                Id = new Guid("223B70C1-BFF7-43CA-9B31-4AA63772AAAA"),
                Name = "جزاير مارشال",
                IsoAlpha3 = "MHL",
                IsoAlpha2 = "MH",
                NameEn = "Marshall Islands",
                UnNumeric3 = "584",
                Fips104 = "RM",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Martinique")
            {
                Id = new Guid("AD3F10BF-1C31-47D6-A24A-743D2793034A"),
                Name = "مارتينيك",
                IsoAlpha3 = "MTQ",
                IsoAlpha2 = "MQ",
                NameEn = "Martinique",
                UnNumeric3 = "474",
                Fips104 = "MB",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Mauritania")
            {
                Id = new Guid("7E457093-7E8E-41F3-85DE-C317DF013439"),
                Name = "موريتاني",
                IsoAlpha3 = "MRT",
                IsoAlpha2 = "MR",
                NameEn = "Mauritania",
                UnNumeric3 = "478",
                Fips104 = "MR",
                CurrencyId = Currency.Mauritanianouguiya.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Mauritius")
            {
                Id = new Guid("87C6DDBC-26FB-4E58-8BE1-C876D499A4CB"),
                Name = "موريتيوس",
                IsoAlpha3 = "MUS",
                IsoAlpha2 = "MU",
                NameEn = "Mauritius",
                UnNumeric3 = "480",
                Fips104 = "MP",
                CurrencyId = Currency.Mauritianrupee.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Mayotte")
            {
                Id = new Guid("CE445EB8-9D28-4886-B430-50CC8DF5CD50"),
                Name = "مايوته",
                IsoAlpha3 = "MYT",
                IsoAlpha2 = "YT",
                NameEn = "Mayotte",
                UnNumeric3 = "175",
                Fips104 = "MF",
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Mexico")
            {
                Id = new Guid("7D1FB53A-67A3-4827-8A43-90863CC0F947"),
                Name = "مكزيك",
                IsoAlpha3 = "MEX",
                IsoAlpha2 = "MX",
                NameEn = "Mexico",
                UnNumeric3 = "484",
                Fips104 = "MX",
                CurrencyId = Currency.Mexicanpeso.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Micronesia")
            {
                Id = new Guid("84854769-75FB-49AF-AFFE-752F43569D69"),
                Name = "مايكرونيژا",
                IsoAlpha3 = "FSM",
                IsoAlpha2 = "FM",
                NameEn = "Micronesia",
                UnNumeric3 = "583",
                Fips104 = "FM",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Moldova")
            {
                Id = new Guid("2D4DCE4E-B4AA-4D38-A753-5A0D4F6641D4"),
                Name = "مولدوا",
                IsoAlpha3 = "MDA",
                IsoAlpha2 = "MD",
                NameEn = "Moldova",
                UnNumeric3 = "498",
                Fips104 = "MD",
                CurrencyId = Currency.Moldovanleu.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Monaco")
            {
                Id = new Guid("C01B8C0C-8FD7-4359-8C74-40D51B45C13F"),
                Name = "موناكو",
                IsoAlpha3 = "MCO",
                IsoAlpha2 = "MC",
                NameEn = "Monaco",
                UnNumeric3 = "492",
                Fips104 = "MN",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Mongolia")
            {
                Id = new Guid("86DF1E42-A0FE-44C7-AE5B-F06DD5E66234"),
                Name = "موغولستان",
                IsoAlpha3 = "MNG",
                IsoAlpha2 = "MN",
                NameEn = "Mongolia",
                UnNumeric3 = "496",
                Fips104 = "MG",
                CurrencyId = Currency.Mongoliantögrög.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Montenegro")
            {
                Id = new Guid("96D62044-3D66-45EA-8970-8481A722DECF"),
                Name = "مانتنگرو",
                IsoAlpha3 = "MNE",
                IsoAlpha2 = "ME",
                NameEn = "Montenegro",
                UnNumeric3 = "499",
                Fips104 = "MW",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Montserrat")
            {
                Id = new Guid("7D74B8A8-10A6-4A59-8E05-4C9041644A0D"),
                Name = "مونتسرات",
                IsoAlpha3 = "MSR",
                IsoAlpha2 = "MS",
                NameEn = "Montserrat",
                UnNumeric3 = "500",
                Fips104 = "MJ",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Morocco")
            {
                Id = new Guid("515A9A4C-C52A-4035-8660-CE79F6F8EE1F"),
                Name = "مراكش",
                IsoAlpha3 = "MAR",
                IsoAlpha2 = "MA",
                NameEn = "Morocco",
                UnNumeric3 = "504",
                Fips104 = "MO",
                CurrencyId = Currency.Moroccandirham.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Mozambique")
            {
                Id = new Guid("2222417D-B483-40D6-ACD8-495E4AF851F8"),
                Name = "موزامبيك",
                IsoAlpha3 = "MOZ",
                IsoAlpha2 = "MZ",
                NameEn = "Mozambique",
                UnNumeric3 = "508",
                Fips104 = "MZ",
                CurrencyId = Currency.Mozambicanmetical.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Myanmar")
            {
                Id = new Guid("4D795524-39A2-4009-AAF9-60AD3DB08167"),
                Name = "برمه",
                IsoAlpha3 = "MMR",
                IsoAlpha2 = "MM",
                NameEn = "Myanmar",
                UnNumeric3 = "104",
                Fips104 = "BM",
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Namibia")
            {
                Id = new Guid("BC65760B-4A3C-4FC2-92E1-21AE038F8C0A"),
                Name = "ناميبيا",
                IsoAlpha3 = "NAM",
                IsoAlpha2 = "NA",
                NameEn = "Namibia",
                UnNumeric3 = "516",
                Fips104 = "WA",
                CurrencyId = Currency.Namibiandollar.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Nauru")
            {
                Id = new Guid("6D98D459-A1B3-4C68-8406-5A46B9D5C7BC"),
                Name = "نائورو",
                IsoAlpha3 = "NRU",
                IsoAlpha2 = "NR",
                NameEn = "Nauru",
                UnNumeric3 = "520",
                Fips104 = "NR",
                CurrencyId = Currency.Australiandollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Nepal")
            {
                Id = new Guid("8B8662A5-CDD9-44D5-9CC9-13268E2870C9"),
                Name = "نپال",
                IsoAlpha3 = "NPL",
                IsoAlpha2 = "NP",
                NameEn = "Nepal",
                UnNumeric3 = "524",
                Fips104 = "NP",
                CurrencyId = Currency.Nepaleserupee.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Netherlands")
            {
                Id = new Guid("221DD3C5-F15C-4C76-9549-5424A512EBDE"),
                Name = "هلند",
                IsoAlpha3 = "NLD",
                IsoAlpha2 = "NL",
                NameEn = "Netherlands",
                UnNumeric3 = "528",
                Fips104 = "NL",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("NetherlandsAntilles")
            {
                Id = new Guid("4ED614DC-D7B3-4219-BF27-696F9EC5ADCA"),
                Name = "انتيليس هلند",
                IsoAlpha3 = "ANT",
                IsoAlpha2 = "AN",
                NameEn = "Netherlands Antilles",
                UnNumeric3 = "530",
                Fips104 = "NT",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("NewCaledonia")
            {
                Id = new Guid("8B27F01E-446B-4916-BAD2-8DB68C743639"),
                Name = "نيو كالدونيا",
                IsoAlpha3 = "NCL",
                IsoAlpha2 = "NC",
                NameEn = "New Caledonia",
                UnNumeric3 = "540",
                Fips104 = "NC",
                CurrencyId = Currency.CFPfranc.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("NewZealand")
            {
                Id = new Guid("C33F5BD7-371A-475C-A90C-B2FD96432DFD"),
                Name = "نيوزيلند",
                IsoAlpha3 = "NZL",
                IsoAlpha2 = "NZ",
                NameEn = "New Zealand",
                UnNumeric3 = "554",
                Fips104 = "NZ",
                CurrencyId = Currency.NewZealanddollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Nicaragua")
            {
                Id = new Guid("436E5D7D-9865-4F6D-896F-03EE59643E94"),
                Name = "نيكاراگوئه",
                IsoAlpha3 = "NIC",
                IsoAlpha2 = "NI",
                NameEn = "Nicaragua",
                UnNumeric3 = "558",
                Fips104 = "NU",
                CurrencyId = Currency.Nicaraguancórdoba.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Niger")
            {
                Id = new Guid("944AB321-EB46-4824-A2CD-E93D2BAF5FD2"),
                Name = "نيجر",
                IsoAlpha3 = "NER",
                IsoAlpha2 = "NE",
                NameEn = "Niger",
                UnNumeric3 = "562",
                Fips104 = "NG",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Nigeria")
            {
                Id = new Guid("0CA51CD6-68BF-49A6-AD5B-C524BE75562F"),
                Name = "نيجريه",
                IsoAlpha3 = "NGA",
                IsoAlpha2 = "NG",
                NameEn = "Nigeria",
                UnNumeric3 = "566",
                Fips104 = "NI",
                CurrencyId = Currency.Nigeriannaira.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Niue")
            {
                Id = new Guid("E7D66650-CC48-4ACC-B38C-35973AE239B5"),
                Name = "ني يو",
                IsoAlpha3 = "NIU",
                IsoAlpha2 = "NU",
                NameEn = "Niue",
                UnNumeric3 = "570",
                Fips104 = "NE",
                CurrencyId = Currency.NewZealanddollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("NorfolkIsland")
            {
                Id = new Guid("E9D0D5D5-A693-41D6-8BB5-64DD27F0D3FC"),
                Name = "جزيره نورفولك",
                IsoAlpha3 = "NFK",
                IsoAlpha2 = "NF",
                NameEn = "Norfolk Island",
                UnNumeric3 = "574",
                Fips104 = "NF",
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("NorthKorea")
            {
                Id = new Guid("3089E195-8345-449A-A5FC-832EC26B3ADF"),
                Name = "كره شمالي",
                IsoAlpha3 = "PRK",
                IsoAlpha2 = "KP",
                NameEn = "North Korea",
                UnNumeric3 = "408",
                Fips104 = "KN",
                CurrencyId = Currency.NorthKoreanwon.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("NorthernMarianaIslands")
            {
                Id = new Guid("9BEFC93D-0477-422D-9501-39C9373EC337"),
                Name = "جزاير مارياناي شمالي",
                IsoAlpha3 = "MNP",
                IsoAlpha2 = "MP",
                NameEn = "Northern Mariana Islands",
                UnNumeric3 = "580",
                Fips104 = "CQ",
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Norway")
            {
                Id = new Guid("4BAE2FBB-4B38-49C1-A8A3-924AD2EF88CB"),
                Name = "نروژ",
                IsoAlpha3 = "NOR",
                IsoAlpha2 = "NO",
                NameEn = "Norway",
                UnNumeric3 = "578",
                Fips104 = "NO",
                CurrencyId = Currency.Norwegiankrone.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Oman")
            {
                Id = new Guid("CDD6FA4F-000E-4989-96A8-EACAD3F6F3E6"),
                Name = "عمان",
                IsoAlpha3 = "OMN",
                IsoAlpha2 = "OM",
                NameEn = "Oman",
                UnNumeric3 = "512",
                Fips104 = "MU",
                CurrencyId = Currency.Omanirial.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Pakistan")
            {
                Id = new Guid("DB19592D-96AE-4346-B798-DB3CFAB51DC8"),
                Name = "پاكستان",
                IsoAlpha3 = "PAK",
                IsoAlpha2 = "PK",
                NameEn = "Pakistan",
                UnNumeric3 = "586",
                Fips104 = "PK",
                CurrencyId = Currency.Pakistanirupee.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Palau")
            {
                Id = new Guid("6750EE9F-871D-45C4-B139-F31D7C7E1598"),
                Name = "پائولا",
                IsoAlpha3 = "PLW",
                IsoAlpha2 = "PW",
                NameEn = "Palau",
                UnNumeric3 = "585",
                Fips104 = "PS",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("PalestinianTerritories")
            {
                Id = new Guid("E4CF7710-3CB6-4D26-9D21-B05A206844F6"),
                Name = "فلسطين",
                IsoAlpha3 = "PSE",
                IsoAlpha2 = "PS",
                NameEn = "Palestinian Territories",
                UnNumeric3 = "275",
                Fips104 = "",
                CurrencyId = Currency.Israelinewshekel.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Panama")
            {
                Id = new Guid("8F272F56-1A86-493D-B156-36D1C3E00C51"),
                Name = "پاناما",
                IsoAlpha3 = "PAN",
                IsoAlpha2 = "PA",
                NameEn = "Panama",
                UnNumeric3 = "591",
                Fips104 = "PM",
                CurrencyId = Currency.Panamanianbalboa.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("PapuaNewGuinea")
            {
                Id = new Guid("F1ADF08A-DD3D-414F-96A6-8ADB2FA76AF1"),
                Name = "پاپا نيو گينه",
                IsoAlpha3 = "PNG",
                IsoAlpha2 = "PG",
                NameEn = "Papua New Guinea",
                UnNumeric3 = "598",
                Fips104 = "PP",
                CurrencyId = Currency.PapuaNewGuineankina.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Paraguay")
            {
                Id = new Guid("2AA1F6CF-CC82-469E-A9B2-7A70851E2F7D"),
                Name = "پاراگوئه",
                IsoAlpha3 = "PRY",
                IsoAlpha2 = "PY",
                NameEn = "Paraguay",
                UnNumeric3 = "600",
                Fips104 = "PA",
                CurrencyId = Currency.Paraguayanguaraní.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("Peru")
            {
                Id = new Guid("8933AE20-CABC-46FB-9A05-83907DC78352"),
                Name = "پرو",
                IsoAlpha3 = "PER",
                IsoAlpha2 = "PE",
                NameEn = "Peru",
                UnNumeric3 = "604",
                Fips104 = "PE",
                CurrencyId = Currency.Peruviannuevosol.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("Philippines")
            {
                Id = new Guid("F5AA5124-FB00-4776-A7F5-C5192F24914D"),
                Name = "فيليپين",
                IsoAlpha3 = "PHL",
                IsoAlpha2 = "PH",
                NameEn = "Philippines",
                UnNumeric3 = "608",
                Fips104 = "RP",
                CurrencyId = Currency.Philippinepeso.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("PitcairnIsland")
            {
                Id = new Guid("C5430CDF-12D7-418F-8EC2-7AF82543CA0D"),
                Name = "جزيره پيتكايرين",
                IsoAlpha3 = "PCN",
                IsoAlpha2 = "PN",
                NameEn = "Pitcairn Island",
                UnNumeric3 = "612",
                Fips104 = "PC",
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Poland")
            {
                Id = new Guid("716C1A73-B75A-48DF-9269-A995E73B9C0B"),
                Name = "لهستان",
                IsoAlpha3 = "POL",
                IsoAlpha2 = "PL",
                NameEn = "Poland",
                UnNumeric3 = "616",
                Fips104 = "PL",
                CurrencyId = Currency.Polishzłoty.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Portugal")
            {
                Id = new Guid("26675B4C-0DFB-4AF4-9305-977DB54F1853"),
                Name = "پرتقال",
                IsoAlpha3 = "PRT",
                IsoAlpha2 = "PT",
                NameEn = "Portugal",
                UnNumeric3 = "620",
                Fips104 = "PO",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("PuertoRico")
            {
                Id = new Guid("B7ED57DB-C794-472C-BA9F-3C3EE3243675"),
                Name = "پورتوريكو",
                IsoAlpha3 = "PRI",
                IsoAlpha2 = "PR",
                NameEn = "Puerto Rico",
                UnNumeric3 = "630",
                Fips104 = "RQ",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Qatar")
            {
                Id = new Guid("E4722A54-5E8D-41DB-8905-46E15F80F771"),
                Name = "قطر",
                IsoAlpha3 = "QAT",
                IsoAlpha2 = "QA",
                NameEn = "Qatar",
                UnNumeric3 = "634",
                Fips104 = "QA",
                CurrencyId = Currency.Qataririyal.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Reunion")
            {
                Id = new Guid("15998CC4-C0D2-48EE-B4C3-824031D056A3"),
                Name = "ريونيون",
                IsoAlpha3 = "REU",
                IsoAlpha2 = "RE",
                NameEn = "Reunion",
                UnNumeric3 = "638",
                Fips104 = "RE",
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Romania")
            {
                Id = new Guid("9AC9D560-9BD9-447B-B0BB-6031781CD86D"),
                Name = "روماني",
                IsoAlpha3 = "ROU",
                IsoAlpha2 = "RO",
                NameEn = "Romania",
                UnNumeric3 = "642",
                Fips104 = "RO",
                CurrencyId = Currency.Romanianleu.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Russia")
            {
                Id = new Guid("299DB8F4-FFE6-475A-8A38-E385FD57C2E0"),
                Name = "روسيه",
                IsoAlpha3 = "RUS",
                IsoAlpha2 = "RU",
                NameEn = "Russia",
                UnNumeric3 = "643",
                Fips104 = "RS",
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Rwanda")
            {
                Id = new Guid("72C11CEC-C6F0-4B43-AE41-F26BCB331EA1"),
                Name = "رواندا",
                IsoAlpha3 = "RWA",
                IsoAlpha2 = "RW",
                NameEn = "Rwanda",
                UnNumeric3 = "646",
                Fips104 = "RW",
                CurrencyId = Currency.Rwandanfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Samoa")
            {
                Id = new Guid("B5D53C78-008A-4EF1-8647-2FD912CB4B68"),
                Name = "ساموئا",
                IsoAlpha3 = "WSM",
                IsoAlpha2 = "WS",
                NameEn = "Samoa",
                UnNumeric3 = "882",
                Fips104 = "WS",
                CurrencyId = Currency.Samoantālā.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("SanMarino")
            {
                Id = new Guid("FFB42148-7073-45CF-AD2D-C11F6296876D"),
                Name = "سان مارينو",
                IsoAlpha3 = "SMR",
                IsoAlpha2 = "SM",
                NameEn = "San Marino",
                UnNumeric3 = "674",
                Fips104 = "SM",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("SaoTomeandPrincipe")
            {
                Id = new Guid("6B841FCD-BD9B-4074-BF8F-5DF33F3BC04A"),
                Name = "سائو تومه و پرينسيپ",
                IsoAlpha3 = "STP",
                IsoAlpha2 = "ST",
                NameEn = "Sao Tome and Principe",
                UnNumeric3 = "678",
                Fips104 = "TP",
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("SaudiArabia")
            {
                Id = new Guid("368CB582-77D5-465D-B404-102D5E1F53E9"),
                Name = "عربستان سعودي",
                IsoAlpha3 = "SAU",
                IsoAlpha2 = "SA",
                NameEn = "Saudi Arabia",
                UnNumeric3 = "682",
                Fips104 = "SA",
                CurrencyId = Currency.Saudiriyal.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Senegal")
            {
                Id = new Guid("C402153A-2CC2-45D2-BAB9-F27F59211E10"),
                Name = "سنگال",
                IsoAlpha3 = "SEN",
                IsoAlpha2 = "SN",
                NameEn = "Senegal",
                UnNumeric3 = "686",
                Fips104 = "SG",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Serbia")
            {
                Id = new Guid("54F8DD08-24F5-4B4F-8489-F4EB32745B0C"),
                Name = "صربستان",
                IsoAlpha3 = "SRB",
                IsoAlpha2 = "RS",
                NameEn = "Serbia",
                UnNumeric3 = "688",
                Fips104 = "RI",
                CurrencyId = Currency.Serbiandinar.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Seychelles")
            {
                Id = new Guid("F4FC7022-BC22-4E5F-8C7C-51B01F92CC15"),
                Name = "سيشل",
                IsoAlpha3 = "SYC",
                IsoAlpha2 = "SC",
                NameEn = "Seychelles",
                UnNumeric3 = "690",
                Fips104 = "SE",
                CurrencyId = Currency.Seychelloisrupee.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("SierraLeone")
            {
                Id = new Guid("BF38A89F-E12D-43D9-9994-0FE9B94AC025"),
                Name = "سيئرالئون",
                IsoAlpha3 = "SLE",
                IsoAlpha2 = "SL",
                NameEn = "Sierra Leone",
                UnNumeric3 = "694",
                Fips104 = "SL",
                CurrencyId = Currency.SierraLeoneanleone.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Singapore")
            {
                Id = new Guid("C2BC63F1-0D97-44D9-B4B9-84AC38054669"),
                Name = "سنگاپور",
                IsoAlpha3 = "SGP",
                IsoAlpha2 = "SG",
                NameEn = "Singapore",
                UnNumeric3 = "702",
                Fips104 = "SN",
                CurrencyId = Currency.Bruneidollar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Slovakia")
            {
                Id = new Guid("D898534A-9E70-4367-9B18-DA6D5FFB2770"),
                Name = "اسلواكي",
                IsoAlpha3 = "SVK",
                IsoAlpha2 = "SK",
                NameEn = "Slovakia",
                UnNumeric3 = "703",
                Fips104 = "LO",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Slovenia")
            {
                Id = new Guid("81E0013C-88D3-4416-9490-6BDB09FB88B8"),
                Name = "اسلوني",
                IsoAlpha3 = "SVN",
                IsoAlpha2 = "SI",
                NameEn = "Slovenia",
                UnNumeric3 = "705",
                Fips104 = "SI",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("SolomonIslands")
            {
                Id = new Guid("18695DE0-B8BE-471F-871E-30766C9E08AB"),
                Name = "جزاير سليمان",
                IsoAlpha3 = "SLB",
                IsoAlpha2 = "SB",
                NameEn = "Solomon Islands",
                UnNumeric3 = "90",
                Fips104 = "BP",
                CurrencyId = Currency.SolomonIslandsdollar.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Somalia")
            {
                Id = new Guid("8E4D36C2-42CA-4437-B8FC-F2FB45941DE5"),
                Name = "سومالي",
                IsoAlpha3 = "SOM",
                IsoAlpha2 = "SO",
                NameEn = "Somalia",
                UnNumeric3 = "706",
                Fips104 = "SO",
                CurrencyId = Currency.Somalishilling.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("SouthAfrica")
            {
                Id = new Guid("82DFE238-C2AC-4A6B-B546-DA855EC9E44E"),
                Name = "آفريقاي جنوبي",
                IsoAlpha3 = "ZAF",
                IsoAlpha2 = "ZA",
                NameEn = "South Africa",
                UnNumeric3 = "710",
                Fips104 = "SF",
                CurrencyId = Currency.SouthAfricanrand.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("SouthGeorgiaandSouthSandwichIslands")
            {
                Id = new Guid("E4085ECF-D613-48F2-B203-DA0616931D16"),
                Name = "جزاير جورجياي جنوبي و ساندويچ جنوبي",
                IsoAlpha3 = "SGS",
                IsoAlpha2 = "GS",
                NameEn = "South Georgia and South Sandwich Islands",
                UnNumeric3 = "",
                Fips104 = "SX",
                CurrencyId = Currency.Britishpound.Id,
                ContinentId = Continent.Antarctica.Id
            });

            result.Add(new Country("SouthKorea")
            {
                Id = new Guid("24898EF5-C2B4-4259-9DA6-5A7746F70E89"),
                Name = "كره جنوبي",
                IsoAlpha3 = "KOR",
                IsoAlpha2 = "KR",
                NameEn = "South Korea",
                UnNumeric3 = "410",
                Fips104 = "KS",
                CurrencyId = Currency.SouthKoreanwon.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("SouthSudan")
            {
                Id = new Guid("BFE5D17C-3EC0-4081-9A40-7264608465AE"),
                Name = "سودان جنوبي",
                IsoAlpha3 = "SSD",
                IsoAlpha2 = "SS",
                NameEn = "South Sudan",
                UnNumeric3 = "728",
                Fips104 = "OD",
                CurrencyId = Currency.SouthSudanesepound.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Spain")
            {
                Id = new Guid("F455FA1A-069E-4D4B-9E85-EFD39D2CF034"),
                Name = "اسپانيا",
                IsoAlpha3 = "ESP",
                IsoAlpha2 = "ES",
                NameEn = "Spain",
                UnNumeric3 = "724",
                Fips104 = "SP",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("SriLanka")
            {
                Id = new Guid("32D44F31-AD7E-4985-9F2C-ED578C77F182"),
                Name = "سريلانكا",
                IsoAlpha3 = "LKA",
                IsoAlpha2 = "LK",
                NameEn = "Sri Lanka",
                UnNumeric3 = "144",
                Fips104 = "CE",
                CurrencyId = Currency.SriLankanrupee.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("St_Helena")
            {
                Id = new Guid("6901CDC2-1C1F-4C50-B97D-9BE4B269B398"),
                Name = "سينت هلنا",
                IsoAlpha3 = "SHN",
                IsoAlpha2 = "SH",
                NameEn = "St. Helena",
                UnNumeric3 = "654",
                Fips104 = "SH",
                CurrencyId = Currency.SaintHelenapound.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("St_KittsandNevis")
            {
                Id = new Guid("ADA16876-52AE-4F92-8074-883E5832EEA0"),
                Name = "سينت كيتز و نويس",
                IsoAlpha3 = "KNA",
                IsoAlpha2 = "KN",
                NameEn = "St. Kitts and Nevis",
                UnNumeric3 = "659",
                Fips104 = "SC",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("St_Lucia")
            {
                Id = new Guid("BC9537E8-F2DF-475C-8F51-1A713DEFE4AA"),
                Name = "سينت لوسيا",
                IsoAlpha3 = "LCA",
                IsoAlpha2 = "LC",
                NameEn = "St. Lucia",
                UnNumeric3 = "662",
                Fips104 = "ST",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("St_PierreandMiquelon")
            {
                Id = new Guid("4BBB3652-BC84-497C-A6ED-A01D5FEE844C"),
                Name = "سينت پي ير و ميكئلون",
                IsoAlpha3 = "SPM",
                IsoAlpha2 = "PM",
                NameEn = "St. Pierre and Miquelon",
                UnNumeric3 = "666",
                Fips104 = "SB",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("St_VincentandtheGrenadines")
            {
                Id = new Guid("7D8D26C4-E8B1-4C80-9C30-9E5BF2DE0BB5"),
                Name = "سينت وينسنت و گرنادينز",
                IsoAlpha3 = "VCT",
                IsoAlpha2 = "VC",
                NameEn = "St. Vincent and the Grenadines",
                UnNumeric3 = "670",
                Fips104 = "VC",
                CurrencyId = Currency.EastCaribbeandollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Sudan")
            {
                Id = new Guid("462EECB7-4499-46F4-B756-51B5D0FB5AF8"),
                Name = "سودان",
                IsoAlpha3 = "SDN",
                IsoAlpha2 = "SD",
                NameEn = "Sudan",
                UnNumeric3 = "736",
                Fips104 = "SU",
                CurrencyId = Currency.Sudanesepound.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Suriname")
            {
                Id = new Guid("F11E92AB-E275-4EBD-B49B-C4B39E3FBFA6"),
                Name = "سورينام",
                IsoAlpha3 = "SUR",
                IsoAlpha2 = "SR",
                NameEn = "Suriname",
                UnNumeric3 = "740",
                Fips104 = "NS",
                CurrencyId = Currency.Surinamesedollar.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("SvalbardandJanMayen")
            {
                Id = new Guid("5952C0CA-8F8F-41DF-9C41-8A9D0B80767D"),
                Name = "سوالبارد و ژان ماين",
                IsoAlpha3 = "SJM",
                IsoAlpha2 = "SJ",
                NameEn = "Svalbard and Jan Mayen",
                UnNumeric3 = "744",
                Fips104 = "SV",
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Swaziland")
            {
                Id = new Guid("580F3887-EEF9-485A-A3BD-4692FBFDBEAC"),
                Name = "سوازيلند",
                IsoAlpha3 = "SWZ",
                IsoAlpha2 = "SZ",
                NameEn = "Swaziland",
                UnNumeric3 = "748",
                Fips104 = "WZ",
                CurrencyId = Currency.Swazililangeni.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Sweden")
            {
                Id = new Guid("CB2B7550-4283-4E9D-A390-6215DB5D9495"),
                Name = "سوئد",
                IsoAlpha3 = "SWE",
                IsoAlpha2 = "SE",
                NameEn = "Sweden",
                UnNumeric3 = "752",
                Fips104 = "SW",
                CurrencyId = Currency.Swedishkrona.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Switzerland")
            {
                Id = new Guid("017DCF37-FBD1-47F6-8A8C-CD727F7098A9"),
                Name = "سوئيس",
                IsoAlpha3 = "CHE",
                IsoAlpha2 = "CH",
                NameEn = "Switzerland",
                UnNumeric3 = "756",
                Fips104 = "SZ",
                CurrencyId = Currency.Swissfranc.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Syria")
            {
                Id = new Guid("FC49EAD2-8265-49CE-BB23-08795ADAE694"),
                Name = "سوريه",
                IsoAlpha3 = "SYR",
                IsoAlpha2 = "SY",
                NameEn = "Syria",
                UnNumeric3 = "760",
                Fips104 = "SY",
                CurrencyId = Currency.Syrianpound.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Taiwan")
            {
                Id = new Guid("266DC18E-E54D-43D7-8E0D-BFB5D607E3F3"),
                Name = "تايوان",
                IsoAlpha3 = "TWN",
                IsoAlpha2 = "TW",
                NameEn = "Taiwan",
                UnNumeric3 = "158",
                Fips104 = "TW",
                CurrencyId = Currency.NewTaiwandollar.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Tajikistan")
            {
                Id = new Guid("7F8DEF7E-4E96-4C70-A591-BC8AE9A10845"),
                Name = "تاجيكستان",
                IsoAlpha3 = "TJK",
                IsoAlpha2 = "TJ",
                NameEn = "Tajikistan",
                UnNumeric3 = "762",
                Fips104 = "TI",
                CurrencyId = Currency.Tajikistanisomoni.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Tanzania")
            {
                Id = new Guid("DFD8FDD2-899B-4579-AC32-983B12AF147B"),
                Name = "تانزانيا",
                IsoAlpha3 = "TZA",
                IsoAlpha2 = "TZ",
                NameEn = "Tanzania",
                UnNumeric3 = "834",
                Fips104 = "TZ",
                CurrencyId = Currency.Tanzanianshilling.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Thailand")
            {
                Id = new Guid("22050AF5-F0CD-4B98-8002-339B4BF866C7"),
                Name = "تايلند",
                IsoAlpha3 = "THA",
                IsoAlpha2 = "TH",
                NameEn = "Thailand",
                UnNumeric3 = "764",
                Fips104 = "TH",
                CurrencyId = Currency.Thaibaht.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Togo")
            {
                Id = new Guid("BC9A660F-9974-4179-B4B3-0A292FA581D6"),
                Name = "توگو",
                IsoAlpha3 = "TGO",
                IsoAlpha2 = "TG",
                NameEn = "Togo",
                UnNumeric3 = "768",
                Fips104 = "TO",
                CurrencyId = Currency.WestAfricanCFAfranc.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Tokelau")
            {
                Id = new Guid("3DC58DC1-36E3-42EA-BA41-1B13A5438EDB"),
                Name = "توكلا",
                IsoAlpha3 = "TKL",
                IsoAlpha2 = "TK",
                NameEn = "Tokelau",
                UnNumeric3 = "772",
                Fips104 = "TL",
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("Tonga")
            {
                Id = new Guid("906DC5D2-39FC-4FC0-81C3-086C2D3AE421"),
                Name = "تونگا",
                IsoAlpha3 = "TON",
                IsoAlpha2 = "TO",
                NameEn = "Tonga",
                UnNumeric3 = "776",
                Fips104 = "TN",
                CurrencyId = Currency.Tonganpaʻanga.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("TrinidadandTobago")
            {
                Id = new Guid("373AD6DE-56A3-4FF2-9EDE-04D85511D910"),
                Name = "ترينيداد و توباگو",
                IsoAlpha3 = "TTO",
                IsoAlpha2 = "TT",
                NameEn = "Trinidad and Tobago",
                UnNumeric3 = "780",
                Fips104 = "TD",
                CurrencyId = Currency.TrinidadandTobagodollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Tunisia")
            {
                Id = new Guid("A27F1793-529F-4AB1-9AF7-A8F9DB42251E"),
                Name = "تونس",
                IsoAlpha3 = "TUN",
                IsoAlpha2 = "TN",
                NameEn = "Tunisia",
                UnNumeric3 = "788",
                Fips104 = "TS",
                CurrencyId = Currency.Tunisiandinar.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Turkey")
            {
                Id = new Guid("DF4EF766-AD67-4D2E-8E6F-9751D376E938"),
                Name = "تركيه",
                IsoAlpha3 = "TUR",
                IsoAlpha2 = "TR",
                NameEn = "Turkey",
                UnNumeric3 = "792",
                Fips104 = "TU",
                CurrencyId = Currency.Turkishlira.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Turkmenistan")
            {
                Id = new Guid("0DEC17C3-B011-4637-AFA1-F26150C4DEE6"),
                Name = "تركمنستان",
                IsoAlpha3 = "TKM",
                IsoAlpha2 = "TM",
                NameEn = "Turkmenistan",
                UnNumeric3 = "795",
                Fips104 = "TX",
                CurrencyId = Currency.Turkmenistanmanat.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("TurksandCaicosIslands")
            {
                Id = new Guid("C5EADD8A-D4A8-48E4-AB8F-63AB82F5A88E"),
                Name = "جزاير تركز و كائيكوس",
                IsoAlpha3 = "TCA",
                IsoAlpha2 = "TC",
                NameEn = "Turks and Caicos Islands",
                UnNumeric3 = "796",
                Fips104 = "TK",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Tuvalu")
            {
                Id = new Guid("68FD93C2-6036-4F2E-B2D5-54450329D054"),
                Name = "تووالو",
                IsoAlpha3 = "TUV",
                IsoAlpha2 = "TV",
                NameEn = "Tuvalu",
                UnNumeric3 = "798",
                Fips104 = "TV",
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("U_S_VirginIslands")
            {
                Id = new Guid("4272BB6B-357E-4F09-A271-823E61A35F7A"),
                Name = "جزاير ورجن آمريكايي",
                IsoAlpha3 = "VIR",
                IsoAlpha2 = "VI",
                NameEn = "U.S. Virgin Islands",
                UnNumeric3 = "850",
                Fips104 = "VQ",
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Uganda")
            {
                Id = new Guid("80EBD66F-DFAF-4407-97FD-72B66DC1EA10"),
                Name = "اوگاندا",
                IsoAlpha3 = "UGA",
                IsoAlpha2 = "UG",
                NameEn = "Uganda",
                UnNumeric3 = "800",
                Fips104 = "UG",
                CurrencyId = Currency.Ugandanshilling.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Ukraine")
            {
                Id = new Guid("9EF47F94-955B-4A35-8E19-E955C949DC23"),
                Name = "اوكراين",
                IsoAlpha3 = "UKR",
                IsoAlpha2 = "UA",
                NameEn = "Ukraine",
                UnNumeric3 = "804",
                Fips104 = "UP",
                CurrencyId = Currency.Ukrainianhryvnia.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("UnitedArabEmirates")
            {
                Id = new Guid("5A480700-3650-45C5-AB2D-6A1587524C59"),
                Name = "امارات متحده عربي",
                IsoAlpha3 = "ARE",
                IsoAlpha2 = "AE",
                NameEn = "United Arab Emirates",
                UnNumeric3 = "784",
                Fips104 = "AE",
                CurrencyId = Currency.UnitedArabEmiratesdirham.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("UnitedKingdom")
            {
                Id = new Guid("68020371-245C-463D-8F0B-19D3DBA77D59"),
                Name = "انگلستان",
                IsoAlpha3 = "GBR",
                IsoAlpha2 = "GB",
                NameEn = "United Kingdom",
                UnNumeric3 = "826",
                Fips104 = "UK",
                CurrencyId = Currency.Britishpound.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("UnitedStates")
            {
                Id = new Guid("47CF36A0-052C-472E-858F-80EA2FFBD78F"),
                Name = "آمريكا",
                IsoAlpha3 = "USA",
                IsoAlpha2 = "US",
                NameEn = "United States",
                UnNumeric3 = "840",
                Fips104 = "US",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.NorthAmerica.Id
            });

            result.Add(new Country("Uruguay")
            {
                Id = new Guid("5F4C0F09-A12D-458C-81FA-EA0E36EE7E59"),
                Name = "اروگوئه",
                IsoAlpha3 = "URY",
                IsoAlpha2 = "UY",
                NameEn = "Uruguay",
                UnNumeric3 = "858",
                Fips104 = "UY",
                CurrencyId = Currency.Uruguayanpeso.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("Uzbekistan")
            {
                Id = new Guid("D2AE3D97-6728-4836-A938-C999D1A1B959"),
                Name = "ازبكستان",
                IsoAlpha3 = "UZB",
                IsoAlpha2 = "UZ",
                NameEn = "Uzbekistan",
                UnNumeric3 = "860",
                Fips104 = "UZ",
                CurrencyId = Currency.Uzbekistanisom.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Vanuatu")
            {
                Id = new Guid("0AD29D91-66EF-45D6-BDE6-668A1CE2930F"),
                Name = "وانوئاتو",
                IsoAlpha3 = "VUT",
                IsoAlpha2 = "VU",
                NameEn = "Vanuatu",
                UnNumeric3 = "548",
                Fips104 = "NH",
                CurrencyId = Currency.Vanuatuvatu.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("VaticanCityState")
            {
                Id = new Guid("D0AA205B-BDBF-4211-AB66-B5B0018EBFA2"),
                Name = "واتيكان",
                IsoAlpha3 = "VAT",
                IsoAlpha2 = "VA",
                NameEn = "Vatican City State",
                UnNumeric3 = "336",
                Fips104 = "VT",
                CurrencyId = Currency.Euro.Id,
                ContinentId = Continent.Europe.Id
            });

            result.Add(new Country("Venezuela")
            {
                Id = new Guid("91216FE0-CECD-40DF-8C3B-5BF5CF2F7B76"),
                Name = "ونوزوئلا",
                IsoAlpha3 = "VEN",
                IsoAlpha2 = "VE",
                NameEn = "Venezuela",
                UnNumeric3 = "548",
                Fips104 = "VE",
                CurrencyId = Currency.Venezuelanbolívar.Id,
                ContinentId = Continent.SouthAmerica.Id
            });

            result.Add(new Country("VietNam")
            {
                Id = new Guid("BFCB5E6C-9F45-4198-8E59-A1A344774C5F"),
                Name = "ويتنام",
                IsoAlpha3 = "VNM",
                IsoAlpha2 = "VN",
                NameEn = "Viet Nam",
                UnNumeric3 = "704",
                Fips104 = "VM",
                CurrencyId = Currency.Vietnameseđồng.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("WallisandFutunaIslands")
            {
                Id = new Guid("9E11C55A-DD73-4030-9F50-9949E0486D8A"),
                Name = "جزاير واليس و فوتونا",
                IsoAlpha3 = "WLF",
                IsoAlpha2 = "WF",
                NameEn = "Wallis and Futuna Islands",
                UnNumeric3 = "876",
                Fips104 = "WF",
                CurrencyId = Currency.CFPfranc.Id,
                ContinentId = Continent.Oceania.Id
            });

            result.Add(new Country("WesternSahara")
            {
                Id = new Guid("5B4E2523-A15E-4E45-92DB-5796E4EFD689"),
                Name = "صحراي غربي",
                IsoAlpha3 = "ESH",
                IsoAlpha2 = "EH",
                NameEn = "Western Sahara",
                UnNumeric3 = "732",
                Fips104 = "WI",
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Yemen")
            {
                Id = new Guid("F5AC17BD-CEA2-479C-A72C-AD167AC16B41"),
                Name = "يمن",
                IsoAlpha3 = "YEM",
                IsoAlpha2 = "YE",
                NameEn = "Yemen",
                UnNumeric3 = "887",
                Fips104 = "YM",
                CurrencyId = Currency.Yemenirial.Id,
                ContinentId = Continent.Asia.Id
            });

            result.Add(new Country("Zambia")
            {
                Id = new Guid("AD4B6F06-B6F2-403F-A106-3F60DD7C9E6F"),
                Name = "زامبيا",
                IsoAlpha3 = "ZMB",
                IsoAlpha2 = "ZM",
                NameEn = "Zambia",
                UnNumeric3 = "894",
                Fips104 = "ZA",
                CurrencyId = Currency.Zambiankwacha.Id,
                ContinentId = Continent.Africa.Id
            });

            result.Add(new Country("Zimbabwe")
            {
                Id = new Guid("1E990B30-EF62-4556-A2FF-2BF9235534B3"),
                Name = "زيمباووه",
                IsoAlpha3 = "ZWE",
                IsoAlpha2 = "ZW",
                NameEn = "Zimbabwe",
                UnNumeric3 = "716",
                Fips104 = "ZI",
                CurrencyId = Currency.UnitedStatesdollar.Id,
                ContinentId = Continent.Africa.Id
            });
		

            return result;
        }
    }
}
