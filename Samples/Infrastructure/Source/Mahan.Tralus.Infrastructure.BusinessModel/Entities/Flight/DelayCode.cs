using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mahan.Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Tralus.Infrastructure.BusinessModel
{
    [Table("DelayCode", Schema = "Infrastructure")]
    [DefaultProperty("Code")]
    public class DelayCode : FixedEntityBase<DelayCode>
    {
        public DelayCode(string fixedName)
            : base(fixedName)
        {
        }

        public DelayCode()
            : base("")
        {

        }

        public virtual DelayType DelayType { get; set; }
        public Guid? DelayTypeId { get; set; }

        public string Description { get; set; }

        public string DescriptionEn { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public bool? IsEnabled { get; set; }

        public static DelayCode DelayCode_00
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_01
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_02_Charterer
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_03_Givenwronginfotothepilot
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_04_ProblemforGDorcrewlist
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_05_Transitpax
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_06
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_07
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_08_Passengerbus
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_09_Minimumgroundtime
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_10_Latecounterstart
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_11_LateCheck_in_acceptanceafterdeadline
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_12_LateCheck_in_congestionincheck_inarea
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_13_Check_inerror_PassengerandBaggage
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_14_Oversales_bookingerrors
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_15_Boarding_discrepanciesandpaging_missedchecked_inpassenger
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_16_Commercial_Publicity_PassengerConvenience_VIP_Press_Groundmealsandmissingpersonalitems
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_17_Cateringorder_lateorincorrectordergiventosupplier
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_18_Baggageprocessing_sorting_etc_
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_19_ACchngduetocomercial
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_20_Specialpassenger_VIP_CIP_WCHR_STRTCHR_
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_21_Documentation_errors_etc_
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_22_Latepositioning
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_23_Lateacceptance
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_24_Inadequatepacking
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_25_Oversales_bookingerrors
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_26_Latepreparationinwarehouse
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_27_Documentation_Packingetc
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_28_Latepositioning
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_29_Lateacceptance
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_30_Transitpax
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_31_Aircraftdocumentationlate_inaccurate_weightandbalance_generaldeclaration_passengermanifest_etc_
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_32_Loading_Unloading_bulky_specialload_cabinload_lackofloadingstaff
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_33_LoadingEquipment_lackoforbreakdown_e_g_containerpalletloader_lackofstaff
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_34_ServicingEquipment_lackoforbreakdown_lackofstaff_e_g_steps
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_35_AircraftCleaning
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_36_Fuelling_Defuelling_fuelsupplier
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_37_Catering_latedeliveryorloading
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_38_ULD_lackoforserviceability
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_39_Technicalequipment_lackoforbreakdown_lackofstaff_e_g_pushback
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_40_LackofMCstaffforfuelordefuel
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_41_Aircraftdefects
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_42_Scheduledmaintenance_laterelease
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_43_Non_scheduledmaintenance_specialchecksand_oradditionalworksbeyondnormalmaintenance
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_44_Sparesandmaintenanceequipment_lackoforbreakdown
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_45_AOGSpares_tobecarriedtoanotherstation
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_46_Aircraftchangefortechnicalreasons
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_47_Standbyaircraft_lackofplannedstandbyaircraftfortechnicalreasons
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_48_Scheduledcabinconfiguration_versionadjustments
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_49_Crewcardelaysinramp
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_50_Aircondition
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_51_Damageduringflightoperations_birdorlightningstrike_turbulence_heavyoroverweightlanding
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_52_Damageduringgroundoperations_collisions_otherthanduringtaxiing__loading_offloadingdamage_contamination_towing_extremeweatherconditions
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_53_Overweightforovertemp
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_54_Latepositioningofcordinatoratcrewcheckingate
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_55_Automatedequipmentfailure_departurecontrol
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_56_Automatedequipmentfailure_cargopreparation_documentation
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_57_Automatedequipmentfailure_flightplans
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_58_Ramphandling
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_59_LateofgroundengineirorGDchange
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_60_Transportdelaysforcabincockpit
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_61_Flightplan_latecompletionorchangeofflightdocumentation
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_62_Operationalrequirements_fuel_loadalteration
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_63_Latecrewboardingordepartureprocedures_otherthanconnectionorstandby_flightdeckor
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_64_Flightdeckcrewshortage_sickness_awaitingstandby_flighttimelimitation_crewmeals_
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_65_Flightdeckcrewspecialrequest_notwithinoperationalrequirements
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_66_Latecabincrewboardingordepartureproceduresotherthanconnectionorstandby
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_67_Cabincrewshortage_sickness_awaitingstandby_flighttimelimitations_crewmeals_valid
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_68_Cabincrewerrororspecialrequest_notwithinoperationalrequirements
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_69_Captainrequestforsecuritycheck_extraordinary
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_70_Groundequipment
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_71_Departurestation
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_72_Destinationstation
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_73_En_routeorAlternate
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_74
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_75_De_Icingofaircraft_removalofice_orsnow_frostprevention_otherthanuns
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_76_Removalofsnow_ice_waterandsandfromairport
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_77_Groundhandlingimpairedbyadverseweatherconditions
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_78
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_79_Permissionofflight_ARR_DEP_ENROUT_
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_80
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_81_Airtrafficservices_flowrestrictions_slots_industrialaction
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_82_Mandatorysecurity
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_83_Immigration_customs_health
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_84_Airportfacilities_parkingstands_rampcongestion_lighting_buildings_gatelimitations
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_85_Restrictionsatdepartureairport_airportand_orrunwayclosedduetoobstruction_industr
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_86_Immigration_Customs_Health
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_87_Nogate_standavailableduetoownairlineactivity
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_88_Restrictionsatdestinationairport_airportand_orrunwayclosedduetoobstruction_indu
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_89_ATC_Groundmomentcontrol_includingstart_upanfpush_uppush_back_industrialaction
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_90_ACM_LateorGDCHNG
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_91_Loadconnection_awaitingaloadfromanotherflight
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_92_ThroughCheck_inerror_passengerandbagage
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_93_Aircraftrotation_latearrivalofaircraftfromanotherflightorprevioussector
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_94_Cabincrewrotation_awaitingcabincrewfromanotherflight
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_95_Crewrotation_awaitingcrewfromanotherflight_flightdeckorentirecrew_
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_96_Operationscontrol_rerouting_diversion_consolidation_aircraftchangeforreasonsotherthantechnical
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_97_Industrialactionwithownairline
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_98_Industrialactionoutsideownairline_excludingA_T_S
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_99_Undifined_useSI
        {
            get { return GetFixedEntity(); }
        }

        public static DelayCode DelayCode_Unknown
        {
            get { return GetFixedEntity(); }
        }


        public override List<DelayCode> PredefinedValues()
        {
            var result = new List<DelayCode>();
            var name = "";
            name = "";
            result.Add(new DelayCode("DelayCode_00")
                        {
                            Id = new Guid("7926E2D4-798D-40ED-BD87-5BA042D8F195"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "",
                            Code = "00",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = false
                        });

            name = "";
            result.Add(new DelayCode("DelayCode_01")
                        {
                            Id = new Guid("9FE6A229-D6F8-4DC1-AB23-0553FE4144DE"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "هل دادن به عقب",
                            Code = "01",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = false
                        });

            name = "Charterer";
            result.Add(new DelayCode("DelayCode_02_Charterer")
                        {
                            Id = new Guid("313DF7F5-EE99-42CC-A370-6781C4F9EA86"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "چارتر كننده",
                            Code = "02",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = true
                        });

            name = "Given wrong info to the pilot";
            result.Add(new DelayCode("DelayCode_03_Givenwronginfotothepilot")
                        {
                            Id = new Guid("5450985A-F5B4-466D-B0C9-969059491DD6"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "دادن اطلاعات ناقص به خلبان",
                            Code = "03",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = true
                        });

            name = "Problem for GD or crew list";
            result.Add(new DelayCode("DelayCode_04_ProblemforGDorcrewlist")
                        {
                            Id = new Guid("5146B42F-F2E8-4CB6-A773-DF558619B015"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشكل GD يا كرو ليست",
                            Code = "04",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = true
                        });

            name = "Transit pax";
            result.Add(new DelayCode("DelayCode_05_Transitpax")
                        {
                            Id = new Guid("A36FF851-B117-4B8B-BA00-6B8912967DB9"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشكل تعمير و نگهداري سيستمهاي رايانه ديسپچ",
                            Code = "05",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = true
                        });

            name = "";
            result.Add(new DelayCode("DelayCode_06")
                        {
                            Id = new Guid("8EC5D753-A83D-4F5D-9D57-B526380DA2D4"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "",
                            Code = "06",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = false
                        });

            name = "";
            result.Add(new DelayCode("DelayCode_07")
                        {
                            Id = new Guid("BFD6487A-DA62-4D27-96D7-4411AB9A0522"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "",
                            Code = "07",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = false
                        });

            name = "Passenger bus";
            result.Add(new DelayCode("DelayCode_08_Passengerbus")
                        {
                            Id = new Guid("96917C08-3816-4248-9041-2154B0A7A340"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "اتوبوس مسافرين",
                            Code = "08",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = true
                        });

            name = "Minimum ground time ";
            result.Add(new DelayCode("DelayCode_09_Minimumgroundtime")
                        {
                            Id = new Guid("03D82775-1378-4C4F-9B41-603495AAC2F5"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "كمبود Ground Time",
                            Code = "09",
                            DelayTypeId = DelayType.Uncategorized.Id,
                            IsEnabled = true
                        });

            name = "Late counter start";
            result.Add(new DelayCode("DelayCode_10_Latecounterstart")
                        {
                            Id = new Guid("0098FC7C-E5BF-4641-AB9A-A983D7EF645C"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "دير باز شدن كانتر مسافر",
                            Code = "10",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Late Check-in, acceptance after deadline ";
            result.Add(new DelayCode("DelayCode_11_LateCheck_in_acceptanceafterdeadline")
                        {
                            Id = new Guid("C0523F89-BAF8-4B6E-AF71-18A85262E6D0"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "دير بسته شدن كانتر مسافر",
                            Code = "11",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Late Check-in, congestion in check-in area ";
            result.Add(new DelayCode("DelayCode_12_LateCheck_in_congestionincheck_inarea")
                        {
                            Id = new Guid("BA08D05B-0D75-4F2B-874F-848C9F227600"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "ازدحام مسافر در جلوی کانتر",
                            Code = "12",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Check-in error, Passenger and Baggage";
            result.Add(new DelayCode("DelayCode_13_Check_inerror_PassengerandBaggage")
                        {
                            Id = new Guid("A9CCECCE-ECC7-4327-B7C1-322C861F9CAD"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشكل چك مسافر",
                            Code = "13",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Oversales, booking errors ";
            result.Add(new DelayCode("DelayCode_14_Oversales_bookingerrors")
                        {
                            Id = new Guid("73380A55-B676-4A27-9896-7C78DFBF80E6"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "فروش بالای ظرفیت",
                            Code = "14",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Boarding, discrepancies and paging, missed checked-in passenger  ";
            result.Add(new DelayCode("DelayCode_15_Boarding_discrepanciesandpaging_missedchecked_inpassenger")
                        {
                            Id = new Guid("0F2CB453-AFE8-4BD0-8CB4-68FABA69D4EF"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مسافر NO SHOW",
                            Code = "15",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Commercial/Publicity, Passenger Convenience, VIP, Press, Ground meals and missing personal items ";
            result.Add(new DelayCode("DelayCode_16_Commercial_Publicity_PassengerConvenience_VIP_Press_Groundmealsandmissingpersonalitems")
                        {
                            Id = new Guid("D9CBEFDA-EBB4-4CCD-8ABF-BAAF79493112"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشكل تجاري - بازرگاني - VIP",
                            Code = "16",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Catering order, late or incorrect order given to supplier ";
            result.Add(new DelayCode("DelayCode_17_Cateringorder_lateorincorrectordergiventosupplier")
                        {
                            Id = new Guid("FCA2BAA5-DB3E-4D1D-8376-912D1B9AB02C"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم دادن اطلاعات کافی به کترینگ",
                            Code = "17",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Baggage processing, sorting, etc. ";
            result.Add(new DelayCode("DelayCode_18_Baggageprocessing_sorting_etc_")
                        {
                            Id = new Guid("A4084562-F527-44A2-8E2F-78F433F6B9B3"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشكل جابجايي و دسته بندي بار مسافر",
                            Code = "18",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "AC chng dueto comercial";
            result.Add(new DelayCode("DelayCode_19_ACchngduetocomercial")
                        {
                            Id = new Guid("2A03C220-F189-4B72-826C-C01FB9514D04"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تعويض هواپيما به دليل بازرگاني",
                            Code = "19",
                            DelayTypeId = DelayType.PassengerandBaggageHandling.Id,
                            IsEnabled = true
                        });

            name = "Special passenger (VIP. CIP. WCHR.STRTCHR)";
            result.Add(new DelayCode("DelayCode_20_Specialpassenger_VIP_CIP_WCHR_STRTCHR_")
                        {
                            Id = new Guid("FC5D4D0C-22AF-4466-A5A7-0A5B54609E7B"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مسافر مخصوص (CIP - VIP - ويلچير - برانكارد) ",
                            Code = "20",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Documentation, errors, etc. ";
            result.Add(new DelayCode("DelayCode_21_Documentation_errors_etc_")
                        {
                            Id = new Guid("8A8B3566-9DF6-4148-937A-FFDD8C181F28"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بار / مدارک ناقص",
                            Code = "21",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Late positioning ";
            result.Add(new DelayCode("DelayCode_22_Latepositioning")
                        {
                            Id = new Guid("5DF63473-652B-4B78-9D9B-29B7FAB457F7"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بار / عدم جابجایی به موقع",
                            Code = "22",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Late acceptance ";
            result.Add(new DelayCode("DelayCode_23_Lateacceptance")
                        {
                            Id = new Guid("71B930A5-BFC3-4E35-B727-3512185DA6E4"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بار / عدم پذیرش به موقع",
                            Code = "23",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Inadequate packing ";
            result.Add(new DelayCode("DelayCode_24_Inadequatepacking")
                        {
                            Id = new Guid("6E910E77-8C3F-4740-9208-1D51840765D6"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بار/ عدم بسته بندي استاندارد",
                            Code = "24",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Oversales, booking errors ";
            result.Add(new DelayCode("DelayCode_25_Oversales_bookingerrors")
                        {
                            Id = new Guid("7E72AAFB-19CE-44ED-860B-C2322D17AE9F"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بار / فروش بالای ظرفیت",
                            Code = "25",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Late preparation in warehouse ";
            result.Add(new DelayCode("DelayCode_26_Latepreparationinwarehouse")
                        {
                            Id = new Guid("C446B7FA-69AD-453E-8A2E-A068B56C2D90"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بار / عدم آمادگي جهت بارگيري",
                            Code = "26",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Documentation, Packing etc";
            result.Add(new DelayCode("DelayCode_27_Documentation_Packingetc")
                        {
                            Id = new Guid("714C3D19-8E04-4BD9-8DCA-58A87EC1EC75"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بسته هاي پستي / مدارك ناقص",
                            Code = "27",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Late positioning ";
            result.Add(new DelayCode("DelayCode_28_Latepositioning")
                        {
                            Id = new Guid("584904D0-BB11-4776-9EBE-B76006603787"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بسته هاي پستي / تاخير در جابجايي",
                            Code = "28",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Late acceptance ";
            result.Add(new DelayCode("DelayCode_29_Lateacceptance")
                        {
                            Id = new Guid("228CE560-3F8D-4344-ACFB-D52C528D4706"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "بسته هاي پستي / تاخير در پذيرش",
                            Code = "29",
                            DelayTypeId = DelayType.CargoandMailHandling.Id,
                            IsEnabled = true
                        });

            name = "Transit pax";
            result.Add(new DelayCode("DelayCode_30_Transitpax")
                        {
                            Id = new Guid("6511419C-1810-4565-AB76-BE9E23FFBC6D"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مسافر ترانزيت",
                            Code = "30",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Aircraft documentation late/ inaccurate,weight and balance, general declaration, passenger manifest, etc. ";
            result.Add(new DelayCode("DelayCode_31_Aircraftdocumentationlate_inaccurate_weightandbalance_generaldeclaration_passengermanifest_etc_")
                        {
                            Id = new Guid("31AB9BEA-C792-4D07-A8E6-5E2696BF74B2"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مدارك ناقص هواپيما (وزن - تعداد - بار و مسافر - PAX MANIFEST - G.D(",
                            Code = "31",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Loading/ Unloading, bulky,special load, cabin load, lack of loading staff ";
            result.Add(new DelayCode("DelayCode_32_Loading_Unloading_bulky_specialload_cabinload_lackofloadingstaff")
                        {
                            Id = new Guid("346C1895-7518-4C74-8A9F-25CA9D694CDC"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشكل بارگيري / نبود كارگر كافي - وجود بارهاي خاص",
                            Code = "32",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Loading Equipment, lack of or breakdown, e.g. container pallet loader, lack of staff ";
            result.Add(new DelayCode("DelayCode_33_LoadingEquipment_lackoforbreakdown_e_g_containerpalletloader_lackofstaff")
                        {
                            Id = new Guid("50270393-B245-4960-B2E6-D72944F5EBF3"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشکل بارگیری / نبود یا کمبود تجهیزات کافی",
                            Code = "33",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Servicing Equipment, lack of or breakdown, lack of staff, e.g. steps ";
            result.Add(new DelayCode("DelayCode_34_ServicingEquipment_lackoforbreakdown_lackofstaff_e_g_steps")
                        {
                            Id = new Guid("F73A4DC1-EEE2-46A3-B4AC-3AE8FC677661"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم وجود تجهیزات کافی پله / نفرات",
                            Code = "34",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Aircraft Cleaning ";
            result.Add(new DelayCode("DelayCode_35_AircraftCleaning")
                        {
                            Id = new Guid("F5A0E30E-EA27-4AC5-A947-A939F4C65149"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تاخیر در تمیز کردن هواپیما",
                            Code = "35",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Fuelling, Defuelling, fuel supplier ";
            result.Add(new DelayCode("DelayCode_36_Fuelling_Defuelling_fuelsupplier")
                        {
                            Id = new Guid("D0E13E78-48D7-4617-801A-600F223EFEFD"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم حضور به موقع ماشین سوخت گیری یا تخلیه بنزین",
                            Code = "36",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Catering, late delivery or loading ";
            result.Add(new DelayCode("DelayCode_37_Catering_latedeliveryorloading")
                        {
                            Id = new Guid("4B3E967D-E3FC-4A9D-BAEE-609A1E890217"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "کترینگ (تحویل - بارگیری - حمل و نقل)",
                            Code = "37",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "ULD,  lack of or serviceability";
            result.Add(new DelayCode("DelayCode_38_ULD_lackoforserviceability")
                        {
                            Id = new Guid("0AAD626B-3308-411B-955C-96E499EBEC7B"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "ULD (قابل سرويس نبودن - تاخير در حضور به موقع)",
                            Code = "38",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Technical equipment, lack of or breakdown, lack of staff, e.g. pushback";
            result.Add(new DelayCode("DelayCode_39_Technicalequipment_lackoforbreakdown_lackofstaff_e_g_pushback")
                        {
                            Id = new Guid("966E7D5F-6896-4562-AEEF-D01B32FC7ADA"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "PUSHBACK (کمبود متخصص / خرابی دستگاه)",
                            Code = "39",
                            DelayTypeId = DelayType.Ramp.Id,
                            IsEnabled = true
                        });

            name = "Lack of MC staff for fuel or defuel";
            result.Add(new DelayCode("DelayCode_40_LackofMCstaffforfuelordefuel")
                        {
                            Id = new Guid("D112DE53-8ACC-40C7-9BC6-C558A7D3A5CC"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم حضور نفر فني جهت سوخت گيري يا تخليه بنزين",
                            Code = "40",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Aircraft defects ";
            result.Add(new DelayCode("DelayCode_41_Aircraftdefects")
                        {
                            Id = new Guid("343FC647-3FA5-49E9-8455-840A4C42FEB5"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "آماده نبودن هواپیما از نظر فنی",
                            Code = "41",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Scheduled maintenance, late release ";
            result.Add(new DelayCode("DelayCode_42_Scheduledmaintenance_laterelease")
                        {
                            Id = new Guid("928C2BAF-F329-4983-AD3A-4C82CC81D43C"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم آمادگی هواپیما بدلیل تمام نشدن چک فنی",
                            Code = "42",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Non-scheduled maintenance, special checks and /or additional works beyond normal maintenance ";
            result.Add(new DelayCode("DelayCode_43_Non_scheduledmaintenance_specialchecksand_oradditionalworksbeyondnormalmaintenance")
                        {
                            Id = new Guid("A8BC28B3-7EA1-404A-8787-7CC45DEC0A72"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "چك خارج از نوبت و بدون برنامه ريزي هواپيما",
                            Code = "43",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Spares and maintenance equipment, lack of or breakdown ";
            result.Add(new DelayCode("DelayCode_44_Sparesandmaintenanceequipment_lackoforbreakdown")
                        {
                            Id = new Guid("B9B4926E-9ACD-484F-A73C-55E1DEC6407F"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مشکل قطعه هواپیما",
                            Code = "44",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "AOG Spares, to be carried to another station ";
            result.Add(new DelayCode("DelayCode_45_AOGSpares_tobecarriedtoanotherstation")
                        {
                            Id = new Guid("48BBCC79-D9B2-4A12-BFBE-905552958A67"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "نياز بردن قطعه AOG به ايستگاه ديگر توسط هواپيما",
                            Code = "45",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Aircraft change for technical reasons ";
            result.Add(new DelayCode("DelayCode_46_Aircraftchangefortechnicalreasons")
                        {
                            Id = new Guid("51AA9694-11DE-4B27-9203-97F8EEDC3BD4"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تعویض هواپیما به دلیل فنی",
                            Code = "46",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Standby aircraft, lack of planned standby aircraft for technical reasons ";
            result.Add(new DelayCode("DelayCode_47_Standbyaircraft_lackofplannedstandbyaircraftfortechnicalreasons")
                        {
                            Id = new Guid("BBC5BC7B-AFBC-41A9-993F-C4816760ECE6"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "گراند شدن هواپیمای رزرو",
                            Code = "47",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Scheduled cabin configuration/version adjustments ";
            result.Add(new DelayCode("DelayCode_48_Scheduledcabinconfiguration_versionadjustments")
                        {
                            Id = new Guid("ABD6B590-5C60-46EB-832B-56376155DFEF"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تغيير ظرفيت كابين (تبديل ظرفيت هواپيما)",
                            Code = "48",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Crew car delays in ramp";
            result.Add(new DelayCode("DelayCode_49_Crewcardelaysinramp")
                        {
                            Id = new Guid("E1107097-78C7-4632-AABF-545225E3A1D7"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تاخير اتومبيلCREW در رساندن كرو زير پرواز",
                            Code = "49",
                            DelayTypeId = DelayType.Technical.Id,
                            IsEnabled = true
                        });

            name = "Aircondition";
            result.Add(new DelayCode("DelayCode_50_Aircondition")
                        {
                            Id = new Guid("44FFC3A2-AA0D-4AAA-ABF5-EEEDF4F831AE"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "اير كانديشن",
                            Code = "50",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Damage during flight operations, bird or lightning strike, turbulence, heavy or overweight landing ";
            result.Add(new DelayCode("DelayCode_51_Damageduringflightoperations_birdorlightningstrike_turbulence_heavyoroverweightlanding")
                        {
                            Id = new Guid("5BBC4D13-0196-4CC1-9E73-BDF9E192C831"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "صدمه دیدن هواپیما در پرواز (برخورد پرنده - رعد و برق و ..)",
                            Code = "51",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Damage during ground operations, collisions (other than during taxiing),loading/offloading damage, contamination, towing, extreme weather conditions ";
            result.Add(new DelayCode("DelayCode_52_Damageduringgroundoperations_collisions_otherthanduringtaxiing__loading_offloadingdamage_contamination_towing_extremeweatherconditions")
                        {
                            Id = new Guid("34C08E00-E773-420B-A21A-00867B021957"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "صدمه ديدن هواپيماي پارك شده ( تخليه و بارگيري - تصادف و...)",
                            Code = "52",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Over weight for over temp";
            result.Add(new DelayCode("DelayCode_53_Overweightforovertemp")
                        {
                            Id = new Guid("B42C7F69-2D4F-4CC6-A6C9-4EBAA353808E"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم پذيرش  به موقع بار و مسافر بهعلت درجه حرارت زياد",
                            Code = "53",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Late positioning of cordinator at crew check in gate";
            result.Add(new DelayCode("DelayCode_54_Latepositioningofcordinatoratcrewcheckingate")
                        {
                            Id = new Guid("A2889140-5DC3-403C-9F3B-EA447953231D"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تاخير حضور كورديناتور ايستگاه براي عبور كرو از گيت ها",
                            Code = "54",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Automated equipment failure - departure control";
            result.Add(new DelayCode("DelayCode_55_Automatedequipmentfailure_departurecontrol")
                        {
                            Id = new Guid("A250468C-285D-4BA3-B3FD-7333E79F807F"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "خراب شدن دستگاههاي اتوماتيك برج مراقبت",
                            Code = "55",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Automated equipment failure - cargo preparation/documentation";
            result.Add(new DelayCode("DelayCode_56_Automatedequipmentfailure_cargopreparation_documentation")
                        {
                            Id = new Guid("16FC8BEC-0469-466E-A3A8-8A4BCE05B298"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "خراب شدن دستگاههاي اتوماتيك بارگير / مدارك",
                            Code = "56",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Automated equipment failure - flight plans";
            result.Add(new DelayCode("DelayCode_57_Automatedequipmentfailure_flightplans")
                        {
                            Id = new Guid("104F504D-A032-4C18-9F3E-5921E61A531B"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "خراب شدن دستگاههاي اتوماتيك ACT FLT PLAN",
                            Code = "57",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Ramp handling";
            result.Add(new DelayCode("DelayCode_58_Ramphandling")
                        {
                            Id = new Guid("BE30AF46-FBA3-49A2-ABB5-A1F5812FE3D2"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "رمپ هندلينگ",
                            Code = "58",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Late of ground engineir or GD change";
            result.Add(new DelayCode("DelayCode_59_LateofgroundengineirorGDchange")
                        {
                            Id = new Guid("B183F8A8-A62E-4E86-983C-F9D97AC05F5C"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم حضور به موقع مهندس زميني جهت پرواز يا تغيير در G.D",
                            Code = "59",
                            DelayTypeId = DelayType.DamagetoAircraft.Id,
                            IsEnabled = true
                        });

            name = "Transport delays for cabin & cockpit";
            result.Add(new DelayCode("DelayCode_60_Transportdelaysforcabincockpit")
                        {
                            Id = new Guid("6D1BA1A8-359A-4415-B917-727480E1D7DE"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تاخير ترانسپورت در رساندن كروي پروازي",
                            Code = "60",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Flight plan, late completion or change of flight documentation ";
            result.Add(new DelayCode("DelayCode_61_Flightplan_latecompletionorchangeofflightdocumentation")
                        {
                            Id = new Guid("B2F1DDE6-2E12-402C-B867-FCE6658B748C"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تغییر یا تاخیر در ارسال فلایت پلن (دیسپچ)",
                            Code = "61",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Operational requirements, fuel, load alteration ";
            result.Add(new DelayCode("DelayCode_62_Operationalrequirements_fuel_loadalteration")
                        {
                            Id = new Guid("20967663-DA5A-4A5B-B06F-0E25DB27A459"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "ناهماهنگی در اعلام مقدار بنزین و تبدیل بار",
                            Code = "62",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Late crew boarding or departure procedures, other than connection or standby (flightdeck or ";
            result.Add(new DelayCode("DelayCode_63_Latecrewboardingordepartureprocedures_otherthanconnectionorstandby_flightdeckor")
                        {
                            Id = new Guid("9B56A5A5-953B-4AC4-99CF-E4353EDB3D39"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تاخير ورود كاكپيت كروي برنامه شده به هواپيما",
                            Code = "63",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Flight deck crew shortage, sickness, awaiting standby, flight time limitation, crew meals, ";
            result.Add(new DelayCode("DelayCode_64_Flightdeckcrewshortage_sickness_awaitingstandby_flighttimelimitation_crewmeals_")
                        {
                            Id = new Guid("97CC0522-F478-4BE6-BADB-EA204CB6E472"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "كمبود كاكپيت كرو (مريضي - استفاده از آماده - محدوديت پرواز)",
                            Code = "64",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Flight deck crew special request, not within operational requirements";
            result.Add(new DelayCode("DelayCode_65_Flightdeckcrewspecialrequest_notwithinoperationalrequirements")
                        {
                            Id = new Guid("8AB18BB5-0BCE-434D-8BE7-743D28FE7051"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "درخواست كاكپيت كرو برخلاف OPR MANUAL",
                            Code = "65",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Late cabin crew boarding or departure procedures other than connection or standby";
            result.Add(new DelayCode("DelayCode_66_Latecabincrewboardingordepartureproceduresotherthanconnectionorstandby")
                        {
                            Id = new Guid("0FE60118-66B1-4322-BC4B-30E8429938AA"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تاخير ورود كابين كروي برنامه شده به هواپيما",
                            Code = "66",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Cabin crew shortage, sickness, awaiting standby, flight time limitations, crew meals, valid";
            result.Add(new DelayCode("DelayCode_67_Cabincrewshortage_sickness_awaitingstandby_flighttimelimitations_crewmeals_valid")
                        {
                            Id = new Guid("4BDA75AF-650E-4BE4-9FB8-1C9F6B60190D"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "كمبود كابين كرو (مريضي - استفاده از اماده - محدوديت پرواز)",
                            Code = "67",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Cabin crew error or special request, not within operational requirements";
            result.Add(new DelayCode("DelayCode_68_Cabincrewerrororspecialrequest_notwithinoperationalrequirements")
                        {
                            Id = new Guid("371DE4CB-9F4C-4F57-BB9A-29F86DD0C544"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "درخواست كابين كرو برخلاف OPR MANUAL",
                            Code = "68",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Captain request for security check, extraordinary ";
            result.Add(new DelayCode("DelayCode_69_Captainrequestforsecuritycheck_extraordinary")
                        {
                            Id = new Guid("7A59FE34-A61D-4F47-A4B4-378194DF721B"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "درخواست کاپیتان پرواز برای چک SECURITY هواپیما",
                            Code = "69",
                            DelayTypeId = DelayType.OperationandCrew.Id,
                            IsEnabled = true
                        });

            name = "Ground equipment";
            result.Add(new DelayCode("DelayCode_70_Groundequipment")
                        {
                            Id = new Guid("2192C38D-29A7-4A35-BF88-2BF184723232"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "وسايل زميني زير پرواز ",
                            Code = "70",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "Departure station ";
            result.Add(new DelayCode("DelayCode_71_Departurestation")
                        {
                            Id = new Guid("D010A7A5-17A8-43F7-B03C-FA5D89A44D91"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "خرابي هواي مبداء",
                            Code = "71",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "Destination station ";
            result.Add(new DelayCode("DelayCode_72_Destinationstation")
                        {
                            Id = new Guid("985BBDDE-BA02-499E-8978-0A23799EA49D"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "خرابي هواي مقصد",
                            Code = "72",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "En-route or Alternate ";
            result.Add(new DelayCode("DelayCode_73_En_routeorAlternate")
                        {
                            Id = new Guid("6B1DAE57-C886-4A49-87F6-CB9B7A44E3AF"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "خرابي هواي EN-Route و يا فرودگاه كمكي",
                            Code = "73",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "";
            result.Add(new DelayCode("DelayCode_74")
                        {
                            Id = new Guid("BE5B83BE-752A-4F64-919E-C6ACFEB8CE8F"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "",
                            Code = "74",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = false
                        });

            name = "De-Icing of aircraft, removal of ice/or snow, frost prevention, other than uns ";
            result.Add(new DelayCode("DelayCode_75_De_Icingofaircraft_removalofice_orsnow_frostprevention_otherthanuns")
                        {
                            Id = new Guid("B81BA158-55DA-4206-A3C6-35ADC8F8A6C9"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "DE-ICING هواپيما / برف روبي / يخ زدگي",
                            Code = "75",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "Removal of snow/ice/water and sand from airport";
            result.Add(new DelayCode("DelayCode_76_Removalofsnow_ice_waterandsandfromairport")
                        {
                            Id = new Guid("E6CA60CB-4B2B-4B65-9E96-1FA4BDCAFD94"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "برف روبي / يخ زدگي / آب روي باند",
                            Code = "76",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "Ground handling impaired by adverse weather conditions ";
            result.Add(new DelayCode("DelayCode_77_Groundhandlingimpairedbyadverseweatherconditions")
                        {
                            Id = new Guid("33A1B81D-1AC3-40A4-AEFF-DAA6D973DEBF"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "كار نكردن وسايل گراند هندلينگ در اثر يخ زدگي",
                            Code = "77",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "";
            result.Add(new DelayCode("DelayCode_78")
                        {
                            Id = new Guid("1E7F4B55-D0BC-48C3-8185-B503FC824C5B"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "",
                            Code = "78",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = false
                        });

            name = "Permission of flight (ARR, DEP, ENROUT)";
            result.Add(new DelayCode("DelayCode_79_Permissionofflight_ARR_DEP_ENROUT_")
                        {
                            Id = new Guid("EB0CB52E-D800-4836-8604-E828AEA0F8A5"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "مجوز پرواز ( مبداء - مقصد - مسير )",
                            Code = "79",
                            DelayTypeId = DelayType.Weather.Id,
                            IsEnabled = true
                        });

            name = "";
            result.Add(new DelayCode("DelayCode_80")
                        {
                            Id = new Guid("E0412320-C41B-448D-B07D-A201262271DE"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "",
                            Code = "80",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = false
                        });

            name = "Air traffic services, flow restrictions, slots, industrial action";
            result.Add(new DelayCode("DelayCode_81_Airtrafficservices_flowrestrictions_slots_industrialaction")
                        {
                            Id = new Guid("03FB5A32-677B-4DC9-BAB6-E08F0549018F"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم سرويس دهي فرودگاه بعلت شلوغي ترافيك / پاركينگ ATC",
                            Code = "81",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "Mandatory security";
            result.Add(new DelayCode("DelayCode_82_Mandatorysecurity")
                        {
                            Id = new Guid("D0D880AB-8E31-4675-9E2C-4410B6B23820"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "چك الزامي Security",
                            Code = "82",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "Immigration, customs, health";
            result.Add(new DelayCode("DelayCode_83_Immigration_customs_health")
                        {
                            Id = new Guid("AAD1A0B0-F0CC-4275-905E-744BE36E431D"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "گذرنامه - گمرك - بهداشت",
                            Code = "83",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "Airport facilities, parking stands, ramp congestion, lighting, buildings, gatelimitations";
            result.Add(new DelayCode("DelayCode_84_Airportfacilities_parkingstands_rampcongestion_lighting_buildings_gatelimitations")
                        {
                            Id = new Guid("D7BEC802-D0E4-4E4A-A018-51DB04B8A767"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "عدم امكانات فرودگاهي (STAND شلوغي رمپ GATE چراغ)",
                            Code = "84",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "Restrictions at departure airport, airport and/or runway closed due to obstruction, industr";
            result.Add(new DelayCode("DelayCode_85_Restrictionsatdepartureairport_airportand_orrunwayclosedduetoobstruction_industr")
                        {
                            Id = new Guid("63157196-1561-479E-83CE-C37095FF02BF"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "محدود يا بسته بودن باند در خروج بعلت OBSTRUCTIONS",
                            Code = "85",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "Immigration, Customs, Health ";
            result.Add(new DelayCode("DelayCode_86_Immigration_Customs_Health")
                        {
                            Id = new Guid("ECBCF1C2-7DE2-46B1-90DF-01121D264917"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "گذر نامه - گمرک - بهداشت",
                            Code = "86",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = false
                        });

            name = "No gate/stand available due to own airline activity";
            result.Add(new DelayCode("DelayCode_87_Nogate_standavailableduetoownairlineactivity")
                        {
                            Id = new Guid("584B2359-434C-4D3E-AB04-F8EC8670DFF9"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "نداشتن GATE و STAD به علت عمليات زياد شركت ماهان",
                            Code = "87",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "Restrictions at destination airport, airport and/or runway closed due to obstruction, indu";
            result.Add(new DelayCode("DelayCode_88_Restrictionsatdestinationairport_airportand_orrunwayclosedduetoobstruction_indu")
                        {
                            Id = new Guid("75BA453F-3ACF-41DA-BC04-325DE8BB667C"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "محدوديت پذيرش يا بسته بودن فرودگاه مقصد",
                            Code = "88",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "ATC/Ground moment control, including start-up anf push-up push-back, industrial action";
            result.Add(new DelayCode("DelayCode_89_ATC_Groundmomentcontrol_includingstart_upanfpush_uppush_back_industrialaction")
                        {
                            Id = new Guid("EC8D3562-B725-43B6-944D-CAEE43D4239A"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "برج مراقبت (واحد كنترل زميني يا مارشالر)",
                            Code = "89",
                            DelayTypeId = DelayType.AirTrafficControl.Id,
                            IsEnabled = true
                        });

            name = "ACM. Late or GD CHNG";
            result.Add(new DelayCode("DelayCode_90_ACM_LateorGDCHNG")
                        {
                            Id = new Guid("4E765442-81D0-48F0-AE78-B374150DF763"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "گارد امنيت - تاخير در حضور و پذيرش - تغيير GD",
                            Code = "90",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Load connection, awaiting a load from another flight";
            result.Add(new DelayCode("DelayCode_91_Loadconnection_awaitingaloadfromanotherflight")
                        {
                            Id = new Guid("37D90DD6-AD8F-429B-B789-43FEF043B911"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "منتظر بار ترانزيت ماندن ",
                            Code = "91",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Through Check-in error, passenger and bagage";
            result.Add(new DelayCode("DelayCode_92_ThroughCheck_inerror_passengerandbagage")
                        {
                            Id = new Guid("B6278A74-EB1C-4703-B211-571DA3820A02"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "چک اشتباهی مسافر / بار همراه",
                            Code = "92",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Aircraft rotation, late arrival of aircraft from another flight or previous sector";
            result.Add(new DelayCode("DelayCode_93_Aircraftrotation_latearrivalofaircraftfromanotherflightorprevioussector")
                        {
                            Id = new Guid("C43B70CF-D613-46A1-AE9F-84F344370A27"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تاخیر ورود هواپیما از پرواز قبلی",
                            Code = "93",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Cabin crew rotation, awaiting cabin crew from another flight";
            result.Add(new DelayCode("DelayCode_94_Cabincrewrotation_awaitingcabincrewfromanotherflight")
                        {
                            Id = new Guid("2DB09DCC-4E1F-4F90-B2B5-D285D0B0C52B"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "انتظار كابين كرو به دليل تاخير ورود هواپيماي ديگر",
                            Code = "94",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Crew rotation, awaiting crew from another flight (flight deck or entire crew)";
            result.Add(new DelayCode("DelayCode_95_Crewrotation_awaitingcrewfromanotherflight_flightdeckorentirecrew_")
                        {
                            Id = new Guid("B649F53C-A2A5-4415-8BD6-4C1135ABEC3F"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "انتظار كاكپيت كرو به دليل تاخير ورود هواپيماي ديگر",
                            Code = "95",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Operations control, rerouting, diversion, consolidation, aircraft change for reasons other than technical ";
            result.Add(new DelayCode("DelayCode_96_Operationscontrol_rerouting_diversion_consolidation_aircraftchangeforreasonsotherthantechnical")
                        {
                            Id = new Guid("F8E10D70-0BC4-46FC-A2B7-809AAA0E7CB9"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "كنترلهاي عملياتي (تغيير مسير - تغيير Reg و Diversion)",
                            Code = "96",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Industrial action with own airline ";
            result.Add(new DelayCode("DelayCode_97_Industrialactionwithownairline")
                        {
                            Id = new Guid("C49F2695-4E2A-4276-B756-3980B03E38A2"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "محدوديت هاي اعمال شده به وسيله اير لاين",
                            Code = "97",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Industrial action outside own airline, excluding A.T.S";
            result.Add(new DelayCode("DelayCode_98_Industrialactionoutsideownairline_excludingA_T_S")
                        {
                            Id = new Guid("91A62B84-A51B-445B-9F1B-D3BCF22CC489"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "محدوديت هاي اعمال شده خارج از اير لاين",
                            Code = "98",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });

            name = "Undifined-use SI";
            result.Add(new DelayCode("DelayCode_99_Undifined_useSI")
                        {
                            Id = new Guid("E0585E8C-1566-405C-A3CD-D7536E25D7D0"),
                            Name = name,
                            DescriptionEn = name,
                            Description = "تعريف نشده",
                            Code = "99",
                            DelayTypeId = DelayType.ReactionaryReasonsorMiscellaneous.Id,
                            IsEnabled = true
                        });


            return result;
        }
    }
}
