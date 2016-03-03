namespace Mahan.Stations.BusinessModel
{
    public enum FlightReportTimingStatus
    {
        Unknown                     = 0,
        Missing                     = 1,
        NotTime                     = 2,
        DueSoon                     = 3,
        Late                        = 4,
        ApprovedByOcc               = 5,
        ReceivedByArrivalStation    = 6
    }
}