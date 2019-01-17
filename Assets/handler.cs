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
    public  void callbtn(){
        Application.OpenURL("tel://7738329546");

    }
    public void emailbtn()
    {
        Application.OpenURL("//");
    }
    public void OpenWebsite()
    {
        Application.OpenURL("http://www.vstakesolutions.com/");
    }
    public void SendMsg()
    {
        Application.OpenURL("tel://7738329546");
    }
    public void OpenLinkedIn(){
        Application.OpenURL("https://www.linkedin.com/in/umang-bilaney-3a2791106?lipi=urn%3Ali%3Apage%3Ad_flagship3_profile_view_base_contact_details%3BjrqFKWGmST6nle1FoIV99w%3D%3D");
    }
}
