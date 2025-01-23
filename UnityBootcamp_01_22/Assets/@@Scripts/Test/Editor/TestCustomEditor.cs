using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.UIElements;


public class TestCustomEditor : EditorWindow
{
    #region Variable
    string hw = "Hello World!";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;
    #endregion


    [MenuItem("TK/TestCustom")]
    public static void ShowWindow()
    {
        TestCustomEditor wnd = GetWindow<TestCustomEditor>();
        wnd.titleContent = new GUIContent("Test Custom Window");
    }

    //실제 콘텐츠가 들어가는 부분
    private void OnGUI()
    {
        //Test_UnityDocs01();
        Test_UnityDocs02();
    }

    /// <summary>
    /// Unity Documents 참고
    /// </summary>
    private void Test_UnityDocs01()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        hw = EditorGUILayout.TextField(hw);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        {
            myBool = EditorGUILayout.Toggle(myBool);
            myFloat = EditorGUILayout.Slider("Slider", myFloat, 0, 100);
        }
        EditorGUILayout.EndToggleGroup();
    }

    /// <summary>
    /// Unity Documents2
    /// </summary>
    private void Test_UnityDocs02()
    {
        //VisualElements objects can contain other VisualElement following a tree hierarchy
        VisualElement root = rootVisualElement;

        Label label = new Label("Hello World");
        root.Add(label);

        Button btn = new Button();
        btn.name = "button";
        btn.text = "Button";
        root.Add(btn);
    }




}
