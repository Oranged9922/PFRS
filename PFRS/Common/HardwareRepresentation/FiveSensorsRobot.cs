using Utils.Vector;
namespace Common.HardwareRepresentation
{
    public class FiveSensorsRobot : Robot
    {
        /// visual representation of this robot
        /// . represents sensor in front
        ///       _________
        ///      |         |   
        ///     o|         |o   (but rotated 270°)
        ///      l_________l    
        ///      .  . . .  . 


        public override IRobotInfo RobotInfo { get; }


        public FiveSensorsRobot(double initPosX = 0, double initPosY = 0, decimal initialAngle = 0)
        {
            this.RobotCoordinates = new() { Position = new(initPosX, initPosY) };
            RobotInfo = new RobotInfo()
            {
                Sensors = new()
                {
                    new OpticalSensor() { MountedOn = this, relPosFromRobotCenter = new(-0.5 , 0.25) }, //most right
                    new OpticalSensor() { MountedOn = this, relPosFromRobotCenter = new(-0.15, 0.25) }, // right
                    new OpticalSensor() { MountedOn = this, relPosFromRobotCenter = new( 0.0 , 0.25) }, // center
                    new OpticalSensor() { MountedOn = this, relPosFromRobotCenter = new( 0.15, 0.25) }, // left
                    new OpticalSensor() { MountedOn = this, relPosFromRobotCenter = new( 0.5 , 0.25) }  // most left
                },
                Motors = new()
                {
                    new Motor() { MountedOn = this, relPosFromRobotCenter = new(-0.5, 0) }, // left wheel
                    new Motor() { MountedOn = this, relPosFromRobotCenter = new( 0.5, 0) }  // right wheel
                },
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
            dTime /= 100;
            //left wheel traversed
            double lWheel = (((Motor)RobotInfo.Motors[0])._speed-50) * dTime;
            //right wheel traversed
            double rWheel = (((Motor)RobotInfo.Motors[1])._speed+50) * dTime;

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
