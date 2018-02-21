using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AsmpMVC.Data;

namespace AsmpMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180221155206_FirstM")]
    partial class FirstM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsmpMVC.Data.Models.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<string>("Code");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Item");

                    b.Property<string>("Note");

                    b.Property<int>("Priority");

                    b.Property<int>("SiteId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Category");

                    b.Property<DateTime>("DateRaised");

                    b.Property<string>("IssueCode");

                    b.Property<string>("Item");

                    b.Property<string>("Note");

                    b.Property<int>("Priority");

                    b.Property<int>("SiteId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.ProgressStage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApprovedBy");

                    b.Property<string>("CompletedBy");

                    b.Property<DateTime>("DateApproved");

                    b.Property<DateTime>("DateCompleted");

                    b.Property<DateTime>("DatePaid");

                    b.Property<int>("PaymentStatus");

                    b.Property<int>("SiteId");

                    b.Property<int>("Stage");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("ProgressStages");
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactEmail");

                    b.Property<int>("ContactNumber");

                    b.Property<DateTime>("ContractDate");

                    b.Property<double>("ContractValueExGST");

                    b.Property<double>("ContractValueIncGST");

                    b.Property<DateTime>("DOPCDate");

                    b.Property<string>("HomeOwner");

                    b.Property<string>("HouseType");

                    b.Property<string>("Note");

                    b.Property<int>("PreContactEOT");

                    b.Property<string>("SiteNumber")
                        .IsRequired();

                    b.Property<DateTime>("TwelveMonthMaintenance");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.Variation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Claimed");

                    b.Property<string>("Comment");

                    b.Property<int>("Contract");

                    b.Property<DateTime>("DateReleased");

                    b.Property<string>("Description");

                    b.Property<int>("EOT");

                    b.Property<string>("Location");

                    b.Property<bool>("Paid");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<double>("Price");

                    b.Property<int>("SiteId");

                    b.Property<int>("Status");

                    b.Property<string>("VariationCode");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Variations");
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.Issue", b =>
                {
                    b.HasOne("AsmpMVC.Data.Models.Site", "Site")
                        .WithMany("Issues")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.Maintenance", b =>
                {
                    b.HasOne("AsmpMVC.Data.Models.Site", "Site")
                        .WithMany("Maintenances")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.ProgressStage", b =>
                {
                    b.HasOne("AsmpMVC.Data.Models.Site", "Site")
                        .WithMany("ProgressStages")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsmpMVC.Data.Models.Variation", b =>
                {
                    b.HasOne("AsmpMVC.Data.Models.Site", "Site")
                        .WithMany("Variations")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
