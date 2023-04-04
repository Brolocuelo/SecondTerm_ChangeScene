using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerScene1 : MonoBehaviour
{
    public TMP_InputField InputField;

    public void Saveusername()
    {
        string inputText = InputField.text;

        if(inputText == "")
        {
            DataPersistence.sharedInstance.username = 
                InputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            DataPersistence.sharedInstance.username = inputText;
        }
    }
}
