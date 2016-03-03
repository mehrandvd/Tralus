using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Stations.BusinessModel
{
    [Table("SpecialServiceType", Schema = "Stations")]
    [DefaultProperty("Name")]
    public class SpecialServiceType : FixedEntityBase<SpecialServiceType>
    {
        public SpecialServiceType()
            : this("")
        {

        }

        public SpecialServiceType(string fixedName)
            : base(fixedName)
        {
        }

        [StringLength(200)]
        public string Description { get; set; }
        public string DescriptionEn { get; set; }

        public static SpecialServiceType ASAP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType AVIH
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType BBML
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType BIKE
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType BLKD
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType BLML
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType BLND
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType BSCT
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType BULK
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType CBBG
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType CHLD
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType CHML
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType CIP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType CKIN
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType COUR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType CREW
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType DEAF
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType DEPA
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType DEPU
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType DIPB
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType DOCO
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType DOCS
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType EXST
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType FQTR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType FQTV
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType GATE
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType GRPS
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType HAJI
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType HAJJ
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType HUM
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType IATA
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType ICAO
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType INAD
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType INFT
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType INTL
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType JUMP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType LANG
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType LEGB
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType LEGL
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType LEGR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType MAAS
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType MEDA
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType OXYG
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType PETC
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType PSGR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType PSPT
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType RQST
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType RUSH
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType SEAT
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType SEMN
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType STCR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType THRU
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType TKNA
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType TKNM
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType UM
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType UNMR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType UPGR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType VGML
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType VIP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType VVIP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCBD
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCBW
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCHC
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCHP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCHR
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCHS
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCMP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WCOB
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WEAP
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType WGHT
        {
            get { return GetFixedEntity(); }
        }

        public static SpecialServiceType XBAG
        {
            get { return GetFixedEntity(); }
        }


        public override List<SpecialServiceType> PredefinedValues()
        {
            var result = new List<SpecialServiceType>();

            result.Add(
                new SpecialServiceType("ASAP")
                {
                    Id = new Guid("C2FEBBA6-95FE-441F-A7D0-CE1168ED2765"),
                    Name = "ASAP",
                    Description = "œ— «”—⁄ Êﬁ ",
                    DescriptionEn = "As Soon as Possible"

                });

            result.Add(
                new SpecialServiceType("AVIH")
                {
                    Id = new Guid("BC7235C6-F3CE-41BD-B4B4-E5D1A39A3FD1"),
                    Name = "AVIH",
                    Description = "„”«›— »« ÕÌÊ«‰ Œ«‰êÌ œ— ç„œ«‰ Ì« »«— ŒÊœ ”›— „Ì‰„«Ìœ",
                    DescriptionEn = "Passenger Traveling with Pet in Luggage or Cargo"

                });

            result.Add(
                new SpecialServiceType("BBML")
                {
                    Id = new Guid("2C0EAEEF-0502-41E3-86D0-675B0544806A"),
                    Name = "BBML",
                    Description = " ”»œ Ê⁄œÂ €–«ÌÌ »çÂ/‰Ê“«œ",
                    DescriptionEn = "Baby/Infant Meal Basket"

                });

            result.Add(
                new SpecialServiceType("BIKE")
                {
                    Id = new Guid("C3E5560D-9159-4E7E-B4D6-5234D58E8D39"),
                    Name = "BIKE",
                    Description = "œÊç—ŒÂ",
                    DescriptionEn = "Bicycle"

                });

            result.Add(
                new SpecialServiceType("BLKD")
                {
                    Id = new Guid("438A164B-CFA0-400E-B6BB-AC12773B49D1"),
                    Name = "BLKD",
                    Description = "’‰œ·Ì „”œÊœ ‘œÂ Ì« »” Â ‘œÂ",
                    DescriptionEn = "Blocked Seat"

                });

            result.Add(
                new SpecialServiceType("BLML")
                {
                    Id = new Guid("E9F9F9EA-FEDF-4295-98E0-7F634732643C"),
                    Name = "BLML",
                    Description = "Ê⁄œÂ €–«ÌÌ ‘Ì—Ì‰ Ì« „ÿ·Ê» „Ê—œ œ—ŒÊ«”  „Ì»«‘œ",
                    DescriptionEn = "Bland Meal Requested"

                });

            result.Add(
                new SpecialServiceType("BLND")
                {
                    Id = new Guid("93D04923-2A1B-4059-91B9-3827DB2DFC99"),
                    Name = "BLND",
                    Description = "„”«›— ﬂÊ— Ì« ‰«»Ì‰«",
                    DescriptionEn = "Blind Passenger"

                });

            result.Add(
                new SpecialServiceType("BSCT")
                {
                    Id = new Guid("FCD94096-2195-47BD-9E44-1AFD532A72E7"),
                    Name = "BSCT",
                    Description = "êÂÊ«—Â ”»œÌ —ÊÅÊ‘ œ«— / ¬€Ê‘Ì ‰Ê“«œ / ”»œ ‰Ê“«œ",
                    DescriptionEn = "Bassinet/Carrycot/Baby Basket"

                });

            result.Add(
                new SpecialServiceType("BULK")
                {
                    Id = new Guid("25CC0AD9-C17F-4BF7-8C38-164BF2C706AC"),
                    Name = "BULK",
                    Description = "„”«›— œ«—«Ì ﬂÌ› »“—ê Ì« ÕÃÌ„ „Ì»«‘œ",
                    DescriptionEn = "Passenger Has Bulky Bag"

                });

            result.Add(
                new SpecialServiceType("CBBG")
                {
                    Id = new Guid("DF4E1A5F-2D92-4686-88CE-472DFF83583C"),
                    Name = "CBBG",
                    Description = "ç„œ«‰ ﬂ«»Ì‰ / ç„œ«‰ ﬁ«»· Õ„·",
                    DescriptionEn = "Cabin Baggage/Carry On Baggage"

                });

            result.Add(
                new SpecialServiceType("CHLD")
                {
                    Id = new Guid("AF3FA868-A5BD-431A-967E-5067635D68ED"),
                    Name = "CHLD",
                    Description = "ﬂÊœﬂ",
                    DescriptionEn = "Child"

                });

            result.Add(
                new SpecialServiceType("CHML")
                {
                    Id = new Guid("1B1D7D91-B6BE-438C-A4D0-8298BA7D2D16"),
                    Name = "CHML",
                    Description = "€–«Ì ﬂÊœﬂ",
                    DescriptionEn = "Child Meal"

                });

            result.Add(
                new SpecialServiceType("CIP")
                {
                    Id = new Guid("C201C421-E6F0-4D92-9618-049E68B0CA39"),
                    Name = "CIP",
                    Description = "",
                    DescriptionEn = "Commercially Important Person"

                });

            result.Add(
                new SpecialServiceType("CKIN")
                {
                    Id = new Guid("BBD4B151-A6A4-46F6-BC9D-021B72E583FA"),
                    Name = "CKIN",
                    Description = "«ÿ·«⁄« Ì »—«Ì  ﬂ«—„‰œ«‰ ﬂ‰ —· ﬂ‰‰œÂ Ì« Å–Ì—‘ ﬂ‰‰œÂ",
                    DescriptionEn = "Information for Check In Staff"

                });

            result.Add(
                new SpecialServiceType("COUR")
                {
                    Id = new Guid("94A9B0E4-48A0-4164-B7EE-9286ED9C3F47"),
                    Name = "COUR",
                    Description = "ÅÌﬂ  Ã«—Ì",
                    DescriptionEn = "Commercial Courier"

                });

            result.Add(
                new SpecialServiceType("CREW")
                {
                    Id = new Guid("100717CF-8E53-4A08-B110-ECABDD418158"),
                    Name = "CREW",
                    Description = "Œœ„Â Å—Ê«“",
                    DescriptionEn = "Crew"

                });

            result.Add(
                new SpecialServiceType("DEAF")
                {
                    Id = new Guid("BC0EFAEE-389F-49C6-BA77-E43F7031E164"),
                    Name = "DEAF",
                    Description = "«“ ‰Ÿ— ‘‰Ê«ÌÌ ﬂ«„·« ‰«‘‰Ê« Ì« »Â ‘œ  œç«— «Œ ·«·",
                    DescriptionEn = "Totally Deaf or Seriously Impaired Hearing "

                });

            result.Add(
                new SpecialServiceType("DEPA")
                {
                    Id = new Guid("13294101-37CD-4F85-89D3-19BF5AF4FE27"),
                    Name = "DEPA",
                    Description = " »⁄Ìœ ‘œÂ-Â„—«Â",
                    DescriptionEn = "Deportee - Accompanied"

                });

            result.Add(
                new SpecialServiceType("DEPU")
                {
                    Id = new Guid("A08219BB-322A-4CCE-B3AB-4619E9C46A82"),
                    Name = "DEPU",
                    Description = " »⁄Ìœ ‘œÂ-»œÊ‰ Â„—«Â",
                    DescriptionEn = "Deportee - Unaccompanied"

                });

            result.Add(
                new SpecialServiceType("DIPB")
                {
                    Id = new Guid("827A294B-700D-4917-B59C-BFC4943515BF"),
                    Name = "DIPB",
                    Description = "ç„œ«‰ œÌÅ·„« Ìﬂ",
                    DescriptionEn = "Diplomatic Baggage"

                });

            result.Add(
                new SpecialServiceType("DOCO")
                {
                    Id = new Guid("BEDCF378-0566-499E-B541-D341ADC787FA"),
                    Name = "DOCO",
                    Description = " „«„ «ÿ·«⁄«  „—»Êÿ »Â „”«›— ",
                    DescriptionEn = "All Travel-Related Information"

                });

            result.Add(
                new SpecialServiceType("DOCS")
                {
                    Id = new Guid("EF8A465D-9E89-4F91-8060-EB4F8B1B3C0A"),
                    Name = "DOCS",
                    Description = "«ÿ·«⁄«  «Ê·ÌÂ ê–—‰«„Â",
                    DescriptionEn = "Passport Primary Information"

                });

            result.Add(
                new SpecialServiceType("EXST")
                {
                    Id = new Guid("5B7912DB-AA39-4F12-B587-C2C195983A2C"),
                    Name = "EXST",
                    Description = "’‰œ·Ì «÷«›Â",
                    DescriptionEn = "Extra Seat"

                });

            result.Add(
                new SpecialServiceType("FQTR")
                {
                    Id = new Guid("F35E229C-B9AE-4229-B565-F698ED9EA6D0"),
                    Name = "FQTR",
                    Description = "»«“ Œ—Ìœ ”›— Ã«Ì“Â „”«›—«‰ ﬂÀÌ—«·”›—",
                    DescriptionEn = "Frequent Traveler Award Redemption Journey"

                });

            result.Add(
                new SpecialServiceType("FQTV")
                {
                    Id = new Guid("F93436DA-35DD-47E8-9EA1-46341B65C0CA"),
                    Name = "FQTV",
                    Description = "«ÿ·«⁄«  „”«›—«‰ ﬂÀÌ—«·”›—",
                    DescriptionEn = "Frequent Traveler Information"

                });

            result.Add(
                new SpecialServiceType("GATE")
                {
                    Id = new Guid("ECD147CB-40A4-4D2B-BFF8-64E22282B8D3"),
                    Name = "GATE",
                    Description = "êÌ ",
                    DescriptionEn = "Gate"

                });

            result.Add(
                new SpecialServiceType("GRPS")
                {
                    Id = new Guid("65DCF5AF-71FF-4B7C-A5A7-A9EDB0DB7237"),
                    Name = "GRPS",
                    Description =
                        "ê—ÊÂÌ ﬂÂ »« Â„ »« «” ›«œÂ «“ ÂÊÌ  „‘ —ﬂ «ÌÃ«œ ‘œÂ   Ê”ÿ ‘—ﬂ  ÂÊ«ÅÌ„«ÌÌ —“—Ê ﬂ‰‰œÂ ”›— „Ìﬂ‰‰œ",
                    DescriptionEn = "Goup Traveling Together Utilizing Common Identity by the Booking Airline"

                });

            result.Add(
                new SpecialServiceType("HAJI")
                {
                    Id = new Guid("4346BEA6-9035-4A8F-BF8F-C44D7A5400EC"),
                    Name = "HAJI",
                    Description = "“«∆— »Â „ﬂÂ „⁄Ÿ„Â",
                    DescriptionEn = "Pilgrim to Mecca"

                });

            result.Add(
                new SpecialServiceType("HAJJ")
                {
                    Id = new Guid("4471B63E-F65E-4151-9FEE-E8FCB3F36AC5"),
                    Name = "HAJJ",
                    Description = "ÕÃ",
                    DescriptionEn = "Hajj"

                });

            result.Add(
                new SpecialServiceType("HUM")
                {
                    Id = new Guid("39E6E9FC-202D-4986-969D-7BC23DC8EC78"),
                    Name = "HUM",
                    Description = "",
                    DescriptionEn = "Human Corpse"

                });

            result.Add(
                new SpecialServiceType("IATA")
                {
                    Id = new Guid("FCC29737-EFF9-4922-8FCC-C53FD7FE5C18"),
                    Name = "IATA",
                    Description = "«‰Ã„‰ Õ„· Ê ‰ﬁ· ÂÊ«ÌÌ »Ì‰ «·„··Ì",
                    DescriptionEn = "International Air Transport Association"

                });

            result.Add(
                new SpecialServiceType("ICAO")
                {
                    Id = new Guid("60C4E428-7984-4748-8712-17583381CA26"),
                    Name = "ICAO",
                    Description = "”«“„«‰ ÂÊ«ÅÌ„«ÌÌ ﬂ‘Ê—Ì",
                    DescriptionEn = "Civil Aviation Organization"

                });

            result.Add(
                new SpecialServiceType("INAD")
                {
                    Id = new Guid("FC4A1A82-A424-4415-BCF9-41D51001EB0F"),
                    Name = "INAD",
                    Description = "€Ì—ﬁ«»· ﬁ»Ê·",
                    DescriptionEn = "Inadmissible"

                });

            result.Add(
                new SpecialServiceType("INFT")
                {
                    Id = new Guid("8F0005F7-80BF-4FA7-98C2-3A7E6D0B7326"),
                    Name = "INFT",
                    Description = "‰Ê“«œ »Â Â„—«Â „”«›— »“—ê”«·",
                    DescriptionEn = "Infant Accompanying Adult Passenger"

                });

            result.Add(
                new SpecialServiceType("INTL")
                {
                    Id = new Guid("2DEDA9EC-2152-41F4-9341-DA2F284321DA"),
                    Name = "INTL",
                    Description = "»Ì‰ «·„··Ì",
                    DescriptionEn = "International"

                });

            result.Add(
                new SpecialServiceType("JUMP")
                {
                    Id = new Guid("CCC9D103-6CD6-497B-A91F-B851B986F30F"),
                    Name = "JUMP",
                    Description = "„”«›— œ— ’‰œ·Ì  « ‘Ê",
                    DescriptionEn = "Passenger on Jump Seat"

                });

            result.Add(
                new SpecialServiceType("LANG")
                {
                    Id = new Guid("43430F48-8DF1-41E0-9B71-4F93563F57F7"),
                    Name = "LANG",
                    Description = "„”«⁄œ  Â«Ì “»«‰Ì „Ê—œ ‰Ì«“ «” ",
                    DescriptionEn = "Language Assistance Needed"

                });

            result.Add(
                new SpecialServiceType("LEGB")
                {
                    Id = new Guid("3E6A51E3-3A26-48FE-999C-7499903E0A74"),
                    Name = "LEGB",
                    Description = "Â— œÊ Å« œ— êç",
                    DescriptionEn = "Both Legs in Cast"

                });

            result.Add(
                new SpecialServiceType("LEGL")
                {
                    Id = new Guid("D60F6BC7-92B0-49A3-9D3F-0DD569587C01"),
                    Name = "LEGL",
                    Description = "Å«Ì çÅ œ— êç",
                    DescriptionEn = "Left Leg in Cast"

                });

            result.Add(
                new SpecialServiceType("LEGR")
                {
                    Id = new Guid("76186419-2C99-483E-86C0-B37ADEAA21B4"),
                    Name = "LEGR",
                    Description = "Å«Ì —«”  œ— êç",
                    DescriptionEn = "Right Leg in Cast"

                });

            result.Add(
                new SpecialServiceType("MAAS")
                {
                    Id = new Guid("0E9EB96D-82AC-4432-A5D0-D795AD87DAC8"),
                    Name = "MAAS",
                    Description =
                        "„·«ﬁ«  Ê œ—Ì«›  ﬂ„ﬂ œ— ‘—«ÌÿÌ ﬂÂ ‰Ì«“„‰œ œ—Ì«›  ﬂ„ﬂ œ— Â‰ê«„ œ—Ì«›  Ã«„Â œ«‰ Ì« œ— œ—» Œ—ÊÃ »«‘ÌœﬂÂ „Ì Ê«‰œ „‘„Ê· ﬂÊ—Ì Ì«ﬂ—Ì ‰Ì“ »«‘œ",
                    DescriptionEn = "Meet and Assist in Need of Assistance with Baggage Claim and/or Connecting Gate"

                });

            result.Add(
                new SpecialServiceType("MEDA")
                {
                    Id = new Guid("25D66750-28ED-4D39-BE1A-70F853AD5509"),
                    Name = "MEDA",
                    Description = "ﬂ„ﬂ Â«Ì Å“‘ﬂÌ («ﬂ”Ìé‰)",
                    DescriptionEn = "Medical Assistance"

                });

            result.Add(
                new SpecialServiceType("OXYG")
                {
                    Id = new Guid("0C6F87E7-DA70-45CB-A28A-0A421E484D63"),
                    Name = "OXYG",
                    Description = "œ— Â‰ê«„ Å—Ê«“ «ﬂ”Ìé‰ „Ê—œ ‰Ì«“ «” ",
                    DescriptionEn = "Oxygen Needed During Flight"

                });

            result.Add(
                new SpecialServiceType("PETC")
                {
                    Id = new Guid("CB53B7C6-3510-438B-8D1D-39A7F0842705"),
                    Name = "PETC",
                    Description = "„”«›— »« ”ê ﬂ„ﬂ ﬂ‰‰œÂ Ê Ì« ÕÌÊ«‰ Œ«‰êÌ œ— „Õ›ŸÂ ﬂ«»Ì‰ ”›— „Ìﬂ‰œ",
                    DescriptionEn = "Passenger is Travelling with an Assistance Dog or Pet in Cabin Compartment"

                });

            result.Add(
                new SpecialServiceType("PSGR")
                {
                    Id = new Guid("CB5C4815-7FD7-419A-89E9-3B68AE855981"),
                    Name = "PSGR",
                    Description = "„”«›—",
                    DescriptionEn = "Passenger"

                });

            result.Add(
                new SpecialServiceType("PSPT")
                {
                    Id = new Guid("F0B2A16D-698B-4A96-B216-C46230A00944"),
                    Name = "PSPT",
                    Description = "Ã“∆Ì«  Ê Ì« «ÿ·«⁄«  ê–—‰«„Â",
                    DescriptionEn = "Passport Detail or Information"

                });

            result.Add(
                new SpecialServiceType("RQST")
                {
                    Id = new Guid("858443D2-3D43-4A9D-A876-D1E8A2A01405"),
                    Name = "RQST",
                    Description = "œ—ŒÊ«”  Ì« œ—ŒÊ«”  ’‰œ·Ì",
                    DescriptionEn = "Request or Seat Request"

                });

            result.Add(
                new SpecialServiceType("RUSH")
                {
                    Id = new Guid("72B30D72-4057-46A0-AE44-607CF80171DA"),
                    Name = "RUSH",
                    Description = "ç„œ«‰ »œÊ‰ Â„—«Â",
                    DescriptionEn = "Unaccompanied Baggage"

                });

            result.Add(
                new SpecialServiceType("SEAT")
                {
                    Id = new Guid("4082AFBD-1CA1-46DD-8BC9-C717CED6ABD5"),
                    Name = "SEAT",
                    Description = "’‰œ·Ì «“ ﬁ»· —“—Ê ‘œÂ",
                    DescriptionEn = "Pre-Reserved Seat"

                });

            result.Add(
                new SpecialServiceType("SEMN")
                {
                    Id = new Guid("DF5FD02C-E15F-41DD-924E-3996F6DF5C6D"),
                    Name = "SEMN",
                    Description = "„·Ê«‰ / Œœ„Â ﬂ‘ Ì",
                    DescriptionEn = "Seaman/Ship Crew"

                });

            result.Add(
                new SpecialServiceType("STCR")
                {
                    Id = new Guid("CE5E9DE4-39D6-48D5-8FFA-34374AF5BCBF"),
                    Name = "STCR",
                    Description = "",
                    DescriptionEn = "STCR"

                });

            result.Add(
                new SpecialServiceType("THRU")
                {
                    Id = new Guid("C362718C-BF45-408F-BF62-0DEAB5460156"),
                    Name = "THRU",
                    Description = "«“ ÿ—Ìﬁ",
                    DescriptionEn = "Through"

                });

            result.Add(
                new SpecialServiceType("TKNA")
                {
                    Id = new Guid("706DC1C1-5AA6-4F66-AAD3-17274CB6A013"),
                    Name = "TKNA",
                    Description = "‘„«—Â »·Ìÿ « Ê„« Ìﬂ / PNR »·Ìÿ",
                    DescriptionEn = "Automated Ticket Number /Ticket PNR"

                });

            result.Add(
                new SpecialServiceType("TKNM")
                {
                    Id = new Guid("59A1E8FB-A2F3-4D55-BEA0-4C8CF9ACCF36"),
                    Name = "TKNM",
                    Description = "‘„«—Â »·Ìÿ œ” Ì",
                    DescriptionEn = "Manual Ticket Number"

                });

            result.Add(
                new SpecialServiceType("UM")
                {
                    Id = new Guid("B4955A5C-6BF1-41F5-A16D-7E755F008476"),
                    Name = "UM",
                    Description = "",
                    DescriptionEn = "Unaccompanied Minor"

                });

            result.Add(
                new SpecialServiceType("UNMR")
                {
                    Id = new Guid("7BC9AEEA-D557-43EE-9BD8-698040D36205"),
                    Name = "UNMR",
                    Description = "ﬂÊœﬂ »œÊ‰ Â„—«Â ",
                    DescriptionEn = "Unaccompanied Minor"

                });

            result.Add(
                new SpecialServiceType("UPGR")
                {
                    Id = new Guid("0D180DE4-36AA-480C-9883-BFE7A4A701C7"),
                    Name = "UPGR",
                    Description = "«— ﬁ«¡ »Â œ—ÃÂ »«·«",
                    DescriptionEn = "Upgrade"

                });

            result.Add(
                new SpecialServiceType("VGML")
                {
                    Id = new Guid("E4A077BD-75BB-490E-8B24-0A10EFB0B965"),
                    Name = "VGML",
                    Description = "êÌ«Â ŒÊ«—Ì €Ì— ·»‰Ì /  Œ„ „—€ (êÌ«ÂŒÊ«—) Ê⁄œÂ €–«ÌÌ „Ê—œ œ—ŒÊ«”  «” ",
                    DescriptionEn = "Vegetarian Non-Dairy/Egg (Vegan) Meal Requested"

                });

            result.Add(
                new SpecialServiceType("VIP")
                {
                    Id = new Guid("A923133B-2419-444E-9B59-BC32BF0687F6"),
                    Name = "VIP",
                    Description = "",
                    DescriptionEn = "Very Important Person"

                });

            result.Add(
                new SpecialServiceType("VVIP")
                {
                    Id = new Guid("01E9AA9B-42E5-484E-8450-55FF13682FAC"),
                    Name = "VVIP",
                    Description = "›—œ »”Ì«— »”Ì«— „Â„",
                    DescriptionEn = "Very Very Important Person"

                });

            result.Add(
                new SpecialServiceType("WCBD")
                {
                    Id = new Guid("99D4D9C5-8735-46D8-9523-BF7DE2C7126D"),
                    Name = "WCBD",
                    Description = "„”«›— »« ’‰œ·Ì ç—Œœ«— ⁄„· ﬂ‰‰œÂ »« ”·Ê· Â«Ì Œ‘ﬂ —›  Ê ¬„œ „Ìﬂ‰œ",
                    DescriptionEn = "Passenger is Traveling with Dry Cell Operated Wheelchair"

                });

            result.Add(
                new SpecialServiceType("WCBW")
                {
                    Id = new Guid("456DB83C-74D7-47BA-A1ED-FC38A5BBE5FE"),
                    Name = "WCBW",
                    Description = "„”«›— »« ’‰œ·Ì ç—Œœ«— ⁄„· ﬂ‰‰œÂ »« ”·Ê· Â«Ì  — —›  Ê ¬„œ „Ìﬂ‰œ",
                    DescriptionEn = "Passenger is Traveling with Wet Cell Operated Wheelchair"

                });

            result.Add(
                new SpecialServiceType("WCHC")
                {
                    Id = new Guid("2B8EB81D-0A4C-4FAD-9953-EA5183F4675C"),
                    Name = "WCHC",
                    Description = "’‰œ·Ì ç—Œœ«—/ »«Ìœ Õ„· ‘Êœ",
                    DescriptionEn = "Wheelchair/Must be Carried"

                });

            result.Add(
                new SpecialServiceType("WCHP")
                {
                    Id = new Guid("DC2ED1C9-484A-411A-A954-66244D8F393B"),
                    Name = "WCHP",
                    Description = "„”«›— »« ’‰œ·Ì ç—Œœ«— œ«—«Ì ﬁœ—  œ” Ì „”«›—  „Ìﬂ‰œ",
                    DescriptionEn = "Passenger is Traveling with Manual Power Wheelchair"

                });

            result.Add(
                new SpecialServiceType("WCHR")
                {
                    Id = new Guid("9E04570F-160C-49B7-B001-DB2EE3C889D2"),
                    Name = "WCHR",
                    Description = "»—«Ì  —œœ »Â Ì« «“ —„Å ’‰œ·Ì ç—Œœ«— „Ê—œ ‰Ì«“ «” ",
                    DescriptionEn = "Wheelchair Required to or from Ramp "

                });

            result.Add(
                new SpecialServiceType("WCHS")
                {
                    Id = new Guid("123E9E8F-A5F9-41A7-934D-FE8B6023FAEB"),
                    Name = "WCHS",
                    Description =
                        "’‰œ·Ì ç—Œœ«— »—«Ì »«·« —› ‰ «“ Å·Â „”«›— ﬁ«œ— »Â —«Â —› ‰ „Ì»«‘œ° «„« ﬁ«œ— »Â ’⁄Êœ Ê Ì« ›—Êœ «“ Å·Â Â« ‰Ì” ",
                    DescriptionEn =
                        "Wheelchair to Top of Steps, Passenger is Able to Walk but Unable to Ascend or Descend Stairs"

                });

            result.Add(
                new SpecialServiceType("WCMP")
                {
                    Id = new Guid("5414A34C-645B-4DBC-B74E-72801913CECA"),
                    Name = "WCMP",
                    Description = "„”«›— »« ’‰œ·Ì ç—Œœ«— »« ﬁœ—  „«‰Ê∆· „”«›—  „Ìﬂ‰œ",
                    DescriptionEn = "Passenger is Traveling with Manuel Power Wheelchair"

                });

            result.Add(
                new SpecialServiceType("WCOB")
                {
                    Id = new Guid("C92178AD-AF7E-4DC1-9653-C659201F3F3E"),
                    Name = "WCOB",
                    Description =
                        "’‰œ·Ì ç—Œœ«— œ— »«— „Ì»«‘œ(onboard) ° „”«›— ‰Ì«“ »Â ’‰œ·Ì ç—Œœ«—œ— ﬂ„ﬂ Â«Ì Å—Ê«“ œ«—œ",
                    DescriptionEn = "Wheelchair Onboard, Passenger Requires Onboard In-Flight Assistance"

                });

            result.Add(
                new SpecialServiceType("WEAP")
                {
                    Id = new Guid("3058D0B7-5D0E-47C4-A3CF-3F0AC0AA1899"),
                    Name = "WEAP",
                    Description = "”·«Õ Ì« ”·«Õ Â«Ì Â” ‰œ ﬂÂ œ— «À«ÀÌÂ »——”Ì ‘œÂ ÊÃÊœ œ«—œ",
                    DescriptionEn = "A Weapon or Weapons are Being Carried in Checked Baggage"

                });

            result.Add(
                new SpecialServiceType("WGHT")
                {
                    Id = new Guid("3733FB0D-FDB2-4537-ADA7-8E5B895B39BC"),
                    Name = "WGHT",
                    Description = "«À«ÀÌÂ »«  ÊÃÂ »Â Ê“‰  ‰«ﬂ«›Ì „ÊÃÊœ œ— ÂÊ«ÅÌ„« —œ ‘œÂ «” ",
                    DescriptionEn = "Baggage Rejected Due to Insufficient Available Weight on Aircraft"

                });

            result.Add(
                new SpecialServiceType("XBAG")
                {
                    Id = new Guid("95AEC7E6-9AA0-4510-BBDB-C3460B97A65E"),
                    Name = "XBAG",
                    Description = "«÷«›Â »«—",
                    DescriptionEn = "Excess Baggage"

                });


            return result;
        }
    }
}
