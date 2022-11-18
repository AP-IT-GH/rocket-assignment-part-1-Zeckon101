using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coins;
    public TextMesh score;

    public void OnTriggerEnter(Collider Col){

        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected");
            coins = coins + 1;
            Destroy(Col.gameObject);
        }

    }

    void OnGUI(){
        GUI.Box (new Rect (25, 25, 40, 40), coins.ToString());
        score.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
