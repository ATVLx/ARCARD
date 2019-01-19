using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public  void callbtn()
    {
        Application.OpenURL("tel://9824524884");

    }
    public void emailbtn()
    {
        Application.OpenURL("mailto://khushboolakhani1974@gmail.com");
    }
    public void OpenWebsite()
    {
        Application.OpenURL("http://www.Vishallakhani.info/");
    }
    public void SendMsg()
    {
        Application.OpenURL("tel://7738329546");
    }
    public void OpenFacebook(){
        Application.OpenURL("https://www.facebook.com/khushboo.lakhani.71");
    }
    public void OpenInstagram()
    {
        Application.OpenURL("https://www.instagram.com/khushboolakhani74/");
    }
}
