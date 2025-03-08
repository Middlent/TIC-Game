using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Player_Inputs inputActions;
    public float speed = 2.7f;
    SpriteRenderer sprite;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        inputActions = new Player_Inputs();
    }
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void onEnable(){
        inputActions.Enable();
    }

    void onDisable(){
        inputActions.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        var moveInputs = inputActions.Player_Map.Movement.ReadValue<Vector2>();

        Debug.Log("Move Inputs " + moveInputs);

        transform.position += speed * Time.deltaTime * new Vector3(moveInputs.x, 0, 0);

        animator.SetBool("b_isWalking", moveInputs.x != 0);
       
        if (moveInputs.x != 0){
            sprite.flipX = moveInputs.x < 0;
        }
    }
}
