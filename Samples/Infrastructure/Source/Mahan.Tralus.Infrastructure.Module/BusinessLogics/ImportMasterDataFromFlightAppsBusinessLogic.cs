using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;
using DevExpress.XtraPrinting.Native;
using Tralus.Framework.BusinessModel.Entities;
using Tralus.Framework.BusinessModel.Utility;
using Tralus.Framework.Module;
using Mahan.Infrastructure.BusinessModel;
using Mahan.Infrastructure.Data;
using Mahan.Infrastructure.Data.ExternalMasterData.FlightApps;

namespace Mahan.Infrastructure.Module.BusinessLogics
{
    public class ImportMasterDataFromFlightAppsBusinessLogic : TralusEntityBusinessLogic<ImportMasterDataLog>
    {
        Dictionary<string, AircraftType> aircraftTypes = new Dictionary<string, AircraftType>();
        Dictionary<string, Aircraft> aircrafts = new Dictionary<string, Aircraft>();
        Dictionary<string, Airline> airlines = new Dictionary<string, Airline>();
        Dictionary<string, Airport> airports = new Dictionary<string, Airport>();
        Dictionary<string, AircraftRegister> aircraftRegisters = new Dictionary<string, AircraftRegister>();
        Dictionary<string, FlightNumber> flightNumbers = new Dictionary<string, FlightNumber>();
        Dictionary<string, Leg> legs = new Dictionary<string, Leg>();
        Dictionary<string, City> cities = new Dictionary<string, City>();
        Dictionary<long, LocalityType> localityTypes = new Dictionary<long, LocalityType>();

        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }

        public ImportMasterDataFromFlightAppsBusinessLogic()
        {
            var now = DateTime.UtcNow;
            StartDate = now.AddDays(-1);
            EndDate = now.AddDays(2);
        }

        /// <summary>
        /// Specifies the required boundries for upserting flight legs based on <param name="startDate"></param> and <param name="endDate"></param> considering no time.
        /// </summary>
        /// <param name="startDate">The time part is ignored.</param>
        /// <param name="endDate">The time part is ignored.</param>
        public ImportMasterDataFromFlightAppsBusinessLogic(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        protected override void ExecuteImpl()
        {
            base.ExecuteImpl();

            aircraftTypes = new Dictionary<string, AircraftType>();
            aircrafts = new Dictionary<string, Aircraft>();
            airlines = new Dictionary<string, Airline>();
            airports = new Dictionary<string, Airport>();
            aircraftRegisters = new Dictionary<string, AircraftRegister>();
            flightNumbers = new Dictionary<string, FlightNumber>();
            legs = new Dictionary<string, Leg>();
            cities = new Dictionary<string, City>();
            localityTypes = new Dictionary<long, LocalityType>();

            Stopwatch sw = Stopwatch.StartNew();

            try
            {
                cities = City.All.ToDictionary(c => c.NameEn);
                localityTypes = LocalityType.All.ToDictionary(l => l.Code ?? -1);

                sw.Restart();

                Log("Import AircraftTypes");
                ImportAircraftTypes();

                Log("Import Aircrafts");
                ImportAircrafts();

                Log("Import Airlines");
                ImportAirlines();

                Log("Import Airports");
                ImportAirports();

                Log("Import AircraftRegisters");
                ImportAircraftRegisters();

                Log("Import FlightNumbers");
                ImportFlightNumbers();

                Log("Import Legs");
                ImportLegs();

                Log("Import FlightLegs");
                ImportFlightLegs();

                SelectedObject.IsFailed = false;
            }
            catch (Exception)
            {
                SelectedObject.IsFailed = true;
                throw;
            }
            finally
            {
                SelectedObject.Duration = sw.Elapsed;
            }
        }

        private void ImportAircraftTypes()
        {
            ImportEntities<GI_AircraftType, AircraftType>(
                getListFromSource:
                    db =>
                    {
                        var query =
                            from item in db.Set<GI_AircraftType>()
                            select item;

                        var list = query.ToList();
                        return list;
                    },
                fillTargetWithSource:
                    (sourceEntity, targetEntity) =>
                    {
                        targetEntity.FullTypeName = sourceEntity.FullTypeName;
                        targetEntity.FwName = sourceEntity.FW_Name;
                        targetEntity.IataCode = sourceEntity.IATACode;
                        targetEntity.IcaoCode = sourceEntity.ICAOCode;
                        targetEntity.Manufacturer = sourceEntity.Manufacturer;
                        targetEntity.Name = sourceEntity.Name;
                        targetEntity.Status = sourceEntity.Status;
                        targetEntity.TypeVariation = sourceEntity.TypeVariation;

                        aircraftTypes.Add(targetEntity.IataCode, targetEntity);
                    },
                getTargetKey: t => t.IataCode,
                getSourceKey: s => s.IATACode
                );
        }
        
        private void ImportAircrafts()
        {
            ImportEntities<GI_Aircraft, Aircraft>(
                getListFromSource:
                    db =>
                    {
                        var query =
                            from item in db.Set<GI_Aircraft>()
                            select item;

                        var list =
                            query
                                .Include(item => item.AircraftType)
                                .ToList();
                        return list;
                    },
                fillTargetWithSource:
                    (sourceEntity, targetEntity) =>
                    {
                        targetEntity.SerialNo = sourceEntity.SerialNo;
                        targetEntity.Register = sourceEntity.Register;
                        targetEntity.AircraftTypeId = aircraftTypes[sourceEntity.AircraftType.IATACode].Id;

                        aircrafts.Add(targetEntity.Register, targetEntity);
                    },
                getTargetKey: t => t.Register,
                getSourceKey: s => s.Register
                );
        }

        private void ImportAirlines()
        {
            ImportEntities<GI_Airline, Airline>(
                getListFromSource:
                    db =>
                    {
                        var query =
                            from item in db.Set<GI_Airline>()
                            select item;

                        var list =
                            query
                                .Include(item => item.Country)
                                .ToList();
                        return list;
                    },
                fillTargetWithSource:
                    (sourceEntity, targetEntity) =>
                    {
                        targetEntity.Name = sourceEntity.Name;

                        if (sourceEntity.Country != null)
                        {
                            var country = Country.All.FirstOrDefault(c => c.IsoAlpha3 == sourceEntity.Country.ISOAlpha3);
                            targetEntity.CountryId = country != null ? (Guid?) country.Id : null;
                        }

                        targetEntity.IataCode = sourceEntity.IATACode;
                        targetEntity.IcaoCode = sourceEntity.ICAOCode;
                        targetEntity.Abv = sourceEntity.Abv;
                        targetEntity.FullName = sourceEntity.Name_Full;
                        targetEntity.ShortName = sourceEntity.Name_Short;
                        targetEntity.Status = sourceEntity.Status;

                        airlines.Add(targetEntity.IcaoCode, targetEntity);
                    },
                getTargetKey: t => t.IcaoCode,
                getSourceKey: s => s.ICAOCode
                );
        }

        private void ImportAirports()
        {
            ImportEntities<GI_Airport, Airport>(
                getListFromSource:
                    db =>
                    {
                        var query =
                            from item in db.Set<GI_Airport>()
                            select item;

                        var list =
                            query
                                .Include(item => item.LocalityType)
                                .Include(item => item.City)
                                .ToList();
                        return list;
                    },
                fillTargetWithSource:
                    (sourceEntity, targetEntity) =>
                    {
                        targetEntity.Name = sourceEntity.Name;
                        targetEntity.NameEn = sourceEntity.Name_EN;
                        targetEntity.IataAirportCode = sourceEntity.IATA_AirportCode;
                        targetEntity.Status = sourceEntity.Status;
                        targetEntity.NickName = sourceEntity.NickName;

                        var city = cities.GetValueOrDefault(sourceEntity.Name_EN, null);
                        targetEntity.CityId = city != null ? (Guid?) city.Id : null;

                        var localityType = localityTypes[sourceEntity.LocalityType.Code ?? -1];
                        targetEntity.LocalityTypeId = localityType != null ? (Guid?) localityType.Id : null;

                        airports.Add(targetEntity.IataAirportCode, targetEntity);
                    },
                getTargetKey: t => t.IataAirportCode,
                getSourceKey: s => s.IATA_AirportCode
                );
        }

        private void ImportAircraftRegisters()
        {
            ImportEntities<GI_AircraftRegister, AircraftRegister>(
                getListFromSource:
                    db =>
                    {
                        var query =
                            from item in db.Set<GI_AircraftRegister>()
                            where item.ID_GI_Aircraft != null
                            select item;

                        var list =
                            query
                                .Include(item => item.Aircraft)
                                .ToList();
                        return list;
                    },
                fillTargetWithSource:
                    (sourceEntity, targetEntity) =>
                    {
                        targetEntity.Code = sourceEntity.Code;
                        targetEntity.ShortRegisterCode = sourceEntity.Short_Register_Code;
                        targetEntity.HasFirstClassSeat = sourceEntity.HasFirstClassSeat;
                        targetEntity.Status = sourceEntity.Status;
                        targetEntity.IsActive = sourceEntity.IsActive ?? false;
                        targetEntity.AircraftId = aircrafts[sourceEntity.Aircraft.Register].Id;

                        aircraftRegisters.Add(targetEntity.Code, targetEntity);
                    },
                getTargetKey: t => t.Code,
                getSourceKey: s => s.Code
                );
        }

        private void ImportFlightNumbers()
        {
            ImportEntities<FLT_FlightNumber, FlightNumber>(
                getListFromSource:
                    db =>
                    {
                        var query =
                            from item in db.Set<FLT_FlightNumber>()
                            select item;

                        var list =
                            query
                                .Include(item => item.Airline)
                                .ToList();
                        return list;
                    },
                fillTargetWithSource:
                    (sourceEntity, targetEntity) =>
                    {
                        targetEntity.FullFlightNumber = sourceEntity.FlightNumber_AbvNumber;
                        targetEntity.ShortFlightNumber = sourceEntity.FlightNumber_Number;
                        targetEntity.AirlineId = airlines[sourceEntity.Airline.ICAOCode].Id;

                        flightNumbers.Add(targetEntity.FullFlightNumber, targetEntity);
                    },
                getTargetKey: t => t.FullFlightNumber,
                getSourceKey: s => s.FlightNumber_AbvNumber
                );
        }

        private void ImportLegs()
        {
            ImportEntities<GI_Route_Leg_Airports, Leg>(
                getListFromSource:
                    db =>
                    {
                        var query =
                            from item in db.Set<GI_Route_Leg_Airports>()
                            select item;

                        var list =
                            query
                                .Include(item=>item.ArrivalAirport)
                                .Include(item=>item.DepartureAirport.LocalityType)
                                .ToList();
                        var cleanList =
                            from item in list
                            where item.ArrivalAirport != null && item.DepartureAirport != null
                            select item;

                        return cleanList.ToList();
                    },
                fillTargetWithSource:
                    (sourceEntity, targetEntity) =>
                    {
                        targetEntity.Name = sourceEntity.Name;
                        targetEntity.Status = sourceEntity.Status;
                        targetEntity.ArrivalAirportId = airports[sourceEntity.ArrivalAirport.IATA_AirportCode].Id;
                        targetEntity.DepartureAirportId = airports[sourceEntity.DepartureAirport.IATA_AirportCode].Id;

                        var localityType =
                            localityTypes.GetValueOrDefault(sourceEntity.DepartureAirport.LocalityType.Code??-1, null);

                        targetEntity.LocalityTypeId = localityType != null ? (Guid?) localityType.Id : null;

                        legs.Add(targetEntity.Name, targetEntity);
                    },
                getTargetKey: t => t.Name,
                getSourceKey: s => s.Name
                );
        }

        private void ImportEntities<TSource, TTarget>(
           Func<DbContext, List<TSource>> getListFromSource,
           Action<TSource, TTarget> fillTargetWithSource,
           Func<TTarget, object> getTargetKey,
           Func<TSource, object> getSourceKey
           )
            where TSource : class
            where TTarget : EntityBase, new()
        {
            using (var flightAppsDb = new FlightAppsDbContext())
            {
                flightAppsDb.Configuration.LazyLoadingEnabled = false;
                flightAppsDb.Configuration.ProxyCreationEnabled = false;

                var sourceEntitiesList = getListFromSource(flightAppsDb);
                Log(string.Format("\tSource: {0} items", sourceEntitiesList.Count));

                using (var infrastructureDb = new InfrastructureDbContext())
                {
                    infrastructureDb.Configuration.LazyLoadingEnabled = false;
                    infrastructureDb.Configuration.ProxyCreationEnabled = false;

                    var localTargets = infrastructureDb.Set<TTarget>().ToDictionary(getTargetKey);
                    Log(string.Format("\tLocal: {0} items", localTargets.Count));

                    var updateCount = 0;
                    var insertCount = 0;
                    foreach (var sourceEntity in sourceEntitiesList)
                    {
                        var targetEntity = localTargets.GetValueOrDefault(getSourceKey(sourceEntity), null);

                        if (targetEntity == null)
                        {
                            targetEntity = new TTarget();
                            ((IXafEntityObject)targetEntity).OnCreated();
                            infrastructureDb.Set<TTarget>().Add(targetEntity);
                            insertCount++;
                        }
                        else
                        {
                            updateCount++;
                        }

                        fillTargetWithSource(sourceEntity, targetEntity);
                    }
                    
                    Log(string.Format("\tUpdates/Insert: {0}/{1}", updateCount, insertCount));

                    var sw = Stopwatch.StartNew();
                    infrastructureDb.SaveChanges();
                    Log(string.Format("\tSave time: {0} ms", sw.ElapsedMilliseconds));
                    sw.Stop();
                }
            }
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void ImportFlightLegs()
        {
            using (var flightAppsDb = new FlightAppsDbContext())
            {
                flightAppsDb.Configuration.LazyLoadingEnabled = false;
                flightAppsDb.Configuration.ProxyCreationEnabled = false;

                var start = StartDate.Date;
                var end = EndDate.Date;

                var query =
                    from item in flightAppsDb.Set<VW_OperationsMaster>()
                    where item.Scheduled_DepartureDate_UTC.Value >= start && item.Scheduled_DepartureDate_UTC.Value < end
                    select item;

                var list =
                    query
                        .Include(item => item.FLT_FlightNumber)
                        .Include(item => item.FLT_FlightType)
                        .Include(item => item.GI_AircraftRegister)
                        .Include(item => item.FLT_Route_FlightLeg)
                        .Include(item => item.GI_Airport_ARRIVAL)
                        .Include(item => item.GI_Airport_DEPARTURE)
                        .Include(item => item.GI_AircraftType)
                        .ToList();

                var buckets =
                    (
                    from item in list
                        group item by
                            new DateTime(item.Scheduled_DepartureDate_UTC.Value.Year,
                                item.Scheduled_DepartureDate_UTC.Value.Month, 1)
                        into dayBucket
                        orderby dayBucket.Key descending
                        select dayBucket
                        ).ToList();

                Log(string.Format("\tSource: {0} items", list.Count));
                Log(string.Format("\tBuckets: {0} items", buckets.Count()));


                foreach (var bucket in buckets)
                {
                    ProcessBucket(bucket);
                }

                
            }
        }

        private void ProcessBucket(IGrouping<DateTime, VW_OperationsMaster> monthBucket)
        {
            Log(string.Format("\t--Bucket: {0} items", monthBucket.Key));
            using ( var infrastructureDb = new InfrastructureDbContext())
            {
                infrastructureDb.Configuration.LazyLoadingEnabled = false;
                infrastructureDb.Configuration.ProxyCreationEnabled = false;

                var existingFlightLegsOfMonthBucketQuery =
                    from item in infrastructureDb.Set<FlightLeg>()
                    where
                        item.ScheduledDepartureDateTime.DateTimeUtc.Value.Year == monthBucket.Key.Year &&
                        item.ScheduledDepartureDateTime.DateTimeUtc.Value.Month == monthBucket.Key.Month
                    select item;

                    var existingFlightLegsOfMonthBucketGrouped = from fl in existingFlightLegsOfMonthBucketQuery.ToList()
                            group fl by string.Format("{0},{1},{2},{3}", fl.FlightNumberId, fl.AircraftRegisterId, fl.RepetitionReasonCode, fl.ScheduledDepartureDateTime.DateTimeUtc) into flGroup
                            select flGroup;

                var existingFlightLegsOfMonthBucket =
                    existingFlightLegsOfMonthBucketGrouped
                        .Select(i => i.First())
                        .ToDictionary(
                            fl =>
                                string.Format("{0},{1},{2},{3}", fl.FlightNumberId, fl.AircraftRegisterId,
                                    fl.RepetitionReasonCode, fl.ScheduledDepartureDateTime.DateTimeUtc));

                Log(string.Format("\tLocal: {0} items", existingFlightLegsOfMonthBucket.Count));

                long updateCount = 0;
                long insertCount = 0;

                foreach (var sourceEntity in monthBucket)
                {
                    var flightNumber =
                        flightNumbers.GetValueOrDefault(sourceEntity.FLT_FlightNumber.FlightNumber_AbvNumber, null);
                    var flightNumberId = flightNumber != null ? (Guid?) flightNumber.Id : null;

                    var aircraftRegister = aircraftRegisters.GetValueOrDefault(
                        sourceEntity.GI_AircraftRegister.Code, null);
                    var aircraftRegisterId = aircraftRegister != null ? (Guid?) aircraftRegister.Id : null;

                    var repetitionReasonCode = sourceEntity.LegNumber;

                    var scheduledDepartureDateTime = sourceEntity.Scheduled_DepartureDatetime_UTC;

                    var searchingKey = string.Format("{0},{1},{2},{3}", flightNumberId, aircraftRegisterId, repetitionReasonCode, scheduledDepartureDateTime);
                    var targetEntity = existingFlightLegsOfMonthBucket.GetValueOrDefault(searchingKey, null);

                    if (targetEntity == null)
                    {
                        targetEntity = new FlightLeg();
                        ((IXafEntityObject) targetEntity).OnCreated();
                        infrastructureDb.Set<FlightLeg>().Add(targetEntity);
                        existingFlightLegsOfMonthBucket[searchingKey] = targetEntity;
                        insertCount++;
                    }
                    else
                    {
                        updateCount++;
                    }

                    var flightType = FlightType.All.FirstOrDefault(f => f.Code == sourceEntity.FLT_FlightType.Code);
                    targetEntity.FlightTypeId = flightType != null ? (Guid?) flightType.Id : null;

                    targetEntity.FlightNumberId = flightNumberId;

                    targetEntity.AircraftRegisterId = aircraftRegisterId;

                    targetEntity.Status = sourceEntity.Status;

                    targetEntity.ScheduledDepartureDateTime = new TralusDateTime()
                    {
                        DateTimeUtc = sourceEntity.Scheduled_DepartureDatetime_UTC
                    };
                    targetEntity.EstimatedDepartureDateTime = new TralusDateTime();
                    targetEntity.ActualDepartureDateTime = new TralusDateTime()
                    {
                        DateTimeUtc = sourceEntity.ACTUAL_DepartureDATETIME_UTC
                    };
                    targetEntity.EstimatedArrivalDateTime = new TralusDateTime();
                    targetEntity.ActualArrivalDateTime = new TralusDateTime()
                    {
                        DateTimeUtc = sourceEntity.Arrival_ACTUAL_DATETIME_UTC
                    };
                    targetEntity.TakeOffDateTime = new TralusDateTime()
                    {
                        DateTimeUtc = sourceEntity.Takeoff_Datetime
                    };

                    var leg = legs.GetValueOrDefault(sourceEntity.FLT_Route_FlightLeg.Name, null);
                    targetEntity.LegId = leg != null ? (Guid?) leg.Id : null;

                    var arrivlaAirport = airports.GetValueOrDefault(
                        sourceEntity.GI_Airport_ARRIVAL.IATA_AirportCode, null);
                    targetEntity.ArrivalAirportId = arrivlaAirport != null ? (Guid?) arrivlaAirport.Id : null;

                    var departureAirport =
                        airports.GetValueOrDefault(sourceEntity.GI_Airport_DEPARTURE.IATA_AirportCode, null);
                    targetEntity.DepartureAirportId = departureAirport != null ? (Guid?) departureAirport.Id : null;

                    var aircraftType = aircraftTypes.GetValueOrDefault(sourceEntity.GI_AircraftType.IATACode, null);
                    targetEntity.ScheduledAircraftTypeId = aircraftType != null ? (Guid?) aircraftType.Id : null;

                    targetEntity.RepetitionReasonCode = sourceEntity.LegNumber;
                }

                Log(string.Format("\tUpdates/Insert: {0}/{1}", updateCount, insertCount));

                var sw = Stopwatch.StartNew();
                infrastructureDb.SaveChanges();
                Log(string.Format("\tSave time: {0} ms", sw.ElapsedMilliseconds));
                sw.Stop();
            }
        }

        private void Log(string messaage)
        {
            SelectedObject.Log(string.Format("[{0}]: {1}", DateTime.UtcNow.ToString("HH:mm:ss"), messaage));
        }
    }
}
