using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FunctionNameSystem : MonoBehaviour
{
    public TMP_InputField textBox;

    public void SetFunctionName(){
        Debug.Log("setFunctionName : " + textBox.text);
        GetComponent<FunctionControl>().functionName = textBox.text;
    }

    public string GetFunctionName(){
        return GetComponent<FunctionControl>().functionName;
    }
}
