using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class textScript : MonoBehaviour
{	
	public Text marcador;
	public int contador;
	public delegate void nextLevel();
	public static event nextLevel nextLevelEvent;
    // Start is called before the first frame update
    void Start()
    {
    	contador = 00;
    	marcador.text = "" + contador;
        BallScript.updateMarkerEvent += incrementarContador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void incrementarContador() {
    	contador += 10;
    	marcador.text = " " + contador.ToString();
    	if (contador >= 50) {
            marcador.text = "Buscar Tesoro";
    		nextLevelEvent();
    	}
    }
}
