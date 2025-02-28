using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shpere : MonoBehaviour
{
    static int score = 0;
    static int fol = 0;  
    public TextMeshProUGUI Winlose;
    void OnMouseDown()
    {
        Destroy (gameObject);
        score = score + 1;
        if(score == 5)
        {
            Winlose.text = "You win!";
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "ground")
        {
            Destroy(gameObject);
            fol = fol + 1;
            if(fol == 7)
            {
                Winlose.text = "You lose!";
            }
            
        }
    }
}
