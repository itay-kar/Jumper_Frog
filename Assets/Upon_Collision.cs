using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Upon_Collision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if frog being hit by car, reset frog to start
        
        // if frog reaches end, reset frog to start


    }

    void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;

        if (other.tag == "Car")
        {
            Debug.Log("Collision with car");
            // move SceneController to Win Scene
            SceneManager.LoadScene("LossScene");

            // reset frog to start
        }

        if (other.tag == "End")
        {
            Debug.Log("Collision with end");
            // reset frog to start
            SceneManager.LoadScene("WinScene");
        }
    }


}
