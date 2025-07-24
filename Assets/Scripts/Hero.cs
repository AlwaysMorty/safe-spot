using UnityEngine;

/// <summary>
/// Simple hero that can be served. When clicked, it notifies the GameManager and destroys itself.
/// </summary>
public class Hero : MonoBehaviour
{
    public HeroNeed Need { get; private set; }
    SpriteRenderer needIcon;

    public void Setup(HeroNeed need)
    {
        Need = need;
        var iconObj = new GameObject("NeedIcon");
        iconObj.transform.SetParent(transform);
        iconObj.transform.localPosition = Vector3.up * 1.2f;
        needIcon = iconObj.AddComponent<SpriteRenderer>();
        needIcon.sprite = Resources.Load<Sprite>($"Sprites/need_{need.ToString().ToLower()}");
    }

    void OnMouseDown()
    {
        var gm = FindObjectOfType<GameManager>();
        if (gm != null)
        {
            gm.ServeHero(this);
        }
    }
}
