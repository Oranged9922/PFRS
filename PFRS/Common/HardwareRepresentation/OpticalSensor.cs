using Utils.Vector;
namespace Common.HardwareRepresentation
{
    public class OpticalSensor : ISensor
    {
        public IRobot MountedOn;
        public Vector2 UVCoords; // x,y pixels in the png image of the robot
        public Vector2 CurrentPosition;

        public float GetReading()
        {

            CalculateCurrentPosition(out Vector2 curPos);
            var track = MountedOn.Track;
            
            if (
                curPos.X > track.GetLength(0) || 
                curPos.Y > track.GetLength(1) ||
                curPos.X < 0 ||
                curPos.Y < 0) return 0;
            return track[(int)curPos.X , (int)curPos.Y ] == -1 ? 0 : 1;
        }

        private void CalculateCurrentPosition(out Vector2 curPos)
        {
            // UVCoords is X,Y in the image to that particular sensor
            // Need to create 3x3 transform matrix for rotation and translation from
            // the origin based on current position of robot and its direction

            // this is top left corner of robot
            //var robotPosition = MountedOn.RobotCoordinates.Position;
            // angle of the robot
            var angle = MountedOn.RobotCoordinates.RotationAngle;

            // vector of absolute position
            // from that we can create 3D homogeneous rotation/translation matrix as
            var mat = Matrix3.Identity.Rotate(angle*(Math.PI/180));

            // now translate the vector by the matrix


           
            curPos = mat.ApplyTrasform(UVCoords);
            
            curPos += MountedOn.RobotCoordinates.Position;
            CurrentPosition = curPos;
        }
    }
}
