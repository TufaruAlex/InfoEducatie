using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class enablebuttons : MonoBehaviour
{
    public ARCoreSession m_ARCoreSession;
    public GameObject buton;
    public void enablebutton()
    {
        buton.SetActive(true);
    }
    public void disablebutton()
    {
        buton.SetActive(false);
    }
}
