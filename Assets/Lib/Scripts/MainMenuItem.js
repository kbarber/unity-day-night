#pragma strict

@script AddComponentMenu("DN/Main Menu Item")
@script RequireComponent(GUIText)

var buttonType = "Quit";

function Start () {

}

function Update () {

}

function OnMouseEnter () {
	guiText.color = Color.red;
}

function OnMouseExit () {
	guiText.color = Color.white;
}

function OnMouseUp () {
	switch (buttonType) {
		case "Start":
			Application.LoadLevel("Game");
			break;
		case "Quit":
			Application.Quit();
			break;
		default:
			print("Invalid buttonType");
			break;
	}
}