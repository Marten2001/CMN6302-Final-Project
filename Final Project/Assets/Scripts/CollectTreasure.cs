using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTreasure : MonoBehaviour
{
    public bool inReach;
    public GameObject collectText;

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

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            inReach = true;
            collectText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            collectText.SetActive(false);
        }
    }

    private void CollectTrs()
    {

    }
}
