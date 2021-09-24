using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] int platformNumber = 200;
    void Start()
    {
        SpawnPlatform();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnPlatform()
    {
        Vector2 platform = new Vector2();
        for(int i=0; i<platformNumber; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            platform.x = Random.Range(-2f, 2f);
            platform.y += Random.Range(1.6f, 2);
            tempPlatform.transform.position = platform;

        }
    }
}
