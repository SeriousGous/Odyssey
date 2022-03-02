using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FristOutTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered***");
    }
    void OnTriggerStay(Collider other)
    {
        if (GameObject.Find("ThirdPersonCamera").GetComponent<EventManager>().transparency > 0f)
            GameObject.Find("ThirdPersonCamera").GetComponent<EventManager>().transparency -= 0.05f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
