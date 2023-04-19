using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStateController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log("AnimatorStateController: Start");
    }

    // Update is called once per frame
    void Update()
    {
        //update the animator with the current state of the game
        
    }
}
