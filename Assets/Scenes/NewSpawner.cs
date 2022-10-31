using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawner : MonoBehaviour
{
    [SerializeField]

    private float spawnradius = 7;
        public float time;
    public GameObject[] enemies;

    private void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    IEnumerator SpawnAnEnemy()
    {
        Vector2 spawnpos = GameObject.Find("Square").transform.position;
        spawnpos += Random.insideUnitCircle.normalized * spawnradius;

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnpos, Quaternion.identity);

        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnAnEnemy());
    }
}
