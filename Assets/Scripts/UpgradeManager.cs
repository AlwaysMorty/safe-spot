using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Provides a simple upgrade to increase gold reward per hero.
/// </summary>
public class UpgradeManager : MonoBehaviour
{
    Text buttonText;

    void Start()
    {
        var canvas = FindObjectOfType<Canvas>();
        var btnObj = new GameObject("UpgradeButton");
        btnObj.transform.SetParent(canvas.transform);
        var btn = btnObj.AddComponent<Button>();
        var image = btnObj.AddComponent<Image>();
        image.color = Color.grey;
        var rect = btnObj.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(1, 1);
        rect.anchorMax = new Vector2(1, 1);
        rect.pivot = new Vector2(1, 1);
        rect.anchoredPosition = new Vector2(-10, -10);
        rect.sizeDelta = new Vector2(120, 30);

        buttonText = new GameObject("Text").AddComponent<Text>();
        buttonText.transform.SetParent(btnObj.transform);
        buttonText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        buttonText.alignment = TextAnchor.MiddleCenter;
        buttonText.rectTransform.sizeDelta = rect.sizeDelta;
        UpdateButtonText();

        btn.onClick.AddListener(PurchaseUpgrade);
    }

    void PurchaseUpgrade()
    {
        int level = PlayerPrefs.GetInt("Upgrade_Gold", 0);
        int cost = (level + 1) * 10;
        var gm = FindObjectOfType<GameManager>();
        if (gm != null && gm.Gold >= cost)
        {
            gm.Gold -= cost;
            PlayerPrefs.SetInt("Gold", gm.Gold);
            PlayerPrefs.SetInt("Upgrade_Gold", level + 1);
            UpdateButtonText();
        }
    }

    void UpdateButtonText()
    {
        int level = PlayerPrefs.GetInt("Upgrade_Gold", 0);
        int cost = (level + 1) * 10;
        if (buttonText != null)
            buttonText.text = $"Upgrade (+1)\nCost: {cost}";
    }
}
