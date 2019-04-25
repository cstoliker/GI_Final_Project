using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Pooler objectPool;
    public float min = 2f;
    public float max = 3f;

    private void Start()
    {
        StartCoroutine(startSpawning());
        
    }


    private void SpawnObject()
    {
        GameObject newItem = objectPool.GetPooledObject();
        newItem.transform.position = transform.position;
        newItem.transform.rotation = transform.rotation;
        newItem.SetActive(true);
    }

    IEnumerator startSpawning()
    {
        while (true)
        {
            int randomTime = UnityEngine.Random.Range(5, 10); //picks a random time
            int randomChance = UnityEngine.Random.Range(0, 100);
            if (randomChance < 50)
            {
                yield return new WaitForSeconds(randomTime);
                SpawnObject();
            }
        }
    }
}