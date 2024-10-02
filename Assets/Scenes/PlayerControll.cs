using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Create a referemce to the the Rigidbody2D so we can manipulate it 
    Rigidbody2D playerObject;
    public float speed = 100f;

    public AudioClip jump;
    public AudioClip background;
    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;



    // Start is called before  the first frame update 
    void Start()
    {
        //Find the Rigidbody2D componebt that is attached to the same object as this script 
        playerObject = GetComponent<Rigidbody2D>();

    

    }


    void Update()
    {
        //Create a  'float' that will be equal to the players horizontal input
        float movementValueX = Input.GetAxis("Horizontal");
        float movementValueY = Input.GetAxis("Vertical");

        //Change theX velocity of the Rigidbody2D to be equal to the movement value 
        playerObject.velocity = new Vector2(movementValueX * speed , playerObject.velocity.y);
        playerObject.velocity = new Vector2(playerObject.velocity.x, movementValueY * speed);




    }



 
   
  
}
