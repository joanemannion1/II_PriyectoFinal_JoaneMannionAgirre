using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{	
	public delegate void updateMarker();
	public static event updateMarker updateMarkerEvent;
    // Start is called before the first frame update
    void Start()
    {
    	
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp() {
    	
    	Destroy(gameObject);
    	updateMarkerEvent();
	}

	
}
