using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormAutomationApi.Migrations
{
    /// <inheritdoc />
    public partial class AddArchivedFormsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_documentversion_documenttype_DocumentTypeId",
                table: "documentversion");

            migrationBuilder.DropForeignKey(
                name: "FK_officedocumentrequirement_office_OfficeId",
                table: "officedocumentrequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_patientpharamcy_patient_PatientId",
                table: "patientpharamcy");

            migrationBuilder.DropForeignKey(
                name: "FK_signeddocument_intakeplan_IntakePacketId",
                table: "signeddocument");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patientpharamcy",
                table: "patientpharamcy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_intakeplan",
                table: "intakeplan");

            migrationBuilder.DropColumn(
                name: "FamilyNumberName",
                table: "hipaafamilymember");

            migrationBuilder.DropColumn(
                name: "PackedDate",
                table: "intakeplan");

            migrationBuilder.RenameTable(
                name: "patientpharamcy",
                newName: "patientpharmacy");

            migrationBuilder.RenameTable(
                name: "intakeplan",
                newName: "intakepacket");

            migrationBuilder.RenameColumn(
                name: "Representative",
                table: "signeddocument",
                newName: "RepresentativeAuthority");

            migrationBuilder.RenameColumn(
                name: "RelationshipType",
                table: "patientinsurance",
                newName: "RelationshipToPatient");

            migrationBuilder.RenameIndex(
                name: "IX_patientpharamcy_PatientId",
                table: "patientpharmacy",
                newName: "IX_patientpharmacy_PatientId");

            migrationBuilder.AlterColumn<string>(
                name: "ResponseType",
                table: "signeddocumentresponse",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "QuestionCode",
                table: "signeddocumentresponse",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderName",
                table: "patientprovider",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientprovider",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientinsurance",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverageType",
                table: "patientinsurance",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientemployment",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "patientdemographics",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "patient",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patient",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<string>(
                name: "Apt",
                table: "patient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Initials",
                table: "patient",
                type: "varchar(4)",
                maxLength: 4,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "officedocumentrequirement",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeName",
                table: "office",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PlanName",
                table: "insuranceplan",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PayerName",
                table: "insuranceplan",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "SignedDocumentId",
                table: "hipaafamilymember",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "hipaafamilymember",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FamilyMemberName",
                table: "hipaafamilymember",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsRepresentative",
                table: "hipaafamilymember",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "emergencycontact",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "emergencycontact",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "emergencycontact",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IsPrimary",
                table: "emergencycontact",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "emergencycontact",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactName",
                table: "emergencycontact",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "VersionLabel",
                table: "documentversion",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TemplatePath",
                table: "documentversion",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTypeId",
                table: "documentversion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "documenttype",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "documenttype",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PharmacyName",
                table: "patientpharmacy",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientpharmacy",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "intakepacket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "intakepacket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "intakepacket",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "intakepacket",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<DateTime>(
                name: "PacketDate",
                table: "intakepacket",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_patientpharmacy",
                table: "patientpharmacy",
                column: "PatientPharmacyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_intakepacket",
                table: "intakepacket",
                column: "IntakePacketId");

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FormIds = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FacilityIds = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArchivedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formsubmissions",
                columns: table => new
                {
                    SessionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    FormIds = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formsubmissions", x => x.SessionId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "patientsignature",
                columns: table => new
                {
                    PatientSignatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    SignatureData = table.Column<byte[]>(type: "longblob", nullable: false),
                    FileType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SignedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientsignature", x => x.PatientSignatureId);
                    table.ForeignKey(
                        name: "FK_patientsignature_patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_patientsignature_PatientId",
                table: "patientsignature",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_documentversion_documenttype_DocumentTypeId",
                table: "documentversion",
                column: "DocumentTypeId",
                principalTable: "documenttype",
                principalColumn: "DocumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_officedocumentrequirement_office_OfficeId",
                table: "officedocumentrequirement",
                column: "OfficeId",
                principalTable: "office",
                principalColumn: "OfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_patientpharmacy_patient_PatientId",
                table: "patientpharmacy",
                column: "PatientId",
                principalTable: "patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_signeddocument_intakepacket_IntakePacketId",
                table: "signeddocument",
                column: "IntakePacketId",
                principalTable: "intakepacket",
                principalColumn: "IntakePacketId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_documentversion_documenttype_DocumentTypeId",
                table: "documentversion");

            migrationBuilder.DropForeignKey(
                name: "FK_officedocumentrequirement_office_OfficeId",
                table: "officedocumentrequirement");

            migrationBuilder.DropForeignKey(
                name: "FK_patientpharmacy_patient_PatientId",
                table: "patientpharmacy");

            migrationBuilder.DropForeignKey(
                name: "FK_signeddocument_intakepacket_IntakePacketId",
                table: "signeddocument");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "formsubmissions");

            migrationBuilder.DropTable(
                name: "patientsignature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patientpharmacy",
                table: "patientpharmacy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_intakepacket",
                table: "intakepacket");

            migrationBuilder.DropColumn(
                name: "Apt",
                table: "patient");

            migrationBuilder.DropColumn(
                name: "Initials",
                table: "patient");

            migrationBuilder.DropColumn(
                name: "FamilyMemberName",
                table: "hipaafamilymember");

            migrationBuilder.DropColumn(
                name: "IsRepresentative",
                table: "hipaafamilymember");

            migrationBuilder.DropColumn(
                name: "PacketDate",
                table: "intakepacket");

            migrationBuilder.RenameTable(
                name: "patientpharmacy",
                newName: "patientpharamcy");

            migrationBuilder.RenameTable(
                name: "intakepacket",
                newName: "intakeplan");

            migrationBuilder.RenameColumn(
                name: "RepresentativeAuthority",
                table: "signeddocument",
                newName: "Representative");

            migrationBuilder.RenameColumn(
                name: "RelationshipToPatient",
                table: "patientinsurance",
                newName: "RelationshipType");

            migrationBuilder.RenameIndex(
                name: "IX_patientpharmacy_PatientId",
                table: "patientpharamcy",
                newName: "IX_patientpharamcy_PatientId");

            migrationBuilder.UpdateData(
                table: "signeddocumentresponse",
                keyColumn: "ResponseType",
                keyValue: null,
                column: "ResponseType",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ResponseType",
                table: "signeddocumentresponse",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "signeddocumentresponse",
                keyColumn: "QuestionCode",
                keyValue: null,
                column: "QuestionCode",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "QuestionCode",
                table: "signeddocumentresponse",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "patientprovider",
                keyColumn: "ProviderName",
                keyValue: null,
                column: "ProviderName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderName",
                table: "patientprovider",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientprovider",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientinsurance",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "patientinsurance",
                keyColumn: "CoverageType",
                keyValue: null,
                column: "CoverageType",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CoverageType",
                table: "patientinsurance",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientemployment",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "patientdemographics",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "patient",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patient",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "officedocumentrequirement",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "office",
                keyColumn: "OfficeName",
                keyValue: null,
                column: "OfficeName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeName",
                table: "office",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "insuranceplan",
                keyColumn: "PlanName",
                keyValue: null,
                column: "PlanName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PlanName",
                table: "insuranceplan",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "insuranceplan",
                keyColumn: "PayerName",
                keyValue: null,
                column: "PayerName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PayerName",
                table: "insuranceplan",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "SignedDocumentId",
                table: "hipaafamilymember",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "hipaafamilymember",
                keyColumn: "Relationship",
                keyValue: null,
                column: "Relationship",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "hipaafamilymember",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FamilyNumberName",
                table: "hipaafamilymember",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "emergencycontact",
                keyColumn: "Relationship",
                keyValue: null,
                column: "Relationship",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "emergencycontact",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "emergencycontact",
                keyColumn: "Phone",
                keyValue: null,
                column: "Phone",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "emergencycontact",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "emergencycontact",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IsPrimary",
                table: "emergencycontact",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "emergencycontact",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "emergencycontact",
                keyColumn: "ContactName",
                keyValue: null,
                column: "ContactName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ContactName",
                table: "emergencycontact",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "documentversion",
                keyColumn: "VersionLabel",
                keyValue: null,
                column: "VersionLabel",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "VersionLabel",
                table: "documentversion",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "documentversion",
                keyColumn: "TemplatePath",
                keyValue: null,
                column: "TemplatePath",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TemplatePath",
                table: "documentversion",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentTypeId",
                table: "documentversion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "documenttype",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "documenttype",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "documenttype",
                keyColumn: "Code",
                keyValue: null,
                column: "Code",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "documenttype",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "patientpharamcy",
                keyColumn: "PharmacyName",
                keyValue: null,
                column: "PharmacyName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PharmacyName",
                table: "patientpharamcy",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "patientpharamcy",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "intakeplan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfficeId",
                table: "intakeplan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "intakeplan",
                keyColumn: "LocationName",
                keyValue: null,
                column: "LocationName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "LocationName",
                table: "intakeplan",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "intakeplan",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PackedDate",
                table: "intakeplan",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_patientpharamcy",
                table: "patientpharamcy",
                column: "PatientPharmacyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_intakeplan",
                table: "intakeplan",
                column: "IntakePacketId");

            migrationBuilder.AddForeignKey(
                name: "FK_documentversion_documenttype_DocumentTypeId",
                table: "documentversion",
                column: "DocumentTypeId",
                principalTable: "documenttype",
                principalColumn: "DocumentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_officedocumentrequirement_office_OfficeId",
                table: "officedocumentrequirement",
                column: "OfficeId",
                principalTable: "office",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patientpharamcy_patient_PatientId",
                table: "patientpharamcy",
                column: "PatientId",
                principalTable: "patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_signeddocument_intakeplan_IntakePacketId",
                table: "signeddocument",
                column: "IntakePacketId",
                principalTable: "intakeplan",
                principalColumn: "IntakePacketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
