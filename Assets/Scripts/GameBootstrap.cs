using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Initializes core objects at runtime so the project can run without a prepared scene.
/// Creates a camera, background, UI canvas and spawn point if they do not exist.
/// </summary>
public class GameBootstrap : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod]
    static void OnLoad()
    {
        new GameObject("Bootstrap").AddComponent<GameBootstrap>();
    }
    void Awake()
    {
        SetupCamera();
        SetupBackground();
        SetupSpawnPoint();
        SetupCanvas();
        SetupManagers();
    }

    void SetupCamera()
    {
        if (Camera.main == null)
        {
            var camObj = new GameObject("Main Camera");
            camObj.tag = "MainCamera";
            var cam = camObj.AddComponent<Camera>();
            cam.orthographic = true;
        }
    }

    void SetupBackground()
    {
        if (GameObject.Find("Background") != null) return;

        var bgSprite = Resources.Load<Sprite>("Sprites/background");
        if (bgSprite == null) return;
        var bg = new GameObject("Background");
        var sr = bg.AddComponent<SpriteRenderer>();
        sr.sprite = bgSprite;
    }

    void SetupSpawnPoint()
    {
        if (GameObject.Find("HeroSpawnPoint") == null)
        {
            var sp = new GameObject("HeroSpawnPoint");
            sp.transform.position = Vector3.zero;
        }
    }

    void SetupCanvas()
    {
        if (FindObjectOfType<Canvas>() != null) return;

        var canvasObj = new GameObject("Canvas");
        var canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasObj.AddComponent<CanvasScaler>();
        canvasObj.AddComponent<GraphicRaycaster>();
    }

    void SetupManagers()
    {
        if (FindObjectOfType<GameManager>() == null)
        {
            var obj = new GameObject("GameManager");
            obj.AddComponent<GameManager>();
        }
        if (FindObjectOfType<HeroSpawner>() == null)
        {
            var obj = new GameObject("HeroSpawner");
            obj.AddComponent<HeroSpawner>();
        }
        if (FindObjectOfType<UpgradeManager>() == null)
        {
            var obj = new GameObject("UpgradeManager");
            obj.AddComponent<UpgradeManager>();
        }
    }
}
