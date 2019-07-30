using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanVehicle
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
                    if (this.type == "submarine")
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
                    if (this.type == "submarine")
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
                    if (this.type == "submarine")
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
                    if (this.type == "submarine")
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
                        y = 1;
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
