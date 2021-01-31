using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using UnityEngine.SceneManagement;

public class inicioScript : MonoBehaviour
{
	

	[SerializeField] private string[] keywords;
	private KeywordRecognizer recognizer;
    // Start is called before the first frame update
    void Start()
    {
    	keywords = new string[]{"empezar"};
    	recognizer = new KeywordRecognizer(keywords);
    	recognizer.OnPhraseRecognized += OnPhraseRecognized;
    	recognizer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp() {
    	SceneManager.LoadScene("World0");
    }

	 private void OnPhraseRecognized(PhraseRecognizedEventArgs datos) {
        if (datos.text == "empezar") {
        		recognizer.Stop();
        		recognizer.Dispose();
        		PhraseRecognitionSystem.Shutdown();
                SceneManager.LoadScene("World0");
        }
    }
}
