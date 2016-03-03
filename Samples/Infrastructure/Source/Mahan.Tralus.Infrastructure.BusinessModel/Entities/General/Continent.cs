using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("Continent", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class Continent : FixedEntityBase<Continent>
    {
        public Continent()
            : this("ForDbMigration")
        {

        }

        public Continent(string fixedName)
            : base(fixedName)
        {
        }

        [StringLength(200)]
        public string Code { get; set; }

        [StringLength(200)]
        public string NameEn { get; set; }

        public static Continent Africa
        {
            get { return GetFixedEntity(); }
        }

        public static Continent Antarctica
        {
            get { return GetFixedEntity(); }
        }

        public static Continent Asia
        {
            get { return GetFixedEntity(); }
        }

        public static Continent Europe
        {
            get { return GetFixedEntity(); }
        }

        public static Continent NorthAmerica
        {
            get { return GetFixedEntity(); }
        }

        public static Continent Oceania
        {
            get { return GetFixedEntity(); }
        }

        public static Continent SouthAmerica
        {
            get { return GetFixedEntity(); }
        }

        /*OrderBy NameEn*/
        public override List<Continent> PredefinedValues()
        {
            var result = new List<Continent>();

            result.Add(new Continent("Africa")
            {
                Id = new Guid("60858700-DEA5-4F56-94A3-BC45E39F2C27"),
                Code = "AF",
                Name = "آفریقا",
                NameEn = "Africa"
            });

            result.Add(new Continent("Antarctica")
            {
                Id = new Guid("4F2EFACA-3F30-4AB2-83C6-178404BB06E2"),
                Code = "AN",
                Name = "قطب جنوب",
                NameEn = "Antarctica"
            });

            result.Add(new Continent("Asia")
            {
                Id = new Guid("1DAA69DB-2F3D-40B2-8F0E-BA12EB20A2B6"),
                Code = "AS",
                Name = "آسیا",
                NameEn = "Asia"
            });

            result.Add(new Continent("Europe")
            {
                Id = new Guid("C11762CC-8DB5-4FCA-953F-B0BC8CC77673"),
                Code = "EU",
                Name = "اروپا",
                NameEn = "Europe"
            });

            result.Add(new Continent("NorthAmerica")
            {
                Id = new Guid("F92A97EF-A68A-43C4-AC8B-30FBEF4A03B1"),
                Code = "NA",
                Name = "آمریکای شمالی",
                NameEn = "North america"
            });

            result.Add(new Continent("Oceania")
            {
                Id = new Guid("46F7C3E7-6AE9-4FD5-8C1A-8CB43B80B13C"),
                Code = "OC",
                Name = "اقیانوسیه",
                NameEn = "Oceania"
            });

            result.Add(new Continent("SouthAmerica")
            {
                Id = new Guid("B22920BA-5E23-4117-B189-41DF92BEFECE"),
                Code = "SA",
                Name = "آمریکای جنوبی",
                NameEn = "South america"
            });		

            return result;
        }
    }
}
