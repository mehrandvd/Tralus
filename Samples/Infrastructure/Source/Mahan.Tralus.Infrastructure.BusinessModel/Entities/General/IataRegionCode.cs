using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("IataRegionCode", Schema = "Infrastructure")]
    [DefaultProperty("RegionName")]
    public class IataRegionCode : FixedEntityBase<IataRegionCode>
    {
        public IataRegionCode()
            : this("ForDbMigration")
        {
            
        }

        public IataRegionCode(string fixedName)
            : base(fixedName)
        {
        }

        [StringLength(200)]
        public string RegionCode { get; set; }

        [StringLength(200)]
        public string RegionNameEn { get; set; }

        public static IataRegionCode Africa
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode CaribbeanSeaCountries
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode CentralAmerica
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode Europe
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode IATAAmericanTrafficConference
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode IATAAsianTrafficConference
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode IATAEuropeanandAfricanTrafficConference
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode JapanandKorea
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode MiddleEast
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode NorthAmerica
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode SchengenAgreementCountries
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode SouthAmerica
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode SouthAsia
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode SouthEasternAsia
        {
            get { return GetFixedEntity(); }
        }

        public static IataRegionCode SouthWestPacific
        {
            get { return GetFixedEntity(); }
        }


        /*OrderBy RegionNameEn*/
        public override List<IataRegionCode> PredefinedValues()
        {
            var result = new List<IataRegionCode>();

            result.Add(new IataRegionCode("Africa")
            {
                Id = new Guid("C1F98485-64AC-4D6D-B91B-4F5D1181A7F0"),
                RegionCode = "AFR",
                Name = "¬›—Ìﬁ«",
                RegionNameEn = "Africa"
            });

            result.Add(new IataRegionCode("CaribbeanSeaCountries")
            {
                Id = new Guid("5E98B661-C12B-472E-BE24-25191CA8973B"),
                RegionCode = "CAR",
                Name = "ﬂ‘Ê—Â«Ì œ—Ì«Ì ﬂ«—«∆Ì»",
                RegionNameEn = "Caribbean Sea Countries"
            });

            result.Add(new IataRegionCode("CentralAmerica")
            {
                Id = new Guid("DA10BE4E-3215-44C4-BCAB-67A8D478A84E"),
                RegionCode = "CEM",
                Name = "¬„—Ìﬂ«Ì „—ﬂ“Ì",
                RegionNameEn = "Central America"
            });

            result.Add(new IataRegionCode("Europe")
            {
                Id = new Guid("6C23C6CF-CA71-45C5-8BB3-A2AF10ABC6A2"),
                RegionCode = "EUR",
                Name = "«—ÊÅ«",
                RegionNameEn = "Europe"
            });

            result.Add(new IataRegionCode("IATAAmericanTrafficConference")
            {
                Id = new Guid("33BFB786-9F88-4A74-99D9-E8DE0B41A468"),
                RegionCode = "TC1",
                Name = "ﬂ‰›—«‰”  —«›Ìﬂ ¬„—Ìﬂ«ÌÌ IATA",
                RegionNameEn = "IATA American Traffic Conference"
            });

            result.Add(new IataRegionCode("IATAAsianTrafficConference")
            {
                Id = new Guid("D28D7B18-501E-4B38-98E8-EAFCA84E18B9"),
                RegionCode = "TC3",
                Name = "ﬂ‰›—«‰”  —«›Ìﬂ ¬”Ì«ÌÌ IATA",
                RegionNameEn = "IATA Asian Traffic Conference"
            });

            result.Add(new IataRegionCode("IATAEuropeanandAfricanTrafficConference")
            {
                Id = new Guid("2D192B9C-812D-44DE-BD95-C639D7DD3355"),
                RegionCode = "TC2",
                Name = "ﬂ‰›—«‰”  —«›Ìﬂ «—ÊÅ«ÌÌ Ê ¬›—Ìﬁ«ÌÌ IATA",
                RegionNameEn = "IATA European and African Traffic Conference"
            });

            result.Add(new IataRegionCode("JapanandKorea")
            {
                Id = new Guid("3F5A2AF9-5663-4A64-A3AC-79ECB3A8325D"),
                RegionCode = "JAK",
                Name = "é«Å‰ Ê ﬂ—Â",
                RegionNameEn = "Japan and Korea"
            });

            result.Add(new IataRegionCode("MiddleEast")
            {
                Id = new Guid("39ABFDEB-C279-48D9-A26E-C9DA590D8187"),
                RegionCode = "MDE",
                Name = "Œ«Ê—„Ì«‰Â",
                RegionNameEn = "Middle East"
            });

            result.Add(new IataRegionCode("NorthAmerica")
            {
                Id = new Guid("FAEAF0CD-E5AC-4FAF-B2DD-B220AE527B39"),
                RegionCode = "NOA",
                Name = "¬„—Ìﬂ«Ì ‘„«·Ì",
                RegionNameEn = "North America"
            });

            result.Add(new IataRegionCode("SchengenAgreementCountries")
            {
                Id = new Guid("03866788-DD05-4B34-B2CF-784AA88EEBD7"),
                RegionCode = "SCH",
                Name = "ﬂ‘Ê—Â«Ì ﬁ—«—œ«œ ‘‰ê‰",
                RegionNameEn = "Schengen Agreement Countries"
            });

            result.Add(new IataRegionCode("SouthAmerica")
            {
                Id = new Guid("A2FB8AA0-0A59-4C40-9B0C-851BEBC1E0D4"),
                RegionCode = "SOA",
                Name = "¬„—Ìﬂ«Ì Ã‰Ê»Ì",
                RegionNameEn = "South America"
            });

            result.Add(new IataRegionCode("SouthAsia")
            {
                Id = new Guid("102BC6D4-DBA2-445C-AE46-04D9F2254F70"),
                RegionCode = "SAS",
                Name = "¬”Ì«Ì Ã‰Ê»Ì",
                RegionNameEn = "South Asia"
            });

            result.Add(new IataRegionCode("SouthEasternAsia")
            {
                Id = new Guid("14D553A0-14DF-4B24-B873-B4E56AC389CB"),
                RegionCode = "SEA",
                Name = "¬”Ì«Ì Ã‰Ê» ‘—ﬁÌ",
                RegionNameEn = "South-Eastern Asia"
            });

            result.Add(new IataRegionCode("SouthWestPacific")
            {
                Id = new Guid("156CB0D5-12AE-4DF5-8D8E-EFCA084D887A"),
                RegionCode = "SWP",
                Name = "Ã‰Ê» €—»Ì «ﬁÌ«‰Ê” ¬—«„",
                RegionNameEn = "South-West Pacific"
            });			
			
            return result;

        }
    }
}
