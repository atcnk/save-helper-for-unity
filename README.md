# save-helper-for-unity

This is my Save Helper project for Unity. This system makes saving easier and increases the number of variable types you can save. 

Unity allows saving only 3 different variable tpyes which are integer, float and string. But in game development we need other types like booleans, Vectors (Vector2-3-4) etc. With Save Helper you can also save these types easily: 

- Bool
- Char
- Vector2
- Vector3
- Vector4
- Quaternion

It also has Delete method which removes the given key and DeleteAll method which removes all save. You can check if key exists with HasKey method. 

SaveHelper is a static class so you can access it from anywhere.

In the project, you can test save system with TestHelper game object. Assign values from inspector. You can save them with button 'X' and load them with button 'Z'. 
