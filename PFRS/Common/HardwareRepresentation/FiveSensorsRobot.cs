using Utils.Vector;
namespace Common.HardwareRepresentation
{
    public class FiveSensorsRobot : Robot
    {
        /// visual representation of this robot
        /// . represents sensor in front
        ///       _________
        ///      |         |   
        ///     o|         |o   (but rotated)
        ///      l_________l    
        ///      .  . . .  . 


        public override IRobotInfo RobotInfo { get; }
        public override Vector2[] SensorsCoordinates { get; set; }
        public override Vector2 BitmapSizeCenter { get; set; }
        public override int[] MotorsSpeed { get; set; }

        public FiveSensorsRobot(Vector2 UV = new(), double initPosX = 0, double initPosY = 0, double initialAngle = 0)
        {
            this.RobotCoordinates = new() { Position = new(initPosX, initPosY), RotationAngle = initialAngle };
            this.BitmapSizeCenter = new() { X = 51, Y = 49 };
            this.MotorsSpeed = new int[] { 0, 0 };
            // 51,49

            RobotInfo = new RobotInfo()
            {
                Sensors = new()
                {
                    new OpticalSensor() { MountedOn = this, UVCoords = new(-50, 100) }, //most right
                    new OpticalSensor() { MountedOn = this, UVCoords = new(-15, 100) }, // right
                    new OpticalSensor() { MountedOn = this, UVCoords = new(0, 100) }, // center
                    new OpticalSensor() { MountedOn = this, UVCoords = new(15, 100) }, // left
                    new OpticalSensor() { MountedOn = this, UVCoords = new(50, 100) }  // most left
                },
                Motors = new()
                {
                    new Motor() { MountedOn = this, relPosFromRobotCenter = new(-50, 0) }, // left wheel
                    new Motor() { MountedOn = this, relPosFromRobotCenter = new(50, 0) }  // right wheel
                },
            };

            this.SensorsCoordinates = new Vector2[]
            {
                new(-50, 100), //most right
                new(-15, 100), // right
                new(0, 100), // center
                new(15, 100), // left
                new(50, 100)  // most left
            };
        }
      

        public override void Update(int fps)
        {
            // let assume that the speed of wheel is between 1400 and 1600 (max speed reverse = 14000, not moving  = 1500, max speed = 1600)
            // calculating position and heading (angle, direction) is quite simple when we know previous
            // data (which we have, they are not updated yet (position and direction)) and new speeds of wheels
            // right hand system means that left wheen moves in direction of robot when 1500<,
            // and right wheel moves in direction of robot when 1500>.

            double dTime = fps/1000.0f;
            //left wheel relative speed
            double lWheel = (((Motor)RobotInfo.Motors[0])._speed - 1500);
            //right wheel relative speed
            double rWheel = (((Motor)RobotInfo.Motors[1])._speed - 1500);

            // from this we know distance between individual wheels

            var baseLength = (((Motor)RobotInfo.Motors[0]).relPosFromRobotCenter.Length * 2);

            var s_n = (dTime * rWheel + dTime * lWheel) / 2;

            var deltaTheta = (dTime * rWheel - dTime * lWheel) / baseLength;
            var prevX = this.RobotCoordinates.Position.X;
            var prevY = this.RobotCoordinates.Position.Y;
            var cAngle = this.RobotCoordinates.RotationAngle;
            var newX = prevX + (s_n * (Math.Cos(deltaTheta + cAngle)));
            var newY = prevY + (s_n * (Math.Sin(deltaTheta + cAngle)));


            this.RobotCoordinates = new RobotCoordinates()
            {
                Position = new Vector2(newX, newY),
                RotationAngle = cAngle + deltaTheta
            };

            MotorsSpeed[0] = ((Motor)RobotInfo.Motors[0])._speed;
            MotorsSpeed[1] = ((Motor)RobotInfo.Motors[1])._speed;
            // add this so we can put this into simulation frame afterwards
            this.SensorsCoordinates = new Vector2[]
            {
                ((OpticalSensor)RobotInfo.Sensors[0]).CurrentPosition,
                ((OpticalSensor)RobotInfo.Sensors[1]).CurrentPosition,
                ((OpticalSensor)RobotInfo.Sensors[2]).CurrentPosition,
                ((OpticalSensor)RobotInfo.Sensors[3]).CurrentPosition,
                ((OpticalSensor)RobotInfo.Sensors[4]).CurrentPosition
            };

        }
    }
}
