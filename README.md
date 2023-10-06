# JuanAndres-Veterinaria

## Cambios en la Base de datos

 - Se reemplazaron las tablas de MoviminetoMedicamento y DetalleMedicamento por -> EntradaMedicamneto y Salida Medicamento; en cada  una se especifica cuanto entro o salio, el precio y la fecha del movimineto.Se elimino la tabla de tipo de movimineto ya que se creo una tabla por tipo de movimiento 
## Registros creados Roles 
[
  {
    "nombre": "Admin"
  },
{
    "nombre": "Empleado"
  },
{
    "nombre": "Cliente"
  }
]
## Registros creados Usuario 
{
  "userName": "Pdr",
  "email": "p@gmail.com",
  "password": "123",
  "rolId": 2
}
{
  "userName": "Jn",
  "email": "j@gmail.com",
  "password": "123",
  "rolId": 1
}
{
  "userName": "Ttis",
  "email": "t@gmail.com",
  "password": "123",
  "rolId": 1
}
## Registros creados de Veterinarios 
[
  {
    "nombre": "Juan Andres",
    "correoElectronico": "j@gmail.com",
    "telefono": "1232",
    "especialidad": "cirujano",
"iD_Usuario":1

  },
{
    "nombre": "Tatiana",
    "correoElectronico": "t@gmail.com",
    "telefono": "12325",
    "especialidad": "cirujano",
"iD_Usuario":2
  },
{
    "nombre": "Pablo",
    "correoElectronico": "p@gmail.com",
    "telefono": "124332",
    "especialidad": "parasitologo",
"iD_Usuario":3
  }

]
## Registros creados Laboratorios
[
  {
    "nombre": "Genfar",
    "direccion": "Calle 23 89",
    "telefono": "123"
  },
{
    "nombre": "LabsCenter",
    "direccion": "Calle 23 88",
    "telefono": "1234"
  }

]
## Registros creados Medicamentos 
[
  {
    "nombre": "Penicilina",
    "cantidadDisponible": 50,
    "precio": 50,
    "iD_Laboratorio": 1
  },
{
    "nombre": "Amoxicilina",
    "cantidadDisponible": 50,
    "precio": 10,
    "iD_Laboratorio": 1
  },
{
    "nombre": "Ibuprofeno",
    "cantidadDisponible": 30,
    "precio": 35,
    "iD_Laboratorio": 2
  },
    {
    "nombre": "Crema Topica de Hongos",
    "cantidadDisponible": 30,
    "precio": 70000,
    "iD_Laboratorio": 1
  }
]
##  Registros creados Especies 
 [
  {
    "nombre": "Felina"
  },
{
    "nombre": "Canina"
  }

]
##  Registros creados Razas
[
  {
    "nombre": "Dobberman",
    "iD_Especie": 2
  },
 {
    "nombre": "Siames",
    "iD_Especie": 1
  }
]

## Documentacion Endpoints
- Consulta 1. Autorizacion  CON ROL Admin con paginacion
endpoint = http://localhost:5159/Veterinario/especialidad-Cirujano?PageSize=2&PageIndex=1&Search=%22%22

- Consulta 2. Usuario debe estar autorizado o logueado con paginacion
endpoint  = http://localhost:5159/Medicamento/Laboratorios-Genfar?PageSize=5&PageIndex=1&Search=%22%22

- Consulta 3. Endpoint con version 1.1 con paginacion
endpoint = http://localhost:5159/Mascota/especie-felina?PageSize=5&PageIndex=1&Search=%22%22

- Consulta 4. 
endpoint = http://localhost:5159/Propietario/propietariosYMascotas

- Consulta 5. Usuario debe estar autorizado o logueado
endpoint = http://localhost:5159/Medicamento/precioMayorA-50000

-Consulta 6. Autorizacion  CON ROL Admin
endpoint = http://localhost:5159/Mascota/MascotasVacunadasPrimerTimestre2023