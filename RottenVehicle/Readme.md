A GigaGames játékfejlesztő cég nagysikerű játéka a Rover Over. A játék első verziójában egy holdjárót 
lehetett vezérelni különböző akadályokon keresztül. A játék nagy sikereket aratott, és a következő 
verziókba újabb járművek (repülő és tengeralattjáró) és közegek (levegő és víz alatt) 
kerültek be.

A vezető fejlesztő, Spageth Tibor zseniális módon látja át a saját kódját, ezért nem bajlódott a különböző
fejlesztési módszerek, alapelvek vagy tervezési minták használatával. Meggyőződése, hogy aki nem tud 
eligazodni többszáz sornyi elágazásokkal tarkított forráskódon, az ne álljon fejlesztőnek.

Hősünk, Valy Dávid a GigaGames frissen felvett fejlesztője. A játék legújabb verziójának fejlesztéséhez 
csatlakozott, miközben a vezető fejlesztő rendes nyári szabadságát tölti. Ezért egyedül kell eligazodnia 
a kódrengetegben. Lássuk milyen teendői vannak Dávidnak!

Az alábbi mintakódból nagyvonalúan kihagytuk a nem ide tartozó részeket.

Feladatok:

*** A következő feladat célja, hogy a tervezés hiánya okozta nehézségeket szemléltesse. Kérünk, hogy mindenképp 
    kezdj bele, és ha már érzed, hogy mit is rontott el a kód szerzője, folytasd a 2. ponttal!

1.: Kevés a négy irány, hiszen ezzel nem tudjuk jelképezni az átlós mozgásokat. Az új érték egy 0 és 7 közötti 
    szám lehet: 

        0 -> fel
        1 -> jobbra-fel
        2 -> jobb
        3 -> jobbra-le
        4 -> le
        5 -> balra-le
        6 -> bal
        7 -> balra-fel
    
    Az irányoknak megfelelően módosítsd a visszatérési értékeket! Ne feledd a paraméter típusát int-re módosítani!

2.: A játék újabb verziója kerül kiadásra. Ebben már a játékosok extrákkal is képesesek felszerelni a 
    járműveiket. A management egyetért a fejlesztőkkel abban, hogy a kód ebben a formában már nem fejleszthető 
    tovább. Felmerült az igény a tervezési minták használatára. 
        
    Első lépésként tanulmányozd a stratégia tervezési mintát (ide jöhet egy link), csak ezután kezdd el a 
    konkrét feladatokat!
    
2.1: Állítsd vissza az állapotot az eredetire, mintha az első feladat nem is létezett volna! Ha túl sok módosítást 
    hajtottál végre, akkor egyszerűen töltsd le újra a forrást!
    
2.3: Készíts egy átfogó tesztet, amivel a refaktorálás lépéseit fogod biztosítani. 
    Tipp: A Game.Program.Main metódus megmutatja, hogy mit és hogyan érdemes tesztelni.

    
2.1: Készíts egy VehicleMoovementStrategy interfészt amely egyetlen Move() metódust tartalmaz!

2.2: Készíts négy konkrét osztályt, amely megvalósítja az imént elkészített interfészt (ShipMoovementStrategy,
     RoverMoovmentStrategy...)!

2.3: A refaktorálás ezen pontján, egyszerűen másold át az egyes konkrét stratégia osztályokba a releváns kódot!

2.4: A Vehicle osztály objektumösszetétel módszerével kapja meg a stratégiát, majd felelősségátadással hívja 
     meg a Move() metódust!

2.5: Teszteld le a működést!