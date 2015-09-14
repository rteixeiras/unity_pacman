using UnityEngine;
using System.Collections;

public class DrawTitleMap : MonoBehaviour {

	// Use this for initialization
	tileMap map;

	void Start () {
	
		map = GetComponent<tileMap> ();

		for (var x=0; x<17; x++)
		{
			for (var y=0; y<21; y++) {
				if (map.tiles[x,y]==0){
					Instantiate (Resources.Load ("blTile"), new Vector3 (x, y, 0), Quaternion.identity);
				}
				else{
					Instantiate (Resources.Load ("tile"), new Vector3 (x, y, 0), Quaternion.identity);
				}
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
