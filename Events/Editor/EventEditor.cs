using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameEventBase), editorForChildClasses: true)]
public class EventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEventBase e = target as GameEventBase;
        if (GUILayout.Button("Raise"))
        {
            e.Raise();
        }
    }
}

[CustomEditor(typeof(GameEvent<int>), editorForChildClasses: true)]
public class IntEventEditor : Editor
{
    private int _value;
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEvent<int> e = target as GameEvent<int>;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Value:", GUILayout.Width(50));
        _value = EditorGUILayout.IntField(_value, GUILayout.Width(100));
        EditorGUILayout.EndHorizontal();

        if (GUILayout.Button("Raise"))
        {
            e.Raise(_value);
        }
    }
}

[CustomEditor(typeof(GameEvent<float>), editorForChildClasses: true)]
public class FloatEventEditor : Editor
{
    private float value;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEvent<float> e = target as GameEvent<float>;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Value:", GUILayout.Width(50));
        value = EditorGUILayout.FloatField(value, GUILayout.Width(100));
        EditorGUILayout.EndHorizontal();

        if (GUILayout.Button("Raise"))
        {
            e.Raise(value);
        }
    }
}

[CustomEditor(typeof(GameEvent<bool>), editorForChildClasses: true)]
public class BoolEventEditor : Editor
{
    private bool value;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEvent<bool> e = target as GameEvent<bool>;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Value:", GUILayout.Width(50));
        value = EditorGUILayout.Toggle(value, GUILayout.Width(100));
        EditorGUILayout.EndHorizontal();

        if (GUILayout.Button("Raise"))
        {
            e.Raise(value);
        }
    }
}

[CustomEditor(typeof(GameEvent<string>), editorForChildClasses: true)]
public class StringEventEditor : Editor
{
    private string value;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GameEvent<string> e = target as GameEvent<string>;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Value:", GUILayout.Width(50));
        value = EditorGUILayout.TextField(value, GUILayout.Width(200));
        EditorGUILayout.EndHorizontal();

        if (GUILayout.Button("Raise"))
        {
            e.Raise(value);
        }
    }
}
