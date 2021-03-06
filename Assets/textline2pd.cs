using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textline2pd : MonoBehaviour
{
    /// The PD patch we're going to communicate with.
	public LibPdInstance pdPatch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pdPatch.SendBang("test");
    }



	/// We send a bang when the player steps on the button (enters the collision
	/// volume).
	void OnTriggerEnter(Collider other)
	{
		//To send a bang to our PD patch, the patch needs a named receive object
		//(in this case, named VolumeUp), and then we can just use the
		//SendBang() function to send a bang to that object from Unity.
		//
		//See the BangExample.pd patch for details.
		pdPatch.SendBang("VolumeUp");
	}

	/// We send a different bang when the player steps off the button (leaves
	/// the collision volume).
	void OnTriggerExit(Collider other)
	{
		pdPatch.SendBang("VolumeDown");
	}
}
