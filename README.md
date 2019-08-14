# Kód refaktorálás kata stratégia tervezési minta felhasználásával

A feladatsor célja, hogy bemutassa a stratégia tervezési minta hasznosságát. A kiinduló állapot egy átgondolatlan programrészlet, amely bonyolultsága miatt alkalmatlanná vált a továbbfejlesztésre. A feladatban szereplő példakód C# programnyelven készült, a feladat végrehajtásához olyan futtatókörnyezet és kódszerkesztő szükséges, amely képes kezelni a .NET környezetet. A feladat készítője a Visual Studio-t javasolja erre a célra.

## Kiinduló állapot

A feladatsor a RefactoringCodeByStrategyPatternKata.sln megnyitásával indul. A szépítendő kód a [RottenVehicle/Vehicle.cs](RottenVehicle/Vehicle.cs) fájlban található. 