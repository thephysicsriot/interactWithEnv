using UnityEngine;
using System.Collections;

public class Interact : MonoBehaviour {

	public GUIText target;

	private bool selected = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.color = Color.white;
		selected = false;
	}

	public void OnLookEnter() 
	{
		renderer.material.color = Color.red;
		target.text = "Press E to interact";
		selected = true;
	}

	void OnGUI()
	{
		Event e = Event.current;
		if(e.isKey && e.character == 'e' && selected){
			rigidbody.AddForce(Vector3.up*100);
		} 		
	}
}
