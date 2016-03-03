CREATE VIEW Stations.FlightReportView
AS
SELECT
	FL.Id												Id,
	FL.Id												FlightLegId,
	FR.Id												FlightReportId,
	FRS.Id												FlightReportStateId,
	FL.[Status],
	FL.FlightNumberId,
	FL.FlightTypeId,
	FL.AircraftRegisterId,
	FL.ScheduledAircraftTypeId,
	FL.DepartureAirportId,
	FL.ArrivalAirportId,

	FL.ScheduledDepartureDateTime_AltCalendarDayUtc,
	FL.ScheduledDepartureDateTime_AltCalendarMonthUtc,
	FL.ScheduledDepartureDateTime_AltCalendarYearUtc,
	FL.ScheduledDepartureDateTime_DateHome,
	FL.ScheduledDepartureDateTime_DateLocal,
	FL.ScheduledDepartureDateTime_DateTimeHome,
	FL.ScheduledDepartureDateTime_DateTimeLocal,
	FL.ScheduledDepartureDateTime_DateTimeUtc,
	FL.ScheduledDepartureDateTime_DateUtc,
	FL.ScheduledDepartureDateTime_LocalTimeZoneId,
	FL.ScheduledDepartureDateTime_TimeHome,
	FL.ScheduledDepartureDateTime_TimeLocal,
	FL.ScheduledDepartureDateTime_TimeUtc,
	
	FL.ActualDepartureDateTime_AltCalendarDayUtc,
	FL.ActualDepartureDateTime_AltCalendarMonthUtc,
	FL.ActualDepartureDateTime_AltCalendarYearUtc,
	FL.ActualDepartureDateTime_DateHome,
	FL.ActualDepartureDateTime_DateLocal,
	FL.ActualDepartureDateTime_DateTimeHome,
	FL.ActualDepartureDateTime_DateTimeLocal,
	FL.ActualDepartureDateTime_DateTimeUtc,
	FL.ActualDepartureDateTime_DateUtc,
	FL.ActualDepartureDateTime_LocalTimeZoneId,
	FL.ActualDepartureDateTime_TimeHome,
	FL.ActualDepartureDateTime_TimeLocal,
	FL.ActualDepartureDateTime_TimeUtc,

	FL.EstimatedDepartureDateTime_AltCalendarDayUtc,
	FL.EstimatedDepartureDateTime_AltCalendarMonthUtc,
	FL.EstimatedDepartureDateTime_AltCalendarYearUtc,
	FL.EstimatedDepartureDateTime_DateHome,
	FL.EstimatedDepartureDateTime_DateLocal,
	FL.EstimatedDepartureDateTime_DateTimeHome,
	FL.EstimatedDepartureDateTime_DateTimeLocal,
	FL.EstimatedDepartureDateTime_DateTimeUtc,
	FL.EstimatedDepartureDateTime_DateUtc,
	FL.EstimatedDepartureDateTime_LocalTimeZoneId,
	FL.EstimatedDepartureDateTime_TimeHome,
	FL.EstimatedDepartureDateTime_TimeLocal,
	FL.EstimatedDepartureDateTime_TimeUtc,

	FL.ActualArrivalDateTime_AltCalendarDayUtc,
	FL.ActualArrivalDateTime_AltCalendarMonthUtc,
	FL.ActualArrivalDateTime_AltCalendarYearUtc,
	FL.ActualArrivalDateTime_DateHome,
	FL.ActualArrivalDateTime_DateLocal,
	FL.ActualArrivalDateTime_DateTimeHome,
	FL.ActualArrivalDateTime_DateTimeLocal,
	FL.ActualArrivalDateTime_DateTimeUtc,
	FL.ActualArrivalDateTime_DateUtc,
	FL.ActualArrivalDateTime_LocalTimeZoneId,
	FL.ActualArrivalDateTime_TimeHome,
	FL.ActualArrivalDateTime_TimeLocal,
	FL.ActualArrivalDateTime_TimeUtc,

	FL.EstimatedArrivalDateTime_AltCalendarDayUtc,		
	FL.EstimatedArrivalDateTime_AltCalendarMonthUtc,		
	FL.EstimatedArrivalDateTime_AltCalendarYearUtc,		
	FL.EstimatedArrivalDateTime_DateHome,				
	FL.EstimatedArrivalDateTime_DateLocal,				
	FL.EstimatedArrivalDateTime_DateTimeHome,			
	FL.EstimatedArrivalDateTime_DateTimeLocal,			
	FL.EstimatedArrivalDateTime_DateTimeUtc,				
	FL.EstimatedArrivalDateTime_DateUtc,					
	FL.EstimatedArrivalDateTime_LocalTimeZoneId,			
	FL.EstimatedArrivalDateTime_TimeHome,				
	FL.EstimatedArrivalDateTime_TimeLocal,				
	FL.EstimatedArrivalDateTime_TimeUtc,	
	
	FL.TakeOffDateTime_AltCalendarDayUtc,		
	FL.TakeOffDateTime_AltCalendarMonthUtc,		
	FL.TakeOffDateTime_AltCalendarYearUtc,		
	FL.TakeOffDateTime_DateHome,				
	FL.TakeOffDateTime_DateLocal,				
	FL.TakeOffDateTime_DateTimeHome,			
	FL.TakeOffDateTime_DateTimeLocal,			
	FL.TakeOffDateTime_DateTimeUtc,				
	FL.TakeOffDateTime_DateUtc,					
	FL.TakeOffDateTime_LocalTimeZoneId,			
	FL.TakeOffDateTime_TimeHome,				
	FL.TakeOffDateTime_TimeLocal,				
	FL.TakeOffDateTime_TimeUtc,				

	FE_ATA.EventDateTime_AltCalendarDayUtc				AtaEventDateTime_AltCalendarDayUtc		,			
	FE_ATA.EventDateTime_AltCalendarMonthUtc			AtaEventDateTime_AltCalendarMonthUtc	,		
	FE_ATA.EventDateTime_AltCalendarYearUtc				AtaEventDateTime_AltCalendarYearUtc		,			
	FE_ATA.EventDateTime_DateHome						AtaEventDateTime_DateHome				,		
	FE_ATA.EventDateTime_DateLocal						AtaEventDateTime_DateLocal				,		
	FE_ATA.EventDateTime_DateTimeHome					AtaEventDateTime_DateTimeHome			,		
	FE_ATA.EventDateTime_DateTimeLocal					AtaEventDateTime_DateTimeLocal			,		
	FE_ATA.EventDateTime_DateTimeUtc					AtaEventDateTime_DateTimeUtc			,		
	FE_ATA.EventDateTime_DateUtc						AtaEventDateTime_DateUtc				,		
	FE_ATA.EventDateTime_LocalTimeZoneId				AtaEventDateTime_LocalTimeZoneId		,		
	FE_ATA.EventDateTime_TimeHome						AtaEventDateTime_TimeHome				,		
	FE_ATA.EventDateTime_TimeLocal						AtaEventDateTime_TimeLocal				,		
	FE_ATA.EventDateTime_TimeUtc						AtaEventDateTime_TimeUtc				,		
																								
	FE_CCT.EventDateTime_AltCalendarDayUtc				CctEventDateTime_AltCalendarDayUtc		,		
	FE_CCT.EventDateTime_AltCalendarMonthUtc			CctEventDateTime_AltCalendarMonthUtc	,		
	FE_CCT.EventDateTime_AltCalendarYearUtc				CctEventDateTime_AltCalendarYearUtc		,			
	FE_CCT.EventDateTime_DateHome						CctEventDateTime_DateHome				,		
	FE_CCT.EventDateTime_DateLocal						CctEventDateTime_DateLocal				,		
	FE_CCT.EventDateTime_DateTimeHome					CctEventDateTime_DateTimeHome			,		
	FE_CCT.EventDateTime_DateTimeLocal					CctEventDateTime_DateTimeLocal			,		
	FE_CCT.EventDateTime_DateTimeUtc					CctEventDateTime_DateTimeUtc			,		
	FE_CCT.EventDateTime_DateUtc						CctEventDateTime_DateUtc				,		
	FE_CCT.EventDateTime_LocalTimeZoneId				CctEventDateTime_LocalTimeZoneId		,		
	FE_CCT.EventDateTime_TimeHome						CctEventDateTime_TimeHome				,		
	FE_CCT.EventDateTime_TimeLocal						CctEventDateTime_TimeLocal				,		
	FE_CCT.EventDateTime_TimeUtc						CctEventDateTime_TimeUtc				,		
																								
	FE_DCT.EventDateTime_AltCalendarDayUtc				DctEventDateTime_AltCalendarDayUtc		,		
	FE_DCT.EventDateTime_AltCalendarMonthUtc			DctEventDateTime_AltCalendarMonthUtc	,		
	FE_DCT.EventDateTime_AltCalendarYearUtc				DctEventDateTime_AltCalendarYearUtc		,			
	FE_DCT.EventDateTime_DateHome						DctEventDateTime_DateHome				,		
	FE_DCT.EventDateTime_DateLocal						DctEventDateTime_DateLocal				,		
	FE_DCT.EventDateTime_DateTimeHome					DctEventDateTime_DateTimeHome			,		
	FE_DCT.EventDateTime_DateTimeLocal					DctEventDateTime_DateTimeLocal			,		
	FE_DCT.EventDateTime_DateTimeUtc					DctEventDateTime_DateTimeUtc			,		
	FE_DCT.EventDateTime_DateUtc						DctEventDateTime_DateUtc				,		
	FE_DCT.EventDateTime_LocalTimeZoneId				DctEventDateTime_LocalTimeZoneId		,		
	FE_DCT.EventDateTime_TimeHome						DctEventDateTime_TimeHome				,		
	FE_DCT.EventDateTime_TimeLocal						DctEventDateTime_TimeLocal				,		
	FE_DCT.EventDateTime_TimeUtc						DctEventDateTime_TimeUtc				,		
																								
	FE_IN.EventDateTime_AltCalendarDayUtc				InEventDateTime_AltCalendarDayUtc		,		
	FE_IN.EventDateTime_AltCalendarMonthUtc				InEventDateTime_AltCalendarMonthUtc		,			
	FE_IN.EventDateTime_AltCalendarYearUtc				InEventDateTime_AltCalendarYearUtc		,		
	FE_IN.EventDateTime_DateHome						InEventDateTime_DateHome				,		
	FE_IN.EventDateTime_DateLocal						InEventDateTime_DateLocal				,		
	FE_IN.EventDateTime_DateTimeHome					InEventDateTime_DateTimeHome			,		
	FE_IN.EventDateTime_DateTimeLocal					InEventDateTime_DateTimeLocal			,		
	FE_IN.EventDateTime_DateTimeUtc						InEventDateTime_DateTimeUtc				,			
	FE_IN.EventDateTime_DateUtc							InEventDateTime_DateUtc					,			
	FE_IN.EventDateTime_LocalTimeZoneId					InEventDateTime_LocalTimeZoneId			,			
	FE_IN.EventDateTime_TimeHome						InEventDateTime_TimeHome				,		
	FE_IN.EventDateTime_TimeLocal						InEventDateTime_TimeLocal				,		
	FE_IN.EventDateTime_TimeUtc							InEventDateTime_TimeUtc					,			
																								
	FE_OUT.EventDateTime_AltCalendarDayUtc				OutEventDateTime_AltCalendarDayUtc		,		
	FE_OUT.EventDateTime_AltCalendarMonthUtc			OutEventDateTime_AltCalendarMonthUtc	,		
	FE_OUT.EventDateTime_AltCalendarYearUtc				OutEventDateTime_AltCalendarYearUtc		,			
	FE_OUT.EventDateTime_DateHome						OutEventDateTime_DateHome				,		
	FE_OUT.EventDateTime_DateLocal						OutEventDateTime_DateLocal				,		
	FE_OUT.EventDateTime_DateTimeHome					OutEventDateTime_DateTimeHome			,		
	FE_OUT.EventDateTime_DateTimeLocal					OutEventDateTime_DateTimeLocal			,		
	FE_OUT.EventDateTime_DateTimeUtc					OutEventDateTime_DateTimeUtc			,		
	FE_OUT.EventDateTime_DateUtc						OutEventDateTime_DateUtc				,		
	FE_OUT.EventDateTime_LocalTimeZoneId				OutEventDateTime_LocalTimeZoneId		,		
	FE_OUT.EventDateTime_TimeHome						OutEventDateTime_TimeHome				,		
	FE_OUT.EventDateTime_TimeLocal						OutEventDateTime_TimeLocal				,		
	FE_OUT.EventDateTime_TimeUtc						OutEventDateTime_TimeUtc				,		
																								
	FE_OFF.EventDateTime_AltCalendarDayUtc				OffEventDateTime_AltCalendarDayUtc		,
	FE_OFF.EventDateTime_AltCalendarMonthUtc			OffEventDateTime_AltCalendarMonthUtc	,
	FE_OFF.EventDateTime_AltCalendarYearUtc				OffEventDateTime_AltCalendarYearUtc		,
	FE_OFF.EventDateTime_DateHome						OffEventDateTime_DateHome				,
	FE_OFF.EventDateTime_DateLocal						OffEventDateTime_DateLocal				,
	FE_OFF.EventDateTime_DateTimeHome					OffEventDateTime_DateTimeHome			,
	FE_OFF.EventDateTime_DateTimeLocal					OffEventDateTime_DateTimeLocal			,
	FE_OFF.EventDateTime_DateTimeUtc					OffEventDateTime_DateTimeUtc			,
	FE_OFF.EventDateTime_DateUtc						OffEventDateTime_DateUtc				,
	FE_OFF.EventDateTime_LocalTimeZoneId				OffEventDateTime_LocalTimeZoneId		,
	FE_OFF.EventDateTime_TimeHome						OffEventDateTime_TimeHome				,
	FE_OFF.EventDateTime_TimeLocal						OffEventDateTime_TimeLocal				,
	FE_OFF.EventDateTime_TimeUtc						OffEventDateTime_TimeUtc				,

	FUEL.FuellingSum									FuellingSum								,
	CAST( ISNULL( FUEL.HasFuelling, 0 ) AS BIT )		HasFuelling								,

	FDELAY.DelaySum										DelaySum,
	CAST( ISNULL( FDELAY.HasDelay, 0 ) AS BIT )			HasDelay,

	SSR.SpecialServicesCount							SpecialServicesCount					,
	CAST( ISNULL( SSR.HasSpecialService, 0 ) AS BIT )	HasSpecialService						,

	CARGO.CargoPiecesCount								CargoPiecesCount						,
	CARGO.CargoWeightSum								CargoWeightSum							,
	CAST( ISNULL( CARGO.HasCargo, 0 ) AS BIT )			HasCargo								,

	PAX.PassengersCount									PassengersCount							,
	CAST( ISNULL( PAX.HasPassenger, 0 ) AS BIT )		HasPassenger
FROM
	Infrastructure.FlightLeg							FL
LEFT OUTER JOIN
	Stations.FlightReport								FR
ON
	FR.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightReportState							FRS
ON
	FR.FlightReportStateId = FRS.Id
LEFT OUTER JOIN
(
	SELECT
		FF.FlightLegId,
		SUM( ABS( FF.Amount ) )							FuellingSum,
		IIF( COUNT( FF.Id ) > 0, 1, 0 )					HasFuelling
	FROM
		Stations.FlightFuelling							FF
	GROUP BY
		FF.FlightLegId
) AS FUEL
ON
	FUEL.FlightLegId = FL.Id
LEFT OUTER JOIN
(
	SELECT
		FD.FlightLegId,
		SUM( ABS( FD.Duration ) )						DelaySum,
		IIF( COUNT( FD.Id ) > 0, 1, 0 )					HasDelay
	FROM
		Stations.FlightDelay							FD
	GROUP BY
		FD.FlightLegId
) AS FDELAY
ON
	FDELAY.FlightLegId = FL.Id
LEFT OUTER JOIN
(
	SELECT
		FC.FlightLegId,
		SUM( ABS( FC_SSR.SpecialServiceCount ) )		SpecialServicesCount,
		IIF( COUNT( FC_SSR.Id ) > 0, 1, 0 )				HasSpecialService
	FROM
		Stations.DestinationProfile						FC
	LEFT OUTER JOIN
		Stations.DestinationSpecialService				FC_SSR
	ON
		FC.Id = FC_SSR.DestinationProfileId
	GROUP BY
		FC.FlightLegId
) AS SSR
ON
	SSR.FlightLegId = FL.Id
LEFT OUTER JOIN
(
	SELECT
		FC.FlightLegId,
		SUM( ABS( FC_CARGO.CargoPieces ) )				CargoPiecesCount,
		SUM( ABS( FC_CARGO.CargoWeight ) )				CargoWeightSum,
		IIF( COUNT( FC_CARGO.Id ) > 0, 1, 0 )			HasCargo
	FROM
		Stations.DestinationProfile						FC
	LEFT OUTER JOIN
		Stations.DestinationCargo						FC_CARGO
	ON
		FC.Id = FC_CARGO.DestinationProfileId
	GROUP BY
		FC.FlightLegId
) AS CARGO
ON
	CARGO.FlightLegId = FL.Id
LEFT OUTER JOIN
(
	SELECT
		FC.FlightLegId,
		SUM( ABS( FC_PAX.PassengerCount ) )				PassengersCount,
		IIF( COUNT( FC_PAX.Id ) > 0, 1, 0 )				HasPassenger
	FROM
		Stations.DestinationProfile						FC
	LEFT OUTER JOIN
		Stations.DestinationPassenger					FC_PAX
	ON
		FC.Id = FC_PAX.DestinationProfileId
	GROUP BY
		FC.FlightLegId
) AS PAX
ON
	PAX.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightEvent								FE_ATA
ON
	FE_ATA.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightEventType							FETYPE_ATA
ON
	FETYPE_ATA.Id = FE_ATA.FlightEventTypeId
LEFT OUTER JOIN
	Stations.FlightEvent								FE_CCT
ON
	FE_CCT.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightEventType							FETYPE_CCT
ON
	FETYPE_CCT.Id = FE_CCT.FlightEventTypeId
LEFT OUTER JOIN
	Stations.FlightEvent								FE_DCT
ON
	FE_DCT.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightEventType							FETYPE_DCT
ON
	FETYPE_DCT.Id = FE_ATA.FlightEventTypeId
LEFT OUTER JOIN
	Stations.FlightEvent								FE_IN
ON
	FE_IN.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightEventType							FETYPE_IN
ON
	FETYPE_IN.Id = FE_ATA.FlightEventTypeId
LEFT OUTER JOIN
	Stations.FlightEvent								FE_OUT
ON
	FE_OUT.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightEventType							FETYPE_OUT
ON
	FETYPE_OUT.Id = FE_ATA.FlightEventTypeId
LEFT OUTER JOIN
	Stations.FlightEvent								FE_OFF
ON
	FE_OFF.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightEventType							FETYPE_OFF
ON
	FETYPE_OFF.Id = FE_ATA.FlightEventTypeId
WHERE
	ISNULL( FETYPE_ATA.Name , 'ATA' ) = 'ATA'	AND
	ISNULL( FETYPE_CCT.Name , 'CCT' ) = 'CCT'	AND
	ISNULL( FETYPE_DCT.Name , 'DCT' ) = 'DCT'	AND
	ISNULL( FETYPE_IN.Name	, 'IN'	) = 'IN'	AND
	ISNULL( FETYPE_OUT.Name , 'OUT' ) = 'OUT'	AND
	ISNULL( FETYPE_OFF.Name , 'OFF'	) = 'OFF'

-- SELECT * FROM Stations.FlightReportView
