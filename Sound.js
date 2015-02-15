var pickupSound : AudioClip;
var audioPos : Vector3;
 
//When There is Contact between player and object this is known as OnTriggerEnter//
function OnTriggerEnter () {
   AudioSource.PlayClipAtPoint(pickupSound, audioPos);
   //Destroy the game object//
    Destroy(gameObject);
}

function Start() {
  audio.volume = 1;
 }
