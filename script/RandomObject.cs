using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RandomObject : MonoBehaviour
{
	public GameObject ball;
	public int xPos;
	public int zPos;
	public int objectToGenerate;
	public int objectQuantity;
	public int maxBalls;
	public int minX, minZ, maxX, maxZ;
    // Start is called before the first frame update
    void Start()
    {
    	Scene currentScene = SceneManager.GetActiveScene ();
    	if (currentScene.name == "World0") {
    	 	maxBalls = 20;
            minZ = 00;
            maxZ = 700;
            minX = -900;
            maxX = 120;
        }
        if (currentScene.name == "World1") {
        	maxBalls = 5;
        	minZ = -80;
        	maxZ = 350;
        	minX = -300;
        	maxX = 160;
        }
        StartCoroutine(GenerateObjects());
       
    }

    IEnumerator GenerateObjects() {
    	while(objectQuantity < maxBalls) {
    		xPos = Random.Range(minX, maxX);
    		zPos = Random.Range(minZ, maxZ);
    		Instantiate(ball, new Vector3(xPos, 50, zPos), Quaternion.identity);
    		yield return new WaitForSeconds(0.1f);
    		objectQuantity += 1;
    	}
    }

}