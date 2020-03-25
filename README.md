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
| studentaiArray | StudVidurkiaiVGTU.Program|
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
| PrintStudentsVidurkiai() | Spausdina studentus ir jų paskaičiuotą balą pagal vidurkį | StudVidurkiaiVGTU.Program |
| PrintStudentsMediana() | Spausdina studentus ir jų paskaičiuotą balą pagal mediana | StudVidurkiaiVGTU.Program |
| PrintStudents() | Spausdina studentus | StudVidurkiaiVGTU.Program |
| PrintStudentsVidurkiaiM() | Spausdina studentus ir jų paskaičiuotą balą pagal vidurkį (darbas su masyvu)| StudVidurkiaiVGTU.Program |
| PrintStudentsMedianaM() | Spausdina studentus ir jų paskaičiuotą balą pagal mediana (darbas su masyvu)| StudVidurkiaiVGTU.Program |
| ReadInputFromConsole() | Nuskaito įvesti iš konsolės į Listą| StudVidurkiaiVGTU.StudentData |
| ReadInputFromConsoleArray() | Nuskaito įvesti iš konsolės į Masyvą | StudVidurkiaiVGTU.StudentData |
| ReadRandomInput() | Sugeneruoja įvesti ir talpina į Listą | StudVidurkiaiVGTU.StudentData |
| GetVidurkis() | Suskaičiuoja, nustato ir gražiną vidurkį| StudVidurkiaiVGTU.Studentas |
| GetMediana() | Nustato ir gražiną medianą | StudVidurkiaiVGTU.Studentas |
| SkaiciuotiMediana() | Suskaičiuoja medianą | StudVidurkiaiVGTU.Studentas |
| SkaiciuotiVidurki() | Suskaičiuoja vidurkį su masyvais| StudVidurkiaiVGTU.StudentasArray |
| SkaiciuotiMediana(int studentas) | Nustato medianą su masyvais| StudVidurkiaiVGTU.StudentasArray |
| SkaiciuotiMediana(double[] skaičiai) | Suskaičiuoja medianą su masyvais| StudVidurkiaiVGTU.StudentasArray |



## Klasių input ir output  / inferface and return

#### **`Klasė - Program`**

#### ShowMenu()
```csharp
public static void ShowMenu()	
```
**Gražina meniu pasirinktys į konsolę**


#### PrintStudentsVidurkiai()
```csharp
 public static void PrintStudentsVidurkiai()
```
**Spausdina studentus ir jų balą skaičiuotą pagal vidurkį naudojant "List"**

#### PrintStudentsMediana()
```csharp
 public static void PrintStudentsMediana()
```
**Spausdina studentus ir jų balą skaičiuotą pagal medianą naudojant "List"**

#### PrintStudents()
```csharp
 public static void PrintStudents()
```
**Spausdina studentus**

#### PrintStudentsVidurkiaiM()
```csharp
 public static void PrintStudentsVidurkiaiM()
```
**Spausdina studentus ir jų balą skaičiuotą pagal vidurkį naudojant "Array"**

#### PrintStudentsMedianaM()
```csharp
 public static void PrintStudentsMedianaM()
```
**Spausdina studentus ir jų balą skaičiuotą pagal medianą naudojant "Array"**

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

#### GeneruotiVarda()
```csharp
 private static string GeneruotiVarda(int ilgis)
```
**Sugeneruoja atsitiktinį vardą ir gražiną jį**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| ilgis | norimas vardo ilgis |

#### ReadInputFromConsoleArray()
```csharp
public static void ReadInputFromConsoleArray()
```
**Nuskaito įvesti iš konsolės į public Array/Masyva esantį klasėje "Program"**

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

#### SkaiciuotiVidurki()
```csharp
 public void SkaiciuotiVidurki(int studentas)
```
**Suskaičiuoja vidurkį studento ir priskiria masyvui pagal duotą eil. nr.**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| studentas | studento eil. nr. masyve |

#### SkaiciuotiMediana()
```csharp
 public void SkaiciuotiMediana(int studentas)
```
**Suskaičiuoja medianą studento ir priskiria masyvui pagal duotą eil. nr.**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| studentas | studento eil. nr. masyve |

#### SkaiciuotiMediana()
```csharp
 private static double SkaiciuotiMediana(double[] skaičiai)
```
**Suskaičiuoja ir gražina medianą pagal duotus skaičius**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| skaičiai | skaičiai iš kurių bus skaičiuojama mediana |
