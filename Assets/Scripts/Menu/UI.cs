using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public AudioSource achievementAudio;
    public GameObject xButton;
    public GameObject retryButton;
    public TextMeshProUGUI scoreText;
    private int childCount;
    private int childCheck;
    private int score;

    void Start()
    {
        childCount = GameObject.Find("DynamicProps").gameObject.transform.childCount;
    }

    void Update()
    {
        childCheck = GameObject.Find("DynamicProps").gameObject.transform.childCount;
        if(childCheck < childCount)
        {
            score = childCount - childCheck;
            achievementAudio.Play();
        }
        scoreText.text = "Score: " + score;
        if(childCount == 0)
        {
            SceneManager.LoadScene("LevelOne");
        }
    }

    public void RetryOption()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void XOption()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
