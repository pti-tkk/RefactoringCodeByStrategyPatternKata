using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A GigaGames játékfejlesztő cég nagysikerű játéka a Rover Over. A játék első verziójában egy holdjárót lehetett vezérelni különböző akadályokon keresztül.
/// A játék nagy sikereket aratott, és a következő verziókba újabb járművek (repülő, hajó, tengeralattjáró) és közegek (levegő, vízfelszín és víz alatt) kerültek be.
/// A vezető fejlesztő, Spageth Tibor zseniális módon látja át a saját kódját, ezért nem bajlódott a különböző fejlesztési módszerek, alapelvek vagy tervezési minták használatával.
/// Meggyőződése, hogy aki nem tud eligazodni többszáz sornyi elágazásokkal tarkított forráskódon, az ne álljon fejlesztőnek.
/// 
/// Hősünk, Valy Dávid a GigaGames frissen felvett fejlesztője. A játék legújabb verziójának fejlesztéséhez csatlakozott, miközben a vezető fejlesztő rendes nyári szabadságát tölti.
/// Ezért egyedül kell eligazodnia a kódrengetegben. Lássuk milyen teendői vannak Dávidnak!
///
/// Feladatok:
/// 
/// 1.: Hozz létre egy aktuális sebesség property-t, [0, 0] kiinduló értékkel, és minden Move() hívás után módosítsd megfelelően.
///     Ez fogja megadni a jármű aktuális irányát és sebességét.
/// 
/// 2.: Kevés a négy irány. A string bemenetet cseréld le int-re! Az érték egy 0 és 7 közötti szám lehet, ahol a 0 a fölfelé a 7 pedig a balra.
///     Az irányoknak megfelelően módosítsd a visszatérési értékeket!
/// 
/// 3.: A játék újabb verziója kerül kiadásra. Ebben már a játékosok extrákkal is képesesek felszerelni a járműveiket. A management egyetért a fejlesztőkkel
///     abban, hogy a kód ebben a formában már nem fejleszthető tovább. Felmerült az igény a tervezési minták használatára. 
///     
///     Első lépésként tanulmányozd a stratégia tervezési mintát (ide jöhet egy link), csak ezután kezdd el a konkrét feladatokat!
///     
///     3/a: Készíts egy VehicleMoovementStrategy interfészt amely egyetlen Move() metódust tartalmaz!
///     3/b: Készíts négy konkrét osztályt, amely megvalósítja az imént elkészített interfészt (ShipMoovementStrategy, RoverMoovmentStrategy...)!
///     3/c: A refaktorálás ezen pontján, egyszerűen másold át az egyes konkrét stratégia osztályokba a releváns kódot!
///     3/d: A Vehicle osztály objektumösszetétel módszerével kapja meg a stratégiát, majd felelősségátadással hívja meg a Move() metódust!
///     3/e: Teszteld le a működést!
/// 
/// </summary>
namespace RottenVehicle
{
    public class Vehicle
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Vehicle(string type)
        {
            this.type = type;
        }

        /// <summary>
        /// A függvény egy x, y egész párost ad vissza tömb formájában.
        /// A számok az egy frame alatti sebesség változását jelképezik.
        /// A Vehicle pozíciója minden frame alatt annyit módosul, amennyit a tárolt x és y érték megad.
        /// A Move függvény által visszaadott értékek, a Vehicle x és y értékét módosítja.
        /// A függvény nem foglalkozik a maximális és minimális sebességgel, az ütközésekkel és a határokkal, 
        /// a feladata mindössze annyi, hogy megadja, hogy egy adott típusú jármű egy adott közegben 
        /// mennyivel képes módosítani a koordinátáit egy adott irányba.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="environment"></param>
        /// <returns>int[x, y]</returns>
        public int[] Move(string direction, string environment)
        {
            int[] adjustCoordinates = new int[2];
            int x = 0;
            int y = 0;

            //A levegőben minden jármű zuhan, kivéve a repülőgépet.
            //A repülőgép két dimenzióban képes mozogni.
            if (environment == "atmosphere")
            {
                if (direction == "up")
                {
                    if (this.type == "ship")
                    {
                        y = -10;
                    }
                    else if (this.type == "submarine")
                    {
                        y = -10;
                    }
                    else if (this.type == "rover")
                    {
                        y = -10;
                    }
                    else if (this.type == "airplane")
                    {
                        y = 4;
                    }
                }
                else if (direction == "right")
                {
                    if (this.type == "ship")
                    {
                        y = -10;
                    }
                    else if (this.type == "submarine")
                    {
                        y = -10;
                    }
                    else if (this.type == "rover")
                    {
                        y = -10;
                    }
                    else if (this.type == "airplane")
                    {
                        x = 5;
                    }

                }
                else if (direction == "down")
                {
                    if (this.type == "ship")
                    {
                        y = -10;
                    }
                    else if (this.type == "submarine")
                    {
                        y = -10;
                    }
                    else if (this.type == "rover")
                    {
                        y = -10;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -7;
                    }

                }
                else if (direction == "left")
                {
                    if (this.type == "ship")
                    {
                        y = -10;
                    }
                    else if (this.type == "submarine")
                    {
                        y = -10;
                    }
                    else if (this.type == "rover")
                    {
                        y = -10;
                    }
                    else if (this.type == "airplane")
                    {
                        x = -5;
                    }

                }

            }
            //A víz alatt minden jármű süllyed, kivéve a tengeralattjárót.
            //A tengeralattjáró két dimenzióban képes mozogni.
            else if (environment == "underwater")
            {
                if (direction == "up")
                {
                    if (this.type == "ship")
                    {
                        y = -2;
                    }
                    else if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                    else if (this.type == "submarine")
                    {
                        y = 1;
                    }
                }
                else if (direction == "right")
                {
                    if (this.type == "ship")
                    {
                        y = -2;
                    }
                    else if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                    else if (this.type == "submarine")
                    {
                        x = 2;
                    }
                }
                else if (direction == "down")
                {
                    if (this.type == "ship")
                    {
                        y = -2;
                    }
                    else if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                    else if (this.type == "submarine")
                    {
                        y = -2;
                    }

                }
                else if (direction == "left")
                {
                    if (this.type == "ship")
                    {
                        y = -2;
                    }
                    else if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                    else if (this.type == "submarine")
                    {
                        x = -2;
                    }

                }
            }
            //A vízen a holdjáró és a repülő süllyed.
            //A hajó egy dimenzióban (x tengely) képes mozogni
            //A tengeralattjáró 2 dimenzióban, de az y tengelyen csak lefelé
            else if (environment == "water")
            {
                if (direction == "up")
                {
                    if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                }
                else if (direction == "right")
                {
                    if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                    else if (this.type == "ship")
                    {
                        x = 3;
                    }
                    else if (this.type == "submarine")
                    {
                        x = 2;
                    }
                }
                else if (direction == "down")
                {
                    if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                    else if (this.type == "submarine")
                    {
                        y = -2;
                    }
                }
                else if (direction == "left")
                {
                    if (this.type == "rover")
                    {
                        y = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        y = -2;
                    }
                    else if (this.type == "ship")
                    {
                        x = -3;
                    }
                    else if (this.type == "submarine")
                    {
                        x = -2;
                    }
                }

            }
            //A szárazföldön csak a repülő és a holdjáró képes mozogni.
            //A holdjáró egy dimenzióban (x tengely) mozog, a játék motorja automatikusan igazítja az y értéket a talajszinthez.
            //A repülő két dimenzióban mozog, de az y tengelyen csak fölfelé.
            else if (environment == "surface")
            {
                if (direction == "up")
                {
                    if (this.type == "airplane")
                    {
                        y = 3;
                    }
                }
                else if (direction == "right")
                {
                    if (this.type == "rover")
                    {
                        x = 2;
                    }
                    else if (this.type == "airplane")
                    {
                        x = 3;
                    }

                }
                else if (direction == "left")
                {
                    if (this.type == "rover")
                    {
                        x = -2;
                    }
                    else if (this.type == "airplane")
                    {
                        x = -3;
                    }
                }

            }

            adjustCoordinates[0] = x;
            adjustCoordinates[1] = y;
            return adjustCoordinates;
        }
    }
}
