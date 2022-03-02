using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;
    public float transparency = 0f;
    void OnGUI()

    {

        GUI.color = new Color(1, 1, 1, transparency);
        //GUI.color.a = x;
        if (GUI.Button(new Rect(Screen.width / 10, 10, 100, 100), "Click"))
        {
            if (OnClicked != null)
                OnClicked();
        }
        //transparency = transparency - 0.001f;
    }

}