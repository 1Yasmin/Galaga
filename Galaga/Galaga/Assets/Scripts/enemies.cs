using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour {

    public GameObject prefab;
    int numEnemies;
    int number = 0;
    bool couroutineStarted = false;

    // Use this for initialization
    void Start () {
        numEnemies = 10;
    }
	
	// Update is called once per frame
	void Update () {
        if (!couroutineStarted)
        {
            for (int i = 0; i < numEnemies; i++)
            {
                StartCoroutine(UsingYield(1));
                Instantiate(prefab, transform.position, transform.rotation);
                numEnemies = numEnemies - 1;
            }
        }
       
    }

    IEnumerator UsingYield(int seconds)
    {
        couroutineStarted = true;

        yield return new WaitForSeconds(seconds);
        number++;

        couroutineStarted = false;
    }
}
