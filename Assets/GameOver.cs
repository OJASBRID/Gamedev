using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup(int score){
        gameObject.SetActive(true);
        scoreText.text = "LEVEL : " + score.ToString();
    }

    public void RestartButton() {
        SceneManager.LoadScene("Game");
        // Invoke(3);
    }

    // public void MainMenuButton(){
    //     SceneManager.LoadScene("MainMenu");
    // }
}
