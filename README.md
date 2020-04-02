# StudVidurkiaiVGTU
## Integruotos programavimo aplinkos laboratorinis darbas v0.4

## Laiko analizė
## X Studentu generavimas ir išvedimas/skaitymas į vieną failą
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 100 | Generuoti | 1ms (0.001s)|
| 100 | Isvesti į failą | 4ms (0.004s) |
| 100 | Skaityti failą | 1ms (0.001s) |
| ------ | ------ |  ------ | 
| 1000 | Generuoti | 3ms (0.003s)|
| 1000 | Isvesti į failą | 4ms (0.004s)|
| 1000 | Skaityti failą | 2ms (0.002s)|
| ------ | ------ |  ------ | 
| 10 000 | Generuoti | 24ms (0.024s)|
| 10 000 | Isvesti į failą | 9ms (0.009s)|
| 10 000 | Skaityti failą | 9ms (0.009s)|
| ------ | ------ |  ------ | 
| 100 000 | Generuoti | 271ms (0.271s)|
| 100 000 | Isvesti į failą | 64ms (0.064s)|
| 100 000 | Skaityti failą | 62ms (0.062s)|
| ------ | ------ |  ------ | 
| 1000 000 | Generuoti | 2884ms (2.884s)|
| 1000 000 | Isvesti į failą | 867ms (0.867s)|
| 1000 000 | Skaityti failą | 490ms (0.490s)|
| ------ | ------ |  ------ | 
| 1000 000 0 | Generuoti | 33695ms (33.695s)|
| 1000 000 0 | Isvesti į failą | 9079ms (9.079s)|
| 1000 000 0 | Skaityti failą | 3737ms (3.737s)|


## X Studentu generavimas, rušiavimas į dvi grupes ir išvedimas į du failus
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 100 | Generuoti | 1ms  (0.001s)|
| 100 | Rušiuoti | 1ms  (0.001s)|
| 100 | Isvesti į du failus | 4ms  (0.004s)|
| 100 | Pilna trukme (total time taken) | 8ms  (0.008s)|
| ------ | ------ |  ------ | 
| 1000 | Generuoti | 3ms  (0.002s)|
| 1000 | Rušiuoti | 2ms  (0.002s)|
| 1000 | Isvesti į du failus | 5ms  (0.005s)|
| 1000 | Pilna trukme (total time taken) | 11ms  (0.011s)|
| ------ | ------ |  ------ | 
| 10 000 | Generuoti | 25ms  (0.025s)|
| 10 000 | Rušiuoti | 8ms  (0.008s)|
| 10 000 | Isvesti į du failus | 11ms  (0.011s)|
| 10 000 | Pilna trukme (total time taken) | 45ms  (0.045s)|
| ------ | ------ |  ------ | 
| 100 000 | Generuoti | 272ms  (0.272s)|
| 100 000 | Rušiuoti | 61ms  (0.061s)|
| 100 000 | Isvesti į du failus | 104ms  (0.104s)|
| 100 000 | Pilna trukme (total time taken) | 439ms  (0.439s)|
| ------ | ------ |  ------ | 
| 1000 000 | Generuoti | 2993ms  (2.993s)|
| 1000 000 | Rušiuoti | 836ms  (0.836s)|
| 1000 000 | Isvesti į du failus | 1021ms  (1.021s)|
| 1000 000 | Pilna trukme (total time taken) | 4852ms  (4.852s)|
| ------ | ------ |  ------ | 
| 100 0000 0 | Generuoti | 34574ms  (34.574s)|
| 100 0000 0 | Rušiuoti | 10601ms  (10.601s)|
| 100 0000 0 | Isvesti į du failus | 11985ms  (11.985s)|
| 100 0000 0 | Pilna trukme (total time taken) | 57168ms  (57.168s)|


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
