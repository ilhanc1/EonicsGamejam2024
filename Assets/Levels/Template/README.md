﻿# Getting started
1) Copy the folder "Template" and rename it to "FirstnameLastname" (your name)
2) Open PlayerController.cs and update line 4:
   ```cs
   namespace Levels.Template >> namespace Levels.FirstnameLastname
   ```
3) Open DoorController.cs and do the same:
   ```cs
   namespace Levels.Template >> namespace Levels.FirstnameLastname
   ```
4) Change the name of the scene file "template.unity" to "firstname_lastname.unity"
5) Open your scene by double clicking on the scene file
6) In the scene hierarchy (top-left), open the "Core Objects" and select the "Player" object.  
![img.png](../../Lib/DocumentationImages/scene_hierarchy.png)  
In the inspector (top-right), press the 3 dots and select "debug" view.  
![img.png](../../Lib/DocumentationImages/object_inspector.png)  
In the same inspector, press the circle next to the PlayerController script and select the PlayerController script that resides in your folder.  
You can also drag and drop your script into this box.  
![img.png](../../Lib/DocumentationImages/object_inspector2.png)
7) Repeat step 6 for the DoorController
8) Put your object inspector back into normal mode (from debug)
9) Press the play button and check that everything runs correctly!

# Building a level 
     