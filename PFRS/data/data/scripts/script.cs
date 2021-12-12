bool readingFromSensor0;


Robot r = new Robot();


// Called only once before simulating
formula.Setup = (IRobotInfo robotInfo) =>
{
  //Motor.Speed = [0-100]
    robotInfo.Motors[0].Speed = 50; // neutral
    robotInfo.Motors[1].Speed = 50; // neutral
};

// Is called every frame
formula.Loop = (IRobotInfo robotInfo) =>
{
   
    // you can access sensors
    readingFromSensor0 = robotInfo.Sensors[0].GetReading() > 0 ? true : false;
    r.currentSpeedMotor0 += 20;
    robotInfo.Motors[0].Speed = r.currentSpeedMotor0;
};

// You can also create your own types and classes
class Robot
{
    public int currentSpeedMotor0 = 50;
    public int currentSpeedMotor1 = 50;
    public Robot(){}
}

