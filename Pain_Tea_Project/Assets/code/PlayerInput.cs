using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    public Text scoreDisplay;
    bool fourDown = false;
    bool fiveDown = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp("4"))
        {
            fourDown = false;
        }
        if (Input.GetKeyDown("4"))
        {
            fiveDown = false;
            fourDown = true;
        }



        if (Input.GetKeyUp("5"))
        {
            fiveDown = false;
        }
        if (Input.GetKeyDown("5"))
        {
            fourDown = false;
            fiveDown = true;
        }








        if (Input.GetKeyDown("0") && fourDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 0 & 4";

        }
        else if (Input.GetKeyDown("1") && fourDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 1 & 4 ";
        }
        else if (Input.GetKeyDown("2") && fourDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 2 & 4 ";
        }
        else if (Input.GetKeyDown("3") && fourDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 3 & 4 ";
        }




        if (Input.GetKeyDown("0") && fiveDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 0 & 5 ";
        }
        else if (Input.GetKeyDown("1") && fiveDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 1 & 5 ";
        }
        else if (Input.GetKeyDown("2") && fiveDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 2 & 5 ";
        }
        else if (Input.GetKeyDown("3") && fiveDown == true)
        {
            scoreDisplay.GetComponent<Text>().text = " 3 & 5 ";
        }
    }
}
