using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchrotate : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if(!GameControl.youwin)
        {
            transform.Rotate(0, 0, 90);
        }
    }
}
