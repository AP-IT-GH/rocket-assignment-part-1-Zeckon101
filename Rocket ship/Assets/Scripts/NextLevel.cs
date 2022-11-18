using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{


    public void OnTriggerEnter(Collider Col){

        if(Col.gameObject.tag == "Silver")
        {
            Debug.Log("Next level");
            SceneManager.LoadScene ("Level_02");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
