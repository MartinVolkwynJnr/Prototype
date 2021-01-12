Prototype: when and where you would use it

Like other creational patterns (Builder, Abstract Factory, and Factory Method), the Prototype design pattern hides object creation from the client. However, instead
of creating a non-initialized object, it returns a new object that is initialized with values it copied from a prototype - or sample - object. The Prototype design 
pattern is only occasionally used in business applications. You'll find it used more often in specialized types of apps, such as, computer graphics, CAD (Computer Assisted
Drawing), GIS (Geographic Information Systems), and computer games.

The Prototype design pattern creates clones of pre-existing sample objects. The best way to implement this in .NET is to use the built-in ICloneable interface on 
the objects that are used as prototypes. ICloneable has a method named Clone that returns an object that is a copy, or clone, of the original object.

When implementing the Clone method you need to be aware there are two types of clone operations: deep copy and shallow copy. Shallow copy only copies properties 
of the object itself but no object references. Deep copy copies the prototype object and all the objects references (which can be several levels deep).

Shallow copy is easy to implement because the Object base class has a MemberwiseClone method that returns a shallow copy of the object. Creating a deep copy can 
be more complicated because some objects are not readily copied (such as Threads, Database connections, etc.). Also, you will need to watch out for circular 
references.


Participants

The classes and/or objects participating in this pattern are:

 Prototype (ColorPrototype)
	o declares an interace for cloning itself
 ConcretePrototype (Color)
	o implements an operation for cloning itself
 Client (ColorManager)
	o creates a new object by asking a prototype to clone itself

Real-world sample code
The real-world code demonstrates the Prototype pattern in which new Color objects are created by copying pre-existing, user-defined Colors of the same type.
Code in project: DoFactory.GangOfFour.Prototype.NetOptimized

.NET optimized sample code
The .NET optimized code demonstrates the same functionality as the real-world example but uses more modern, built-in .NET features. The abstract classes have been
replaced by interfaces because the abstract classes contain no implementation code. RGB values range between 0-255, therefore the int has been replaced with a smaller
byte data type. The colors collection in the ColorManager class is implemented with a type-safe generic Dictionary class. A Dictionary is an array of key/value pairs.
In this implementation the key is of type string (i.e. the color name) and the value is of type Color (the Color object instance).

ICloneable is a built-in .NET prototype interface. ICloneable requires that the class hierarchy be serializable. Here the Serializable attribute is used to do just 
that (as an aside: if a class has 'event' members then these must be decorated with the NonSerialized attribute). Alternatively, reflection could have been used to 
query each member in the ICloneable class (tip: always check for performance when implementing cloning many objects through serialization or reflection).
