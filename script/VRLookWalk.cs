using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class VRLookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float toggleAngle = 15.0f;
    public float speed = 30.0f;
    public bool moveForward;

    private CharacterController cc;

    [SerializeField] private string[] keywords;
    private KeywordRecognizer recognizer;

    // Use this for initialization
    void Start()
    {
        moveForward = true;
        cc = GetComponent<CharacterController>();
        keywords = new string[]{"rapido", "lento", "parar", "empezar"};
        recognizer = new KeywordRecognizer(keywords);
        recognizer.OnPhraseRecognized += OnPhraseRecognized;
        recognizer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        // if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        // {
        //     moveForward = true;
        // }
        // else
        // {
        //     moveForward = false;
        // }

        if (moveForward )
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
        }
    }

     private void OnPhraseRecognized(PhraseRecognizedEventArgs datos) {
        if (datos.text == "rapido") {
                speed +=10.0f;
        }
        if (datos.text == "lento") {
                speed = speed - 10.0f;
        }
        if (datos.text == "parar") {
               moveForward = false;
        }
        if (datos.text == "empezar") {
                moveForward = true;
        }
    }
}