# api.net.template

Usa dotnet ef dbcontext scaffold para generar las clases.

```sh
dotnet ef dbcontext scaffold "Server=TU_SERVIDOR;Database=TU_BD;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f
```

Parámetros útiles:

- -o Models: Carpeta donde se guardarán las clases.

- -f: Fuerza la sobrescritura si ya existen archivos.

- Puedes filtrar tablas con -t NombreTabla.

💡 Si no tienes dotnet-ef, instálalo con:

```sh
dotnet tool install --global dotnet-ef
```
