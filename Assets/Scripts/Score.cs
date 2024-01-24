using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text Scoretxt;
    public static int Points;
    public float Timer = 30;
    public static float CurrentTime;
    public Text TimeText;

    void Update()
    {
        Scoretxt.text = "Score: " + Points;
        if (Points < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        Timer -= Time.deltaTime;
        CurrentTime = Mathf.Floor(Timer);
        TimeText.text = "Timer: " + CurrentTime;
        if (CurrentTime <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }


    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedCube")
        {
            Points++;
        }
        if (other.gameObject.tag == "GreenCube")
        {
            Points++;
        }
        if (other.gameObject.tag == "BrownCube")
        {
            Points++;
        }
        Destroy(other.gameObject);
    }
}
