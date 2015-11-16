using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
    public GameObject[] misEsferas;
    private float[] distancias;
    private int escala;
    private float turn;
    private float turnSpeed;
    private float maxVelocity;
    private float push;
	// Use this for initialization
	void Start () {
        distancias = new float[4];
        distancias[0] = Random.Range(1, 3) +misEsferas[0].transform.position.y;
        distancias[1] = Random.Range(1, 3) +misEsferas[1].transform.position.y;
        distancias[2] = Random.Range(1, 3) +misEsferas[2].transform.position.y;
        distancias[3] = Random.Range(1, 3) + misEsferas[3].transform.position.y;
        //Radios aleatorios
        Debug.Log(misEsferas[0].ToString());
        escala = Random.Range(2, 5);
        Debug.Log("Soy la escala1 " + escala);
        misEsferas[0].transform.localScale.Set(escala, escala, escala);
        escala = Random.Range(2, 5);
        Debug.Log("Soy la escala2 " + escala);
        misEsferas[1].transform.localScale.Set(escala, escala, escala);
        escala = Random.Range(2, 5);
        Debug.Log("Soy la escala3 " + escala);
        misEsferas[2].transform.localScale.Set(escala, escala, escala);
        escala = Random.Range(2, 5);
        Debug.Log("Soy la escala4 " + escala);
        misEsferas[3].transform.localScale.Set(escala, escala, escala);

        maxVelocity = 5.0f;
        turnSpeed = 2.0f;

    }
	
	// Update is called once per frame
	void Update () {

        Controles();
	}

    void Controles()
    {
        turn = Input.GetAxis("Horizontal");
        push = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {


            //Esfera 1

            if (misEsferas[0].transform.position.y != distancias[0]) {
                Debug.Log("Estoy por aquí razonando 0");
                misEsferas[0].transform.Translate(new Vector3(0, misEsferas[0].transform.position.x + turn * turnSpeed, 0));
                misEsferas[0].GetComponent<Rigidbody>().velocity = transform.forward * push * maxVelocity;
            }

            //Esfera 2

            if (misEsferas[1].transform.position.y != distancias[1])
            {
                Debug.Log("Estoy por aquí razonando 1");
                misEsferas[1].transform.Translate(new Vector3(0, misEsferas[1].transform.position.y + turn * turnSpeed, 0));
                misEsferas[1].GetComponent<Rigidbody>().velocity = transform.forward * push * maxVelocity;
            }

            //Esfera 3

            if (misEsferas[2].transform.position.y != distancias[2])
            {
                Debug.Log("Estoy por aquí razonando 2");
                misEsferas[2].transform.Translate(new Vector3(0, misEsferas[2].transform.position.y+turn * turnSpeed,0));
                misEsferas[2].GetComponent<Rigidbody>().velocity = transform.forward * push * maxVelocity;
            }

            //Esfera 4

            if (misEsferas[3].transform.position.y != distancias[3])
            {
                Debug.Log("Estoy por aquí razonando 3");
                misEsferas[3].transform.Translate(new Vector3(0, misEsferas[3].transform.position.y+turn * turnSpeed, 0));
                misEsferas[3].GetComponent<Rigidbody>().velocity = transform.forward * push * maxVelocity;
            }



        }
    }
}
