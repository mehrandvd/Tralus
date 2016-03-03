if OBJECT_ID('Stations.FlightReportView') IS NOT NULL
	DROP VIEW Stations.FlightReportView;
CREATE VIEW Stations.FlightReportView
AS
SELECT
	FL.Id										Id,
	FL.Id										FlightLegId,
	FR.Id										FlightReportId,
	FRS.Id										FlightReportStateId,
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

	FE_ATA.EventDateTime_AltCalendarDayUtc		AtaEventDateTime_AltCalendarDayUtc		,			
	FE_ATA.EventDateTime_AltCalendarMonthUtc	AtaEventDateTime_AltCalendarMonthUtc	,		
	FE_ATA.EventDateTime_AltCalendarYearUtc		AtaEventDateTime_AltCalendarYearUtc		,			
	FE_ATA.EventDateTime_DateHome				AtaEventDateTime_DateHome				,		
	FE_ATA.EventDateTime_DateLocal				AtaEventDateTime_DateLocal				,		
	FE_ATA.EventDateTime_DateTimeHome			AtaEventDateTime_DateTimeHome			,		
	FE_ATA.EventDateTime_DateTimeLocal			AtaEventDateTime_DateTimeLocal			,		
	FE_ATA.EventDateTime_DateTimeUtc			AtaEventDateTime_DateTimeUtc			,		
	FE_ATA.EventDateTime_DateUtc				AtaEventDateTime_DateUtc				,		
	FE_ATA.EventDateTime_LocalTimeZoneId		AtaEventDateTime_LocalTimeZoneId		,		
	FE_ATA.EventDateTime_TimeHome				AtaEventDateTime_TimeHome				,		
	FE_ATA.EventDateTime_TimeLocal				AtaEventDateTime_TimeLocal				,		
	FE_ATA.EventDateTime_TimeUtc				AtaEventDateTime_TimeUtc				,		
																						
	FE_CCT.EventDateTime_AltCalendarDayUtc		CctEventDateTime_AltCalendarDayUtc		,		
	FE_CCT.EventDateTime_AltCalendarMonthUtc	CctEventDateTime_AltCalendarMonthUtc	,		
	FE_CCT.EventDateTime_AltCalendarYearUtc		CctEventDateTime_AltCalendarYearUtc		,			
	FE_CCT.EventDateTime_DateHome				CctEventDateTime_DateHome				,		
	FE_CCT.EventDateTime_DateLocal				CctEventDateTime_DateLocal				,		
	FE_CCT.EventDateTime_DateTimeHome			CctEventDateTime_DateTimeHome			,		
	FE_CCT.EventDateTime_DateTimeLocal			CctEventDateTime_DateTimeLocal			,		
	FE_CCT.EventDateTime_DateTimeUtc			CctEventDateTime_DateTimeUtc			,		
	FE_CCT.EventDateTime_DateUtc				CctEventDateTime_DateUtc				,		
	FE_CCT.EventDateTime_LocalTimeZoneId		CctEventDateTime_LocalTimeZoneId		,		
	FE_CCT.EventDateTime_TimeHome				CctEventDateTime_TimeHome				,		
	FE_CCT.EventDateTime_TimeLocal				CctEventDateTime_TimeLocal				,		
	FE_CCT.EventDateTime_TimeUtc				CctEventDateTime_TimeUtc				,		
																						
	FE_DCT.EventDateTime_AltCalendarDayUtc		DctEventDateTime_AltCalendarDayUtc		,		
	FE_DCT.EventDateTime_AltCalendarMonthUtc	DctEventDateTime_AltCalendarMonthUtc	,		
	FE_DCT.EventDateTime_AltCalendarYearUtc		DctEventDateTime_AltCalendarYearUtc		,			
	FE_DCT.EventDateTime_DateHome				DctEventDateTime_DateHome				,		
	FE_DCT.EventDateTime_DateLocal				DctEventDateTime_DateLocal				,		
	FE_DCT.EventDateTime_DateTimeHome			DctEventDateTime_DateTimeHome			,		
	FE_DCT.EventDateTime_DateTimeLocal			DctEventDateTime_DateTimeLocal			,		
	FE_DCT.EventDateTime_DateTimeUtc			DctEventDateTime_DateTimeUtc			,		
	FE_DCT.EventDateTime_DateUtc				DctEventDateTime_DateUtc				,		
	FE_DCT.EventDateTime_LocalTimeZoneId		DctEventDateTime_LocalTimeZoneId		,		
	FE_DCT.EventDateTime_TimeHome				DctEventDateTime_TimeHome				,		
	FE_DCT.EventDateTime_TimeLocal				DctEventDateTime_TimeLocal				,		
	FE_DCT.EventDateTime_TimeUtc				DctEventDateTime_TimeUtc				,		
																						
	FE_IN.EventDateTime_AltCalendarDayUtc		InEventDateTime_AltCalendarDayUtc		,		
	FE_IN.EventDateTime_AltCalendarMonthUtc		InEventDateTime_AltCalendarMonthUtc		,			
	FE_IN.EventDateTime_AltCalendarYearUtc		InEventDateTime_AltCalendarYearUtc		,		
	FE_IN.EventDateTime_DateHome				InEventDateTime_DateHome				,		
	FE_IN.EventDateTime_DateLocal				InEventDateTime_DateLocal				,		
	FE_IN.EventDateTime_DateTimeHome			InEventDateTime_DateTimeHome			,		
	FE_IN.EventDateTime_DateTimeLocal			InEventDateTime_DateTimeLocal			,		
	FE_IN.EventDateTime_DateTimeUtc				InEventDateTime_DateTimeUtc				,			
	FE_IN.EventDateTime_DateUtc					InEventDateTime_DateUtc					,			
	FE_IN.EventDateTime_LocalTimeZoneId			InEventDateTime_LocalTimeZoneId			,			
	FE_IN.EventDateTime_TimeHome				InEventDateTime_TimeHome				,		
	FE_IN.EventDateTime_TimeLocal				InEventDateTime_TimeLocal				,		
	FE_IN.EventDateTime_TimeUtc					InEventDateTime_TimeUtc					,			
																						
	FE_OUT.EventDateTime_AltCalendarDayUtc		OutEventDateTime_AltCalendarDayUtc		,		
	FE_OUT.EventDateTime_AltCalendarMonthUtc	OutEventDateTime_AltCalendarMonthUtc	,		
	FE_OUT.EventDateTime_AltCalendarYearUtc		OutEventDateTime_AltCalendarYearUtc		,			
	FE_OUT.EventDateTime_DateHome				OutEventDateTime_DateHome				,		
	FE_OUT.EventDateTime_DateLocal				OutEventDateTime_DateLocal				,		
	FE_OUT.EventDateTime_DateTimeHome			OutEventDateTime_DateTimeHome			,		
	FE_OUT.EventDateTime_DateTimeLocal			OutEventDateTime_DateTimeLocal			,		
	FE_OUT.EventDateTime_DateTimeUtc			OutEventDateTime_DateTimeUtc			,		
	FE_OUT.EventDateTime_DateUtc				OutEventDateTime_DateUtc				,		
	FE_OUT.EventDateTime_LocalTimeZoneId		OutEventDateTime_LocalTimeZoneId		,		
	FE_OUT.EventDateTime_TimeHome				OutEventDateTime_TimeHome				,		
	FE_OUT.EventDateTime_TimeLocal				OutEventDateTime_TimeLocal				,		
	FE_OUT.EventDateTime_TimeUtc				OutEventDateTime_TimeUtc				,		
																						
	FE_OFF.EventDateTime_AltCalendarDayUtc		OffEventDateTime_AltCalendarDayUtc		,
	FE_OFF.EventDateTime_AltCalendarMonthUtc	OffEventDateTime_AltCalendarMonthUtc	,
	FE_OFF.EventDateTime_AltCalendarYearUtc		OffEventDateTime_AltCalendarYearUtc		,
	FE_OFF.EventDateTime_DateHome				OffEventDateTime_DateHome				,
	FE_OFF.EventDateTime_DateLocal				OffEventDateTime_DateLocal				,
	FE_OFF.EventDateTime_DateTimeHome			OffEventDateTime_DateTimeHome			,
	FE_OFF.EventDateTime_DateTimeLocal			OffEventDateTime_DateTimeLocal			,
	FE_OFF.EventDateTime_DateTimeUtc			OffEventDateTime_DateTimeUtc			,
	FE_OFF.EventDateTime_DateUtc				OffEventDateTime_DateUtc				,
	FE_OFF.EventDateTime_LocalTimeZoneId		OffEventDateTime_LocalTimeZoneId		,
	FE_OFF.EventDateTime_TimeHome				OffEventDateTime_TimeHome				,
	FE_OFF.EventDateTime_TimeLocal				OffEventDateTime_TimeLocal				,
	FE_OFF.EventDateTime_TimeUtc				OffEventDateTime_TimeUtc				,

	SSR.SumSSR									SpecialServicesCount					,
	CARGO.SumCargoPiece							CargoPiecesCount						,
	CARGO.SumCragoWeight						CargoWeightSum							,
	PAX.SumPax									PassengersCount
FROM
	Infrastructure.FlightLeg							FL
LEFT OUTER JOIN
	Stations.FlightReport								FR
ON
	FR.FlightLegId = FL.Id
LEFT OUTER JOIN
	Stations.FlightReportState							FRS
ON
	FR.FlightReportState_Id = FRS.Id
LEFT OUTER JOIN
(
	SELECT 
		FC.FlightLegId									LEGID,
		SSRSUM.SumSSR									SumSSR
	FROM
		Stations.DestinationProfile						FC
	LEFT OUTER JOIN
	(
		SELECT
			DestSSR.DestinationProfileId,
			SUM( ABS( DestSSR.SpecialServiceCount ) )	SumSSR
		FROM
			Stations.DestinationSpecialService			DestSSR
		GROUP BY
			DesTSSR.DestinationProfileId
	) AS SSRSUM
	ON
		SSRSUM.DestinationProfileId = FC.Id
	WHERE
		ISNULL( SSRSUM.SumSSR, 0 ) > 0
) AS SSR
ON
	SSR.LEGID = FL.Id
LEFT OUTER JOIN
(
	SELECT
		FC.FlightLegId									LEGID,
		CARGOSUM.SumPiece								SumCargoPiece,
		CARGOSUM.SumWeight								SumCragoWeight
	FROM
		Stations.DestinationProfile						FC
	LEFT OUTER JOIN
	(
		SELECT
			CARGO.DestinationProfileId,
			SUM( ABS( CARGO.CargoPieces ) )	SumPiece,
			SUM( ABS( CARGO.CargoWeight ) )	SumWeight
		FROM
			Stations.DestinationCargo					CARGO
		GROUP BY
			CARGO.DestinationProfileId
	) AS CARGOSUM
	ON
		CARGOSUM.DestinationProfileId = FC.Id
	WHERE
		ISNULL( CARGOSUM.SumPiece, 0 ) > 0
) AS CARGO
ON
	CARGO.LEGID = FL.Id
LEFT OUTER JOIN
(
	SELECT
		FC.FlightLegId									LEGID,
		PAXSUM.SumPax									SumPax
	FROM
		Stations.DestinationProfile						FC
	LEFT OUTER JOIN
	(
		SELECT
			PAX.DestinationProfileId,
			SUM( ABS( PAX.PassengerCount ) )			SumPax
		FROM
			Stations.DestinationPassenger				PAX
		GROUP BY
			PAX.DestinationProfileId
	) AS PAXSUM
	ON
		PAXSUM.DestinationProfileId = FC.Id
	WHERE
		ISNULL( PAXSUM.SumPax, 0 ) > 0
) AS PAX
ON
	PAX.LEGID = FL.Id
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
	FETYPE_ATA.Name = 'ATA' AND
	FETYPE_CCT.Name = 'CCT' AND
	FETYPE_DCT.Name = 'DCT' AND
	FETYPE_IN.Name	= 'IN'	AND
	FETYPE_OUT.Name = 'OUT' AND
	FETYPE_OFF.Name = 'OFF'

-- SELECT * FROM Stations.FlightReportView
