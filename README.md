# AstroSimCharts
The goal of this project is to create a C# Forms application that charts celestial objects on a point chart. Once the charting functions are available, functions that calculate distance, velocity, and gravitational pull will be added.
This personal project is meant to help me learn C# fundamentals.

## Forms
### SystemPointChart
![Screenshot of the main form called SystemPointChart. Its a Box with a section for a point chart on top and a section for buttons on the bottom. The buttons have labels "Add a planet" and "Add a Satellite"](/assets/images/MainForm.png)
Form that contains two sections :
* Points chart : Charts every object added to the system as points using a cartesian system.
* Buttons : Opens a dialog box with textboxes to allow users to add an object of their choice to the system.<br>

### ObjectDialogBox
<p align="center">
  <img src="/assets/images/DialogBox.png" alt="Screenshot of the dialog box that opens when you click on either the 'Add a planet' button or 'Add a satellite'"/>
</p>

Form that opens when either "Add planet" or "Add satellite" buttons are pressed. Has textboxes to allow users to input data used to create objects that will later be charted on the points chart in the SystemPointChart form. 
Data that can be inputted:
* Object name
* Object mass
* Object X position
* Object Y position
* Object Z position
## Classes
As of now, the only difference between child classes of Object is their implementation of the IdentifySelf() method. Further updates will add more methods unique to each subclass.
### Object
An abstract class that serves as an interface for every celestial object that can be found in the system. Has attributes :
* Name
* Mass
* X position
* Y position
* Z position
Defines an abstract method IdentifySelf() that will be implemented in its child classes and a StatePosition() method to allow all objects in the system to state its position. These methods make the debugging and the testing simpler.
### Planet
A class that implements Object. Supposed to represent a Planet.
### Satellite
A class that implements Object. Supposed to represent a Satellite.
### ObjectSystem
A class that represents a system of celestial objects (like the solar system). It contains a list of celestial objects so that it can be used in the points chart later on in the project. It has two methods to add either a Planet or a Satellite to its list of objects.
It will eventually have functions to populate the chart with data.

