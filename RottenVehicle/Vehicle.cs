using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenVehicle
{

    public class Vehicle : IVehicle
    {
        public ISpeed Speed { get; set; }

        public void Accelerate(int direction)
        {
            throw new NotImplementedException();
        }

        public string Type { get; set; }


        public int[] Accelerate(string direction, string environment)
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
                    if (Type == "submarine")
                    {
                        y = -10;
                    }
                    else if (Type == "rover")
                    {
                        y = -10;
                    }
                    else if (Type == "airplane")
                    {
                        y = 4;
                    }
                }
                else if (direction == "right")
                {
                    if (Type == "submarine")
                    {
                        y = -10;
                    }
                    else if (Type == "rover")
                    {
                        y = -10;
                    }
                    else if (Type == "airplane")
                    {
                        x = 5;
                    }

                }
                else if (direction == "down")
                {
                    if (Type == "submarine")
                    {
                        y = -10;
                    }
                    else if (Type == "rover")
                    {
                        y = -10;
                    }
                    else if (Type == "airplane")
                    {
                        y = -7;
                    }

                }
                else if (direction == "left")
                {
                    if (Type == "submarine")
                    {
                        y = -10;
                    }
                    else if (Type == "rover")
                    {
                        y = -10;
                    }
                    else if (Type == "airplane")
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
                    if (Type == "rover")
                    {
                        y = -2;
                    }
                    else if (Type == "airplane")
                    {
                        y = -2;
                    }
                    else if (Type == "submarine")
                    {
                        y = 1;
                    }
                }
                else if (direction == "right")
                {
                    if (Type == "rover")
                    {
                        y = -2;
                    }
                    else if (Type == "airplane")
                    {
                        y = -2;
                    }
                    else if (Type == "submarine")
                    {
                        x = 2;
                    }
                }
                else if (direction == "down")
                {
                    if (Type == "rover")
                    {
                        y = -2;
                    }
                    else if (Type == "airplane")
                    {
                        y = -2;
                    }
                    else if (Type == "submarine")
                    {
                        y = -2;
                    }

                }
                else if (direction == "left")
                {
                    if (Type == "rover")
                    {
                        y = -2;
                    }
                    else if (Type == "airplane")
                    {
                        y = -2;
                    }
                    else if (Type == "submarine")
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
                    if (Type == "airplane")
                    {
                        y = 3;
                    }
                }
                else if (direction == "right")
                {
                    if (Type == "rover")
                    {
                        x = 2;
                    }
                    else if (Type == "airplane")
                    {
                        x = 3;
                    }

                }
                else if (direction == "left")
                {
                    if (Type == "rover")
                    {
                        x = -2;
                    }
                    else if (Type == "airplane")
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
