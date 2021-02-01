using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    private int points1 = 0;
    private int points2 = 0;
    public Text mytext = null;
    public Text mytext2 = null;
    private int winAmount = 10;
    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "platform1")
        {
            points1++;
        }
        if (other.gameObject.tag == "platform2")
        {
            points2++;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (points1 == winAmount)
        {
            LoadScene("game over");

        }
        if (points2 == winAmount)
        {
            LoadScene("game over");
        }
        mytext.text = " " + points1;
        mytext2.text = " " + points2;

    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
