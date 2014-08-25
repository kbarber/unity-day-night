#pragma strict

@script AddComponentMenu("DN/Camera Switch")

var cameras : Camera[];

function SelectCamera (index : int) {
    for (var i : int=0 ;i < cameras.length; i++) {
    	// Activate the selected camera
        if (i == index){
        	cameras[i].gameObject.SetActive(true);
//            cameras[i].camera.active = true;
    	// Deactivate all other cameras
        } else {
//    	    cameras[i].camera.active = false;
    	    cameras[i].gameObject.SetActive(false);
	    }
 
	}
}

function Start () {
	SelectCamera(0);
}

function Update () {
	if (Input.GetKey("c")) {
		SelectCamera(0);
	}
	
	if (Input.GetKey("v")) {
		SelectCamera(1);
	}
}