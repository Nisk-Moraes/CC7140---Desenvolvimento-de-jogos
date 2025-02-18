using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquetes : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float UpperY = 0f;
    public float LowerY = 5f;
    public float LimitX = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        if (gameObject.CompareTag("Player")){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            pos.x = mousePos.x;
            pos.y = mousePos.y;
            if (mousePos.y > UpperY){
                pos.y = UpperY;
            }
            if(mousePos.y < (LowerY*-1)){
                pos.y = LowerY*-1;
            }
            
                
            
            if (mousePos.x > LimitX){
                pos.x = LimitX;
            }
            if(mousePos.x < (LimitX*-1)){
                pos.x = LimitX*-1;
            }
            
            
        }
        else{
            pos.x = GameObject.FindWithTag("Bola").transform.position.x;
        }
        transform.position = pos;
       
    }
}
