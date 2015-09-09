using UnityEngine;
using System.Collections;

public class DrawTitleMap : MonoBehaviour {

	// Use this for initialization
	tileMap map;

	void Start () {
	
		map = GetComponent<tileMap> ();

		for (var c=-4; c<=4;c++)
		{
			for (var i=-8; i<=8; i++) {
				if (map.tiles[c+4,i+8]==0){
					Instantiate (Resources.Load ("tile"), new Vector3 (i, c, 0), Quaternion.identity);
				}
				else{
					Instantiate (Resources.Load ("tile_oc"), new Vector3 (i, c, 0), Quaternion.identity);
				}
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
