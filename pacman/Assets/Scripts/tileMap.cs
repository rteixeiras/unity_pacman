using UnityEngine;
using System.Collections;

public class tileMap : MonoBehaviour {

	public int[,] tiles;
	int mapSizeX = 17;
	int mapSiseY = 9;

	// Use this for initialization
	void Start () {

		tiles = new int[mapSiseY,mapSizeX];
		for (var z=0; z<=8; z++) {
			for (var y=0; y<=16;y++){
				tiles [z, y] = 0;
			}
		}

		tiles [3, 4] = 1;
		tiles [3, 5] = 1;
		tiles [3, 6] = 1;
		tiles [3, 7] = 1;
		tiles [3, 8] = 1;
		tiles [3, 9] = 1;
		tiles [3, 10] = 1;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	private static Texture2D _staticRectTexture;
	private static GUIStyle _staticRectStyle;
	
	// Note that this function is only meant to be called from OnGUI() functions.
	public static void GUIDrawRect( Rect position, Color color )
	{
		if( _staticRectTexture == null )
		{
			_staticRectTexture = new Texture2D( 1, 1 );
		}
		
		if( _staticRectStyle == null )
		{
			_staticRectStyle = new GUIStyle();
		}
		
		_staticRectTexture.SetPixel( 0, 0, color );
		_staticRectTexture.Apply();
		
		_staticRectStyle.normal.background = _staticRectTexture;
		
		GUI.Box( position, GUIContent.none, _staticRectStyle );
		
		
	}


	void OnGui(){

		GUIDrawRect (new Rect(2f,2f,2f,2f), Color.blue);
	}
*/

}
