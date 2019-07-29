using PlayerComponent.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RottenVehicle
{
    public class Vehicle
    {
        public string type;
        public Player player;

        public Vehicle(string type)
        {
            this.type = type;
            player = new Player();
        }

        public int[] Move(string direction, string environment)
        {
            int x = 0;
            int y = 0;

            if (environment == "atmosphere")
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
                    if (direction == "up")
                        y = 4;
                    else if (direction == "down")
                        y = -7;
                    if (direction == "left")
                        x = -5;
                    else if (direction == "right")
                        x = 5;
                }
            }
            else if (environment == "underwater")
            {
                if (this.type == "ship")
                {
                    y = -2;
                }
                else if (this.type == "submarine")
                {
                    if (direction == "up")
                        y = 1;
                    else if (direction == "down")
                        y = -2;
                    if (direction == "left")
                        x = -2;
                    else if (direction == "right")
                        x = 2;
                }
                else if (this.type == "rover")
                {
                    y = -2;
                }
                else if (this.type == "airplane")
                {
                    y = -2;
                }
            }
            else if (environment == "water")
            {
                if (this.type == "ship")
                {
                    if (direction == "left")
                        x = -3;
                    else if (direction == "right")
                        x = 3;
                }
                else if (this.type == "submarine")
                {
                    if (direction == "down")
                        y = -2;
                    if (direction == "left")
                        x = -2;
                    else if (direction == "right")
                        x = 2;
                }
                else if (this.type == "rover")
                {
                    y = -2;
                }
                else if (this.type == "airplane")
                {
                    y = -2;
                }
            }
            else if (environment == "terrain")
            {
                if (this.type == "ship")
                {
                }
                else if (this.type == "submarine")
                {
                }
                else if (this.type == "rover")
                {
                    if (direction == "left")
                        x = -2;
                    else if (direction == "right")
                        x = 2;
                }
                else if (this.type == "airplane")
                {
                    if (direction == "up")
                        y = 3;
                    if (direction == "left")
                        x = -3;
                    else if (direction == "right")
                        x = 3;
                }
            }

            return new int[] { x, y };
        }
    }
}
