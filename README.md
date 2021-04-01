# CSharp.27.LINQ

es un lenguaje similar a sql que se puede usar en
json files
datos en memoria
datos extraidos de bd

tiene el sig formato:
```csharp
var librosDeSantiago = from libro in libros
where libro.Autor == "Santiago Posteguillo"
select libro;
```

