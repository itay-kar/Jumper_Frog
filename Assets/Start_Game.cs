using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Start_Game : MonoBehaviour
{
    public InputAction startGame = new InputAction(type: InputActionType.Button);


    void OnEnable()
    {
        startGame.Enable();
    }

    void OnDisable()
    {
        startGame.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool start = startGame.triggered;
        Debug.Log("start: " + start);
        if (start)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
