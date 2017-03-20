using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bala_enemiga : MonoBehaviour {

    private Rigidbody2D rb2D;
    float thrust;     // velocidad de la bala
    public GameObject balaDestruida;


    // Use this for initialization
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        thrust = 2.5f;
     
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.AddForce(transform.up * thrust);

        if (transform.position.y < -15.0f)
        {
            Destroy(balaDestruida);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name != "enemy")
        {
            Destroy(col.gameObject);
            
        }
        if (col.gameObject.name == "player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
