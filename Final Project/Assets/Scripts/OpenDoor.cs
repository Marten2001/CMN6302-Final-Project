using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator door;
    public GameObject openText;

    public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        inReach = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inReach && Input.GetKeyDown("e"))
        {
            doorOpen();
        }
        else
        {
            doorClosed();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }
    private void doorOpen()
    {
        Debug.Log("It's Open!");
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
    }

    private void doorClosed()
    {
        Debug.Log("It's Closed");
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
    }
}
