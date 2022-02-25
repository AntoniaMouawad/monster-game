using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform LeftPos, RightPos;
    private int randomSide;

    [SerializeField]
    private GameObject spawnedHeal;

    [SerializeField]
    private GameObject heal;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnHeal());

    }

    IEnumerator SpawnHeal()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, 5));
            randomSide = Random.Range(0, 2);
            spawnedHeal = Instantiate(heal);
            if (randomSide == 0)
            {
                spawnedHeal.transform.position = LeftPos.position;
                spawnedHeal.GetComponent<Heal>().speed = Random.Range(2, 4);
            }

            else
            {
                spawnedHeal.transform.position = RightPos.position;
                spawnedHeal.GetComponent<Heal>().speed = -Random.Range(2, 4);

            }
            

        }
    }
}
