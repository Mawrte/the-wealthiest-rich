using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullScreenOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.fullScreen = false;
	}

    // Update is called once per frame
    uint exitCount = 0;
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        
        //////////////

        //if (Input.GetKeyUp(KeyCode.Escape))
        //{

        //    exitCount++;
        //    if (!IsInvoking("disableDoubleClick"))
        //        Invoke("disableDoubleClick", 0.3f);
        //}


        //if (exitCount == 2)
        //{
        //    CancelInvoke("disableDoubleClick");
        //    Application.Quit();
        //}



        ////////
    }

    void disableDoubleClick()
    {
        exitCount = 0;
    }

}
