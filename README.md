# Kód refaktorálás kata stratégia tervezési minta felhasználásával

A feladatsor célja, hogy bemutassa a stratégia tervezési minta hasznosságát. A kiinduló állapot egy átgondolatlan programrészlet, amely bonyolultsága miatt alkalmatlanná vált a továbbfejlesztésre. A feladatban szereplő példakód C# programnyelven készült, a feladat végrehajtásához olyan futtatókörnyezet és kódszerkesztő szükséges, amely képes kezelni a .NET környezetet. A feladat készítője a Visual Studio-t javasolja erre a célra.

## Kiinduló állapot

- A feladatsor a RefactoringCodeByStrategyPatternKata.sln megnyitásával indul. A szépítendő kód a [RottenVehicle/Vehicle.cs](RottenVehicle/Vehicle.cs) fájlban található. 
- Az Accelerate metódus egy jármű sebességének változását hivatott megvalósítani az elmozdulás iránya és a járművet körülvevő közeg függvényében. A program első verziójában csak egy típusú jármű (holdjáró) és egyetlen közeg (talaj) volt elérhető. Időközben újabb járművek (tengeralattjáró és repülőgép), illetve újabb közegek (víz alatt és levegőben) kerültek bevezetésre.  Az első verzióban csak két irányba(jobbra, balra), az újabb elemek bekerülésével pedig már négy irányba(jobbra, balra, fel és le) tudtak haladni a járművek. A kódot készítő fejlesztő minden egyes újdonságot feltételes elágazásokkal oldott meg. Kiderült, hogy a jelenlegi négy irány nem elegendő arra, hogy a bevezeetni kívánt vezérlést pontosan legyen képes megvalósítani. Ezért újabb irányok bevezetésére van szükség.
- Időközben az is kiderült, hogy a teljes mozgási koncepció hibás, a kliens program kódja is egyre bonyolultabbá válik a felhasználása miatt.

## Feladatok

- Kíséreld meg az újabb négy irány bevezetését újabb elágazások hozzáadásával! Az újabb irányok: jobbra fel, jobbra le, balra le és balra fel.
- Ha úgy érzed, hogy ez a feladat túl sok energiába kerül, akkor a kata már részben el is érte a célját. Térj vissza a kiinduló állaponthoz, és folytasd a következő ponttal!

### A mozgás modellje
Gondoljuk át a járművek mozgásának a működését egy nagyon egyszerű minta alapján!
- A játék kliense egy Windows Form alkalmazás, az animációkért egy timer a felelős.
- A timer minden egyes tick eseményére a jármű (x, y) koordinátája annyit változik, amennyi a sebessége. Tehát a sebesség is egy (x, y) egész számpárral jellemezhető, ami természetesen negatív is lehet a haladási iránytól függően.
- A játékos által megadott bemenet az irány, amely esetünkben 8 különböző érték lehet.
- A sebesség változása, vagyis a gyorsulás függ az iránytól, a jármű típusától és a közegtől, amiben a jármű tartózkodik.
- Ahhoz, hogy az elágazásoktól teljes mértékben megszabaduljunk, minden közeg-jármű pároshoz szükségünk van egy-egy elkülönített stratégiára, ami az irány függvényében egy (x, y) egész párost ad vissza.

### 1. lépés: a gyorsulás bevezetése
Hozz létre egy Acceleration osztályt, amelynek két publikus property-je van: int X és int Y!

### 2. lépés: a sebesség bevezetése
Hozz létre egy Speed osztályt, amelynek szintén egy int X és int Y publikus property-je, illetve egy publikus Modify metódusa van! A Modify metódus két egész paramétert vár (int x, int y), a törzse a bemenetként kapott értékkel módosítja a releváns property-ket.

### 3. Lépés: a stratégia interfész létrehozása
Az interfész egyetlen publikus metódust tartalmaz: Accelerate. A visszatérési érték típusa legyen a korábban létrehozott Acceleration típusú tömb, a paramétere pedig egy egész szám, amely az irányt jelképezi!

### 4. lépés: a stratégia interfész megvalósítása
Az imént létrehozott interfészt valósítsd meg egy konkrét osztályban! Válassz ki egy közeget-jármű párost (levegó-repülő, vagy víz alatt-tengeralatjáró...), ez alapján nevezd el az osztályt! Hozz létre egy 8 elemű, Acceleration típusú tömböt, sorold fel benne az egyes irányokra vonatkozó gyorsulásokat! Ez a tömb legyen a visszatérési értéke az Accelerate metódusnak!

### 5. lépés: az elemek összeillesztése
- A Vehicle osztályban hozz létre egy Speed típusú propertyt!
- A Vehicle osztályban hozz létre egy stratégia interfész típusú property-t!
- A Vehicle osztályban hozz létre egy settert, amiben a stratégía típusú property-t lehet beállítani! 
- A Vehicle osztály Accelerate metódus törzsét cseréld le olyan módon, hogy stratégia típusú property saját Accelerate metódusát hívod meg benne az irány átadásával (felelősségátadás)! Az Accelerate metódus formális paraméterlistáját is módosítsd, most már csak az irányra van szükséged!

### Eredméyn kiértékelése
A felsorolt lépések elvégzésével teljesen eltávolítottad az elágazásokat a járműved gyorsulását modellező kódból. Bármennyi új jármű-közeg párost hozzá tudsz adni a stratégia interfész megvalósításával, csak a visszaadott tömb elemeit kell módosítanod. Azt már a kódot felhasználó kliensnek kell eldöntenie, hogy a járműved épp milyen stratégia szerint módosítja a sebességét.

A CleanVehicle projektben a feladat megoldásának egy letisztult változatát találod meg.

Köszönjük a figyelmet!
	