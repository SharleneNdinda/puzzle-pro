using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pieces : MonoBehaviour
{
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    public int score;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(1f,10f), Random.Range(4f,-4));
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, RightPosition) < 0.5f)
        {   
           
            if (!Selected)
            { 
            score = 10;
            Score.text = score.ToString();

            transform.position = RightPosition;
            InRightPosition = true;

           
            }

        }
}
}
