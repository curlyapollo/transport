# transport
## The separate class library "EKRLib" describes the Transport, Car, MotorBoat, and TransportException classes. The abstract class Transport describes an abstract vehicle and contains:
1) String property Model. The model consists of only capital latin characters and digits and exactly 5 characters long. If there is a mismatch, a TransportException is thrown with the message "Недопустимая модель <Model>".
2) Integer property Power (power in horsepower, type uint), cannot be less than 20 (an exception of type TransportException is thrown with the message “мощность не может быть меньше 20 л.с.”).
3) Overridden ToString() method that returns a string of the format "Model: <Model>, Power: <Power>".
4) The abstract method string StartEngine(), overridden in derived classes to get the sound (as a string) emitted by the vehicle.
5) Constructor with parameters for the Model and Power properties.

## The Car class with a parametric constructor that describes a car (an inheritor of the Transport class). Requirements:

1) The overridden ToString() method, assigns the string "Car. " to the left
string returned from the base class method of the same name.
2) Overridden StartEngine() method returning string "<Model>:
Vroom", where <Model> is the model.

## The MotorBoat class with a parametric constructor that describes the MotorBoat (a descendant of the Transport class). Requirements:

1) The overridden ToString() method appends the string "MotorBoat. " to the string returned from the base class method of the same name.
2) Overridden StartEngine() method returning the string "<Model>: Brrrbrr", where <Model> is the model.

## In a console program:

1) An array of the Transport[] type is created, consisting of a random (in the range [6; 10)) number of elements and filled with its references to randomly
generated objects Car and MotorBoat (the choice of object type is equally probable):
Model and Power are generated randomly (Power - in the range [10; 100), Model - according to the specification). If an exception occurs, an attempt to create an object is repeated (the text of the message from the exception is displayed on the screen).
After the object is created (using WriteLine), the result of the StartEngine() call is displayed.
2) Information about vehicles (returned by the ToString() method) from the generated array is written to text files "Cars.txt" and "MotorBoats.txt" (utf-16 encoding, location: folder with the solution file), containing only information about cars (Cars.txt) and motorboats
(MotorBoats.txt) respectively (information about each vehicle on a new line).
