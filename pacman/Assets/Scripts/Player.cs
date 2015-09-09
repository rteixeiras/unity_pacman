using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float velocidade = 5f;
	public float tileSize = 1f;

	private Vector3 pos;
	private Transform tr;
	private int direction; //-1 (left or down) and 1 (right or up)
	private int axis; // 1 (axis x) and 2 (axis y)
	private int previusAxis; // 1 (axis x) and 2 (axis y) before direction change
	private int previusDirection; // //-1 (left or down) and 1 (right or up) before direction change
	private int MapCurrentX; //Current x position on tile map array
	private int MapNextX; //Next x position on tile map array
	private int MapCurrentY; //Current y position on tile map array
	private int MapNextY; //Next y position on tile map array
	private tileMap map; // tileMap Array object

	// Use this for initialization
	void Start () {
		MapCurrentX = MapNextX =  MapCurrentY = MapNextY = 0; //initiallize tile map positions
		pos = transform.position; //next x,y,z positions on inspector
		tr = transform; ////current x,y,z positions on inspector
		previusAxis = axis;
		previusDirection = direction;
		map = GetComponent<tileMap> (); //get component for tile map reading
	}
	
	// Update is called once per frame
	void Update () {

		//if press left arrow key (same apply for the other keys)
		if (Input.GetKey ("left")) {
			setTileMapPositions(-1); //set current and next positions base on direction for axis x and y (same apply for below direction key inputs)
			//if the next position is a "unwalkable" tile, do not even change axis and direction so pacman does not stop on scene trying to change axis (same apply for below direction key inputs)
			if (!isOcupied(MapNextX, MapCurrentY)){ 
				//if tile is "walkable" then set next axis and direction pacman is going to walk (same apply for below direction key inputs)
				axis = 1; 
				direction = -1;
			}
		}
		else if (Input.GetKey ("right")){
			setTileMapPositions(1);
			if (!isOcupied(MapNextX, MapCurrentY)){
				axis = 1;
				direction = 1;
			}
		}
		
		if (Input.GetKey ("up")) {
			setTileMapPositions(1);
			if (!isOcupied(MapCurrentX, MapNextY)){
				axis = 2;
				direction = 1;
			}
		}
		else if (Input.GetKey ("down")){
			setTileMapPositions(-1);
			if (!isOcupied(MapCurrentX, MapNextY)){
				axis = 2;
				direction = -1;
			}
		}

		//if current position equals next position (that means pacman have reached targeted tile)  OR 
		//the next movement happens in the same axis but in different direction, ( its not necessary to wait for pacman to reach next 
		//tile to execute the movement, this is important for pacman to run from ghosts.)
		// Then executes the next movement and move automaticaly to next tile
		if (tr.position == pos || (tr.position != pos && previusAxis == axis && previusDirection != direction)) {

			//update current and next positions base on direction for axis x and y
			setTileMapPositions(direction);

			//if the movement is in axis x then set next position, this routine will keep runing until pacman hits the boundaries or an unwalkable tile
			if (axis == 1) {
				pos.x += isOutOfBounds(axis,(int)pos.x) || isOcupied(MapNextX, MapCurrentY) ?  0 : tileSize * direction;
			}
			//if the movement is in axis y then set next position, this routine will keep runing until pacman hits the boundaries or an unwalkable tile
			else if (axis == 2) {
				pos.y += isOutOfBounds(axis,(int)pos.y) || isOcupied(MapCurrentX, MapNextY) ? 0 : tileSize * direction;
			}

		} 

		previusAxis = axis;
		previusDirection = direction;

		//executa movimentaçao atraves do MoveTowards, que leva a uma determinada posiçao frame by frame (smoothly)
		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * velocidade);

	}

	void setTileMapPositions(int pDir){

		MapCurrentX = (int)pos.x + 8;
		MapNextX =  ((int)pos.x + ((int)tileSize * pDir) + 8);
		MapCurrentY = (int)pos.y + 4;
		MapNextY = ((int)pos.y + ((int)tileSize * pDir)+ 4);

	}

	bool isOcupied(int x, int y){

		//check if title is walkable or not
		if ( y > 8 || x > 16 || y < 0 || x < 0) {
			return true;
		}

		if( map.tiles[y,x] == 1){
			return true;
		}

		return false;
	}

	bool isOutOfBounds(int pAxis, int position){

		//check if player hits boundaries
		if (pAxis == 1) {
			if ((position <= -8 && direction == -1) || (position >= 8 && direction == 1)){
				return true;
			}
		}

		if (pAxis == 2) {
			if ((position <= -4 && direction == -1) || (position >= 4 && direction == 1)){
				return true;
			}
		}

		return false;

	}


}
