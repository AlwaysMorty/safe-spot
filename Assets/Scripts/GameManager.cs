using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Tracks player gold and handles hero serving.
/// </summary>
public class GameManager : MonoBehaviour
{
    public int Gold { get; private set; }
    public int RewardPerHero => 1 + PlayerPrefs.GetInt("Upgrade_Gold", 0);
    Text goldText;

    void Start()
    {
        Gold = PlayerPrefs.GetInt("Gold", 0);
        goldText = FindObjectOfType<Canvas>().gameObject.AddComponent<Text>();
        var tf = goldText.rectTransform;
        tf.anchorMin = new Vector2(0, 1);
        tf.anchorMax = new Vector2(0, 1);
        tf.pivot = new Vector2(0, 1);
        tf.anchoredPosition = new Vector2(10, -10);
        goldText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        UpdateGoldUI();
    }

    public void ServeHero(Hero hero)
    {
        Gold += RewardPerHero;
        PlayerPrefs.SetInt("Gold", Gold);
        PlayerPrefs.Save();
        UpdateGoldUI();
        Destroy(hero.gameObject);
    }

    void UpdateGoldUI()
    {
        if (goldText != null)
        {
            goldText.text = $"Gold: {Gold}";
        }
    }
}
