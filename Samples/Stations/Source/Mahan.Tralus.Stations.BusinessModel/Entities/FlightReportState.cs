using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using Tralus.Framework.BusinessModel.Entities;

namespace Mahan.Stations.BusinessModel
{
    [Table("FlightReportState", Schema = "Stations")]
    [DefaultProperty("Name")]
    public class FlightReportState : FixedEntityBase<FlightReportState>
    {
        public FlightReportState()
            : this("ForDbMigration")
        {

        }

        public FlightReportState(string fixedName)
            : base(fixedName)
        {
        }

        public string Name { get; set; }

        public string Code { get; set; }
        
        #region Static Members

        public static FlightReportState Unknown
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState Blank
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState ReadyForDepStaManagerInput
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState ModifiedByDepStaManager
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState AwaitingDepStaInput
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState UnderEditByDepSta
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState AwaitingOccApproval
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState RejectedByOcc
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState RetractedByDepStaStaff
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState RetractedByDepStaManager
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState ApprovedByOcc
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState ReceivedByArrSta
        {
            get { return GetFixedEntity(); }
        }

        public static FlightReportState Done
        {
            get { return GetFixedEntity(); }
        }

        #endregion

        public override List<FlightReportState> PredefinedValues()
        {
            var result = new List<FlightReportState>();
            var programmingKey = "";

            programmingKey = "Unknown";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("7100C918-B16F-4362-9A73-2A683906E07C"),
                    Name = "** UNKNOWN **",
                    Code = "0"
                }
                );


            programmingKey = "Blank";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("B49F2FEA-7FE1-48DC-B902-FF95C03536AE"),
                    Name = "Blank",
                    Code = "1"
                }
                );

            programmingKey = "ReadyForDepStaManagerInput";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("CE83B6D1-DC80-4D6D-BB04-A653F4CF47EB"),
                    Name = "Ready for DEP STA Manager Input",
                    Code = "2"
                }
                );

            programmingKey = "ModifiedByDepStaManager";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("A821F3F5-DD59-472B-B214-61C27E5B465A"),
                    Name = "Modified by DEP STA Manager",
                    Code = "3"
                }
                );

            programmingKey = "AwaitingDepStaInput";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("AD5A5B6E-3D8E-4501-8079-3D819A029663"),
                    Name = "Awaiting DEP STA Input",
                    Code = "4"
                }
                );

            programmingKey = "UnderEditByDepSta";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("7C0AA0AD-EE6D-4A5E-97C7-82067B52CF60"),
                    Name = "Under Edit by DEP STA",
                    Code = "5"
                }
                );

            programmingKey = "AwaitingOccApproval";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("9573E377-21C8-4228-90E5-8FF5F6F8EE0E"),
                    Name = "Awaiting OCC Approval",
                    Code = "6"
                }
                );

            programmingKey = "RejectedByOcc";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("2A54F779-26D4-4354-83EC-332666E55386"),
                    Name = "Rejected by OCC",
                    Code = "7"
                }
                );

            programmingKey = "RetractedByDepStaStaff";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("FC8A334E-24A6-463C-80DD-D9BCFC178930"),
                    Name = "Retracted by DEP STA Staff",
                    Code = "8"
                }
                );

            programmingKey = "RetractedByDepStaManager";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("B1183995-4089-4284-B903-5849259A1DFF"),
                    Name = "Retracted by DEP STA Manager",
                    Code = "9"
                }
                );

            programmingKey = "ApprovedByOcc";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("4D91FBFC-D7D4-4A0C-8955-AFABD4E78833"),
                    Name = "Approved by OCC",
                    Code = "10"
                }
                );



            programmingKey = "ReceivedByArrSta";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("525FEF7F-F848-46A6-8001-CAF4F5AD82BB"),
                    Name = "Received by ARR STA",
                    Code = "11"
                }
                );

            programmingKey = "Done";
            result.Add(
                new FlightReportState(programmingKey)
                {
                    Id = new Guid("D3B1B998-FBAA-4D1F-B86A-7F13E08A20F9"),
                    Name = "Done",
                    Code = "12"
                }
                );

            return result;
        }

        public bool IsOwnedBySystem
        {
            get
            {
                return
                    this == Blank ||
                    this == Unknown ||
                    this == Done;
            }
        }

        public bool IsOwnedByDepartureStationManager
        {
            get
            {
                return
                    this == ReadyForDepStaManagerInput ||
                    this == ModifiedByDepStaManager;
            }
        }

        public bool IsOwnedByDepartureStationStaff
        {
            get
            {
                return
                    this == AwaitingDepStaInput ||
                    this == UnderEditByDepSta ||
                    this == RetractedByDepStaStaff ||
                    this == RetractedByDepStaManager ||
                    this == ReceivedByArrSta;
            }
        }

        public bool IsOwnedByArrivalStation
        {
            get
            {
                return
                    this == ApprovedByOcc;
            }
        }

        public bool IsOwnedByOcc
        {
            get
            {
                return
                    this == AwaitingOccApproval;
            }
        }
        
    }


}




