#pragma strict
//values
	var jumpRange : float;
	var jumpPower : float;
	var jumpTimer : float;
	
//private
	//stores the time the enemys jumped at 
	private var lastJump : float;	
	//the random Value for the jump
	private var randomJump : float;
	//the min and max values the random jump will use. affected by the result of the last time
	private var min : float = -1;
	private var max : float = 1;
	// the jumpdirection which is multiplied by the speed
	private var jumpDirection : int;	
	
function Start () {
	lastJump = Time.time;
	randomJump = Random.Range(-1, 2);
}
function Update () {	
	if(lastJump + jumpTimer < Time.time){
		Jump();
		lastJump = Time.time;
	}
}

function Jump (){
	randomJump = Random.Range(min, max);
	if(randomJump > 0){
		min = -1;
		max = 1-randomJump/4;
		jumpDirection = 1;
	}
	if(randomJump < 0){
		min = -1+randomJump/4;
		max = 1;
		jumpDirection = -1;
	}
	GetComponent.<Rigidbody2D>().velocity = Vector2(jumpRange*jumpDirection, jumpPower);
	lastJump = Time.time;
}