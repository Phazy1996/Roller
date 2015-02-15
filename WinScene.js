#pragma strict

function Start () {

};
function OnTriggerEnter (col : Collider ) {
 
 Debug.Log(col.gameObject.name);
 if(col.gameObject.name == "Player"){
  Application.LoadLevel("_Win");
 }

}
