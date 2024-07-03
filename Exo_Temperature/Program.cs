using Exo_Temperature.Models;

Celsius c1 = new Celsius();
c1.Temperature = 42;
Fahrenheit f1 = new Fahrenheit();
f1.Temperature = 33.3;


// Utilisation "simple"
// - Conversion via méthode 
Fahrenheit f2 = c1.ToFahrenheit();
Celsius c2 = f1.ToCelsius();


// Utilisation "via surcharge d'operateur"
// - Conversion implicite
Fahrenheit f3 = c1;
// - Conversion explicite (→ Cast)
Celsius c3 = (Celsius)f1;

