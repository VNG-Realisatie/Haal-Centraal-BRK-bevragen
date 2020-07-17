# Test cases
Hier vind je een aantal csv bestanden in te lezen in bijvoorbeeld Calc, Excel of Google sheets. Hierin zie je per resource in welke testgevallen je bepaalde soorten gegevens kunt vinden.

Bijvoorbeeld:
|                                 | 76870487970000 | 76870488070000 | 76870482670000    |
| aardCultuurBebouwd{}            | X              | X              |                   |
| aardCultuurOnbebouwd{}          |                | X              |                   |			
| adressen[{}]                    | 1              | 2              | 1                 |
|   koppelingswijze{}             | X              | X              | X                 |
|   nummeraanduidingIdentificatie |	X              | X              | X                 |
| type()                          | perceel        | perceel        | appartementsrecht |

De bovenste rij bevat de identificaties van de test-resources.
De linker kolom(men) bevatten de namen van properties van de resource.
Aan het einde van een propertynaam toegevoegde
- "{}" betekent dat dit property een object (gegevensgroep) is.
- "[]" betekent dat dit property een array is.
- "[{}]" betekent dat dit property een array van objecten is.
- "()" betekent dat dit property een enumeratie is.

Bij een testgeval betekent
- "X" dat dit testgeval een waarde heeft voor het betreffende gegeven.
- Een getal dat het aantal items van het gegeven het testgeval heeft.
- Tekst dat dit de enumeratiewaarde is van het gegeven bij dit testgeval.
