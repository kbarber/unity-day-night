#pragma strict

@script AddComponentMenu("DN/Splash Screen To Main Menu")
@script RequireComponent(GUITexture)

var timeToWait = 3.0;

function Start () {
	/* Wait for a set amount of time, then switch to the main menu */
	yield WaitForSeconds (timeToWait);
	Application.LoadLevel("MainMenu");
}

function Update () {

}