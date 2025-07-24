using System.Collections;
using UnityEngine;

/// <summary>
/// Spawns heroes periodically at the spawn point.
/// </summary>
public class HeroSpawner : MonoBehaviour
{
    public float spawnInterval = 15f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnHero();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnHero()
    {
        var heroSprite = Resources.Load<Sprite>("Sprites/hero");
        if (heroSprite == null) return;

        var heroObj = new GameObject("Hero");
        heroObj.transform.position = GameObject.Find("HeroSpawnPoint").transform.position;
        var sr = heroObj.AddComponent<SpriteRenderer>();
        sr.sprite = heroSprite;
        heroObj.AddComponent<BoxCollider2D>();
        var hero = heroObj.AddComponent<Hero>();
        var need = (HeroNeed)Random.Range(0, System.Enum.GetValues(typeof(HeroNeed)).Length);
        hero.Setup(need);
    }
}
