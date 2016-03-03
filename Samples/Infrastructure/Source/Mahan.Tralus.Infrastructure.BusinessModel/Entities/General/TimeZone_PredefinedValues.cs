using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    public partial class TimeZone
    {
        public static TimeZone Africa_Abidjan
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Accra
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Cairo
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Djibouti
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Johannesburg
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Khartoum
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Lagos
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Maputo
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Tripoli
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Africa_Windhoek
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Aden
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Almaty
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Amman
        {
            get { return GetFixedEntity(); }
        }

        //public static TimeZone Asia_AnadyrAsia_YekaterinburgAsia_IrkutskEurope_KaliningradAsia_MagadanEurope_MoscowAsia_NovokuznetskAsia_NovosibirskAsia_OmskEurope_SamaraAsia_VladivostokEurope_VolgogradAsia_Yakutsk
        //{
        //    get { return GetFixedEntity(); }
        //}

        public static TimeZone Asia_Ashgabat
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Baghdad
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Bahrain
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Baku
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Bangkok
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Beirut
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Bishkek
        {
            get { return GetFixedEntity(); }
        }

        //public static TimeZone Asia_ChongqingAsia_HarbinAsia_ShanghaiAsia_Urumqi
        //{
        //    get { return GetFixedEntity(); }
        //}

        public static TimeZone Asia_Colombo
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Damascus
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Dubai
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Dushanbe
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Jerusalem
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Kabul
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Karachi
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Kuching
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Kuwait
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Muscat
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Nicosia
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Riyadh
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Seoul
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Shanghai
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Tashkent
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Tbilisi
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Tehran
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Asia_Yerevan
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Athens
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Berlin
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Brussels
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Dublin
        {
            get { return GetFixedEntity(); }
        }

        //public static TimeZone Europe_GuernseyEurope_JerseyEurope_LondonAustralia_Perth
        //{
        //    get { return GetFixedEntity(); }
        //}

        public static TimeZone Europe_Istanbul
        {
            get { return GetFixedEntity(); }
        }

        //public static TimeZone Europe_IstanbulAsia_Yerevan
        //{
        //    get { return GetFixedEntity(); }
        //}

        public static TimeZone Europe_Kiev
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_London
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Minsk
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Moscow
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Rome
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Sofia
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Vienna
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Europe_Volgograd
        {
            get { return GetFixedEntity(); }
        }

        public static TimeZone Indian_Mauritius
        {
            get { return GetFixedEntity(); }
        }

        /*OrderBy Name*/
        public override List<TimeZone> PredefinedValues()
        {
            var result = new List<TimeZone>();

            result.Add(new TimeZone("Africa_Abidjan")
                       {
                           Id = new Guid("C5095179-7847-406C-80EA-019B9D987546"),
                           IanaCode = "Africa/Abidjan",
                           Name = "Africa/Abidjan"
                       });

            result.Add(new TimeZone("Africa_Accra")
                       {
                           Id = new Guid("407324E5-E5CD-4E85-8111-66B023438391"),
                           IanaCode = "Africa/Accra",
                           Name = "Africa/Accra"
                       });

            result.Add(new TimeZone("Africa_Cairo")
                       {
                           Id = new Guid("FE221725-2258-44C2-BAD3-FCCD1DD51A3A"),
                           IanaCode = "Africa/Cairo",
                           Name = "Africa/Cairo"
                       });

            result.Add(new TimeZone("Africa_Djibouti")
                       {
                           Id = new Guid("B12ADC6D-9388-4926-87DC-7939CEFADB66"),
                           IanaCode = "Africa/Djibouti",
                           Name = "Africa/Djibouti"
                       });

            result.Add(new TimeZone("Africa_Johannesburg")
                       {
                           Id = new Guid("9EF4E3FF-D6FC-4E86-A3B8-20017A719A5F"),
                           IanaCode = "Africa/Johannesburg",
                           Name = "Africa/Johannesburg"
                       });

            result.Add(new TimeZone("Africa_Khartoum")
                       {
                           Id = new Guid("064B0F2A-586F-4C30-A2FE-6A4FD2869A62"),
                           IanaCode = "Africa/Khartoum",
                           Name = "Africa/Khartoum"
                       });

            result.Add(new TimeZone("Africa_Lagos")
                       {
                           Id = new Guid("BD0910DF-9D30-42C9-869C-8DA97E689D45"),
                           IanaCode = "Africa/Lagos",
                           Name = "Africa/Lagos"
                       });

            result.Add(new TimeZone("Africa_Maputo")
                       {
                           Id = new Guid("C0376F02-85B7-4C4A-9331-FECE2329E473"),
                           IanaCode = "Africa/Maputo",
                           Name = "Africa/Maputo"
                       });

            result.Add(new TimeZone("Africa_Tripoli")
                       {
                           Id = new Guid("0E708DF2-BDDE-49ED-A04E-568512BBC338"),
                           IanaCode = "Africa/Tripoli",
                           Name = "Africa/Tripoli"
                       });

            result.Add(new TimeZone("Africa_Windhoek")
                       {
                           Id = new Guid("3EF9A024-6E84-4635-A1CF-828ECBE48248"),
                           IanaCode = "Africa/Windhoek",
                           Name = "Africa/Windhoek"
                       });

            result.Add(new TimeZone("Asia_Aden")
                       {
                           Id = new Guid("775E2884-9165-4687-A7D6-8AE172298CA2"),
                           IanaCode = "Asia/Aden",
                           Name = "Asia/Aden"
                       });

            result.Add(new TimeZone("Asia_Almaty")
                       {
                           Id = new Guid("E1C714D9-7374-4EA3-8E0C-215338C3610B"),
                           IanaCode = "Asia/Almaty",
                           Name = "Asia/Almaty"
                       });

            result.Add(new TimeZone("Asia_Amman")
                       {
                           Id = new Guid("3F397903-0083-43E7-946E-4FC41D7DCD69"),
                           IanaCode = "Asia/Amman",
                           Name = "Asia/Amman"
                       });

            //result.Add(new TimeZone("Asia_AnadyrAsia_YekaterinburgAsia_IrkutskEurope_KaliningradAsia_MagadanEurope_MoscowAsia_NovokuznetskAsia_NovosibirskAsia_OmskEurope_SamaraAsia_VladivostokEurope_VolgogradAsia_Yakutsk")
            //           {
            //               Id = new Guid("412252B4-26C4-4FF0-9E7B-6B555E3D42CE"),
            //               IanaCode = "Asia/AnadyrAsia/YekaterinburgAsia/IrkutskEurope/KaliningradAsia/MagadanEurope/MoscowAsia/NovokuznetskAsia/NovosibirskAsia/OmskEurope/SamaraAsia/VladivostokEurope/VolgogradAsia/Yakutsk",
            //               Name = "Asia/AnadyrAsia/YekaterinburgAsia/IrkutskEurope/KaliningradAsia/MagadanEurope/MoscowAsia/NovokuznetskAsia/NovosibirskAsia/OmskEurope/SamaraAsia/VladivostokEurope/VolgogradAsia/Yakutsk"
            //           });

            result.Add(new TimeZone("Asia_Ashgabat")
                       {
                           Id = new Guid("4B54CD4C-A3F3-4541-A5FD-CB0FADCDDED3"),
                           IanaCode = "Asia/Ashgabat",
                           Name = "Asia/Ashgabat"
                       });

            result.Add(new TimeZone("Asia_Baghdad")
                       {
                           Id = new Guid("B1829E20-FB3A-4260-9D1E-547FB27BA017"),
                           IanaCode = "Asia/Baghdad",
                           Name = "Asia/Baghdad"
                       });

            result.Add(new TimeZone("Asia_Bahrain")
                       {
                           Id = new Guid("EE6F0EEE-CC98-4FEF-91D2-4D9DFFFDC922"),
                           IanaCode = "Asia/Bahrain",
                           Name = "Asia/Bahrain"
                       });

            result.Add(new TimeZone("Asia_Baku")
                       {
                           Id = new Guid("948C95D3-E60C-48DF-B715-9D58B0B96834"),
                           IanaCode = "Asia/Baku",
                           Name = "Asia/Baku"
                       });

            result.Add(new TimeZone("Asia_Bangkok")
                       {
                           Id = new Guid("158B339F-DABA-4AE8-B1CD-3DC38FFDBA51"),
                           IanaCode = "Asia/Bangkok",
                           Name = "Asia/Bangkok"
                       });

            result.Add(new TimeZone("Asia_Beirut")
                       {
                           Id = new Guid("BD1EFBE5-4F8B-4777-8DE3-3E3D64D648A0"),
                           IanaCode = "Asia/Beirut",
                           Name = "Asia/Beirut"
                       });

            result.Add(new TimeZone("Asia_Bishkek")
                       {
                           Id = new Guid("DA38202C-9FBC-4BC8-8157-1C889EA490E0"),
                           IanaCode = "Asia/Bishkek",
                           Name = "Asia/Bishkek"
                       });

            //result.Add(new TimeZone("Asia_ChongqingAsia_HarbinAsia_ShanghaiAsia_Urumqi")
            //           {
            //               Id = new Guid("F4A5C9B9-4D88-4405-A31D-71B8F61DCA12"),
            //               IanaCode = "Asia/ChongqingAsia/HarbinAsia/ShanghaiAsia/Urumqi",
            //               Name = "Asia/ChongqingAsia/HarbinAsia/ShanghaiAsia/Urumqi"
            //           });

            result.Add(new TimeZone("Asia_Colombo")
                       {
                           Id = new Guid("915331BF-94F4-4F36-B58E-F3579E7E7160"),
                           IanaCode = "Asia/Colombo",
                           Name = "Asia/Colombo"
                       });

            result.Add(new TimeZone("Asia_Damascus")
                       {
                           Id = new Guid("8EA5ECE4-48F5-4F0C-AA5C-2C2454D02F34"),
                           IanaCode = "Asia/Damascus",
                           Name = "Asia/Damascus"
                       });

            result.Add(new TimeZone("Asia_Dubai")
                       {
                           Id = new Guid("F2B84549-92E2-4795-9D7D-227B2E02CDDA"),
                           IanaCode = "Asia/Dubai",
                           Name = "Asia/Dubai"
                       });

            result.Add(new TimeZone("Asia_Dushanbe")
                       {
                           Id = new Guid("FCE088AA-1517-4A19-AF0B-89C319BECA08"),
                           IanaCode = "Asia/Dushanbe",
                           Name = "Asia/Dushanbe"
                       });

            result.Add(new TimeZone("Asia_Jerusalem")
                       {
                           Id = new Guid("AB3E3837-F57F-4BB4-A75C-E432749F333A"),
                           IanaCode = "Asia/Jerusalem",
                           Name = "Asia/Jerusalem"
                       });

            result.Add(new TimeZone("Asia_Kabul")
                       {
                           Id = new Guid("B8D1E408-5192-4D34-85F1-FED70264D973"),
                           IanaCode = "Asia/Kabul",
                           Name = "Asia/Kabul"
                       });

            result.Add(new TimeZone("Asia_Karachi")
                       {
                           Id = new Guid("5640E8B0-D1EC-4F00-B32D-6158C9E8573F"),
                           IanaCode = "Asia/Karachi",
                           Name = "Asia/Karachi"
                       });

            result.Add(new TimeZone("Asia_Kuching")
                       {
                           Id = new Guid("5687AE2D-2F00-42E4-B1A3-BEB4A60C9707"),
                           IanaCode = "Asia/Kuching",
                           Name = "Asia/Kuching"
                       });

            result.Add(new TimeZone("Asia_Kuwait")
                       {
                           Id = new Guid("6F29F6C3-3A90-4280-9EE5-64ACB72FE9C5"),
                           IanaCode = "Asia/Kuwait",
                           Name = "Asia/Kuwait"
                       });

            result.Add(new TimeZone("Asia_Muscat")
                       {
                           Id = new Guid("9624013C-3BEA-400D-A41F-23D5E01D5ED7"),
                           IanaCode = "Asia/Muscat",
                           Name = "Asia/Muscat"
                       });

            result.Add(new TimeZone("Asia_Nicosia")
                       {
                           Id = new Guid("850CD769-9B84-40EC-838D-712DACD84353"),
                           IanaCode = "Asia/Nicosia",
                           Name = "Asia/Nicosia"
                       });

            result.Add(new TimeZone("Asia_Riyadh")
                       {
                           Id = new Guid("8F1736BD-7BC3-43AD-B40A-57B3BB552DE4"),
                           IanaCode = "Asia/Riyadh",
                           Name = "Asia/Riyadh"
                       });

            result.Add(new TimeZone("Asia_Seoul")
                       {
                           Id = new Guid("686F3633-79E3-49F5-B817-1702C7869C39"),
                           IanaCode = "Asia/Seoul",
                           Name = "Asia/Seoul"
                       });

            result.Add(new TimeZone("Asia_Shanghai")
                       {
                           Id = new Guid("5A177D35-AAAE-4ED1-97D6-33B3AC33573A"),
                           IanaCode = "Asia/Shanghai",
                           Name = "Asia/Shanghai"
                       });

            result.Add(new TimeZone("Asia_Tashkent")
                       {
                           Id = new Guid("2933184B-271B-4532-9F7C-CEC480F9B09B"),
                           IanaCode = "Asia/Tashkent",
                           Name = "Asia/Tashkent"
                       });

            result.Add(new TimeZone("Asia_Tbilisi")
                       {
                           Id = new Guid("58F4C6C3-87CC-457A-80A8-0FCBBED31D44"),
                           IanaCode = "Asia/Tbilisi",
                           Name = "Asia/Tbilisi"
                       });

            result.Add(new TimeZone("Asia_Tehran")
                       {
                           Id = new Guid("5637D0F1-D651-4D03-8BE2-0D501D886FCC"),
                           IanaCode = "Asia/Tehran",
                           Name = "Asia/Tehran"
                       });

            result.Add(new TimeZone("Asia_Yerevan")
                       {
                           Id = new Guid("B0119564-0205-4F4D-916C-8721A9AB18FA"),
                           IanaCode = "Asia/Yerevan",
                           Name = "Asia/Yerevan"
                       });

            result.Add(new TimeZone("Europe_Athens")
                       {
                           Id = new Guid("F278F515-F044-47A2-B5BD-21F2E509CEE0"),
                           IanaCode = "Europe/Athens",
                           Name = "Europe/Athens"
                       });

            result.Add(new TimeZone("Europe_Berlin")
                       {
                           Id = new Guid("4EC87207-492E-41E5-A2DE-9CBDB53F006B"),
                           IanaCode = "Europe/Berlin",
                           Name = "Europe/Berlin"
                       });

            result.Add(new TimeZone("Europe_Brussels")
                       {
                           Id = new Guid("B32FFDE4-4FB2-40EC-8E1F-E36758D82312"),
                           IanaCode = "Europe/Brussels",
                           Name = "Europe/Brussels"
                       });

            result.Add(new TimeZone("Europe_Dublin")
                       {
                           Id = new Guid("5C23F48D-83F7-4B95-8104-886AAB232D9F"),
                           IanaCode = "Europe/Dublin",
                           Name = "Europe/Dublin"
                       });

            //result.Add(new TimeZone("Europe_GuernseyEurope_JerseyEurope_LondonAustralia_Perth")
            //           {
            //               Id = new Guid("D1A1564E-0CF5-480C-8361-ED79E4CC2E5B"),
            //               IanaCode = "Europe/GuernseyEurope/JerseyEurope/LondonAustralia/Perth",
            //               Name = "Europe/GuernseyEurope/JerseyEurope/LondonAustralia/Perth"
            //           });

            result.Add(new TimeZone("Europe_Istanbul")
                       {
                           Id = new Guid("64A76C5D-D60B-4786-B24A-2AA5F3238A25"),
                           IanaCode = "Europe/Istanbul",
                           Name = "Europe/Istanbul"
                       });

            //result.Add(new TimeZone("Europe_IstanbulAsia_Yerevan")
            //           {
            //               Id = new Guid("ED0457CC-5FA5-4783-B7F4-26556FE5499A"),
            //               IanaCode = "Europe/IstanbulAsia/Yerevan",
            //               Name = "Europe/IstanbulAsia/Yerevan"
            //           });

            result.Add(new TimeZone("Europe_Kiev")
                       {
                           Id = new Guid("B77A9F32-4C16-4AC4-9460-84B9FE1F2D36"),
                           IanaCode = "Europe/Kiev",
                           Name = "Europe/Kiev"
                       });

            result.Add(new TimeZone("Europe_London")
                       {
                           Id = new Guid("5CC32BE6-1CBB-4EE0-9CED-005A4FD0F302"),
                           IanaCode = "Europe/London",
                           Name = "Europe/London"
                       });

            result.Add(new TimeZone("Europe_Minsk")
                       {
                           Id = new Guid("FF1E2C12-264C-409E-98CF-9E676CB83FA0"),
                           IanaCode = "Europe/Minsk",
                           Name = "Europe/Minsk"
                       });

            result.Add(new TimeZone("Europe_Moscow")
                       {
                           Id = new Guid("FEF2C309-F3D0-41EF-B586-CD9C6AB2F909"),
                           IanaCode = "Europe/Moscow",
                           Name = "Europe/Moscow"
                       });

            result.Add(new TimeZone("Europe_Rome")
                       {
                           Id = new Guid("3AA73E83-C8BB-4A0B-BBEF-180EF971F4D1"),
                           IanaCode = "Europe/Rome",
                           Name = "Europe/Rome"
                       });

            result.Add(new TimeZone("Europe_Sofia")
                       {
                           Id = new Guid("B49B158E-1EC9-4041-947F-39C5DAAFE88A"),
                           IanaCode = "Europe/Sofia",
                           Name = "Europe/Sofia"
                       });

            result.Add(new TimeZone("Europe_Vienna")
                       {
                           Id = new Guid("101D40E7-6AE4-4DF0-B8D8-024951BB5236"),
                           IanaCode = "Europe/Vienna",
                           Name = "Europe/Vienna"
                       });

            result.Add(new TimeZone("Europe_Volgograd")
                        {
                            Id = new Guid("0575C980-47D8-49F5-BEC2-FEDB5C80D71D"),
                            IanaCode = "Europe/Volgograd",
                            Name = "Europe/Volgograd"
                        });

            result.Add(new TimeZone("Indian_Mauritius")
                       {
                           Id = new Guid("F502134C-F671-427E-AE19-96DE81442BF2"),
                           IanaCode = "Indian/Mauritius",
                           Name = "Indian/Mauritius"
                       });


            return result;
        }
    }
}
