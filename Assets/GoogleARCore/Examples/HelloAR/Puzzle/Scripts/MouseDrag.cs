using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    float distance = 20;
    private bool dragging = false;
    Vector3 startPos;
    Vector3 swapPos;
    SpriteRenderer mySpriteRenderer;

    void Start()
    {

        mySpriteRenderer = GetComponent<SpriteRenderer>();
        startPos = this.transform.position;
    }

    void OnMouseDrag()
    {
        dragging = true;
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = objectPos;
    }
    // void OnCollisionEnter2D(Collision2D col)
    // {
    //Lets say this gameObject (go1) collided to go2
    //so the value of spriteName will be spr2, 'cause go2's spritename is spr2 right?
    //string spriteName = col.gameObject.GetComponent<SpriteRenderer>().sprite.name;

    //The function I used here is to locate and get the sprite name from "spriteName" variable.
    //As you can here below, it says (Sprite)Resource.Load("Sprites/" + spriteName), if you got confuse where the "Sprites/ + spriteName" came from
    //it goes like this  (Sprite)Resource.Load("FolderName/" + spriteName (the variable we declared))
    //mySpriteRenderer.sprite = (Sprite)Resources.Load("Sprites/" + spriteName) as Sprite;
    //Debug.Log("Accident");
    //  swapPos = col.transform.position;
    // this.transform.position = startPos;
    //col.transform.position = startPos;
    //  }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "puzzle")
        {
            Debug.Log("Da");
            swapPos = gameObject.transform.position;
            collision.gameObject.transform.position = startPos;
            this.transform.position = swapPos;
        }
    }
}
