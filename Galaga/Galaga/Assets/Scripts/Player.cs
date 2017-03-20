using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Vector2 naveTras;
    float factorVel;
    public GameObject prefab;
    

    // Use this for initialization
    void Start () {
        // estado inicial
        naveTras = new Vector2(0.0f, 0.0f);
        //factor de la velocidad en el juego
        factorVel = 17.0f;
    }
	
	// Update is called once per frame
	void Update () {
        //iniciar la nave
        naveTras.x = 0.0f;
        naveTras.y = 0.0f;

        // definir el movimiento del player
        // movimiento en y positiva con la flecha de arriba
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            naveTras.x = factorVel * Time.deltaTime;
            transform.Translate(naveTras);
            Instantiate(prefab, transform.position, transform.rotation);
        }

        // movimiento en y negativa con la flecha de abajo
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            naveTras.x = -factorVel * Time.deltaTime;
            transform.Translate(naveTras);
            Instantiate(prefab, transform.position, transform.rotation);
        }
        }
}
