using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CollectingTreasure : MonoBehaviour
{
    public GameObject colAmmount;
    public static int colNum;
    

    void Start()
    {
        colNum = 0;
    }


    void Update()
    {
        colAmmount.GetComponent<TMP_Text>().text = colNum + "/8";

        if(colNum == 8f)
        {
            SceneManager.LoadScene("WinScreen");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }
    }

 
   
        
 


}
