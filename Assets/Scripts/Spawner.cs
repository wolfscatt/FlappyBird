using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public BirdManager birdManager;

    public GameObject boru;

    public float height;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(SpawnObject(time));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!birdManager.isDead)
        {
            Instantiate(boru, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
