using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class ProjectSetup
{
    private static readonly string[] Folders = {
        "Scenes", "Scripts", "Prefabs",
        "Sprites", "Audio", "UI", "Materials"
    };

    [MenuItem("Tools/Project Setup/Create Default Folders")]
    public static void CreateDefaultFolders()
    {
        foreach (string folder in Folders)
        {
            if (!AssetDatabase.IsValidFolder("Assets/" + folder))
            {
                AssetDatabase.CreateFolder("Assets", folder);
            }
        }

        var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        EditorSceneManager.SaveScene(newScene, "Assets/Scenes/Main.unity");
        AssetDatabase.Refresh();
        Debug.Log("Standardordner und Main‑Szene wurden erstellt.");
    }
}
