using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListButton : MonoBehaviour {
	//public Planets p;
	// public Planets p = new GameObject().GetComponent<Planets>();
	public Planets p;
	[SerializeField]
	private Text myText;
	[SerializeField]
	private ButtonListControl buttonControl;

	private string myTextString;

	private string[] starInfo; 
	private List<string[]> planetInfo;
	private int systemId;
	private Vector3 offset;
	private GameObject allThings;

	/*void Awake() {
		p = new GameObject ().GetComponent<Planets> ();
	}*/

	public void SetText(string textString) {
		myTextString = textString;
		myText.text = textString;
	}

	public void GetInfo(string[] sI, int sysId, List<string[]> pI, Vector3 o, GameObject at) {
		starInfo = sI;
		planetInfo = pI;
		systemId = sysId;
		offset = o;
		allThings = at;
		//Debug.Log (sI[0].ToString());
		//Debug.Log (pI[0][0].ToString());
	}

	public void TaskOnClick() {

		foreach (GameObject g in p.current3dstars)
			Destroy (g);

		/*foreach (List<GameObject> l in p.current3dplanets)
			foreach (GameObject g in l)
				Destroy (g);*/
		foreach (GameObject g in p.current3dplanets)
			Destroy (g);

		// Debug.Log (p.numberOf3Dplanets);
		buttonControl.ButtonClicked (myTextString);
		GameObject SolarCenter = new GameObject ();
		GameObject SunStuff = new GameObject ();
		GameObject AllOrbits = new GameObject ();
		GameObject Planets = new GameObject ();

		SolarCenter.transform.parent = allThings.transform;
		AllOrbits.transform.parent = SolarCenter.transform;
		SunStuff.transform.parent = SolarCenter.transform;
		Planets.transform.parent = SolarCenter.transform;

		p.dealWithStar (starInfo, SunStuff, AllOrbits);
		p.dealWithPlanets (planetInfo, Planets, AllOrbits);
		p.numberOf3Dsystems += 1;
			// Debug.Log (p.current3dstars[0]);

			// p.generate3dSystem (p.starData[systemId], systemId, p.planetData[systemId], offset, allThings);


		//p = new GameObject ().GetComponent<Planets> ();

		// p.generate3dSystem (starInfo, systemId, planetInfo, offset, allThings);


		// PROMISING!
		/*if (p.numberOf3Dplanets == 0)
			allThings.transform.position = Vector3.zero;
		else if (p.numberOf3Dplanets == 1) {
			allThings.transform.position = new Vector3 (0, -70, 0);
		} else if (p.numberOf3Dplanets == 2) {
			allThings.transform.position = new Vector3 (0, -140, 0);
		} else if (p.numberOf3Dplanets == 3) {
			allThings.transform.position = new Vector3 (0, -210, 0);
		} else if (p.numberOf3Dplanets == 4) {
			allThings.transform.position = new Vector3 (0, -280, 0);
		} else {
			allThings.transform.position = Vector3.zero;
		}*/

		/*if (p.numberOf3Dplanets == 0) {
			allThings.transform.position = Vector3.zero;
			p.numberOf3Dplanets = 1;
		} else {
			allThings.transform.position = Vector3.zero;
			Destroy (p.current3dstars[0]);
			foreach (GameObject g in p.current3dplanets)
				Destroy (g);
			p.current3dstars.Clear ();
			p.current3dplanets.Clear ();
		}*/
			


		// SolarCenter.transform.localPosition = Vector3.zero;
		// AllOrbits.transform.localPosition = Vector3.zero;
		// SunStuff.transform.localPosition = Vector3.zero;
		// Planets.transform.localPosition = Vector3.zero;

		/*Debug.Log ("Solar center: " + SolarCenter.transform.localPosition);
		Debug.Log ("Sun Stuff: " + SunStuff.transform.localPosition);
		Debug.Log ("AllOrbits: " + AllOrbits.transform.localPosition);
		Debug.Log ("Planets: " + Planets.transform.localPosition);*/

//		Debug.Log ("SunStuff position: " + SunStuff.transform.position);
//		Debug.Log ("Planets position: " + Planets.transform.position);

		// Debug.Log ("AllOrbits: " + AllOrbits.transform.localPosition);



		// p.generate3dSystem (p.starData, systemId, p.planetData, offset, allThings);
		// SolarCenter.transform.position = offset;
		// p.numberOf3Dplanets += 1;
	}
}
