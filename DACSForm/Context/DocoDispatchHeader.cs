using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DACSForm.Context
{
    public partial class DacshHeader
    {
        public byte[] Timestamp { get; set; }
        public DateTime OrderDate { get; set; }
        public string FlightNo { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerDetail { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string EntryType { get; set; }
        public int RangeType { get; set; }
        public string LoadingSetup { get; set; }
        public string AircraftVersion { get; set; }
        public string ArrFrom { get; set; }
        public DateTime DepTime { get; set; }
        public string Leg1 { get; set; }
        public string Leg2 { get; set; }
        public string Leg3 { get; set; }
        public string Leg4 { get; set; }
        public string Leg5 { get; set; }
        public string ExternalDocumentNo { get; set; }
        public int NoPrinted { get; set; }
        public string NoSeries { get; set; }
        public int FlightTimeTableLineNo { get; set; }
        public byte Open { get; set; }
        public int HandlingType { get; set; }
        public DateTime ArrTime { get; set; }
        public int ReturnLegNo { get; set; }
        public string ReturnFlightNo { get; set; }
        public string LoadingSetupLabel { get; set; }
        public string GidisMsg { get; set; }
        public string DonusMsg { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastPrintedBy { get; set; }
        public string DepFrom { get; set; }
        public string AircraftConfiguration { get; set; }
        public string Hlno { get; set; }
        public string GateNo { get; set; }
        public string Hldriver { get; set; }
        public string ParkPos { get; set; }
        public DateTime OrderDateTime { get; set; }
        public int MarketDiversity { get; set; }
        public int Route { get; set; }
        public int BusinessType { get; set; }
        public int SalesType { get; set; }
        public byte NightStop { get; set; }
        public int DefaultEqp { get; set; }
        public int ActualEqp { get; set; }
        public byte EqpUpdated { get; set; }
        public byte AutoPrint { get; set; }
        public byte ParkPosConclusive { get; set; }
        public byte Cancelled { get; set; }
        public string CancellationReasonCode { get; set; }
        public byte CancellationComment { get; set; }
        public int DayOfWeek { get; set; }
        public byte CargoProblem { get; set; }
        public string Shift { get; set; }
        public int DocumentStatus { get; set; }
        public string KontrolEden { get; set; }
        public string AcconfMsg { get; set; }
        public byte IsHmlonTray { get; set; }
        public DateTime OrderDateTimeLocal { get; set; }
    }
}
