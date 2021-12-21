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
            // let assume that the speed of wheel is between 0 and 100 (max speed reverse = 0, not moving  = 50, max speed = 100)
            // calculating position and heading (angle, direction) is quite simple when we know previous
            // data (which we have, they are not updated yet (position and direction)) and new speeds of wheels
            // right hand system means that left wheen moves in direction of robot when 50<,
            // and right wheel moves in direction of robot when 50>.

            double dTime = 10.0f / fps;
            //left wheel traversed
            double lWheel = (((Motor)RobotInfo.Motors[0])._speed-50) * dTime;
            //right wheel traversed
            double rWheel = (((Motor)RobotInfo.Motors[1])._speed-50) * dTime;

            // from this we know distance between individual wheels

            double angle = (rWheel - lWheel) / (((Motor)RobotInfo.Motors[0]).relPosFromRobotCenter.Length * 2);
            var dY = (rWheel + lWheel) * Math.Sin(angle);
            var dX = (rWheel + lWheel) * Math.Cos(angle);

            var cPos = this.RobotCoordinates.Position;
            var cAngle = this.RobotCoordinates.RotationAngle;
            this.RobotCoordinates = new RobotCoordinates() 
            { 
                Position = new Vector2(cPos.X + dX, cPos.Y + dY), 
                RotationAngle =  cAngle+angle
            };
        }
    }
}
