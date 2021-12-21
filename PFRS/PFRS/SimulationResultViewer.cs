using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils.Vector;
namespace PFRS
{
    public partial class SimulationResultViewer : Form
    {

        Bitmap Robot;
        Bitmap Track;
        bool sensorsOnly = false;
        List<Simulator.SimulationFrame> simulationFrames;
        //float prevAngle;
        public SimulationResultViewer(Bitmap Track, Bitmap Robot, List<Simulator.SimulationFrame> simFrames, (string SelectedScript, string SelectedTrack, string SelectedRobot) WindowTitle)
        {
            this.simulationFrames = simFrames;
            //prevAngle = (float)simFrames[0].RobotCoordinates.RotationAngle;

            InitializeComponent();
            this.LabelEnd.Text = simFrames.Count.ToString();
            Slider.Maximum = simFrames.Count-1;
            Slider.Minimum = 0;
            //PictureBoxRobot.BackColor = Color.Transparent;
            //PictureBoxRobot.Parent = PictureBoxTrack;
            //PictureBoxSensorsCoords.BackColor = Color.Transparent;
            //PictureBoxSensorsCoords.Parent = PictureBoxTrack;
            this.Robot = Robot;
            this.Track = Track;
            //PictureBoxRobot.Image = RotateImage(Robot, (float)simulationFrames[0].RobotCoordinates.RotationAngle); ;
            //PictureBoxTrack.Image = Track;

            SetText(0);
            PictureBoxSimulationFrame.Image = GenerateImage(0);
            motorsInfo.Text = $"{String.Concat(simFrames[0].MotorsSpeed.Select(x => x.ToString() + ", ")).TrimEnd(' ').TrimEnd(',')}";
            this.Text = $"Simulation of script \"{WindowTitle.SelectedScript}\", using {WindowTitle.SelectedRobot} on {WindowTitle.SelectedTrack}";
            //var pos = simulationFrames[0].RobotCoordinates.Position;
            //PictureBoxRobot.Location = new Point((int)pos.X, (int)pos.Y);

        }

        private void Slider_Scroll(object sender, EventArgs e)
        {
            SetText(Slider.Value);
            PictureBoxSimulationFrame.Image = GenerateImage(Slider.Value);
            //var pos = simulationFrames[Slider.Value].RobotCoordinates.Position;
            //PictureBoxRobot.Image = RotateImage(Robot, (float)simulationFrames[Slider.Value].RobotCoordinates.RotationAngle);
            ////prevAngle = (float)simulationFrames[Slider.Value].RobotCoordinates.RotationAngle;
            //PictureBoxRobot.Location = new Point
            //    (
            //        (int)pos.X, 
            //        (int)pos.Y
            //    );

            //Bitmap bmp = new Bitmap(PictureBoxSensorsCoords.Width, PictureBoxSensorsCoords.Height);
            //bmp.MakeTransparent();
            //Graphics g = Graphics.FromImage(bmp);
            //Pen p = new Pen(Color.Red);
            //foreach (var SensorPos in simulationFrames[Slider.Value].SensorsCoordinates)
            //{
            //    g.DrawRectangle(p, (int)SensorPos.X, (int)SensorPos.Y, 2,2);

            //}
            //g.Dispose();
            //bmp.MakeTransparent();
            //PictureBoxSensorsCoords.Image = bmp;

        }

        private void SetText(int value)
        {
            LabelFrameNumber.Text =
                simulationFrames[Slider.Value].FrameNumber.ToString();
            LabelDirection.Text =
                ((int)simulationFrames[Slider.Value].RobotCoordinates.RotationAngle).ToString();
            LabelPosition.Text =
                simulationFrames[Slider.Value].RobotCoordinates.Position.AsInt().ToString();
            LabelSensors.Text = String.Concat(simulationFrames[Slider.Value].SensorsReadings);
            Sensors.Text =
                String.Concat(simulationFrames[Slider.Value].SensorsCoordinates.Select(x => $"({(int)x.X},{(int)x.Y})\n"));
            motorsInfo.Text = $"{String.Concat(simulationFrames[Slider.Value].MotorsSpeed.Select(x => x.ToString() + ", ")).TrimEnd(' ').TrimEnd(',')}";
        
        }

        private Image GenerateImage(int frame)
        {
            Bitmap bmp = new(Track);
            Graphics graphics = Graphics.FromImage(bmp);
            if (sensorsOnly)
            {
                 Pen p = new Pen(Color.Red);
                foreach (var SensorPos in simulationFrames[Slider.Value].SensorsCoordinates)
                {
                    graphics.DrawRectangle(p, (int)SensorPos.X, (int)SensorPos.Y, 2, 2);

                }
            }
            else
            {
                Image rotatedRobot = RotateImage(Robot, (float)simulationFrames[frame].RobotCoordinates.RotationAngle);
                graphics.DrawImage(rotatedRobot,
                    new Rectangle((int)simulationFrames[frame].RobotCoordinates.Position.X - Robot.Width / 2,
                                  (int)simulationFrames[frame].RobotCoordinates.Position.Y - Robot.Height / 2,
                                  rotatedRobot.Width, rotatedRobot.Height));

            }
            graphics.Dispose();

            return bmp;
        }


        // https://stackoverflow.com/a/2163854/14302346 
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width*2, img.Height*2);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);
            Matrix transformM = new Matrix();
            transformM.RotateAt(rotationAngle, new((float)bmp.Width / 2, (float)bmp.Height / 2));

            //now we set the rotation point to the center of our image
            //gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.Transform = transformM;

            //now rotate the image
            //gfx.RotateTransform(-rotationAngle);

            //gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(img.Width/2, img.Height/2));


            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }

        private void SensorsOnly_Click(object sender, EventArgs e)
        {
            sensorsOnly = sensorsOnly ? false : true; 
            PictureBoxSimulationFrame.Image = GenerateImage(Slider.Value);
        }
    }
}
