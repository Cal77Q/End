using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player;
    Renderer rend;

    float playerStartPos;
    public float speed = 0.5f;

   
    
    // Start is called before the first frame update
    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));


    }

    // Update is called once per frame
    
  
}
