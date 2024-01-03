using UnityEngine;

public class FunctionControl : ControlElement {
	// Advice: FYFY component aims to contain only public members (according to Entity-Component-System paradigm).
	public string functionName;    // No name variable, we should directly access the name written on the
								   // UI element if I understand ECS right i probably don't though
}