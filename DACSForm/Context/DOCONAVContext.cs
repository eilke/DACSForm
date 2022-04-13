using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DACSForm.Context
{
    public partial class DOCONAVContext : DbContext
    {
        public DOCONAVContext()
        {
        }

        public DOCONAVContext(DbContextOptions<DOCONAVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DacshHeader> DacshHeader { get; set; }
        public virtual DbSet<DacsTransaction> DacsTransaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ilke;Initial Catalog=DacsFormDb; Persist Security Info=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DacshHeader>(entity =>
            {
                entity.HasKey(e => new { e.OrderDate, e.FlightNo, e.CustomerNo, e.CustomerDetail, e.ShortcutDimension1Code, e.EntryType })
                    .HasName("Dacs Header$0");

                entity.ToTable("Dacs Header");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightNo)
                    .HasColumnName("Flight No_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDetail)
                    .HasColumnName("Customer Detail")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType)
                    .HasColumnName("Entry Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcconfMsg)
                    .IsRequired()
                    .HasColumnName("ACConfMsg")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AircraftConfiguration)
                    .IsRequired()
                    .HasColumnName("Aircraft Configuration")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AircraftVersion)
                    .IsRequired()
                    .HasColumnName("Aircraft Version")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArrFrom)
                    .IsRequired()
                    .HasColumnName("Arr_ From")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArrTime)
                    .HasColumnName("Arr_ Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BusinessType).HasColumnName("Business Type");

                entity.Property(e => e.CancellationComment).HasColumnName("Cancellation Comment");

                entity.Property(e => e.CancellationReasonCode)
                    .IsRequired()
                    .HasColumnName("Cancellation Reason Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeek).HasColumnName("Day Of Week");

                entity.Property(e => e.DepFrom)
                    .IsRequired()
                    .HasColumnName("Dep_ From")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepTime)
                    .HasColumnName("Dep_ Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentStatus).HasColumnName("Document Status");

                entity.Property(e => e.DonusMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlightTimeTableLineNo).HasColumnName("Flight Time Table Line No_");

                entity.Property(e => e.GateNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GidisMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HandlingType).HasColumnName("Handling Type");

                entity.Property(e => e.Hldriver)
                    .IsRequired()
                    .HasColumnName("HLDriver")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hlno)
                    .IsRequired()
                    .HasColumnName("HLNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsHmlonTray).HasColumnName("isHMLOnTray");

                entity.Property(e => e.KontrolEden)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastPrintedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Leg1)
                    .IsRequired()
                    .HasColumnName("Leg 1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg2)
                    .IsRequired()
                    .HasColumnName("Leg 2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg3)
                    .IsRequired()
                    .HasColumnName("Leg 3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg4)
                    .IsRequired()
                    .HasColumnName("Leg 4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg5)
                    .IsRequired()
                    .HasColumnName("Leg 5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoadingSetup)
                    .IsRequired()
                    .HasColumnName("Loading Setup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoadingSetupLabel)
                    .IsRequired()
                    .HasColumnName("Loading Setup Label")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MarketDiversity).HasColumnName("Market Diversity");

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderDateTimeLocal).HasColumnType("datetime");

                entity.Property(e => e.ParkPos)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RangeType).HasColumnName("Range Type");

                entity.Property(e => e.ReturnFlightNo)
                    .IsRequired()
                    .HasColumnName("Return Flight No_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnLegNo).HasColumnName("Return Leg No_");

                entity.Property(e => e.SalesType).HasColumnName("Sales Type");

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DacsTransaction>(entity =>
            {
                entity.HasKey(e => new { e.OrderDate, e.FlightNo, e.CustomerNo, e.CustomerDetail, e.ShortcutDimension1Code, e.EntryType, e.Leg, e.Class })
                    .HasName("DOCO$Pax Transaction$0");

                entity.ToTable("DOCO$Pax Transaction");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightNo)
                    .HasColumnName("Flight No_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNo)
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDetail)
                    .HasColumnName("Customer Detail")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryType)
                    .HasColumnName("Entry Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AcRegistrationNo)
                    .IsRequired()
                    .HasColumnName("AC Registration No_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActualMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActualPax).HasColumnName("Actual Pax");

                entity.Property(e => e.Additions)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AircraftConfiguration)
                    .IsRequired()
                    .HasColumnName("Aircraft Configuration")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AircraftVersion)
                    .IsRequired()
                    .HasColumnName("Aircraft Version")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArrFrom)
                    .IsRequired()
                    .HasColumnName("Arr_ From")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArrTime)
                    .HasColumnName("Arr_ Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChildMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChildPax).HasColumnName("Child Pax");

                entity.Property(e => e.ConfigMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DayOfWeek).HasColumnName("Day Of Week");

                entity.Property(e => e.DepTime)
                    .HasColumnName("Dep_ Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightTimeTableLineNo).HasColumnName("Flight Time Table Line No_");

                entity.Property(e => e.ForecastMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ForecastPax).HasColumnName("Forecast Pax");

                entity.Property(e => e.InfantPax).HasColumnName("Infant Pax");

                entity.Property(e => e.InitialMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InitialPax).HasColumnName("Initial Pax");

                entity.Property(e => e.Leg1)
                    .IsRequired()
                    .HasColumnName("Leg 1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg2)
                    .IsRequired()
                    .HasColumnName("Leg 2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg3)
                    .IsRequired()
                    .HasColumnName("Leg 3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg4)
                    .IsRequired()
                    .HasColumnName("Leg 4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Leg5)
                    .IsRequired()
                    .HasColumnName("Leg 5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LegCode)
                    .IsRequired()
                    .HasColumnName("Leg Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.LoadMsg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoadPax).HasColumnName("Load Pax");

                entity.Property(e => e.LoadingConcept1)
                    .IsRequired()
                    .HasColumnName("Loading Concept 1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoadingConcept2)
                    .IsRequired()
                    .HasColumnName("Loading Concept 2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoadingConcept3)
                    .IsRequired()
                    .HasColumnName("Loading Concept 3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LoadingSetup)
                    .IsRequired()
                    .HasColumnName("Loading Setup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaxCapacity).HasColumnName("Max_ Capacity");

                entity.Property(e => e.MealServiceType1)
                    .IsRequired()
                    .HasColumnName("Meal Service Type 1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MealServiceType2)
                    .IsRequired()
                    .HasColumnName("Meal Service Type 2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MealServiceType3)
                    .IsRequired()
                    .HasColumnName("Meal Service Type 3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousPax).HasColumnName("Previous Pax");

                entity.Property(e => e.RangeType).HasColumnName("Range Type");

                entity.Property(e => e.ReturnFlightNo)
                    .IsRequired()
                    .HasColumnName("Return Flight No_")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnLegNo).HasColumnName("Return Leg No_");

                entity.Property(e => e.RotationPlan)
                    .IsRequired()
                    .HasColumnName("Rotation Plan")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
