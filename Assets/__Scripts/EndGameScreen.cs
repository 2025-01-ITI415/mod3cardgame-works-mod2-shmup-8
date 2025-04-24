using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndGameScreen : MonoBehaviour
{
    
    public Text endGameText;
    public Text scoreText;
    public GameObject panel;
    // Start is called before the first frame update
    
   public void endGame(int remaining)
    {
        
        endGameText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
        scoreText.text = "Final Score: "+remaining;
        
    }
    

}
