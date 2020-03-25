# StudVidurkiaiVGTU
## Integruotos programavimo aplinkos laboratorinis darbas v0.1


## Užduotis
> Parašykite programą, kuri nuskaito šiuos studentų duomenis:

>> **`vardą`** ir **`pavardę`**
>
>> **`n`** atliktų namų darbų (nd) rezultatus (10-balėje sistemoje), 
>
>> Taip pat egzamino (egz) rezultatą.
Tuomet iš šių duomenų, suskaičiuoja galutinį balą (galutinis):
>> #####  Galutinis = 0.3 * Vidurkis + 0.7 * Egzaminas



## Objektai / Masyvai
| objektas / masyvas | classpath |
| ------ | ------ | 
| studentai |StudVidurkiaiVGTU.Program |
## Objektų kintamieji
| Kintamasis | Classpath |Apibudinimas |
| ------ | ------ | ------ | 
| Vardas | StudVidurkiaiVGTU.Studentas | Studento vardas  |
| Pavarde | StudVidurkiaiVGTU.Studentas | Studento pavarde|
| Egzaminas | StudVidurkiaiVGTU.Studentas | Studento egzamino balas|
| NamuDarbai | StudVidurkiaiVGTU.Studentas | Namu darbai (List)|
| Mediana | StudVidurkiaiVGTU.Studentas | Namu darbu mediana|
| Vidurkis | StudVidurkiaiVGTU.Studentas | Namu darbu vidurkis|

## Funkcijos
| funkcija | apibrėžimas | classpath |
| ------ | ------ | ------ |
| ShowMenu() | Parodo pasirenkamajį meniu per konsolę| StudVidurkiaiVGTU.Program |
| PrintStudentsRezultatai() | Spausdina studentus ir jų paskaičiuotus balus pagal formules | StudVidurkiaiVGTU.Program |
| PrintStudents() | Spausdina studentus | StudVidurkiaiVGTU.Program |
| ReadInputFromConsole() | Nuskaito įvesti iš konsolės į Listą| StudVidurkiaiVGTU.StudentData |
| ReadRandomInput() | Sugeneruoja įvesti ir talpina į Listą | StudVidurkiaiVGTU.StudentData |
| ReadInputFromFile() | Ivesti gaunama is failo ir talpina į Listą | StudVidurkiaiVGTU.StudentData |
| GetVidurkis() | Suskaičiuoja, nustato ir gražiną vidurkį| StudVidurkiaiVGTU.Studentas |
| GetMediana() | Nustato ir gražiną medianą | StudVidurkiaiVGTU.Studentas |
| SkaiciuotiMediana() | Suskaičiuoja medianą | StudVidurkiaiVGTU.Studentas |
| SkaiciuotiMediana(double[] skaičiai) | Suskaičiuoja medianą su masyvais| StudVidurkiaiVGTU.StudentasArray |



## Klasių input ir output  / inferface and return

#### **`Klasė - Program`**

#### ShowMenu()
```csharp
public static void ShowMenu()	
```
**Gražina meniu pasirinktys į konsolę**


#### PrintStudentsRezultatai()
```csharp
 public static void PrintStudentsRezultatai()
```
**Spausdina studentus ir jų balą skaičiuotą pagal formules naudojant "List"**

#### PrintStudents()
```csharp
 public static void PrintStudents()
```
**Spausdina studentus**

#### **`Klasė - StudentData`**

#### ReadInputFromConsole()
```csharp
public static void ReadInputFromConsole()
```
**Nuskaito įvesti iš konsolės į public Listą esantį klasėje "Program"**


#### ReadRandomInput()
```csharp
 public static void ReadRandomInput()
```
**Sugeneruoja įvesti ir talpina į public Listą esantį klasėje "Program"**

#### ReadInputFromFile()
```csharp
 public static void ReadInputFromFile()
```
**Ivesti gauna is failo ir talpina į public Listą esantį klasėje "Program"**

#### GeneruotiVarda()
```csharp
 private static string GeneruotiVarda(int ilgis)
```
**Sugeneruoja atsitiktinį vardą ir gražiną jį**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| ilgis | norimas vardo ilgis |

#### **`Klasė - Studentas`**

#### GetVidurkis()
```csharp
 public string GetVidurkis()
```
**Suskaičiuoja, nustato ir gražiną vidurkį**

#### GetMediana()
```csharp
  public string GetMediana()
```
**Nustato ir gražiną medianą**

#### SkaiciuotiMediana()
```csharp
 private static double SkaiciuotiMediana(double[] skaičiai)
```
**Suskaičiuoja ir gražina medianą pagal duotus skaičius**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| skaičiai | skaičiai iš kurių bus skaičiuojama mediana |

#### **`Klasė - StudentasArray`**

#### SkaiciuotiMediana()
```csharp
 private static double SkaiciuotiMediana(double[] skaičiai)
```
**Suskaičiuoja ir gražina medianą pagal duotus skaičius**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| skaičiai | skaičiai iš kurių bus skaičiuojama mediana |
