using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Input_Mover : MonoBehaviour
{
    public float speed = 0;
    public Rigidbody rb;
    [SerializeField] InputAction moveHorizontal = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction moveVertical = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction Jump = new InputAction(type: InputActionType.Button);
    private Animator anim;
    public float jumpForce = 100;

    void OnEnable()
    {
        moveVertical.Enable();
        moveHorizontal.Enable();
        Jump.Enable();
    }

    void OnDisable()
    {
        moveVertical.Disable();
        moveHorizontal.Disable();
        Jump.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if(anim!=null){
        // Debug.Log(anim.GetBool("isJumping"));
        bool jump = Jump.triggered;
        // Debug.Log("jump: " + jump);
        if (jump)
        {
            if(rb.velocity.y == 0)
            {
                anim.SetBool("isJumping", true);
                Debug.Log("Before velocity check: " + anim.GetBool("isJumping"));
                transform.Translate(Vector3.back * speed * Time.deltaTime);                
            }
            anim.SetBool("isJumping", false);
                Debug.Log("After velocity check: " + anim.GetBool("isJumping"));
        }
}



}
}