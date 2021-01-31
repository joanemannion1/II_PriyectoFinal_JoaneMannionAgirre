using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreasureScript : MonoBehaviour
{
	Scene currentScene;
	GameObject treasure;
    // Start is called before the first frame update
    void Start()
    {
       treasure = GameObject.FindGameObjectWithTag("Treasure");
    	treasure.SetActive(false);
    	textScript.nextLevelEvent += showTreasure; 
    	currentScene = SceneManager.GetActiveScene ();
    	
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showTreasure() {
		treasure.SetActive(true);
	}

	public void PickUp() {
    	Destroy(gameObject);
    	if (currentScene.name == "World0") {
    		SceneManager.LoadScene("World1");
    	}
    	if (currentScene.name == "World1") {
    		SceneManager.LoadScene("Menu");
    	}
	}
}
