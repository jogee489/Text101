using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States { start, cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1,
						  freedom, outside };
	private States mystate;
	
	// Use this for initialization
	void Start () {
		text.text = "Welcom to pRisON BreAK!\n Press the spacebar to begin!";
		mystate = States.start;
	}
	
	// Update is called once per frame
	void Update () {
		if (mystate == States.start && Input.GetKeyDown(KeyCode.Space)) { mystate = States.cell; }
		
		if 		(mystate == States.cell) 		{ cell(); }
		else if (mystate == States.sheets_0) 	{ sheets_0(); }
		else if (mystate == States.mirror) 		{ mirror(); }
		else if (mystate == States.lock_0) 		{ lock_0(); }
		else if (mystate == States.cell_mirror)	{ cell_mirror(); }
		else if (mystate == States.sheets_1)	{ sheets_1(); }
		else if (mystate == States.lock_1)		{ lock_1(); }
		else if (mystate == States.freedom)		{ freedom(); }
		else if (mystate == States.outside)		{ outside(); }
		
	}
	void cell () {
		text.text = "You are in a dark stone prison cell. A soft glow permeates into your " +
					"cage seemingly from the outer walls. Dripping water can be heard " +
					"in the distace denting the uncomfortably still silence. The black " + 
					"bars are locked from the outside. A mirror is hanging on the back " + 
					"wall near the corner near a small sheeted cot.\n\n" +
					"Press S to view Sheets, M to view Mirror, L to view Lock";
		if 		(Input.GetKeyDown(KeyCode.S)) { mystate = States.sheets_0; }
		else if (Input.GetKeyDown(KeyCode.M)) { mystate = States.mirror; }
		else if (Input.GetKeyDown(KeyCode.L)) { mystate = States.lock_0; }
	}
	void sheets_0 () {
		text.text = "The sheets have few visible tears in between dark red stains. You " +
					"notice the smell of death wafting from the sheets. No living thing " +
					"should sleep with this. The cold jagged rocks may be prefered to these cursed " +
					"sheets.\n\nPress R to return.";
		if (Input.GetKeyDown(KeyCode.R)) {
			mystate = States.cell;
		}
	}
	
	void mirror () {
		text.text = "The piece of metal in from of you can barely be called a mirror. " +
					"A blurry and rust spotted image of yourself is all you can make out " +
					"through the cracks. As you squint to get a look at yourself, you notice " +
					"a few dried blood streaks brushing along your cheek and meeting at a fist " +
					"sized gash on your left temple. The metal slab feels colder and harder " +
					"than the rigid stonefloor, but at least there is no blood on it!\n\n" +
					"Press R to return. Press T to take the mirror";
					
		if (Input.GetKeyDown(KeyCode.R)) { mystate = States.cell; }
		else if (Input.GetKeyDown(KeyCode.T)) { mystate = States.cell_mirror; }
	}
	void lock_0 () {
		text.text = "A shoddy metal lock holds a rusted chain together. Although your past is " +
					"hidden from you, you know terrible craftsmanship when you see it.\n\n" +
					"Press R to return.";
		
		if (Input.GetKeyDown(KeyCode.R)) { mystate = States.cell; }
	}
	void cell_mirror () {
		text.text = "You are in a dark stone prison cell. A soft glow permeates into your " +
					"cage seemingly from the outer walls. Dripping water can be heard " +
					"in the distace denting the uncomfortably still silence. The black " + 
					"bars are locked from the outside. A small sheeted cot is near the back " + 
					"wall near the corner.\n\n" +
					"Press S to view Sheets, L to view Lock";
					
		if (Input.GetKeyDown(KeyCode.S)) { mystate = States.sheets_1; }
		else if (Input.GetKeyDown(KeyCode.L)){ mystate = States.lock_1; }
	}
	void sheets_1 () {
		text.text = "The sheets have few visible tears in between dark red stains. You " +
					"notice the smell of death wafting from the sheets. No living thing " +
					"should sleep with this. The cold air may be prefered to these cursed " +
					"sheets.\n\nPress R to return.";
					
		if (Input.GetKeyDown(KeyCode.R)) { mystate = States.cell_mirror; }
	}
	void lock_1 () {
		text.text = "A shoddy metal lock holds a rusted chain together. Although your past is " +
					"hidden from you, you know terrible craftsmanship when you see it.\n\n" +
					"Press R to return. Press S to smash the lock with the mirror.";
		
		if (Input.GetKeyDown(KeyCode.R)) { mystate = States.cell_mirror; }
		else if (Input.GetKeyDown(KeyCode.S)) { mystate = States.freedom; }
	}
	void freedom () {
		text.text = "A loud crash severs the chain holding the bars closed. A metal clang " +
					"echos as the heavy lock meets the stone floor and shatters. The door " +
					"slowly creaks open as if being pulled by invisible hands.\n\n" + 
					"Press Spacebar to walk out the door...";
		if (Input.GetKeyDown(KeyCode.Space)) { mystate = States.outside; }
	}
	
	void outside () {
		text.text = "Panic strikes as you feel pure darkness close in and engulf you. You " +
					"shut your eyes as you realize you can not fight the dark. Suddenly, " + 
					"you feel the cold and weight of your body begin to fade. As you open " +
					"your eyes, you notice a person twice your height standing in front of you " +
					"in a grassy meadow. You are filled with peace and calm. You are free!";
		//if (Input.GetKeyDown(KeyCode.Space)) {
			
		//}
	}
}
