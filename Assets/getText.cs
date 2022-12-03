using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class getText : MonoBehaviour
{

    public Transform contentWindow;
    public GameObject recallTextObject;

    // Start is called before the first frame update
    void Start()
    {
        string readFromFilePath = Application.streamingAssetsPath + "/recall_chat" + "/recall" + ".txt";
        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        foreach (string line in fileLines)
        {
            Instantiate(recallTextObject, contentWindow);
            recallTextObject.GetComponent<TMPro.TextMeshProUGUI>().text = line;
            recallTextObject.GetComponent<TMPro.TextMeshProUGUI>().fontSize = 20;


        }
    
    }

   
}
