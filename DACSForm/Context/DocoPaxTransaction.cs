using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DACSForm.Context
{
    public partial class DacsTransaction
    {
        public byte[] Timestamp { get; set; }
        public DateTime OrderDate { get; set; }
        public string FlightNo { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerDetail { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string EntryType { get; set; }
        public int Leg { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        public string AircraftVersion { get; set; }
        public int Status { get; set; }
        public int MaxCapacity { get; set; }
        public int InitialPax { get; set; }
        public int ActualPax { get; set; }
        public int LineNo { get; set; }
        public int Priority { get; set; }
        public string LegCode { get; set; }
        public string MealServiceType1 { get; set; }
        public string MealServiceType2 { get; set; }
        public string MealServiceType3 { get; set; }
        public DateTime ArrTime { get; set; }
        public DateTime DepTime { get; set; }
        public string Leg1 { get; set; }
        public string Leg2 { get; set; }
        public string Leg3 { get; set; }
        public string Leg4 { get; set; }
        public string Leg5 { get; set; }
        public int RangeType { get; set; }
        public string LoadingSetup { get; set; }
        public string ArrFrom { get; set; }
        public string AcRegistrationNo { get; set; }
        public int ReturnLegNo { get; set; }
        public string ReturnFlightNo { get; set; }
        public string Msg { get; set; }
        public int LoadPax { get; set; }
        public int ChildPax { get; set; }
        public int DayOfWeek { get; set; }
        public string Additions { get; set; }
        public int PreviousPax { get; set; }
        public string AircraftConfiguration { get; set; }
        public int FlightTimeTableLineNo { get; set; }
        public int ForecastPax { get; set; }
        public string RotationPlan { get; set; }
        public byte InitialPaxLocked { get; set; }
        public byte Cancelled { get; set; }
        public string LoadingConcept1 { get; set; }
        public string LoadingConcept2 { get; set; }
        public string LoadingConcept3 { get; set; }
        public string InitialMsg { get; set; }
        public string LoadMsg { get; set; }
        public string ActualMsg { get; set; }
        public string ConfigMsg { get; set; }
        public string ChildMsg { get; set; }
        public string ForecastMsg { get; set; }
        public int InfantPax { get; set; }
    }
}
