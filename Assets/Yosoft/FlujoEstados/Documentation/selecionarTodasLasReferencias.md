Para seleccionar multiples objetos
```csharp

[CustomEditor(typeof(EnemyBehaviour)), CanEditMultipleObjects]
public class EnemyBehaviourEditor : Editor
{
public override void OnInspectorGUI()
{
 base.OnInspectorGUI();
 EditorGUILayout.BeginHorizontal();
 if (GUILayout.Button("Select all enemies"))
 {
     var allEnemyBehaviour = GameObject.FindObjectsOfType
            <EnemyBehaviour>();
     var allEnemyGameObjects = allEnemyBehaviour
                                 .Select(enemy => enemy.gameObject)
                                 .ToArray();
     Selection.objects = allEnemyGameObjects;
  }
  if (GUILayout.Button("Clear selection"))
  {
    Selection.objects = new Object[] { (target as
    EnemyBehaviour).gameObject };
   }
   EditorGUILayout.EndHorizontal();
   
   using (new EditorGUILayout.HorizontalScope())
    {
     //Draw the buttons
    }
    var cachedColor = GUI.backgroundColor;
    GUI.backgroundColor = Color.green;
    if (GUILayout.Button("Disable/Enable all enemy", GUILayout.
    Height(40)))
    {
     foreach (var enemy in GameObject.FindObjectsOfType<Enem
    yBehaviour>(true))
     {
    enemy.gameObject.SetActive(!enemy.gameObject.activeSelf);
     }
    }
    GUI.backgroundColor = cachedColor;


}
}

```

|  Field   | Description    |
|-----|-----|

