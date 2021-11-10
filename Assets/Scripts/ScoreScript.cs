using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public Text MyscoreText;
    private int ScoreNumber;
    // Start is called before the first frame update
    void Start()
    {

        ScoreNumber = 0;
        MyscoreText.text = "Score : " + ScoreNumber;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "MyCoin")
        {
            ScoreNumber++;
            Destroy(collision.gameObject);
            MyscoreText.text = "Score : " + ScoreNumber;
        }
    }

}
