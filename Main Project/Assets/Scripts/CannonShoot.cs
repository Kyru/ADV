using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    [SerializeField] private GameObject cannonballPrefab;
    private List<GameObject> cannons;
    private bool spawnNext;
    void Start()
    {
        spawnNext = true;
        cannons = new List<GameObject>();
        foreach (Transform child in this.gameObject.transform)
        {
            cannons.Add(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnNext) StartCoroutine("SpawnCannonBall");
    }

    IEnumerator SpawnCannonBall()
    {
        spawnNext = false;
        yield return new WaitForSeconds(2);
        int randomCannon = Random.Range(0, 4);
        Instantiate(cannonballPrefab, cannons[randomCannon].transform.position, cannonballPrefab.transform.rotation, gameObject.transform);
        spawnNext = true;
    }
}
