using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour {

    public GameObject balaDestruida;
    public Transform[] camino;
    public float speed = 5.0f;
    public float meta = 1.0f;
    public int punto = 1;
    int numEnemies;
    int number = 0;
    bool couroutineStarted = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

           float distancia = Vector3.Distance(camino[punto].position, transform.position);

           transform.position = Vector3.MoveTowards(transform.position, camino[punto].position, Time.deltaTime*speed);

        //Vector3 dir = camino[punto].position - transform.position;
        //transform.position += dir * Time.deltaTime* speed;

        if (distancia <= meta)
        {
            punto++;
        }
        if(punto >= camino.Length)
        {
            punto = 0;

        }

        numEnemies = 1;
        for (int i = 0; i < numEnemies; i++)
        {
            StartCoroutine(UsingYield(5));
            Instantiate(balaDestruida, transform.position, transform.rotation);
            numEnemies = numEnemies - 1;
        }
    }

    void dibujo()
    {
        for (int i= 0; i < camino.Length; i++)
        {
            if(camino[i] != null)
            {
                Gizmos.DrawSphere(camino[i].position, meta);
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
