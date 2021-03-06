// Button2Bang.cs - Script to send a bang to a PD patch when the player enters
//					and leaves a collision volume.
// -----------------------------------------------------------------------------
// Copyright (c) 2018 Niall Moody

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Script to send a bang to a PD patch when the player enters and leaves a
/// collision volume.
public class Button2Bang : MonoBehaviour
{

	/// The PD patch we're going to communicate with.
	public LibPdInstance pdPatch;

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
