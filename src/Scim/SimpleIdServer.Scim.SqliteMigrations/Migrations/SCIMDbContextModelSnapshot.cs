﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleIdServer.Scim.Persistence.EF;

#nullable disable

namespace SimpleIdServer.Scim.SqliteMigrations.Migrations
{
    [DbContext(typeof(SCIMDbContext))]
    partial class SCIMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("scim")
                .HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("SCIMRepresentationSCIMSchema", b =>
                {
                    b.Property<string>("RepresentationsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SchemasId")
                        .HasColumnType("TEXT");

                    b.HasKey("RepresentationsId", "SchemasId");

                    b.HasIndex("SchemasId");

                    b.ToTable("SCIMRepresentationSCIMSchema", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceType")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ProvisioningConfigurations", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Exception")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExecutionDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvisioningConfigurationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RepresentationId")
                        .HasColumnType("TEXT");

                    b.Property<int>("RepresentationVersion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WorkflowId")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowInstanceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProvisioningConfigurationId");

                    b.ToTable("ProvisioningConfigurationHistory", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsArray")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvisioningConfigurationId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProvisioningConfigurationRecordId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ValuesString")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProvisioningConfigurationId");

                    b.HasIndex("ProvisioningConfigurationRecordId");

                    b.ToTable("ProvisioningConfigurationRecord", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.Realm", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Realms", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMAttributeMapping", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Mode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SourceAttributeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceAttributeSelector")
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceResourceType")
                        .HasColumnType("TEXT");

                    b.Property<string>("TargetAttributeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TargetResourceType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SCIMAttributeMappingLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExternalId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("RealmName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceType")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SCIMRepresentationLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AttributeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ComputedValueIndex")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullPath")
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsComputed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Namespace")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentAttributeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RepresentationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceType")
                        .HasColumnType("TEXT");

                    b.Property<string>("SchemaAttributeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValueBinary")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("ValueBoolean")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ValueDateTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("ValueDecimal")
                        .HasPrecision(18, 2)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ValueInteger")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ValueReference")
                        .HasColumnType("TEXT");

                    b.Property<string>("ValueString")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FullPath");

                    b.HasIndex("ParentAttributeId");

                    b.HasIndex("RepresentationId");

                    b.HasIndex("SchemaAttributeId");

                    b.HasIndex("ValueString");

                    b.ToTable("SCIMRepresentationAttributeLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchema", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRootSchema")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResourceType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SCIMSchemaLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaAttribute", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CanonicalValues")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CaseExact")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DefaultValueInt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefaultValueString")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullPath")
                        .HasColumnType("TEXT");

                    b.Property<bool>("MultiValued")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mutability")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReferenceTypes")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Required")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Returned")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SchemaId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Uniqueness")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SchemaId");

                    b.ToTable("SCIMSchemaAttribute", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaExtension", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Required")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SCIMSchemaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Schema")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SCIMSchemaId");

                    b.ToTable("SCIMSchemaExtension", "scim");
                });

            modelBuilder.Entity("SCIMRepresentationSCIMSchema", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMRepresentation", null)
                        .WithMany()
                        .HasForeignKey("RepresentationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchema", null)
                        .WithMany()
                        .HasForeignKey("SchemasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationHistory", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", "ProvisioningConfiguration")
                        .WithMany("HistoryLst")
                        .HasForeignKey("ProvisioningConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ProvisioningConfiguration");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", null)
                        .WithMany("Records")
                        .HasForeignKey("ProvisioningConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", null)
                        .WithMany("Values")
                        .HasForeignKey("ProvisioningConfigurationRecordId");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", null)
                        .WithMany("Children")
                        .HasForeignKey("ParentAttributeId");

                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMRepresentation", "Representation")
                        .WithMany("FlatAttributes")
                        .HasForeignKey("RepresentationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchemaAttribute", "SchemaAttribute")
                        .WithMany()
                        .HasForeignKey("SchemaAttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Representation");

                    b.Navigation("SchemaAttribute");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaAttribute", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchema", null)
                        .WithMany("Attributes")
                        .HasForeignKey("SchemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaExtension", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchema", null)
                        .WithMany("SchemaExtensions")
                        .HasForeignKey("SCIMSchemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", b =>
                {
                    b.Navigation("HistoryLst");

                    b.Navigation("Records");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentation", b =>
                {
                    b.Navigation("FlatAttributes");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchema", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("SchemaExtensions");
                });
#pragma warning restore 612, 618
        }
    }
}
