# PFRS
 Path Following Robot Simulator

## Revision

- 01/12/2021 Created the document, version 0.1.0.
- 02/12/2021 Edited Functional description, version 0.1.1.

------

## Product goal 

Create standalone C# application using WinForms that works as learning tool for practicing basic understanding of simple models of robots and how to move them based on certain conditions (different sensors and # of sensors used, motors and # of motors used, different steering types (differential, ackermann...),  obstacles etc.).  

------

## Functional description 

User is able to write own script for controlling the robot based on robots implementation and by usage of its properties (motor speeds, reading sensor input data...), as well as add self-made tracks (and possibly own robot implementation ? **to be discussed**). The application will then precalculate the movement on robot using the script and will create timeline that user can interact with afterwards. 

*   Ability to run multiple scripts at once and precalculate multiple scripts at once.

------

## User interface

* Main WinForm window; with track displayed as well as options menu and buttons that user can interact with such as ``Run Script/s``, ``Upload track``,``Options`` etc. (**to be discussed**) 

------

## Functional requirements 

* The application is written in WinForms app, which implies usage of Windows.
* .NET 6 installed on the device
* Multithreaded
* Ability to interpret (compile?) scripts

------

## Data inputs 

* User written script that will be compiled/interpreted and based on its functionality move the robot around

* Option for user to use different self defined paths (upload image file)

* Options for user such as:

  - setting the position of robot

  * choosing the track
  * allowing/disabling physics options (**to be discussed later**)
  * **TO DO**

------

## Notes to resolve 

* **TBD**

------

## Deadlines

* **TBD**

------

## 
