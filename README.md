# StudVidurkiaiVGTU
## Integruotos programavimo aplinkos laboratorinis darbas v0.4

## Laiko analizė
## X Studentu generavimas ir išvedimas į vieną failą
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 100 | Generuoti | 1ms |
| 100 | Isvesti į failą | 4ms |
| ------ | ------ |  ------ | 
| 1000 | Generuoti | 3ms |
| 1000 | Isvesti į failą | 4ms |
| ------ | ------ |  ------ | 
| 10000 | Generuoti | 24ms |
| 10000 | Isvesti į failą | 9ms |
| ------ | ------ |  ------ | 
| 100000 | Generuoti | 271ms |
| 100000 | Isvesti į failą | 64ms |
| ------ | ------ |  ------ | 
| 1000000 | Generuoti | 2884ms |
| 1000000 | Isvesti į failą | 867ms |
| ------ | ------ |  ------ | 
| 1000000 | Generuoti | 33695ms |
| 1000000 | Isvesti į failą | 9079ms |


## X Studentu generavimas, rušiavimas į dvi grupes ir išvedimas į du failus
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 100 | Generuoti | 1ms |
| 100 | Rušiuoti | 1ms |
| 100 | Isvesti į du failus | 4ms |
| 100 | Pilna trukme (total time taken) | 8ms |
| ------ | ------ |  ------ | 
| 1000 | Generuoti | 3ms |
| 1000 | Rušiuoti | 2ms |
| 1000 | Isvesti į du failus | 5ms |
| 1000 | Pilna trukme (total time taken) | 11ms |
| ------ | ------ |  ------ | 
| 10000 | Generuoti | 25ms |
| 10000 | Rušiuoti | 8ms |
| 10000 | Isvesti į du failus | 11ms |
| 10000 | Pilna trukme (total time taken) | 45ms |
| ------ | ------ |  ------ | 
| 100000 | Generuoti | 272ms |
| 100000 | Rušiuoti | 61ms |
| 100000 | Isvesti į du failus | 104ms |
| 100000 | Pilna trukme (total time taken) | 439ms |
| ------ | ------ |  ------ | 
| 1000000 | Generuoti | 2993ms |
| 1000000 | Rušiuoti | 836ms |
| 1000000 | Isvesti į du failus | 1021ms |
| 1000000 | Pilna trukme (total time taken) | 4852ms |
| ------ | ------ |  ------ | 
| 10000000 | Generuoti | 34574ms |
| 10000000 | Rušiuoti | 10601ms |
| 10000000 | Isvesti į du failus | 11985ms |
| 10000000 | Pilna trukme (total time taken) | 57168ms |


# Dokumentacija
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

#### GeneruotiXStudentuIFaila()
```csharp
 private static void GeneruotiXStudentuIFaila(int kiekis)
```
**Sugeneruoja x studentu ir isveda i faila**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| kiekis | norimas studentu kiekis |

#### RusiuotiXStudentu()
```csharp
 private static void RusiuotiXStudentu(int kiekis)
```
**Sugeneruoja ir surusiuoja x studentu  i du sarasus ir isveda i du failus**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| kiekis | norimas studentu kiekis |

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
