using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int velocidad;
    public int vidas;
    public float valorGravedad = 15.81f;
    CharacterController controller;
    public TextMeshProUGUI vidasTexto;
    public TextMeshProUGUI tiempoTexto;
    private Vector3 posicionInicialPlayer;
    float contadorSegundos = 0;
    int tiempoCrearComida = 3;
    
    public GameObject comidaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        posicionInicialPlayer = gameObject.transform.position;
        //puntuacion = 10;
        //gameObject.name = "NuevoNombre";
        //gameObject.SetActive(false);
        //Debug.Log (gameObject.name);
        //Debug.Log(gameObject.transform.position);
        //Debug.Log(gameObject.transform.rotation);
        //Debug.Log(gameObject.transform.localScale);

        //Debug.Log(gameObject.GetComponent<Transform>().position);

        //Debug.Log(gameObject.GetComponent<Jugador>().enabled);
        //gameObject.GetComponent<Jugador>().gameObject.SetActive(false);
        //Debug.Log(gameObject.GetComponent<Jugador>().gameObject.transform.name);


        //Debug.Log("Hola mundo");
    }

    // Update is called once per frame
    public void Update()
    {
        Movimiento();
        DebajoDeSuelo();
        Contador();
        CrearComida();

    }

    public void CrearComida()
    {
        if (contadorSegundos > tiempoCrearComida)
        {

            Debug.Log("Crear comida");
            tiempoCrearComida += tiempoCrearComida;
            
            int x = UnityEngine.Random.Range(0, 26);
            int z = UnityEngine.Random.Range(0, 39);
            Vector3 nuevaPosicion = new Vector3(x, 2, z);
            Instantiate(comidaPrefab, nuevaPosicion, Quaternion.identity);
        }
    }

    public void Contador()
    {
        //El tiempo que tardó en completar el último frame   
        contadorSegundos += Time.deltaTime;
        tiempoTexto.text= "Tiempo: " + Convert.ToInt32(contadorSegundos).ToString();

    }

    public void DebajoDeSuelo()
    {
        if (gameObject.transform.position.y < -25)
        {
            Debug.Log("Bajo el suelo");
            //gameObject.transform.position = Vector3.zero;
            gameObject.transform.position = posicionInicialPlayer;
            vidas --;
            vidasTexto.text = "Vidas: " + vidas.ToString();
        }
    }

    public void Movimiento()
    {
        //Debug.Log("Hola mundo cruel");
        //Debug.Log(gameObject.transform.position);

        float horizontal = Input.GetAxis("Horizontal");
        //Debug.Log(horizontal);

        float vertical = Input.GetAxis("Vertical");
        //Debug.Log(vertical);

        Vector3 direccion = new Vector3(horizontal, 0, vertical);
        direccion.y = direccion.y - valorGravedad;
        //direccion.y -= valorGravedad;

        //Saltar
        if(Input.GetButton("Jump"))
        {
            direccion.y = 10;
        }

        controller.Move(direccion * Time.deltaTime * velocidad);

    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger: " + other.name);

        if (other.tag == "Explosivos")
        {
            vidas = vidas - 1; //restarle una vida a las vidas actuales
            //vidas -= 1;
            //vidas--;
            other.gameObject.SetActive(false);
            vidasTexto.text = "Vidas: " + vidas.ToString();
        }
        if (other.tag == "Comida")
        {
            vidas = vidas + 1; //sumar una vida a las vidas actuales
            other.gameObject.SetActive(false);
            vidasTexto.text = "Vidas: " + vidas.ToString();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
    }


}
