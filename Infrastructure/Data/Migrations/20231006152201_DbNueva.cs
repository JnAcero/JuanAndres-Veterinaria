using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbNueva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Mascota_ID_Mascota",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_Cita_Veterinario_ID_Veterinario",
                table: "Cita");

            migrationBuilder.DropForeignKey(
                name: "FK_EntradaMedicamento_Medicamento_ID_Medicamento",
                table: "EntradaMedicamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_Especie_ID_Especie",
                table: "Mascota");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_Propietario_ID_Propietario",
                table: "Mascota");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_Raza_ID_Raza",
                table: "Mascota");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicamento_Laboratorio_ID_Laboratorio",
                table: "Medicamento");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoPoveedor_Medicamento_ID_Medicamento",
                table: "MedicamentoPoveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoPoveedor_Proveedor_ID_Proveedor",
                table: "MedicamentoPoveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietario_Usuarios_ID_Usuario",
                table: "Propietario");

            migrationBuilder.DropForeignKey(
                name: "FK_Raza_Especie_ID_Especie",
                table: "Raza");

            migrationBuilder.DropForeignKey(
                name: "FK_SalidaMedicamento_Medicamento_ID_Medicamento",
                table: "SalidaMedicamento");

            migrationBuilder.DropForeignKey(
                name: "FK_TratamientoMedico_Cita_ID_Cita",
                table: "TratamientoMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TratamientoMedico_Medicamento_ID_Medicamento",
                table: "TratamientoMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinario_Usuarios_ID_Usuario",
                table: "Veterinario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinario",
                table: "Veterinario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TratamientoMedico",
                table: "TratamientoMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalidaMedicamento",
                table: "SalidaMedicamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Raza",
                table: "Raza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Propietario",
                table: "Propietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicamento",
                table: "Medicamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mascota",
                table: "Mascota");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laboratorio",
                table: "Laboratorio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especie",
                table: "Especie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntradaMedicamento",
                table: "EntradaMedicamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cita",
                table: "Cita");

            migrationBuilder.RenameTable(
                name: "Veterinario",
                newName: "Veterinarios");

            migrationBuilder.RenameTable(
                name: "TratamientoMedico",
                newName: "TratamientoMedicos");

            migrationBuilder.RenameTable(
                name: "SalidaMedicamento",
                newName: "SalidasMedicamentos");

            migrationBuilder.RenameTable(
                name: "Raza",
                newName: "Razas");

            migrationBuilder.RenameTable(
                name: "Proveedor",
                newName: "Proveedores");

            migrationBuilder.RenameTable(
                name: "Propietario",
                newName: "Propietarios");

            migrationBuilder.RenameTable(
                name: "Medicamento",
                newName: "Medicamentos");

            migrationBuilder.RenameTable(
                name: "Mascota",
                newName: "Mascotas");

            migrationBuilder.RenameTable(
                name: "Laboratorio",
                newName: "Laboratorios");

            migrationBuilder.RenameTable(
                name: "Especie",
                newName: "Especies");

            migrationBuilder.RenameTable(
                name: "EntradaMedicamento",
                newName: "EntradasMedicamentos");

            migrationBuilder.RenameTable(
                name: "Cita",
                newName: "Citas");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinario_ID_Usuario",
                table: "Veterinarios",
                newName: "IX_Veterinarios_ID_Usuario");

            migrationBuilder.RenameIndex(
                name: "IX_TratamientoMedico_ID_Medicamento",
                table: "TratamientoMedicos",
                newName: "IX_TratamientoMedicos_ID_Medicamento");

            migrationBuilder.RenameIndex(
                name: "IX_TratamientoMedico_ID_Cita",
                table: "TratamientoMedicos",
                newName: "IX_TratamientoMedicos_ID_Cita");

            migrationBuilder.RenameIndex(
                name: "IX_SalidaMedicamento_ID_Medicamento",
                table: "SalidasMedicamentos",
                newName: "IX_SalidasMedicamentos_ID_Medicamento");

            migrationBuilder.RenameIndex(
                name: "IX_Raza_ID_Especie",
                table: "Razas",
                newName: "IX_Razas_ID_Especie");

            migrationBuilder.RenameIndex(
                name: "IX_Propietario_ID_Usuario",
                table: "Propietarios",
                newName: "IX_Propietarios_ID_Usuario");

            migrationBuilder.RenameIndex(
                name: "IX_Medicamento_ID_Laboratorio",
                table: "Medicamentos",
                newName: "IX_Medicamentos_ID_Laboratorio");

            migrationBuilder.RenameIndex(
                name: "IX_Mascota_ID_Raza",
                table: "Mascotas",
                newName: "IX_Mascotas_ID_Raza");

            migrationBuilder.RenameIndex(
                name: "IX_Mascota_ID_Propietario",
                table: "Mascotas",
                newName: "IX_Mascotas_ID_Propietario");

            migrationBuilder.RenameIndex(
                name: "IX_Mascota_ID_Especie",
                table: "Mascotas",
                newName: "IX_Mascotas_ID_Especie");

            migrationBuilder.RenameIndex(
                name: "IX_EntradaMedicamento_ID_Medicamento",
                table: "EntradasMedicamentos",
                newName: "IX_EntradasMedicamentos_ID_Medicamento");

            migrationBuilder.RenameIndex(
                name: "IX_Cita_ID_Veterinario",
                table: "Citas",
                newName: "IX_Citas_ID_Veterinario");

            migrationBuilder.RenameIndex(
                name: "IX_Cita_ID_Mascota",
                table: "Citas",
                newName: "IX_Citas_ID_Mascota");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TratamientoMedicos",
                table: "TratamientoMedicos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalidasMedicamentos",
                table: "SalidasMedicamentos",
                column: "ID_Salida");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Razas",
                table: "Razas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Propietarios",
                table: "Propietarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicamentos",
                table: "Medicamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mascotas",
                table: "Mascotas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laboratorios",
                table: "Laboratorios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especies",
                table: "Especies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntradasMedicamentos",
                table: "EntradasMedicamentos",
                column: "ID_Entrada");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citas",
                table: "Citas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Mascotas_ID_Mascota",
                table: "Citas",
                column: "ID_Mascota",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Veterinarios_ID_Veterinario",
                table: "Citas",
                column: "ID_Veterinario",
                principalTable: "Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradasMedicamentos_Medicamentos_ID_Medicamento",
                table: "EntradasMedicamentos",
                column: "ID_Medicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Especies_ID_Especie",
                table: "Mascotas",
                column: "ID_Especie",
                principalTable: "Especies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Propietarios_ID_Propietario",
                table: "Mascotas",
                column: "ID_Propietario",
                principalTable: "Propietarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Razas_ID_Raza",
                table: "Mascotas",
                column: "ID_Raza",
                principalTable: "Razas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoPoveedor_Medicamentos_ID_Medicamento",
                table: "MedicamentoPoveedor",
                column: "ID_Medicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoPoveedor_Proveedores_ID_Proveedor",
                table: "MedicamentoPoveedor",
                column: "ID_Proveedor",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_Laboratorios_ID_Laboratorio",
                table: "Medicamentos",
                column: "ID_Laboratorio",
                principalTable: "Laboratorios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietarios_Usuarios_ID_Usuario",
                table: "Propietarios",
                column: "ID_Usuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Razas_Especies_ID_Especie",
                table: "Razas",
                column: "ID_Especie",
                principalTable: "Especies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalidasMedicamentos_Medicamentos_ID_Medicamento",
                table: "SalidasMedicamentos",
                column: "ID_Medicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TratamientoMedicos_Citas_ID_Cita",
                table: "TratamientoMedicos",
                column: "ID_Cita",
                principalTable: "Citas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TratamientoMedicos_Medicamentos_ID_Medicamento",
                table: "TratamientoMedicos",
                column: "ID_Medicamento",
                principalTable: "Medicamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinarios_Usuarios_ID_Usuario",
                table: "Veterinarios",
                column: "ID_Usuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Mascotas_ID_Mascota",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Veterinarios_ID_Veterinario",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_EntradasMedicamentos_Medicamentos_ID_Medicamento",
                table: "EntradasMedicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Especies_ID_Especie",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Propietarios_ID_Propietario",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Razas_ID_Raza",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoPoveedor_Medicamentos_ID_Medicamento",
                table: "MedicamentoPoveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentoPoveedor_Proveedores_ID_Proveedor",
                table: "MedicamentoPoveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_Laboratorios_ID_Laboratorio",
                table: "Medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Propietarios_Usuarios_ID_Usuario",
                table: "Propietarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Razas_Especies_ID_Especie",
                table: "Razas");

            migrationBuilder.DropForeignKey(
                name: "FK_SalidasMedicamentos_Medicamentos_ID_Medicamento",
                table: "SalidasMedicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_TratamientoMedicos_Citas_ID_Cita",
                table: "TratamientoMedicos");

            migrationBuilder.DropForeignKey(
                name: "FK_TratamientoMedicos_Medicamentos_ID_Medicamento",
                table: "TratamientoMedicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinarios_Usuarios_ID_Usuario",
                table: "Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TratamientoMedicos",
                table: "TratamientoMedicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalidasMedicamentos",
                table: "SalidasMedicamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Razas",
                table: "Razas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proveedores",
                table: "Proveedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Propietarios",
                table: "Propietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicamentos",
                table: "Medicamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mascotas",
                table: "Mascotas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laboratorios",
                table: "Laboratorios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Especies",
                table: "Especies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntradasMedicamentos",
                table: "EntradasMedicamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citas",
                table: "Citas");

            migrationBuilder.RenameTable(
                name: "Veterinarios",
                newName: "Veterinario");

            migrationBuilder.RenameTable(
                name: "TratamientoMedicos",
                newName: "TratamientoMedico");

            migrationBuilder.RenameTable(
                name: "SalidasMedicamentos",
                newName: "SalidaMedicamento");

            migrationBuilder.RenameTable(
                name: "Razas",
                newName: "Raza");

            migrationBuilder.RenameTable(
                name: "Proveedores",
                newName: "Proveedor");

            migrationBuilder.RenameTable(
                name: "Propietarios",
                newName: "Propietario");

            migrationBuilder.RenameTable(
                name: "Medicamentos",
                newName: "Medicamento");

            migrationBuilder.RenameTable(
                name: "Mascotas",
                newName: "Mascota");

            migrationBuilder.RenameTable(
                name: "Laboratorios",
                newName: "Laboratorio");

            migrationBuilder.RenameTable(
                name: "Especies",
                newName: "Especie");

            migrationBuilder.RenameTable(
                name: "EntradasMedicamentos",
                newName: "EntradaMedicamento");

            migrationBuilder.RenameTable(
                name: "Citas",
                newName: "Cita");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinarios_ID_Usuario",
                table: "Veterinario",
                newName: "IX_Veterinario_ID_Usuario");

            migrationBuilder.RenameIndex(
                name: "IX_TratamientoMedicos_ID_Medicamento",
                table: "TratamientoMedico",
                newName: "IX_TratamientoMedico_ID_Medicamento");

            migrationBuilder.RenameIndex(
                name: "IX_TratamientoMedicos_ID_Cita",
                table: "TratamientoMedico",
                newName: "IX_TratamientoMedico_ID_Cita");

            migrationBuilder.RenameIndex(
                name: "IX_SalidasMedicamentos_ID_Medicamento",
                table: "SalidaMedicamento",
                newName: "IX_SalidaMedicamento_ID_Medicamento");

            migrationBuilder.RenameIndex(
                name: "IX_Razas_ID_Especie",
                table: "Raza",
                newName: "IX_Raza_ID_Especie");

            migrationBuilder.RenameIndex(
                name: "IX_Propietarios_ID_Usuario",
                table: "Propietario",
                newName: "IX_Propietario_ID_Usuario");

            migrationBuilder.RenameIndex(
                name: "IX_Medicamentos_ID_Laboratorio",
                table: "Medicamento",
                newName: "IX_Medicamento_ID_Laboratorio");

            migrationBuilder.RenameIndex(
                name: "IX_Mascotas_ID_Raza",
                table: "Mascota",
                newName: "IX_Mascota_ID_Raza");

            migrationBuilder.RenameIndex(
                name: "IX_Mascotas_ID_Propietario",
                table: "Mascota",
                newName: "IX_Mascota_ID_Propietario");

            migrationBuilder.RenameIndex(
                name: "IX_Mascotas_ID_Especie",
                table: "Mascota",
                newName: "IX_Mascota_ID_Especie");

            migrationBuilder.RenameIndex(
                name: "IX_EntradasMedicamentos_ID_Medicamento",
                table: "EntradaMedicamento",
                newName: "IX_EntradaMedicamento_ID_Medicamento");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_ID_Veterinario",
                table: "Cita",
                newName: "IX_Cita_ID_Veterinario");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_ID_Mascota",
                table: "Cita",
                newName: "IX_Cita_ID_Mascota");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinario",
                table: "Veterinario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TratamientoMedico",
                table: "TratamientoMedico",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalidaMedicamento",
                table: "SalidaMedicamento",
                column: "ID_Salida");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Raza",
                table: "Raza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proveedor",
                table: "Proveedor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Propietario",
                table: "Propietario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicamento",
                table: "Medicamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mascota",
                table: "Mascota",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laboratorio",
                table: "Laboratorio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Especie",
                table: "Especie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntradaMedicamento",
                table: "EntradaMedicamento",
                column: "ID_Entrada");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cita",
                table: "Cita",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Mascota_ID_Mascota",
                table: "Cita",
                column: "ID_Mascota",
                principalTable: "Mascota",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cita_Veterinario_ID_Veterinario",
                table: "Cita",
                column: "ID_Veterinario",
                principalTable: "Veterinario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradaMedicamento_Medicamento_ID_Medicamento",
                table: "EntradaMedicamento",
                column: "ID_Medicamento",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_Especie_ID_Especie",
                table: "Mascota",
                column: "ID_Especie",
                principalTable: "Especie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_Propietario_ID_Propietario",
                table: "Mascota",
                column: "ID_Propietario",
                principalTable: "Propietario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_Raza_ID_Raza",
                table: "Mascota",
                column: "ID_Raza",
                principalTable: "Raza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamento_Laboratorio_ID_Laboratorio",
                table: "Medicamento",
                column: "ID_Laboratorio",
                principalTable: "Laboratorio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoPoveedor_Medicamento_ID_Medicamento",
                table: "MedicamentoPoveedor",
                column: "ID_Medicamento",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentoPoveedor_Proveedor_ID_Proveedor",
                table: "MedicamentoPoveedor",
                column: "ID_Proveedor",
                principalTable: "Proveedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Propietario_Usuarios_ID_Usuario",
                table: "Propietario",
                column: "ID_Usuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Raza_Especie_ID_Especie",
                table: "Raza",
                column: "ID_Especie",
                principalTable: "Especie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalidaMedicamento_Medicamento_ID_Medicamento",
                table: "SalidaMedicamento",
                column: "ID_Medicamento",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TratamientoMedico_Cita_ID_Cita",
                table: "TratamientoMedico",
                column: "ID_Cita",
                principalTable: "Cita",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TratamientoMedico_Medicamento_ID_Medicamento",
                table: "TratamientoMedico",
                column: "ID_Medicamento",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinario_Usuarios_ID_Usuario",
                table: "Veterinario",
                column: "ID_Usuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
