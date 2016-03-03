using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Infrastructure.BusinessModel
{
    [Table("Currency", Schema = "Infrastructure")]
    [DefaultProperty("Name")]
    public class Currency : FixedEntityBase<Currency>
    {
        public Currency()
            : this("ForDbMigration")
        {
            
        }

        public Currency(string fixedName)
            : base(fixedName)
        {
        }

        [StringLength(20)]
        public string Symbol { get; set; }

        [StringLength(50)]
        public string NameEn { get; set; }

        [StringLength(5)]
        public string Code { get; set; }

        public static Currency Guernseypound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency UnitedArabEmiratesdirham
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Afghanafghani
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Albanianlek
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Armeniandram
        {
            get { return GetFixedEntity(); }
        }

        public static Currency NetherlandsAntilleanguilder
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Angolankwanza
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Argentinepeso
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Australiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Arubanflorin
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Azerbaijanimanat
        {
            get { return GetFixedEntity(); }
        }

        public static Currency BosniaandHerzegovinaconvertiblemark
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Barbadiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bangladeshitaka
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bulgarianlev
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bahrainidinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Burundianfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bermudiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bruneidollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bolivianboliviano
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Brazilianreal
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bahamiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Bhutanesengultrum
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Botswanapula
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Belarusianruble
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Belizedollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Canadiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Congolesefranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Swissfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Chileanpeso
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Chineseyuan
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Colombianpeso
        {
            get { return GetFixedEntity(); }
        }

        public static Currency CostaRicancolón
        {
            get { return GetFixedEntity(); }
        }

        public static Currency CapeVerdeanescudo
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Czechkoruna
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Djiboutianfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Danishkrone
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Dominicanpeso
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Algeriandinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Egyptianpound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Eritreannakfa
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Ethiopianbirr
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Euro
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Fijiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency FalklandIslandspound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Britishpound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Georgianlari
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Ghanacedi
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Gibraltarpound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Gambiandalasi
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Guineanfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Guatemalanquetzal
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Guyanesedollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency HongKongdollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Honduranlempira
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Croatiankuna
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Haitiangourde
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Hungarianforint
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Indonesianrupiah
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Israelinewshekel
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Manxpound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Indianrupee
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Iraqidinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Iranianrial
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Icelandickróna
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Jamaicandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Jordaniandinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Japaneseyen
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Kenyanshilling
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Kyrgyzstanisom
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Cambodianriel
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Comorianfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency NorthKoreanwon
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SouthKoreanwon
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Kuwaitidinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency CaymanIslandsdollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Kazakhstanitenge
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Laokip
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Lebanesepound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SriLankanrupee
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Liberiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Lesotholoti
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Lithuanianlitas
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Libyandinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Moroccandirham
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Moldovanleu
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Malagasyariary
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Macedoniandenar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Burmesekyat
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Mongoliantögrög
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Macanesepataca
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Mauritanianouguiya
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Mauritianrupee
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Maldivianrufiyaa
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Malawiankwacha
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Mexicanpeso
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Malaysianringgit
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Mozambicanmetical
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Namibiandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Nigeriannaira
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Nicaraguancórdoba
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Norwegiankrone
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Nepaleserupee
        {
            get { return GetFixedEntity(); }
        }

        public static Currency NewZealanddollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Omanirial
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Panamanianbalboa
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Peruviannuevosol
        {
            get { return GetFixedEntity(); }
        }

        public static Currency PapuaNewGuineankina
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Philippinepeso
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Pakistanirupee
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Polishzłoty
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Transnistrianruble
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Paraguayanguaraní
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Qataririyal
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Romanianleu
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Serbiandinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Russianruble
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Rwandanfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Saudiriyal
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SolomonIslandsdollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Seychelloisrupee
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Sudanesepound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Swedishkrona
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Singaporedollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SaintHelenapound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SierraLeoneanleone
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Somalishilling
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Surinamesedollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SouthSudanesepound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SãoToméandPríncipedobra
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Syrianpound
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Swazililangeni
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Thaibaht
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Tajikistanisomoni
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Turkmenistanmanat
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Tunisiandinar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Tonganpaʻanga
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Turkishlira
        {
            get { return GetFixedEntity(); }
        }

        public static Currency TrinidadandTobagodollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency NewTaiwandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Tanzanianshilling
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Ukrainianhryvnia
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Ugandanshilling
        {
            get { return GetFixedEntity(); }
        }

        public static Currency UnitedStatesdollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Uruguayanpeso
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Uzbekistanisom
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Venezuelanbolívar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Vietnameseđồng
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Vanuatuvatu
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Samoantālā
        {
            get { return GetFixedEntity(); }
        }

        public static Currency CentralAfricanCFAfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency EastCaribbeandollar
        {
            get { return GetFixedEntity(); }
        }

        public static Currency WestAfricanCFAfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency CFPfranc
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Yemenirial
        {
            get { return GetFixedEntity(); }
        }

        public static Currency SouthAfricanrand
        {
            get { return GetFixedEntity(); }
        }

        public static Currency Zambiankwacha
        {
            get { return GetFixedEntity(); }
        }
		

        /*OrderBy NameEn*/
        public override List<Currency> PredefinedValues()
        {
            var result = new List<Currency>();

            result.Add(new Currency("Afghanafghani")
            {
                Id = new Guid("BC116A4F-72F3-45A8-9F7D-BF467D5D2218"),
                Code = "AFN",
                Name = "افغانی افغانستان ",
                NameEn = "Afghan afghani",
                Symbol = "؋"
            });

            result.Add(new Currency("Albanianlek")
            {
                Id = new Guid("CCAC3A17-E1CB-4CA7-9993-38213DBF8A03"),
                Code = "ALL",
                Name = "لک آلبانی",
                NameEn = "Albanian lek",
                Symbol = "L"
            });

            result.Add(new Currency("Algeriandinar")
            {
                Id = new Guid("877A594E-F1D2-4331-9BE9-E72C0FD84599"),
                Code = "DZD",
                Name = "دینار الجزایر ",
                NameEn = "Algerian dinar",
                Symbol = "د.ج"
            });

            result.Add(new Currency("Angolankwanza")
            {
                Id = new Guid("4E5A0700-A255-458B-8EAF-429B321A366B"),
                Code = "AOA",
                Name = "کوانزا آنگولا",
                NameEn = "Angolan kwanza",
                Symbol = "Kz"
            });

            result.Add(new Currency("Argentinepeso")
            {
                Id = new Guid("4E1A66AD-E1B8-4FB4-9D73-902AA90AB17E"),
                Code = "ARS",
                Name = "پزو آرژانتین ",
                NameEn = "Argentine peso",
                Symbol = "$"
            });

            result.Add(new Currency("Armeniandram")
            {
                Id = new Guid("4B270B61-92FA-4CD9-96CF-86FBCBE98616"),
                Code = "AMD",
                Name = "درم ارمنستان ",
                NameEn = "Armenian dram",
                Symbol = ""
            });

            result.Add(new Currency("Arubanflorin")
            {
                Id = new Guid("CBD482C6-D02D-40EA-B3B2-D1C012EF0393"),
                Code = "AWG",
                Name = "فلورین آروبن",
                NameEn = "Aruban florin",
                Symbol = "ƒ"
            });

            result.Add(new Currency("Australiandollar")
            {
                Id = new Guid("82B10C54-AF56-450D-85C1-BDE819F7EAD4"),
                Code = "AUD",
                Name = "دلار استرالیا ",
                NameEn = "Australian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Azerbaijanimanat")
            {
                Id = new Guid("555039D7-91F4-44A0-9BA1-ECF198A3E045"),
                Code = "AZN",
                Name = "منات آذربایجان ",
                NameEn = "Azerbaijani manat",
                Symbol = ""
            });

            result.Add(new Currency("Bahamiandollar")
            {
                Id = new Guid("055FB51B-5C90-4500-8E23-F340E78CC8C1"),
                Code = "BSD",
                Name = "دلار باهاما ",
                NameEn = "Bahamian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Bahrainidinar")
            {
                Id = new Guid("931F06EF-F5B9-4367-A3DF-E90D3141563E"),
                Code = "BHD",
                Name = "دینار بحرین ",
                NameEn = "Bahraini dinar",
                Symbol = ".د.ب"
            });

            result.Add(new Currency("Bangladeshitaka")
            {
                Id = new Guid("1D42FAC3-F2A9-44AD-8893-37B785D069FB"),
                Code = "BDT",
                Name = "تاکا بنگلادش",
                NameEn = "Bangladeshi taka",
                Symbol = "৳"
            });

            result.Add(new Currency("Barbadiandollar")
            {
                Id = new Guid("B5C08A96-EEC9-4463-9934-AE8001C5D40C"),
                Code = "BBD",
                Name = "دلار باربادین ",
                NameEn = "Barbadian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Belarusianruble")
            {
                Id = new Guid("E8757898-F5DC-42E2-837B-1A3F646C3C12"),
                Code = "BYR",
                Name = "روبل بلاروس ",
                NameEn = "Belarusian ruble",
                Symbol = "Br"
            });

            result.Add(new Currency("Belizedollar")
            {
                Id = new Guid("F6D163CF-258A-4663-9F39-0AAC72FF6C16"),
                Code = "BZD",
                Name = "دلار بلیز ",
                NameEn = "Belize dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Bermudiandollar")
            {
                Id = new Guid("342AAAE6-B8C6-4C72-AFDE-7E793D9089AF"),
                Code = "BMD",
                Name = "دلار برمودا ",
                NameEn = "Bermudian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Bhutanesengultrum")
            {
                Id = new Guid("2205D131-C0A1-4651-A597-2D7F77842121"),
                Code = "BTN",
                Name = "انگولتروم بوهتانی",
                NameEn = "Bhutanese ngultrum",
                Symbol = "Nu."
            });

            result.Add(new Currency("Bolivianboliviano")
            {
                Id = new Guid("29858FDC-3131-4A92-A31A-0947E6641772"),
                Code = "BOB",
                Name = "بولیویانو بولیوی ",
                NameEn = "Bolivian boliviano",
                Symbol = "Bs."
            });

            result.Add(new Currency("BosniaandHerzegovinaconvertiblemark")
            {
                Id = new Guid("4DF20605-EBD0-4085-A9C5-B0F69A52E42F"),
                Code = "BAM",
                Name = "مارک قابل تبدیل بوسنی و هرزگویین",
                NameEn = "Bosnia and Herzegovina convertible mark",
                Symbol = "KM or КМ"
            });

            result.Add(new Currency("Botswanapula")
            {
                Id = new Guid("E4F0D306-E99C-48DD-BDC8-C098DD440C6C"),
                Code = "BWP",
                Name = "پولا بوتسوانا ",
                NameEn = "Botswana pula",
                Symbol = "P"
            });

            result.Add(new Currency("Brazilianreal")
            {
                Id = new Guid("634A2411-2D39-457F-92E9-D2849156F514"),
                Code = "BRL",
                Name = "ریل برزیل",
                NameEn = "Brazilian real",
                Symbol = "R$"
            });

            result.Add(new Currency("Britishpound")
            {
                Id = new Guid("6263F553-7AF6-49AB-A25B-7265872C05E5"),
                Code = "GBP",
                Name = "پوند انگلیس ",
                NameEn = "British pound",
                Symbol = "£"
            });

            result.Add(new Currency("Bruneidollar")
            {
                Id = new Guid("0CC66541-EE30-47FC-850A-4379824AB912"),
                Code = "BND",
                Name = "دلار برونئی ",
                NameEn = "Brunei dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Bulgarianlev")
            {
                Id = new Guid("6AAE03C4-C06E-4C15-82D8-9BB0FF3DD66D"),
                Code = "BGN",
                Name = "لف بلغارستان ",
                NameEn = "Bulgarian lev",
                Symbol = "лв"
            });

            result.Add(new Currency("Burmesekyat")
            {
                Id = new Guid("12F176BA-B2D8-4093-A8E1-5D66E85BD071"),
                Code = "MMK",
                Name = "کیات برمه ",
                NameEn = "Burmese kyat",
                Symbol = "Ks"
            });

            result.Add(new Currency("Burundianfranc")
            {
                Id = new Guid("47556D00-3789-4D9C-9780-BA8CB765CF78"),
                Code = "BIF",
                Name = "فرانک بوروندی ",
                NameEn = "Burundian franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("Cambodianriel")
            {
                Id = new Guid("CDB0AE5B-B26D-4794-A487-AE569DAF89D5"),
                Code = "KHR",
                Name = "ریل کامبوج ",
                NameEn = "Cambodian riel",
                Symbol = "៛"
            });

            result.Add(new Currency("Canadiandollar")
            {
                Id = new Guid("A91B9653-0677-4014-B40C-68948E84C2CB"),
                Code = "CAD",
                Name = "دلار کانادا ",
                NameEn = "Canadian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("CapeVerdeanescudo")
            {
                Id = new Guid("598D0859-CFF1-45E1-9CA7-C0ED3274D932"),
                Code = "CVE",
                Name = "اسکودوی کیپ وردان ",
                NameEn = "Cape Verdean escudo",
                Symbol = "Esc or $"
            });

            result.Add(new Currency("CaymanIslandsdollar")
            {
                Id = new Guid("3C6DA2EF-6F4F-4B64-B358-78B8FDB39633"),
                Code = "KYD",
                Name = "دلار جزایر کیمن ",
                NameEn = "Cayman Islands dollar",
                Symbol = "$"
            });

            result.Add(new Currency("CentralAfricanCFAfranc")
            {
                Id = new Guid("162DF4B6-B5CD-4C86-9E13-2169C20AF03F"),
                Code = "XAF",
                Name = "فرانک آفریقای مرکزی CFA",
                NameEn = "Central African CFA franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("CFPfranc")
            {
                Id = new Guid("47BB58CA-69E7-46F4-9CBC-2604B1A714DB"),
                Code = "XPF",
                Name = "فرانک CFP ",
                NameEn = "CFP franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("Chileanpeso")
            {
                Id = new Guid("AB067200-326A-48BA-9EDA-72B0829B0099"),
                Code = "CLP",
                Name = "پزو شیلی ",
                NameEn = "Chilean peso",
                Symbol = "$"
            });

            result.Add(new Currency("Chineseyuan")
            {
                Id = new Guid("F14A1A74-DD55-4885-A82F-0CCB3BA01936"),
                Code = "CNY",
                Name = "یوان چین ",
                NameEn = "Chinese yuan",
                Symbol = "¥ or 元"
            });

            result.Add(new Currency("Colombianpeso")
            {
                Id = new Guid("55E8BD99-2E87-4DA3-A40E-86B06277FA4C"),
                Code = "COP",
                Name = "پزوی کلمبیا ",
                NameEn = "Colombian peso",
                Symbol = "$"
            });

            result.Add(new Currency("Comorianfranc")
            {
                Id = new Guid("A783BFAF-FC64-49E4-8D0B-D95901C846D2"),
                Code = "KMF",
                Name = "فرانک کموریا",
                NameEn = "Comorian franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("Congolesefranc")
            {
                Id = new Guid("6D54D484-7827-4BD9-AAF1-5D5933D071CE"),
                Code = "CDF",
                Name = "فرانک کنگو ",
                NameEn = "Congolese franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("CostaRicancolón")
            {
                Id = new Guid("6771A164-01A6-4758-9B30-9FB59EE0169C"),
                Code = "CRC",
                Name = "کولون کاستاریکا ",
                NameEn = "Costa Rican colón",
                Symbol = "₡"
            });

            result.Add(new Currency("Croatiankuna")
            {
                Id = new Guid("7E665853-DDD1-4746-A3DB-017753971740"),
                Code = "HRK",
                Name = "کونا کرواتی ",
                NameEn = "Croatian kuna",
                Symbol = "kn"
            });

            result.Add(new Currency("Czechkoruna")
            {
                Id = new Guid("E7437024-D34B-4F2B-BFEB-85C75DB460E3"),
                Code = "CZK",
                Name = "کرون جمهوری چک ",
                NameEn = "Czech koruna",
                Symbol = "Kč"
            });

            result.Add(new Currency("Danishkrone")
            {
                Id = new Guid("D4C06DB2-EE2E-4F76-89C8-26D955CBB9CF"),
                Code = "DKK",
                Name = "کرون دانمارک ",
                NameEn = "Danish krone",
                Symbol = "kr"
            });

            result.Add(new Currency("Djiboutianfranc")
            {
                Id = new Guid("5D2C5323-1CE0-437D-AFD4-A06290C4DEF4"),
                Code = "DJF",
                Name = "فرانک جیبوتی ",
                NameEn = "Djiboutian franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("Dominicanpeso")
            {
                Id = new Guid("813E0B6C-9DEA-4C68-9E4F-F36FDC1C2589"),
                Code = "DOP",
                Name = "پزو دومینیکن ",
                NameEn = "Dominican peso",
                Symbol = "$"
            });

            result.Add(new Currency("EastCaribbeandollar")
            {
                Id = new Guid("9DE46EB1-7889-4617-8F33-817C1EBD92E3"),
                Code = "XCD",
                Name = "دلار شرق کارائیب ",
                NameEn = "East Caribbean dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Egyptianpound")
            {
                Id = new Guid("B03B101A-6DB1-4EF2-8F9D-440050BEC3AA"),
                Code = "EGP",
                Name = "پوند مصر ",
                NameEn = "Egyptian pound",
                Symbol = "£ or ج.م"
            });

            result.Add(new Currency("Eritreannakfa")
            {
                Id = new Guid("7B5D362C-51E1-45EB-A345-54E130CE3833"),
                Code = "ERN",
                Name = "ناکفا اریتره ",
                NameEn = "Eritrean nakfa",
                Symbol = "Nfk"
            });

            result.Add(new Currency("Ethiopianbirr")
            {
                Id = new Guid("62D5F4FE-6ADC-4506-A15D-59CCD2606105"),
                Code = "ETB",
                Name = "بیر اتیوپی",
                NameEn = "Ethiopian birr",
                Symbol = "Br"
            });

            result.Add(new Currency("Euro")
            {
                Id = new Guid("4C8EEE8F-1A96-4894-9A3F-EC22A4DFC94F"),
                Code = "EUR",
                Name = "یورو",
                NameEn = "Euro",
                Symbol = "€"
            });

            result.Add(new Currency("FalklandIslandspound")
            {
                Id = new Guid("C2CA3605-2739-45ED-9E50-2C845C3E9338"),
                Code = "FKP",
                Name = "پوند جزایر فالکلند",
                NameEn = "Falkland Islands pound",
                Symbol = "£"
            });

            result.Add(new Currency("Fijiandollar")
            {
                Id = new Guid("B924774C-B0AA-4E95-A725-E37D656E030A"),
                Code = "FJD",
                Name = "دلار فیجی ",
                NameEn = "Fijian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Gambiandalasi")
            {
                Id = new Guid("2B518821-EE77-4DDB-8AE6-F3C59BBD095E"),
                Code = "GMD",
                Name = "دالاسی گامبیا ",
                NameEn = "Gambian dalasi",
                Symbol = "D"
            });

            result.Add(new Currency("Georgianlari")
            {
                Id = new Guid("E1B625D7-F3B8-4E2D-876E-B51AD029BAD9"),
                Code = "GEL",
                Name = "لاری گرجستان ",
                NameEn = "Georgian lari",
                Symbol = "ლ"
            });

            result.Add(new Currency("Ghanacedi")
            {
                Id = new Guid("6BB7D112-2404-4DDF-BE7D-785344DB52F7"),
                Code = "GHS",
                Name = "سدی غنا ",
                NameEn = "Ghana cedi",
                Symbol = "₵"
            });

            result.Add(new Currency("Gibraltarpound")
            {
                Id = new Guid("3F5EC6B1-44E9-4D13-BA40-BA1A15E32F8B"),
                Code = "GIP",
                Name = "پوند جبل الطارق ",
                NameEn = "Gibraltar pound",
                Symbol = "£"
            });

            result.Add(new Currency("Guatemalanquetzal")
            {
                Id = new Guid("3432027B-363F-4947-B133-81E151DE26B5"),
                Code = "GTQ",
                Name = "کوتزال گواتمالا ",
                NameEn = "Guatemalan quetzal",
                Symbol = "Q"
            });

            result.Add(new Currency("Guernseypound")
            {
                Id = new Guid("3A71D2E4-035E-4D8E-8FC2-23D50BF8CE71"),
                Code = "GGP",
                Name = "پوند گورنسی",
                NameEn = "Guernsey pound",
                Symbol = "£"
            });

            result.Add(new Currency("Guineanfranc")
            {
                Id = new Guid("91778770-776E-4D4B-826B-CD28E7570A3F"),
                Code = "GNF",
                Name = "فرانک گینه ",
                NameEn = "Guinean franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("Guyanesedollar")
            {
                Id = new Guid("CF167576-D986-400B-BF30-58E54D728890"),
                Code = "GYD",
                Name = "دلار گویانسه",
                NameEn = "Guyanese dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Haitiangourde")
            {
                Id = new Guid("06C4B5F6-7C3D-4EAB-8FC4-4BACE76337D4"),
                Code = "HTG",
                Name = "گورد هائیتی ",
                NameEn = "Haitian gourde",
                Symbol = "G"
            });

            result.Add(new Currency("Honduranlempira")
            {
                Id = new Guid("BD10E6AA-1188-4CC9-8B81-36CB23FA9F59"),
                Code = "HNL",
                Name = "لمپایرا هندوراس ",
                NameEn = "Honduran lempira",
                Symbol = "L"
            });

            result.Add(new Currency("HongKongdollar")
            {
                Id = new Guid("D79A49DD-3EBB-4177-B25C-65B4D575F3DF"),
                Code = "HKD",
                Name = "دلار هنگ کنگ ",
                NameEn = "Hong Kong dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Hungarianforint")
            {
                Id = new Guid("71E36C0F-652B-4B98-AC57-5E938A526E45"),
                Code = "HUF",
                Name = "فورینت مجارستان ",
                NameEn = "Hungarian forint",
                Symbol = "Ft"
            });

            result.Add(new Currency("Icelandickróna")
            {
                Id = new Guid("07ECE5F7-106F-48F9-8E2B-ABB7EEF47142"),
                Code = "ISK",
                Name = "کرون ایسلندی ",
                NameEn = "Icelandic króna",
                Symbol = "kr"
            });

            result.Add(new Currency("Indianrupee")
            {
                Id = new Guid("2BB2C2D8-7810-4AC4-AF5D-B5E4C7778FBD"),
                Code = "INR",
                Name = "روپیه هند ",
                NameEn = "Indian rupee",
                Symbol = ""
            });

            result.Add(new Currency("Indonesianrupiah")
            {
                Id = new Guid("F519D48C-7C0D-4701-A326-E8BE6179CCD5"),
                Code = "IDR",
                Name = "روپیه اندونزی ",
                NameEn = "Indonesian rupiah",
                Symbol = "Rp"
            });

            result.Add(new Currency("Iranianrial")
            {
                Id = new Guid("F7019005-8A2D-46A0-88C9-5F0C9682E5B2"),
                Code = "IRR",
                Name = "ریال ایران ",
                NameEn = "Iranian rial",
                Symbol = "﷼"
            });

            result.Add(new Currency("Iraqidinar")
            {
                Id = new Guid("6436B454-04F6-4C30-BDCB-614CFF01B930"),
                Code = "IQD",
                Name = "دینار عراق ",
                NameEn = "Iraqi dinar",
                Symbol = "ع.د"
            });

            result.Add(new Currency("Israelinewshekel")
            {
                Id = new Guid("CDE030AD-6C98-4A3A-9BCA-486D90D74305"),
                Code = "ILS",
                Name = "شکل جدید اسرائیل",
                NameEn = "Israeli new shekel",
                Symbol = "₪"
            });

            result.Add(new Currency("Jamaicandollar")
            {
                Id = new Guid("321127C5-F096-40C1-A21D-7A7AE87B29D8"),
                Code = "JMD",
                Name = "دلار جامائیکا",
                NameEn = "Jamaican dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Japaneseyen")
            {
                Id = new Guid("C8AE94A0-7888-4098-A00C-7B9830BE06D9"),
                Code = "JPY",
                Name = "ین ژاپن ",
                NameEn = "Japanese yen",
                Symbol = "¥"
            });

            result.Add(new Currency("Jordaniandinar")
            {
                Id = new Guid("1C8F58FF-9B91-4618-BD98-40F0D1A371DD"),
                Code = "JOD",
                Name = "دینار اردن ",
                NameEn = "Jordanian dinar",
                Symbol = "د.ا"
            });

            result.Add(new Currency("Kazakhstanitenge")
            {
                Id = new Guid("F3F9D59C-97B0-464D-9B31-09ED12D23BD7"),
                Code = "KZT",
                Name = "تنگه قزاقستان ",
                NameEn = "Kazakhstani tenge",
                Symbol = "₸"
            });

            result.Add(new Currency("Kenyanshilling")
            {
                Id = new Guid("02DAA862-424D-40EE-9CEC-6D901D3ED4A3"),
                Code = "KES",
                Name = "شیلینگ کنیا ",
                NameEn = "Kenyan shilling",
                Symbol = "Sh"
            });

            result.Add(new Currency("Kuwaitidinar")
            {
                Id = new Guid("F01419DB-0EB8-4507-97D3-8FE301A36E6D"),
                Code = "KWD",
                Name = "دینار کویت ",
                NameEn = "Kuwaiti dinar",
                Symbol = "د.ك"
            });

            result.Add(new Currency("Kyrgyzstanisom")
            {
                Id = new Guid("1567BF83-B241-4014-A9AE-41A7A32EB0C9"),
                Code = "KGS",
                Name = "سام قرقیزستان ",
                NameEn = "Kyrgyzstani som",
                Symbol = "лв"
            });

            result.Add(new Currency("Laokip")
            {
                Id = new Guid("12FBD642-6C80-40C1-ACA3-F7DAE9B42820"),
                Code = "LAK",
                Name = "کیپ لائوس ",
                NameEn = "Lao kip",
                Symbol = "₭"
            });

            result.Add(new Currency("Lebanesepound")
            {
                Id = new Guid("08686044-C83D-4740-A73B-45B671140279"),
                Code = "LBP",
                Name = "پوند لبنان ",
                NameEn = "Lebanese pound",
                Symbol = "ل.ل"
            });

            result.Add(new Currency("Lesotholoti")
            {
                Id = new Guid("0160013B-54D9-4FC2-8D64-BEA62535585B"),
                Code = "LSL",
                Name = "لوتی لسوتو ",
                NameEn = "Lesotho loti",
                Symbol = "L"
            });

            result.Add(new Currency("Liberiandollar")
            {
                Id = new Guid("39F2EDDD-A85C-4890-9386-2A95040E485F"),
                Code = "LRD",
                Name = "دلار لیبریا ",
                NameEn = "Liberian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Libyandinar")
            {
                Id = new Guid("CE982ADF-4234-4EE0-87F7-E01CC7DEB758"),
                Code = "LYD",
                Name = "دینار لیبی ",
                NameEn = "Libyan dinar",
                Symbol = "ل.د"
            });

            result.Add(new Currency("Lithuanianlitas")
            {
                Id = new Guid("8D552F4E-2EC4-4765-9BA8-AFB3C92A5117"),
                Code = "LTL",
                Name = "لیتوانیایی لتس ",
                NameEn = "Lithuanian litas",
                Symbol = "Lt"
            });

            result.Add(new Currency("Macanesepataca")
            {
                Id = new Guid("F417CA22-118B-456E-9D9C-7829C1812CD5"),
                Code = "MOP",
                Name = "ماکانس ماکائو",
                NameEn = "Macanese pataca",
                Symbol = "P"
            });

            result.Add(new Currency("Macedoniandenar")
            {
                Id = new Guid("D1B9DF9E-4388-4452-ADDD-91B914D60D2F"),
                Code = "MKD",
                Name = "دینار مقدونی ",
                NameEn = "Macedonian denar",
                Symbol = "ден"
            });

            result.Add(new Currency("Malagasyariary")
            {
                Id = new Guid("7DA6D5AC-4D81-48D5-B894-35B1662BC645"),
                Code = "MGA",
                Name = "آریاری ماداگاسکار ",
                NameEn = "Malagasy ariary",
                Symbol = "Ar"
            });

            result.Add(new Currency("Malawiankwacha")
            {
                Id = new Guid("ADBB880E-5153-47E1-9A44-BC35CE56EC3D"),
                Code = "MWK",
                Name = "کواچا مالاویا",
                NameEn = "Malawian kwacha",
                Symbol = "MK"
            });

            result.Add(new Currency("Malaysianringgit")
            {
                Id = new Guid("37FA61F6-4D98-47B9-9989-901FAB98C828"),
                Code = "MYR",
                Name = "رینگیت مالزی ",
                NameEn = "Malaysian ringgit",
                Symbol = "RM"
            });

            result.Add(new Currency("Maldivianrufiyaa")
            {
                Id = new Guid("7D2695BD-6C7D-464F-8473-8F1F9675C6F3"),
                Code = "MVR",
                Name = "روفیه مالدیو",
                NameEn = "Maldivian rufiyaa",
                Symbol = ".ރ"
            });

            result.Add(new Currency("Manxpound")
            {
                Id = new Guid("3049EE26-0306-4299-AC32-66A6C1A320D7"),
                Code = "IMP[B",
                Name = "پوند منکس",
                NameEn = "Manx pound",
                Symbol = "£"
            });

            result.Add(new Currency("Mauritanianouguiya")
            {
                Id = new Guid("496A337B-1EDD-429B-AA83-7434C68BE3E6"),
                Code = "MRO",
                Name = "اوگوییا موریتانی ",
                NameEn = "Mauritanian ouguiya",
                Symbol = "UM"
            });

            result.Add(new Currency("Mauritianrupee")
            {
                Id = new Guid("3D638123-7266-459B-8237-D5F1D5D99BFC"),
                Code = "MUR",
                Name = "روپیه موریس ",
                NameEn = "Mauritian rupee",
                Symbol = "₨"
            });

            result.Add(new Currency("Mexicanpeso")
            {
                Id = new Guid("28A9A968-D12C-44D5-B055-B31C05E7E759"),
                Code = "MXN",
                Name = "پزو مکزیک ",
                NameEn = "Mexican peso",
                Symbol = "$"
            });

            result.Add(new Currency("Moldovanleu")
            {
                Id = new Guid("7EFF7D91-DFD6-4D45-8E54-A983C1CE8C7B"),
                Code = "MDL",
                Name = "لئو مولداوی ",
                NameEn = "Moldovan leu",
                Symbol = "L"
            });

            result.Add(new Currency("Mongoliantögrög")
            {
                Id = new Guid("7B61CF78-B8B3-46C5-B60B-48C90A22F74C"),
                Code = "MNT",
                Name = "توگروگ مغولی ",
                NameEn = "Mongolian tögrög",
                Symbol = "₮"
            });

            result.Add(new Currency("Moroccandirham")
            {
                Id = new Guid("D8167344-42FB-4B90-B7CF-2EEAED21AC06"),
                Code = "MAD",
                Name = "درهم مراکش ",
                NameEn = "Moroccan dirham",
                Symbol = "د.م."
            });

            result.Add(new Currency("Mozambicanmetical")
            {
                Id = new Guid("6A32B274-482D-49DE-823C-423757AB21D3"),
                Code = "MZN",
                Name = "متیکال موزامبیک ",
                NameEn = "Mozambican metical",
                Symbol = "MT"
            });

            result.Add(new Currency("Namibiandollar")
            {
                Id = new Guid("3EC7B3CA-BB81-44A8-B4A2-AD694EAC4664"),
                Code = "NAD",
                Name = "دلار نامیبیا ",
                NameEn = "Namibian dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Nepaleserupee")
            {
                Id = new Guid("1F15D127-81EA-43DA-9D31-C288E83501E4"),
                Code = "NPR",
                Name = "روپیه نپال ",
                NameEn = "Nepalese rupee",
                Symbol = "₨"
            });

            result.Add(new Currency("NetherlandsAntilleanguilder")
            {
                Id = new Guid("20FDE013-70A1-483D-9926-3CEAA00D70DD"),
                Code = "ANG",
                Name = "گیلدر هلند آنتیلین",
                NameEn = "Netherlands Antillean guilder",
                Symbol = "ƒ"
            });

            result.Add(new Currency("NewTaiwandollar")
            {
                Id = new Guid("06228386-3C28-4BCB-BCDC-7A917AB2C399"),
                Code = "TWD",
                Name = "دلار جدید تایوان ",
                NameEn = "New Taiwan dollar",
                Symbol = "$"
            });

            result.Add(new Currency("NewZealanddollar")
            {
                Id = new Guid("36AC0FDA-E25B-41E7-AB99-C1E29AC3CD23"),
                Code = "NZD",
                Name = "دلار نیوزیلند ",
                NameEn = "New Zealand dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Nicaraguancórdoba")
            {
                Id = new Guid("692091FE-166E-46D8-8768-4F3E7CB0337F"),
                Code = "NIO",
                Name = "کوردوبا نیکاراگوئه ",
                NameEn = "Nicaraguan córdoba",
                Symbol = "C$"
            });

            result.Add(new Currency("Nigeriannaira")
            {
                Id = new Guid("E4745824-4906-439F-B9C2-E1FC964BAB72"),
                Code = "NGN",
                Name = "ناییرا نیجریه ",
                NameEn = "Nigerian naira",
                Symbol = "₦"
            });

            result.Add(new Currency("NorthKoreanwon")
            {
                Id = new Guid("32539917-730B-48CB-AA3C-9B4AFAF0F688"),
                Code = "KPW",
                Name = "ون کره شمالی ",
                NameEn = "North Korean won",
                Symbol = "₩"
            });

            result.Add(new Currency("Norwegiankrone")
            {
                Id = new Guid("7EAA9A68-1796-409E-9D76-E3854EE3DA0A"),
                Code = "NOK",
                Name = "کرون نروژی ",
                NameEn = "Norwegian krone",
                Symbol = "kr"
            });

            result.Add(new Currency("Omanirial")
            {
                Id = new Guid("9C311D7A-7A4F-4D4F-8E98-0F01FB581B4B"),
                Code = "OMR",
                Name = "ریال عمان ",
                NameEn = "Omani rial",
                Symbol = "ر.ع."
            });

            result.Add(new Currency("Pakistanirupee")
            {
                Id = new Guid("09E3E232-60DA-4149-80CB-FDEB4603FECB"),
                Code = "PKR",
                Name = "روپیه پاکستان ",
                NameEn = "Pakistani rupee",
                Symbol = "₨"
            });

            result.Add(new Currency("Panamanianbalboa")
            {
                Id = new Guid("92AF58B3-F7A6-4728-811B-CA3C702B47DD"),
                Code = "PAB",
                Name = "بالبوا پاناما ",
                NameEn = "Panamanian balboa",
                Symbol = "B/."
            });

            result.Add(new Currency("PapuaNewGuineankina")
            {
                Id = new Guid("A0390FEF-8F7D-4016-8711-7F98A50FE29D"),
                Code = "PGK",
                Name = "کینا پاپوا گینه ",
                NameEn = "Papua New Guinean kina",
                Symbol = "K"
            });

            result.Add(new Currency("Paraguayanguaraní")
            {
                Id = new Guid("65A6A21C-3B30-40FF-AD26-C0E17C7F825A"),
                Code = "PYG",
                Name = "گوارانی پاراگوئه ",
                NameEn = "Paraguayan guaraní",
                Symbol = "₲"
            });

            result.Add(new Currency("Peruviannuevosol")
            {
                Id = new Guid("040AF97A-4FFC-438E-BE7D-A59BF7E82EAA"),
                Code = "PEN",
                Name = "نوئوو سل پرو ",
                NameEn = "Peruvian nuevo sol",
                Symbol = "S/."
            });

            result.Add(new Currency("Philippinepeso")
            {
                Id = new Guid("4A7F4D84-285E-43D4-9AF3-CB56FDFE5DC8"),
                Code = "PHP",
                Name = "پزو فیلیپین ",
                NameEn = "Philippine peso",
                Symbol = "₱"
            });

            result.Add(new Currency("Polishzłoty")
            {
                Id = new Guid("DA6822FE-A46A-4A54-A77A-9C42344FA7E8"),
                Code = "PLN",
                Name = "ین لهستانی ",
                NameEn = "Polish złoty",
                Symbol = "zł"
            });

            result.Add(new Currency("Qataririyal")
            {
                Id = new Guid("C5C40D09-6386-40CE-BD4A-EEE79B67D8D9"),
                Code = "QAR",
                Name = "ریال قطر ",
                NameEn = "Qatari riyal",
                Symbol = "ر.ق"
            });

            result.Add(new Currency("Romanianleu")
            {
                Id = new Guid("78CCDC67-F4D2-467F-8DFA-00EB24B28D4D"),
                Code = "RON",
                Name = "لئو رومانی ",
                NameEn = "Romanian leu",
                Symbol = "lei"
            });

            result.Add(new Currency("Russianruble")
            {
                Id = new Guid("257152C3-B158-4512-8673-30AD4B544000"),
                Code = "RUB",
                Name = "روبل روسیه ",
                NameEn = "Russian ruble",
                Symbol = "р."
            });

            result.Add(new Currency("Rwandanfranc")
            {
                Id = new Guid("CA87382D-48B6-46F0-99A3-28E93AE45DE5"),
                Code = "RWF",
                Name = "فرانک رواندا ",
                NameEn = "Rwandan franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("SaintHelenapound")
            {
                Id = new Guid("B9C639A0-2691-429B-977B-C8F64A4FC978"),
                Code = "SHP",
                Name = "پوند سنت هلن ",
                NameEn = "Saint Helena pound",
                Symbol = "£"
            });

            result.Add(new Currency("Samoantālā")
            {
                Id = new Guid("96FA3F2B-F937-4BB3-B0EC-ECBB3E15735C"),
                Code = "WST",
                Name = "تلا سمون ",
                NameEn = "Samoan tālā",
                Symbol = "T"
            });

            result.Add(new Currency("SãoToméandPríncipedobra")
            {
                Id = new Guid("B91BFC92-8138-459C-942F-66E552CF6C93"),
                Code = "STD",
                Name = "دوبرا سائو تومه و پرینسیپ",
                NameEn = "São Tomé and Príncipe dobra",
                Symbol = "Db"
            });

            result.Add(new Currency("Saudiriyal")
            {
                Id = new Guid("E9FBFF9F-D81A-4963-BE6F-C77FA4D524DB"),
                Code = "SAR",
                Name = "ریال عربستان سعودی ",
                NameEn = "Saudi riyal",
                Symbol = "ر.س"
            });

            result.Add(new Currency("Serbiandinar")
            {
                Id = new Guid("795A62C0-AEE8-4289-ABC4-98684BFF1F37"),
                Code = "RSD",
                Name = "دینار صربستان ",
                NameEn = "Serbian dinar",
                Symbol = "дин. or din."
            });

            result.Add(new Currency("Seychelloisrupee")
            {
                Id = new Guid("EF10B7B0-6CB0-4801-9645-0BC49B354458"),
                Code = "SCR",
                Name = "روپیه سیشل ",
                NameEn = "Seychellois rupee",
                Symbol = "₨"
            });

            result.Add(new Currency("SierraLeoneanleone")
            {
                Id = new Guid("2408FC87-E270-41A7-A956-C249CBAB0BC7"),
                Code = "SLL",
                Name = "لئون سیرالئون",
                NameEn = "Sierra Leonean leone",
                Symbol = "Le"
            });

            result.Add(new Currency("Singaporedollar")
            {
                Id = new Guid("9E1EA0FD-929B-4A60-84AC-365BF67D60FC"),
                Code = "SGD",
                Name = "دلار سنگاپور ",
                NameEn = "Singapore dollar",
                Symbol = "$"
            });

            result.Add(new Currency("SolomonIslandsdollar")
            {
                Id = new Guid("CD84FFB5-42EA-4986-80A7-AC3CA2DC1B51"),
                Code = "SBD",
                Name = "دلار جزایر سلیمان ",
                NameEn = "Solomon Islands dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Somalishilling")
            {
                Id = new Guid("0254CCA4-B24F-4EBD-AF43-13566FC4CECB"),
                Code = "SOS",
                Name = "شیلینگ سومالی ",
                NameEn = "Somali shilling",
                Symbol = "Sh"
            });

            result.Add(new Currency("SouthAfricanrand")
            {
                Id = new Guid("61B62EE7-FB42-45BB-A64B-B82BABB7AD9E"),
                Code = "ZAR",
                Name = "رند آفریقای جنوبی ",
                NameEn = "South African rand",
                Symbol = "R"
            });

            result.Add(new Currency("SouthKoreanwon")
            {
                Id = new Guid("F08B8C50-E9C2-4EBE-B020-DA4893724D9B"),
                Code = "KRW",
                Name = "ون کره جنوبی ",
                NameEn = "South Korean won",
                Symbol = "₩"
            });

            result.Add(new Currency("SouthSudanesepound")
            {
                Id = new Guid("5F46971F-BA75-4E9E-BE6C-7EC615FE5A4F"),
                Code = "SSP",
                Name = "پوند سودان جنوبی ",
                NameEn = "South Sudanese pound",
                Symbol = "£"
            });

            result.Add(new Currency("SriLankanrupee")
            {
                Id = new Guid("3D836326-2C4D-4027-8D84-1F2732D1CE1E"),
                Code = "LKR",
                Name = "روپیه سریلانکا ",
                NameEn = "Sri Lankan rupee",
                Symbol = "Rs or රු"
            });

            result.Add(new Currency("Sudanesepound")
            {
                Id = new Guid("E5676E10-0983-4991-8BB5-25004E93A033"),
                Code = "SDG",
                Name = "پوند سودان ",
                NameEn = "Sudanese pound",
                Symbol = "£"
            });

            result.Add(new Currency("Surinamesedollar")
            {
                Id = new Guid("95CDF71C-EA64-483E-B22F-31B062EB106F"),
                Code = "SRD",
                Name = "دلار سورینام ",
                NameEn = "Surinamese dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Swazililangeni")
            {
                Id = new Guid("591C7184-9D60-4C91-AC55-5DC48CA6A3B1"),
                Code = "SZL",
                Name = "لیلانگنی سوازی ",
                NameEn = "Swazi lilangeni",
                Symbol = "L"
            });

            result.Add(new Currency("Swedishkrona")
            {
                Id = new Guid("8982E450-3034-438E-9B9A-491A8D15A501"),
                Code = "SEK",
                Name = "کرون سوئد ",
                NameEn = "Swedish krona",
                Symbol = "kr"
            });

            result.Add(new Currency("Swissfranc")
            {
                Id = new Guid("2E91C57E-C7A5-4551-A45C-F91C558AF7D9"),
                Code = "CHF",
                Name = "فرانک سوئیس ",
                NameEn = "Swiss franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("Syrianpound")
            {
                Id = new Guid("5A9AB7B9-2118-4459-AB26-53A2D3FD7141"),
                Code = "SYP",
                Name = "پوند سوریه ",
                NameEn = "Syrian pound",
                Symbol = "£ or ل.س"
            });

            result.Add(new Currency("Tajikistanisomoni")
            {
                Id = new Guid("F625F8AB-EF8F-4E78-B192-1131DDCB4D3F"),
                Code = "TJS",
                Name = "سامانی تاجیکستان ",
                NameEn = "Tajikistani somoni",
                Symbol = "ЅМ"
            });

            result.Add(new Currency("Tanzanianshilling")
            {
                Id = new Guid("29A03B04-FB5F-485C-BC69-336640FB0F9C"),
                Code = "TZS",
                Name = "شیلینگ تانزانیا ",
                NameEn = "Tanzanian shilling",
                Symbol = "Sh"
            });

            result.Add(new Currency("Thaibaht")
            {
                Id = new Guid("4B5DE34D-3995-4B90-A463-C9BA6440FF6A"),
                Code = "THB",
                Name = "بات تایلند ",
                NameEn = "Thai baht",
                Symbol = "฿"
            });

            result.Add(new Currency("Tonganpaʻanga")
            {
                Id = new Guid("ED023014-F0AF-4425-AEDF-9727492D387C"),
                Code = "TOP",
                Name = "پانگا تونگیا",
                NameEn = "Tongan paʻanga",
                Symbol = "T$"
            });

            result.Add(new Currency("Transnistrianruble")
            {
                Id = new Guid("2BA27B92-CFB4-4863-9814-03BE9CF4EE93"),
                Code = "PRB[B",
                Name = "روبل ترنسنیسترین",
                NameEn = "Transnistrian ruble",
                Symbol = "р."
            });

            result.Add(new Currency("TrinidadandTobagodollar")
            {
                Id = new Guid("0E42C95D-3C5E-4243-81E6-526FB60F72ED"),
                Code = "TTD",
                Name = "دلار ترینیداد و توباگو",
                NameEn = "Trinidad and Tobago dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Tunisiandinar")
            {
                Id = new Guid("196055F5-238A-4529-B43E-55172805E2FF"),
                Code = "TND",
                Name = "دینار تونس ",
                NameEn = "Tunisian dinar",
                Symbol = "د.ت"
            });

            result.Add(new Currency("Turkishlira")
            {
                Id = new Guid("D96F0168-0C0D-40AF-94C5-ADE3BD2C8BA7"),
                Code = "TRY",
                Name = "لیره ترکیه ",
                NameEn = "Turkish lira",
                Symbol = ""
            });

            result.Add(new Currency("Turkmenistanmanat")
            {
                Id = new Guid("8DCC8B65-B763-498C-B6BC-D8360AF03E12"),
                Code = "TMT",
                Name = "منات ترکمنستان ",
                NameEn = "Turkmenistan manat",
                Symbol = "m"
            });

            result.Add(new Currency("Ugandanshilling")
            {
                Id = new Guid("E71D2F71-E17F-45CA-91AA-CF99C9ADB57A"),
                Code = "UGX",
                Name = "شیلینگ اوگاندا ",
                NameEn = "Ugandan shilling",
                Symbol = "Sh"
            });

            result.Add(new Currency("Ukrainianhryvnia")
            {
                Id = new Guid("3CE59983-AF1A-43D5-BAFB-FE0DA6A15168"),
                Code = "UAH",
                Name = "هریوینیا  اوکراین ",
                NameEn = "Ukrainian hryvnia",
                Symbol = "₴"
            });

            result.Add(new Currency("UnitedArabEmiratesdirham")
            {
                Id = new Guid("B27C5904-00C2-4D64-B341-84876DB06CBF"),
                Code = "AED",
                Name = "درهم امارات متحده عربی ",
                NameEn = "United Arab Emirates dirham",
                Symbol = "د.إ"
            });

            result.Add(new Currency("UnitedStatesdollar")
            {
                Id = new Guid("CF86B590-ECD9-462C-9C0A-FC618DC0EB3C"),
                Code = "USD",
                Name = "دلار ایالات متحده",
                NameEn = "United States dollar",
                Symbol = "$"
            });

            result.Add(new Currency("Uruguayanpeso")
            {
                Id = new Guid("8E76D9D8-17E8-4A0C-9AC0-EDFBE99AC70F"),
                Code = "UYU",
                Name = "پزو اروگوئه ",
                NameEn = "Uruguayan peso",
                Symbol = "$"
            });

            result.Add(new Currency("Uzbekistanisom")
            {
                Id = new Guid("AF216959-9401-49E3-8ECA-5DABD42732D0"),
                Code = "UZS",
                Name = "سام ازبکستان ",
                NameEn = "Uzbekistani som",
                Symbol = "лв"
            });

            result.Add(new Currency("Vanuatuvatu")
            {
                Id = new Guid("088A8269-1E33-489C-B854-2A82867AC972"),
                Code = "VUV",
                Name = "واتو وانواتو ",
                NameEn = "Vanuatu vatu",
                Symbol = "Vt"
            });

            result.Add(new Currency("Venezuelanbolívar")
            {
                Id = new Guid("4D154FB8-9568-44BA-A6FA-72D451C16245"),
                Code = "VEF",
                Name = "بولیوار ونزوئلا ",
                NameEn = "Venezuelan bolívar",
                Symbol = "Bs F"
            });

            result.Add(new Currency("Vietnameseđồng")
            {
                Id = new Guid("DE168728-65F7-4209-AA2C-EF57C14E67D2"),
                Code = "VND",
                Name = "دانگ ویتنامی ",
                NameEn = "Vietnamese đồng",
                Symbol = "₫"
            });

            result.Add(new Currency("WestAfricanCFAfranc")
            {
                Id = new Guid("A3C0F70E-C7D1-4E90-8A3F-BFCFB45182B3"),
                Code = "XOF",
                Name = "فرانک غرب آفریقا CFA",
                NameEn = "West African CFA franc",
                Symbol = "Fr"
            });

            result.Add(new Currency("Yemenirial")
            {
                Id = new Guid("613E85E3-44BE-4748-A584-3173C4C77F53"),
                Code = "YER",
                Name = "ریال یمن ",
                NameEn = "Yemeni rial",
                Symbol = "﷼"
            });

            result.Add(new Currency("Zambiankwacha")
            {
                Id = new Guid("ADC24918-1B98-419E-8990-FBF808B5B8AB"),
                Code = "ZMW",
                Name = "کواچا زامبیا",
                NameEn = "Zambian kwacha",
                Symbol = "ZK"
            });
			

            return result;
        }
    }
}
