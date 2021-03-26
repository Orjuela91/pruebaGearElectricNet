lenguaje: c#
Framework: ASP.NET Core
ORM: Entity Framework

1) despues de clonar el proyecto hay que ir al manejador de paquetes nuget y descargar las depencias que el proyecto tiene instaladas.
2) crear una base de datos local en visual studio que se llame GearElectric.

3) agregar la cadena de conexion al archivo appsettings.json =>
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GearElectric;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
  4) abrir una terminal en visual studio y ejecutar el comando Add-migration
  5) ejecutar el proyecto.
  
  Nota: imagen configuracion https://ibb.co/vQC4JxR
