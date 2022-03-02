using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTrigger : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(WaitingCoroutine());
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
    }
    void OnTriggerStay(Collider other)
    {
        if (GameObject.Find("ThirdPersonCamera").GetComponent<EventManager>().transparency < 1f)
            GameObject.Find("ThirdPersonCamera").GetComponent<EventManager>().transparency += 0.1f;
    }
    void OnTriggerExit(Collider other)
    {
        /*while (GameObject.Find("ThirdPersonCamera").GetComponent<EventManager>().transparency > 0)
        {
            GameObject.Find("ThirdPersonCamera").GetComponent<EventManager>().transparency -= 0.05f;
            WaitingCoroutine();
        }*/
        Debug.Log("antihype");
    }
    /*IEnumerator WaitingCoroutine()
    {
        Debug.Log("courutine");
        yield return new WaitForSeconds(0.05f);
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
