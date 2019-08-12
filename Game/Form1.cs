using CleanVehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private Vehicle vehicle;
        private bool up, down, left, right;
        public Form1()
        {
            InitializeComponent();
            vehicle = new Vehicle(new Speed())
            {
                AccelerationStrategy = new AirplaneAtmosphereAccelerationStrategy()
            };
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                vehicle.Reset();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up && right)
                vehicle.Accelerate(1);
            else if (up && left)
                vehicle.Accelerate(7);
            else if (down && right)
                vehicle.Accelerate(3);
            else if (down && left)
                vehicle.Accelerate(5);
            else if (up)
                vehicle.Accelerate(0);
            else if (right)
                vehicle.Accelerate(2);
            else if (down)
                vehicle.Accelerate(4);
            else if (left)
                vehicle.Accelerate(6);

            Player.Top -= vehicle.Speed.Y / 10;
            Player.Left += vehicle.Speed.X / 10;


            if (Player.Top <= 0)
            {
                Player.Top = 1;
                vehicle.Reset();
            }

            if (Player.Left <= 0)
            {
                Player.Left = 1;
                vehicle.Reset();
            }

            if (Player.Top >= (ClientRectangle.Height - Player.Height - Ground.Height))
            {
                Player.Top = (ClientRectangle.Height - Player.Height - Ground.Height -1);
                vehicle.Reset();
            }

            if (Player.Left >= (ClientRectangle.Width - Player.Width))
            {
                Player.Left = (ClientRectangle.Width - Player.Width -1);
                vehicle.Reset();
            }
        }
    }
}
