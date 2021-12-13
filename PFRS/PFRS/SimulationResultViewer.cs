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
        List<Simulator.SimulationFrame> simulationFrames;
        float prevAngle;
        public SimulationResultViewer(Bitmap Track, Bitmap Robot, List<Simulator.SimulationFrame> simFrames)
        {
            this.simulationFrames = simFrames;
            prevAngle = (float)simFrames[0].RobotCoordinates.RotationAngle;

            InitializeComponent();
            this.LabelEnd.Text = simFrames.Count.ToString();
            Slider.Maximum = simFrames.Count-1;
            Slider.Minimum = 0;
            PictureBoxRobot.BackColor = Color.Transparent;
            PictureBoxRobot.Parent = PictureBoxTrack;
            this.Robot = Robot;
            PictureBoxRobot.Image = RotateImage(Robot, (float)simulationFrames[0].RobotCoordinates.RotationAngle); ;
            PictureBoxTrack.Image = Track;

            var pos = simulationFrames[0].RobotCoordinates.Position;
            PictureBoxRobot.Location = new Point((int)pos.X-Robot.Width, (int)pos.Y-Robot.Height);

        }

        private void Slider_Scroll(object sender, EventArgs e)
        {
            this.LabelFrameNumber.Text = 
                simulationFrames[Slider.Value].FrameNumber.ToString();
            this.LabelDirection.Text = 
                ((int)simulationFrames[Slider.Value].RobotCoordinates.RotationAngle).ToString();
            this.LabelPosition.Text = 
                simulationFrames[Slider.Value].RobotCoordinates.Position.AsInt().ToString();
            this.LabelSensors.Text = String.Concat(simulationFrames[Slider.Value].sensorsReadings);
            var pos = simulationFrames[Slider.Value].RobotCoordinates.Position;

            PictureBoxRobot.Image = RotateImage(Robot, (float)simulationFrames[Slider.Value].RobotCoordinates.RotationAngle);
            prevAngle = (float)simulationFrames[Slider.Value].RobotCoordinates.RotationAngle;
            PictureBoxRobot.Location = new Point
                (
                    (int)pos.X-Robot.Width, 
                    (int)pos.Y-Robot.Height
                );
        }


        // https://stackoverflow.com/a/2163854/14302346 
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width*2, img.Height*2);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);
            Matrix transformM = new Matrix();
            transformM.RotateAt(-rotationAngle, new((float)bmp.Width / 2, (float)bmp.Height / 2));

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
    }
}
