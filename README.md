# Ejercicio de Manejo de Fechas

Realice una clase utilitaria de manejo de tiempo y fechas que tenga al menos:

### Métodos:
- `ObtenerDiasCalendario()`: Obtiene los dias entre dos fechas.
- `ObtenerDiasLaborables()`: Obtiene los dias laborables entre dos fechas (fines de semana y feriados no son dias laborables).
- `SumarDiasLaborables()`: Obtiene una fecha sumando una cantidad de dias laborables a una fecha inicial.

### Consideraciones:
Puedes crear un arreglo de feriados aleatorios en el año

## `Program`
1. Crea una instancia de la clase utilitaria.
2. Crea dos variables de tipo fecha, una fecha de inicio y una fecha de final.
3. Utiliza el método ObtenerDiasCalendario() con las dos variables.
4. Crea un List<> con los feriados que tu decidas.
5. Utiliza el método ObtenerDiasLaborables() con las dos variables de tipo fecha y la lista de feriados.
6. Utiliza el método SumarDiasLaborables() con la fecha de inicio.

## Instrucciones

1. Ejecuta el programa.
2. Observa las salidas en la consola.

## Ejecución del Programa
```
+-------------------------------------------------------------------------------+
|                                  OUTPUT                                       |
+-------------------------------------------------------------------------------+
| Days between '1/1/2024 00:00:00' and '15/1/2024 00:00:00' is 14 days.         |
| Working days between '1/1/2024 00:00:00' and '15/1/2024 00:00:00' is 9 days.  |
| New date adding '5' working days to '1/1/2024 00:00:00' is: 9/1/2024 00:00:00 |
+-------------------------------------------------------------------------------+
```


