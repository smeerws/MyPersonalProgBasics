using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasicsPartOne : MonoBehaviour {

    string myName = "susanne";

    public void PrintDebug()
    {
        Debug.Log("Angeklickt");
    }

    public void PrintMyName(string myNameis)
    {
        Debug.Log("Mein Name ist: " + myNameis);
    }

    public void AddNumbers(int first, int second)
    {
        Debug.Log("Add Numbers: first + second" + (first + second));
    }

    public void MultiplyNumbers(int first, int second, int third)
    {
        Debug.Log("MultiplyNumbers: first * second * third " + (first * second * third));
    }

    public void DivideNumbers(float first, float second, float third)
    {
        Debug.Log("DivideNumbers: first / second / third " + first / second / third);
    }

    public void ConcatinateStrings(string myName, string msg)
    {
        Debug.Log("First concatination " + myName + " , " + msg);
    }

    // Use this for initialization
    void Start () {
        PrintDebug();
        PrintMyName("susi");
        PrintMyName(myName);
        AddNumbers(1,2);
        MultiplyNumbers(1,99,0);
        DivideNumbers(20.0f, 2.0f, 0.0f);
        ConcatinateStrings("susi", "heute ist ein schöner Tag");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
