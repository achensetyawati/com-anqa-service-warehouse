﻿// <auto-generated />
using Com.Anqa.Service.Warehouse.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Anqa.Service.Warehouse.Lib.Migrations
{
    [DbContext(typeof(WarehouseDbContext))]
    [Migration("20200827034816_Change_Type_in_Expditionitem_table")]
    partial class Change_Type_in_Expditionitem_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.Expeditions.ExpeditionSPKDoc", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DestinationCode")
                        .HasMaxLength(255);

                    b.Property<int>("DestinationId");

                    b.Property<string>("DestinationName")
                        .HasMaxLength(255);

                    b.Property<int>("ExpeditionId");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDistributed");

                    b.Property<bool>("IsDraft");

                    b.Property<bool>("IsReceived");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("PackingList")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .HasMaxLength(255);

                    b.Property<string>("Reference")
                        .HasMaxLength(255);

                    b.Property<int>("SPKDocsId");

                    b.Property<string>("SourceCode")
                        .HasMaxLength(255);

                    b.Property<int>("SourceId");

                    b.Property<string>("SourceName")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("ExpeditionSPKDocs");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.Expeditions.ExpeditionSPKDocItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("ArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("DomesticCOGS");

                    b.Property<double>("DomesticRetail");

                    b.Property<double>("DomesticSale");

                    b.Property<double>("DomesticWholesale");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemCode")
                        .HasMaxLength(255);

                    b.Property<long>("ItemId");

                    b.Property<string>("ItemName")
                        .HasMaxLength(1000);

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Quantity");

                    b.Property<string>("Remark");

                    b.Property<int>("SPKDocsId");

                    b.Property<double>("SendQuantity");

                    b.Property<string>("Size")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("Uom")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ExpeditionSPKDocItems");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.InventoryModel.Inventory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("ItemCode")
                        .HasMaxLength(255);

                    b.Property<double>("ItemDomesticCOGS");

                    b.Property<double>("ItemDomesticRetail");

                    b.Property<double>("ItemDomesticSale");

                    b.Property<double>("ItemDomesticWholeSale");

                    b.Property<long>("ItemId");

                    b.Property<double>("ItemInternationalCOGS");

                    b.Property<double>("ItemInternationalRetail");

                    b.Property<double>("ItemInternationalSale");

                    b.Property<double>("ItemInternationalWholeSale");

                    b.Property<string>("ItemName")
                        .HasMaxLength(255);

                    b.Property<string>("ItemSize")
                        .HasMaxLength(255);

                    b.Property<string>("ItemUom")
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Quantity");

                    b.Property<string>("StorageCode")
                        .HasMaxLength(255);

                    b.Property<long>("StorageId");

                    b.Property<bool>("StorageIsCentral");

                    b.Property<string>("StorageName")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.InventoryModel.InventoryMovement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<double>("After");

                    b.Property<double>("Before");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("ItemCode")
                        .HasMaxLength(255);

                    b.Property<double>("ItemDomesticCOGS");

                    b.Property<double>("ItemDomesticRetail");

                    b.Property<double>("ItemDomesticSale");

                    b.Property<double>("ItemDomesticWholeSale");

                    b.Property<long>("ItemId");

                    b.Property<double>("ItemInternationalCOGS");

                    b.Property<double>("ItemInternationalRetail");

                    b.Property<double>("ItemInternationalSale");

                    b.Property<double>("ItemInternationalWholeSale");

                    b.Property<string>("ItemName")
                        .HasMaxLength(255);

                    b.Property<string>("ItemSize")
                        .HasMaxLength(255);

                    b.Property<string>("ItemUom")
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Quantity");

                    b.Property<string>("Reference")
                        .HasMaxLength(255);

                    b.Property<string>("Remark")
                        .HasMaxLength(1000);

                    b.Property<string>("StorageCode")
                        .HasMaxLength(255);

                    b.Property<long>("StorageId");

                    b.Property<bool>("StorageIsCentral");

                    b.Property<string>("StorageName")
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("InventoryMovements");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.SPKDocsModel.SPKDocs", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DestinationCode")
                        .HasMaxLength(255);

                    b.Property<long>("DestinationId");

                    b.Property<string>("DestinationName")
                        .HasMaxLength(1000);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsDistributed");

                    b.Property<bool>("IsDraft");

                    b.Property<bool>("IsReceived");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("PackingList")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .HasMaxLength(255);

                    b.Property<string>("Reference")
                        .HasMaxLength(255);

                    b.Property<string>("SourceCode")
                        .HasMaxLength(255);

                    b.Property<long>("SourceId");

                    b.Property<string>("SourceName")
                        .HasMaxLength(1000);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("PackingList")
                        .IsUnique()
                        .HasFilter("[IsDeleted]=(0) AND [CreatedUtc]>CONVERT([datetime2],'2020-02-01 00:00:00.0000000')");

                    b.ToTable("SPKDocs");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.SPKDocsModel.SPKDocsItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("ItemCode")
                        .HasMaxLength(255);

                    b.Property<double>("ItemDomesticCOGS");

                    b.Property<double>("ItemDomesticRetail");

                    b.Property<double>("ItemDomesticSale");

                    b.Property<double>("ItemDomesticWholesale");

                    b.Property<long>("ItemId");

                    b.Property<string>("ItemName")
                        .HasMaxLength(1000);

                    b.Property<string>("ItemSize")
                        .HasMaxLength(255);

                    b.Property<string>("ItemUom")
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Quantity");

                    b.Property<string>("Remark");

                    b.Property<long>("SPKDocsId");

                    b.Property<double>("SendQuantity");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("SPKDocsId");

                    b.ToTable("SPKDocsItems");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferInDoc", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DestinationCode")
                        .HasMaxLength(255);

                    b.Property<long>("DestinationId");

                    b.Property<string>("DestinationName")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Reference")
                        .HasMaxLength(255);

                    b.Property<string>("Remark")
                        .HasMaxLength(1000);

                    b.Property<string>("SourceCode")
                        .HasMaxLength(255);

                    b.Property<long>("SourceId");

                    b.Property<string>("SourceName")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("TransferInDocs");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferInDocItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("ArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("DomesticCOGS");

                    b.Property<double>("DomesticRetail");

                    b.Property<double>("DomesticSale");

                    b.Property<double>("DomesticWholeSale");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemCode")
                        .HasMaxLength(255);

                    b.Property<long>("ItemId");

                    b.Property<string>("ItemName")
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Quantity");

                    b.Property<string>("Remark")
                        .HasMaxLength(1000);

                    b.Property<string>("Size");

                    b.Property<long>("TransferDocsId");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("Uom");

                    b.HasKey("Id");

                    b.HasIndex("TransferDocsId");

                    b.ToTable("TransferInDocItems");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferOutDoc", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DestinationCode")
                        .HasMaxLength(255);

                    b.Property<long>("DestinationId");

                    b.Property<string>("DestinationName")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Reference")
                        .HasMaxLength(255);

                    b.Property<string>("Remark")
                        .HasMaxLength(1000);

                    b.Property<string>("SourceCode")
                        .HasMaxLength(255);

                    b.Property<long>("SourceId");

                    b.Property<string>("SourceName")
                        .HasMaxLength(255);

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("TransferOutDocs");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferOutDocItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("ArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<double>("DomesticCOGS");

                    b.Property<double>("DomesticRetail");

                    b.Property<double>("DomesticSale");

                    b.Property<double>("DomesticWholeSale");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ItemCode")
                        .HasMaxLength(255);

                    b.Property<long>("ItemId");

                    b.Property<string>("ItemName")
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<double>("Quantity");

                    b.Property<string>("Remark")
                        .HasMaxLength(1000);

                    b.Property<string>("Size");

                    b.Property<long>("TransferOutDocsId");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("Uom");

                    b.HasKey("Id");

                    b.HasIndex("TransferOutDocsId");

                    b.ToTable("TransferOutDocItems");
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.SPKDocsModel.SPKDocsItem", b =>
                {
                    b.HasOne("Com.Anqa.Service.Warehouse.Lib.Models.SPKDocsModel.SPKDocs", "SPKDocs")
                        .WithMany("Items")
                        .HasForeignKey("SPKDocsId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferInDocItem", b =>
                {
                    b.HasOne("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferInDoc", "TransferInDocs")
                        .WithMany("Items")
                        .HasForeignKey("TransferDocsId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferOutDocItem", b =>
                {
                    b.HasOne("Com.Anqa.Service.Warehouse.Lib.Models.TransferModel.TransferOutDoc", "TransferOutDoc")
                        .WithMany("Items")
                        .HasForeignKey("TransferOutDocsId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
