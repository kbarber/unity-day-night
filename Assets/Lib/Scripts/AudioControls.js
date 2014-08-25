#pragma strict

@script AddComponentMenu("DN/Audio Controls")
@script RequireComponent(AudioSource)

var musicOn = true;
var audioSource : AudioSource;

function Start () {
	audioSource = FindObjectOfType(AudioSource);
	
	if(musicOn) {
		audioSource.mute = false;
	} else {
		audioSource.mute = true;
	}
}

function Update () {
	if(Input.GetKeyDown("m")) {
		if(musicOn) {
			audioSource.mute = true;
			musicOn = false;
		} else {
			audioSource.mute = false;
			musicOn = true;
		}
	}
}