# StudVidurkiaiVGTU
## Integruotos programavimo aplinkos laboratorinis darbas v0.5

#Note: rezultatai List tipui gali skirtis nuo v0.4, del padaryto refactor/rusiavimo logikos

## Laiko analizė
## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [List]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 9ms (0.009s)|
| 1000 | Isvedimas i faila | 4ms (0.004s) |
| 1000 | Visos proceduros bendras laikas | 14ms (0.0014s) |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 40ms (0.040s)|
| 10 000 | Isvedimas i faila | 9ms (0.009s)|
| 10 000 | Visos proceduros bendras laikas | 51ms (0.0051s)|
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 347ms (0.347s)|
| 100 000 | Isvedimas i faila | 68ms (0.068s)|
| 100 000 | Visos proceduros bendras laikas | 416ms (0.416s)|
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3296ms (3.296s)|
| 1000 000 | Isvedimas i faila | 677ms (0.677s)|
| 1000 000 | Visos proceduros bendras laikas | 3973ms (3.973s)|
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 34192ms (34.192s)|
| 1000 000 0 | Isvedimas i faila | 6271ms (6.271s)|
| 1000 000 0 | Visos proceduros bendras laikas | 40464ms (40.464s)|

## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [LinkedList]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 10ms (0.010s)|
| 1000 | Isvedimas i faila | 5ms (0.005s) |
| 1000 | Visos proceduros bendras laikas | 16ms (0.0016s) |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 41ms (0.041s)|
| 10 000 | Isvedimas i faila | 9ms (0.009s)|
| 10 000 | Visos proceduros bendras laikas | 52ms (0.0052s)|
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 419ms (0.419s)|
| 100 000 | Isvedimas i faila | 86ms (0.086s)|
| 100 000 | Visos proceduros bendras laikas | 506ms (0.506s)|
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3783ms (3.783s)|
| 1000 000 | Isvedimas i faila | 714ms (0.714s)|
| 1000 000 | Visos proceduros bendras laikas | 4498ms (4.498s)|
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 49001ms (49.001s)|
| 1000 000 0 | Isvedimas i faila | 6712ms (6.712s)|
| 1000 000 0 | Visos proceduros bendras laikas | 55714ms (55.714s)|

## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [Queue]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 14ms (0.014s)|
| 1000 | Isvedimas i faila | 4ms (0.004s) |
| 1000 | Visos proceduros bendras laikas | 18ms (0.0018s) |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 39ms (0.039s)|
| 10 000 | Isvedimas i faila | 20ms (0.0020s)|
| 10 000 | Visos proceduros bendras laikas | 59ms (0.0059s)|
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 330ms (0.330s)|
| 100 000 | Isvedimas i faila | 74ms (0.074s)|
| 100 000 | Visos proceduros bendras laikas | 405ms (0.405s)|
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3386ms (3.386s)|
| 1000 000 | Isvedimas i faila | 684ms (0.684s)|
| 1000 000 | Visos proceduros bendras laikas | 4071ms (4.071s)|
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 34752ms (34.752s)|
| 1000 000 0 | Isvedimas i faila | 6935ms (6.935s)|
| 1000 000 0 | Visos proceduros bendras laikas | 41688ms (41.688s)|


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
