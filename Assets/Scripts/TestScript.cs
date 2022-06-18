using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public int monedas;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HOLAAA MUNDOOOO");
        ChauMundo();
    }

    // Update is called once per frame
    void Update()
    {
        RecolectarMonedas();
    }

    void ChauMundo()
    {
        Debug.Log("chaaaaauuuu mundo");
    }

    void Saltar()
    {
	Debug.Log("El jugador esta saltando");	
    }

    void RecolectarMonedas()
    {
        monedas++;
        Debug.Log("He recolectado "+monedas+" monedas");
    }
}
