using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public bool is_2d_cam = true;
    Vector3 camera_pos;
    [SerializeField]
    private CinemachineFreeLook vcam1; //3d

    [SerializeField]
    private CinemachineVirtualCamera vcam2; //2d  


    void OnEnable()
    {
        EventManager.OnClicked += CamSwitch;

    }

    void OnDisable()
    {
        EventManager.OnClicked -= CamSwitch;
    }

    void CamSwitch()
    {
        if (is_2d_cam)
        {
            CamBackSwitch();
            is_2d_cam = !is_2d_cam;
            // camera_pos = GameObject.FindGameObjectWithTag("Your_Tag_Here").transform.position;
        }
        else
        {
            Debug.Log("Hello world!");
            GameObject.Find("SecondPersonCamera").transform.position += new Vector3(36f, 2f, 34f);
            GameObject.Find("ThirdPersonPlayer").GetComponent<MovementScript>().gravity = 0f;
            vcam1.Priority = 0;
            vcam2.Priority = 1;
            is_2d_cam = !is_2d_cam;
        }
    }
    void CamBackSwitch()
    {
        Debug.Log("Back to 3D");
        vcam2.Priority = 0;
        vcam1.Priority = 1;
    }
}
// ¿  ∆≈ ﬂ ’Œ–Œÿ