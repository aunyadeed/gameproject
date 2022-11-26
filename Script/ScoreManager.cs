using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //ScoreText.text = "SCORE : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "item")
        {
            score++;

            Destroy(other.gameObject);

            ScoreText.text = "SCORE : " + score;
        }
        else if(other.tag == "Pacman")
        {
            SceneManager.LoadScene(2);
        }
    }
}
