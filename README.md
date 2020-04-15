# StudVidurkiaiVGTU
## Integruotos programavimo aplinkos laboratorinis darbas v1.0

## Release aprašai trumpi
### Release v0.1
Pridėtas Nuskaitymas iš konsolės studentų
Galimybė sugeneruoti įvesti
Pridėjimas į Array arba List tipą
Spausdinimas su vidrukiais, mediana arba "raw"
### Release v0.2
Mažas refactor
Nuskaitymas iš failų palaikomas
Ištraukiamas "Array" palaikymas
### Release v0.3
Mažas refactor
Pataisos v0.2 versijai keli
Pridėtas exception handling nenumatytom situacijom
### Release v0.4
Pridėtas laiko/spartos skaičiavimas studentų įvesčiai, rušiavimui ir išvedimui
Pridėta spartos analizė programos veikimui
Laiko matavimas sekundėmis pridėtas prie analizės
### Release v0.5
Didelis refactor, kad palaikyti tris konteinerių tipus vienu metu - List, LinkedList ir Queue
Spartos analizė visiems trims konteinerių tipams
Analizės išvados
### Release v1.0
Nauja rušiavimo strategiją (nr.2), kai nekuriami tris konteineriai vienu metu
Pridėta Atminties naudojimo analizė visiem triem konteineriam, bei strategijoms
Laiko analizė antrai strategijai
Atminties analizė pirmai ir antrai strategijai
Išvados spartos ir atminties naudojimo abiejų strategijų

## Naudojimo  ir diegimo instrukcija
Kodą klonuoti iš github, su "SourceTree" arba pačiu VisualStudio
Paleidus programą, perskaityti išvesta meniu ir sekti ekrano instrukcijas
NB! - Kai kurioms funkcijoms pries jungiant reikia sugeneruoti studentų failus!


## Analizes isvados
### Iš gautų rezultatų, galime teigti, jog list tipo konteineriam antra strategija yra "skaudžiausia", jos veikimo sparta sumažėja (net ir su pritaikytais List algoritmo optimizacijomis), Linked List ir Queue/Dequeue irgi praranda šiek tiek spartos, tačiau mažiau. Antroji strategija išlaisvino didelį kiekį atminties, kadangi mažiau studentų laikome atmintyje. Kombinuojant optimizacija su antrą strategiją, gauname algoritma kuris yra pakankamai spartus ir naudoja gerokai mažiau atminties

## Laiko analizė - 1 strategija
## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [List]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 9ms (0.009s)|
| 1000 | Isvedimas i faila | 4ms (0.004s) |
| 1000 | Visos proceduros bendras laikas | 14ms (0.0014s) |
| 1000 | Atminties naudota | 11MB |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 40ms (0.040s)|
| 10 000 | Isvedimas i faila | 9ms (0.009s)|
| 10 000 | Visos proceduros bendras laikas | 51ms (0.0051s)|
| 10 000 | Atminties naudota | 17MB |
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 347ms (0.347s)|
| 100 000 | Isvedimas i faila | 68ms (0.068s)|
| 100 000 | Visos proceduros bendras laikas | 416ms (0.416s)|
| 100 000 | Atminties naudota | 51MB |
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3296ms (3.296s)|
| 1000 000 | Isvedimas i faila | 677ms (0.677s)|
| 1000 000 | Visos proceduros bendras laikas | 3973ms (3.973s)|
| 1000 000 | Atminties naudota | 340MB |
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 34192ms (34.192s)|
| 1000 000 0 | Isvedimas i faila | 6271ms (6.271s)|
| 1000 000 0 | Visos proceduros bendras laikas | 40464ms (40.464s)|
| 1000 000 0 | Atminties naudota | 3950MB |

## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [LinkedList]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 10ms (0.010s)|
| 1000 | Isvedimas i faila | 5ms (0.005s) |
| 1000 | Visos proceduros bendras laikas | 16ms (0.0016s) |
| 1000 | Atminties naudota | 11MB |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 41ms (0.041s)|
| 10 000 | Isvedimas i faila | 9ms (0.009s)|
| 10 000 | Visos proceduros bendras laikas | 52ms (0.0052s)|
| 10 000 | Atminties naudota | 18MB |
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 419ms (0.419s)|
| 100 000 | Isvedimas i faila | 86ms (0.086s)|
| 100 000 | Visos proceduros bendras laikas | 506ms (0.506s)|
| 100 000 | Atminties naudota | 64MB |
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3783ms (3.783s)|
| 1000 000 | Isvedimas i faila | 714ms (0.714s)|
| 1000 000 | Visos proceduros bendras laikas | 4498ms (4.498s)|
| 1000 000 | Atminties naudota | 421MB |
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 49001ms (49.001s)|
| 1000 000 0 | Isvedimas i faila | 6712ms (6.712s)|
| 1000 000 0 | Visos proceduros bendras laikas | 55714ms (55.714s)|
| 1000 000 0 | Atminties naudota | 3720MB |

## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [Queue]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 14ms (0.014s)|
| 1000 | Isvedimas i faila | 4ms (0.004s) |
| 1000 | Visos proceduros bendras laikas | 18ms (0.0018s) |
| 1000 | Atminties naudota | 11MB |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 39ms (0.039s)|
| 10 000 | Isvedimas i faila | 20ms (0.0020s)|
| 10 000 | Visos proceduros bendras laikas | 59ms (0.0059s)|
| 10 000 | Atminties naudota | 17MB |
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 330ms (0.330s)|
| 100 000 | Isvedimas i faila | 74ms (0.074s)|
| 100 000 | Visos proceduros bendras laikas | 405ms (0.405s)|
| 100 000 | Atminties naudota | 51MB |
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3386ms (3.386s)|
| 1000 000 | Isvedimas i faila | 684ms (0.684s)|
| 1000 000 | Visos proceduros bendras laikas | 4071ms (4.071s)|
| 1000 000 | Atminties naudota | 348MB |
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 34752ms (34.752s)|
| 1000 000 0 | Isvedimas i faila | 6935ms (6.935s)|
| 1000 000 0 | Visos proceduros bendras laikas | 41688ms (41.688s)|
| 1000 000 0 | Atminties naudota | 3110MB |

## Laiko analizė - 2 strategija + List optimizacija
## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [List]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 12ms (0.0012s)|
| 1000 | Isvedimas i faila | 4ms (0.004s) |
| 1000 | Visos proceduros bendras laikas | 16ms (0.0016s) |
| 1000 | Atminties naudota | 10MB |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 48ms (0.048s)|
| 10 000 | Isvedimas i faila | 8ms (0.008s)|
| 10 000 | Visos proceduros bendras laikas | 56ms (0.0056s)|
| 10 000 | Atminties naudota | 14MB |
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 385ms (0.385s)|
| 100 000 | Isvedimas i faila | 69ms (0.069s)|
| 100 000 | Visos proceduros bendras laikas | 454ms (0.454s)|
| 100 000 | Atminties naudota | 48MB |
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3924ms (3.924s)|
| 1000 000 | Isvedimas i faila | 656ms (0.656s)|
| 1000 000 | Visos proceduros bendras laikas | 4583ms (4.583s)|
| 1000 000 | Atminties naudota | 290MB |
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 37322ms (37.322s)|
| 1000 000 0 | Isvedimas i faila | 6151ms (6.151s)|
| 1000 000 0 | Visos proceduros bendras laikas | 43473ms (43.473s)|
| 1000 000 0 | Atminties naudota | 3320MB |

## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [LinkedList]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 11ms (0.011s)|
| 1000 | Isvedimas i faila | 6ms (0.005s) |
| 1000 | Visos proceduros bendras laikas | 18ms (0.0018s) |
| 1000 | Atminties naudota | 11MB |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 45ms (0.045s)|
| 10 000 | Isvedimas i faila | 9ms (0.009s)|
| 10 000 | Visos proceduros bendras laikas | 52ms (0.0054s)|
| 10 000 | Atminties naudota | 15MB |
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 431ms (0.431s)|
| 100 000 | Isvedimas i faila | 83ms (0.083s)|
| 100 000 | Visos proceduros bendras laikas | 506ms (0.514s)|
| 100 000 | Atminties naudota | 55MB |
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3801ms (3.801s)|
| 1000 000 | Isvedimas i faila | 712ms (0.712s)|
| 1000 000 | Visos proceduros bendras laikas | 4498ms (4.513s)|
| 1000 000 | Atminties naudota | 378MB |
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 49421ms (49.421s)|
| 1000 000 0 | Isvedimas i faila | 6756ms (6.756s)|
| 1000 000 0 | Visos proceduros bendras laikas | 56177ms (56.177s)|
| 1000 000 0 | Atminties naudota | 3150MB |

## X Studentu nuskaitymas, rusiavimas ir išvedimas/skaitymas į du failus [Queue]
| Studentu skaicius | Uzduotis | Laiko trukme |
| ------ | ------ |  ------ | 
| 1000 | Nuskaitymas ir Rusiavimas | 17ms (0.017s)|
| 1000 | Isvedimas i faila | 3ms (0.003s) |
| 1000 | Visos proceduros bendras laikas | 20ms (0.0020s) |
| 1000 | Atminties naudota | 9MB |
| ------ | ------ |  ------ | 
| 10 000 | Nuskaitymas ir Rusiavimas | 44ms (0.044s)|
| 10 000 | Isvedimas i faila | 18ms (0.0018s)|
| 10 000 | Visos proceduros bendras laikas | 62ms (0.0062s)|
| 10 000 | Atminties naudota | 15MB |
| ------ | ------ |  ------ | 
| 100 000 | Nuskaitymas ir Rusiavimas | 361ms (0.361s)|
| 100 000 | Isvedimas i faila | 73ms (0.073s)|
| 100 000 | Visos proceduros bendras laikas | 434ms (0.434s)|
| 100 000 | Atminties naudota | 45MB |
| ------ | ------ |  ------ | 
| 1000 000 | Nuskaitymas ir Rusiavimas | 3513ms (3.513s)|
| 1000 000 | Isvedimas i faila | 664ms (0.664s)|
| 1000 000 | Visos proceduros bendras laikas | 4177ms (4.177s)|
| 1000 000 | Atminties naudota | 312MB |
| ------ | ------ |  ------ | 
| 1000 000 0 | Nuskaitymas ir Rusiavimas | 36332ms (36.332s)|
| 1000 000 0 | Isvedimas i faila | 6736ms (6.736s)|
| 1000 000 0 | Visos proceduros bendras laikas | 43068ms (43.068s)|
| 1000 000 0 | Atminties naudota | 2768MB |

# Dokumentacija
## Objektai / Masyvai
| objektas / masyvas | classpath |
| ------ | ------ | 
| studentaiL |StudVidurkiaiVGTU.Program |
| vargsiukaiL |StudVidurkiaiVGTU.Program |
| kietiakiaiL |StudVidurkiaiVGTU.Program |
| ------ | ------ |
| studentaiLL |StudVidurkiaiVGTU.Program |
| vargsiukaiLL |StudVidurkiaiVGTU.Program |
| kietiakiaiLL |StudVidurkiaiVGTU.Program |
| ------ | ------ |
| studentaiQ |StudVidurkiaiVGTU.Program |
| vargsiukaiQ |StudVidurkiaiVGTU.Program |
| kietiakiaiQ |StudVidurkiaiVGTU.Program |

## Objektų kintamieji
| Kintamasis | Classpath |Apibudinimas |
| ------ | ------ | ------ | 
| Vardas | StudVidurkiaiVGTU.StudentasSimple | Studento vardas  |
| Pavarde | StudVidurkiaiVGTU.StudentasSimple | Studento pavarde|
| Egzaminas | StudVidurkiaiVGTU.StudentasSimple | Studento egzamino balas|
| NamuDarbai | StudVidurkiaiVGTU.StudentasSimple | Namu darbai (List)|
| Mediana | StudVidurkiaiVGTU.StudentasSimple | Namu darbu mediana|
| Vidurkis | StudVidurkiaiVGTU.StudentasSimple | Namu darbu vidurkis|

## Funkcijos
| funkcija | apibrėžimas | classpath |
| ------ | ------ | ------ |
| ShowMenu() | Parodo pasirenkamajį meniu per konsolę| StudVidurkiaiVGTU.Program |
| PrintStudentsRezultatai() | Spausdina studentus ir jų paskaičiuotus balus pagal formules | StudVidurkiaiVGTU.Program |
| PrintStudentsRezultataiIFaila() | Spausdina studentus is studentai list objekto i faila | StudVidurkiaiVGTU.Program |
| GeneruotiXStudentuIFaila() | Generuoja ir spausdina studentus is studentai list objekto i faila | StudVidurkiaiVGTU.Program |
| RusiuotiXStudentu() | Nuskaito X studentu is failo, surusiuoja i dvi grupes | StudVidurkiaiVGTU.Program |
| IsvestiIfaila() | Spausdina studentu grupes i failus | StudVidurkiaiVGTU.Program |
| ReadInputFromConsole() | Nuskaito įvesti iš konsolės į duomenu eilute| StudVidurkiaiVGTU.StudentDataSimple |
| ReadRandomInput() | Sugeneruoja įvesti ir talpina į Listą | StudVidurkiaiVGTU.StudentDataSimple |
| ReadInputFromFile() | Ivesti gaunama is failo ir talpina į Listą | StudVidurkiaiVGTU.StudentDataSimple |
| ParseStudent() | Ivestied duomenu eiute talpina i studento objekta ir grazina | StudVidurkiaiVGTU.StudentDataSimple |
| GetVidurkis() | Suskaičiuoja, nustato ir gražiną vidurkį| StudVidurkiaiVGTU.StudentDataSimple |
| GetMediana() | Nustato ir gražiną medianą | StudVidurkiaiVGTU.StudentDataSimple |
| SkaiciuotiMediana() | Suskaičiuoja medianą | StudVidurkiaiVGTU.StudentDataSimple |



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

#### GeneruotiXStudentuIFaila()
```csharp
 private static void GeneruotiXStudentuIFaila(int kiekis, int strategija)
```
**Sugeneruoja x studentu ir isveda i faila**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| kiekis | norimas studentu kiekis |
| strategija | naudojama strategija |

#### RusiuotiXStudentu()
```csharp
 private static void RusiuotiXStudentu(int kiekis, String type, int strategija)
```
**Sugeneruoja ir surusiuoja x studentu  i du sarasus ir isveda i du failus**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| kiekis | norimas studentu kiekis |
| type | konteinerio tipas |
| strategija | naudojama strategija |


#### IsvestiIfaila()
```csharp
 private static void IsvestiIfaila(int kiekis, String type, String group, int strategija)
```
**Sugeneruoja ir surusiuoja x studentu  i du sarasus ir isveda i du failus**
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| kiekis | norimas studentu kiekis |
| type | konteinerio tipas |
| group | studentu rusiavimo grupe |
| strategija | naudojama strategija |

#### **`Klasė - StudentDataSimple`**

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
 public static void ReadInputFromFile(int kiekis, String tipas, Boolean sort, Boolean full, int strategija)
```
Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| kiekis | norimas studentu kiekis |
| tipas | konteinerio tipas |
| sort | rusiuoti ar ne |
| full | failo tipas (su ar be namu darbu) |
| strategija | naudojama strategija |

**Ivesti gauna is failo ir talpina į public Listą esantį klasėje "Program"**

#### GetVidurkis()
```csharp
 public string GetVidurkis(List<double> NamuDarbai, double Egzaminas)
```
 Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| NamuDarbai | studento namu darbai |
| Egzaminas | studento egzamino rezultatas |

**Suskaičiuoja, nustato ir gražiną vidurkį**

#### GetMediana()
```csharp
  public string GetMediana(List<double> NamuDarbai, double Egzaminas)
```
 Parametrai:
| įvestis | apibrėžimas |
| ------ | ------ |
| NamuDarbai | studento namu darbai |
| Egzaminas | studento egzamino rezultatas |

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

