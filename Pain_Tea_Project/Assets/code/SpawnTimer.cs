using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawn = false;
    public float spawnTime;
    public float spawnDelay;

    public int colourPicker = 0;
    public int binaryPicker = 0;

    //[SerializeField] List<Sprite> images = new List<Sprite>();


    levelInfo info;
    [SerializeField] string msgCount = "messageCounter";



    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<levelInfo>();

        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        var spawnedBox = Instantiate(spawnee, transform.position, transform.rotation);
        //below is working text creator
        //spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = info.msgCount.ToString();
        //    spawnedBox.GetComponentInChildren<UnityEngine.UI.Image>().sprite = images[Random.Range(0, images.Count - 1)];
        if (stopSpawn)
        {
            CancelInvoke("SpawnObject");
        }
        info.addMessage();



        switch (info.msgCount)
        {

            case 1:

                //Phone 1
                //  0 = blue
                //  1 =  red
                //  4 = 0

                //Phone 2
                //  2 = green
                //  3 = yellow
                //  5 = 1
                //spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = info.msgCount.ToString() + " message 3 ";
                spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = "05 / 15 / 24 /15";

                colourPicker = 0;
                binaryPicker = 5;

                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;

                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 2;
                binaryPicker = 4;

                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;

                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(binaryPicker).gameObject.active = true;

                break;
            case 2:
                //Phone 1
                //  0 = blue
                //  1 =  red
                //  4 = 0

                //Phone 2
                //  2 = green
                //  3 = yellow
                //  5 = 1
                spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = "35 / 05 / 34 /24";
                colourPicker = 3;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 0;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 3;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 2;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(binaryPicker).gameObject.active = true;
                break;
            case 3:
                //Phone 1
                //  0 = blue
                //  1 =  red
                //  4 = 0

                //Phone 2
                //  2 = green
                //  3 = yellow
                //  5 = 1
                spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = "34 / 15 / 24 /05";
                colourPicker = 3;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 2;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 0;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(binaryPicker).gameObject.active = true;
                break;
            case 4:
                //Phone 1
                //  0 = blue
                //  1 =  red
                //  4 = 0

                //Phone 2
                //  2 = green
                //  3 = yellow
                //  5 = 1
                spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = "24 / 15 / 14 /34";
                colourPicker = 2;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 3;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(binaryPicker).gameObject.active = true;
                break;
            case 5:
                //Phone 1
                //  0 = blue
                //  1 =  red
                //  4 = 0

                //Phone 2
                //  2 = green
                //  3 = yellow
                //  5 = 1
                spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = "05 / 34 / 24 /15";
                colourPicker = 0;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 3;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 2;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(binaryPicker).gameObject.active = true;
                break;
            case 6:
                //Phone 1
                //  0 = blue
                //  1 =  red
                //  4 = 0

                //Phone 2
                //  2 = green
                //  3 = yellow
                //  5 = 1
                spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = "05 / 15 / 24 /34";
                colourPicker = 0;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 2;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 3;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(binaryPicker).gameObject.active = true;
                break;
            case 7:
                //Phone 1
                //  0 = blue
                //  1 =  red
                //  4 = 0

                //Phone 2
                //  2 = green
                //  3 = yellow
                //  5 = 1
                spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = "25 / 15 / 34 /25";
                colourPicker = 2;
                binaryPicker = 5;

                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos1.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 1;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos2.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 3;
                binaryPicker = 4;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos3.transform.GetChild(binaryPicker).gameObject.active = true;

                colourPicker = 2;
                binaryPicker = 5;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(colourPicker).gameObject.active = true;
                spawnedBox.GetComponent<text_box_code>().pos4.transform.GetChild(binaryPicker).gameObject.active = true;

                break;
            default:
                // spawnedBox.GetComponentInChildren<TextMeshProUGUI>().text = info.msgCount.ToString();
                break;
        }


    }

    private void FixedUpdate()
    {
        if (Input.GetKey("g"))
        {
            // do something
        }




    }
}




