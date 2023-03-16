# Unity Event System Using Scriptable Objects
 This is a flexible and easy-to-use event system for Unity, implemented using ScriptableObject-derived classes. The system allows you to define events with custom data types that can be easily subscribed to and raised by game objects or other scripts.  The main advantage of this event system is that it decouples event logic from game objects and scripts, making it easier to maintain and refactor your code. Additionally, it allows you to define events as assets in your project, which can be reused across multiple game objects and scenes.  The system includes a base event class (BaseEvent<T>) that can be inherited to define custom events with specific data types, as well as a void event class (VoidEvent) for events with no data. The events can be raised by calling the RaiseEvent method, which will invoke all subscribed event handlers.  This project includes several example classes that demonstrate how to use the event system, as well as a simple demo scene that showcases some basic functionality. We hope that this event system will be useful to other Unity developers looking for a flexible and maintainable way to implement events in their games or applications.


### Git URL

Project supports Unity Package Manager. To install the project as a Git package do the following:

1. In Unity, open **Window** -> **Package Manager**.
2. Press the **+** button, choose "**Add package from git URL...**"
3. Copy the URL below.
```
https://github.com/FahimKamal/Unity_Event_System_Using_Scriptable_Objects.git#package
```
3. Enter the **URL** and press **Add**.
