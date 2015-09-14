using UnityEngine;
using System.Collections;

public class tileMap : MonoBehaviour {

	public int[,] tiles;
	int mapSizeX = 17;
	int mapSiseY = 21;

	// Use this for initialization
	void Start () {

		tiles = new int[mapSizeX, mapSiseY];
		for (var x=0; x<17; x++) {
			for (var y=0; y<=20;y++){

				if (y==0 || y==20){ //desenha bordas exceto a linha 10 vazada
					tiles [x, y] = 1;
				}
				else if ((x==0 || x==16) && y!=10){
					tiles [x, y] = 1;
				}
				else{
					tiles [x, y] = 0;
				}

			}
		}

		//desenha boxes superiores esquerdo
		tiles [2, 18] = 1;
		tiles [2, 17] = 1;
		tiles [3, 18] = 1;
		tiles [3, 17] = 1;

		tiles [5, 18] = 1;
		tiles [5, 17] = 1;
		tiles [6, 18] = 1;
		tiles [6, 17] = 1;

		//desenha boex superior direito
		tiles [13, 18] = 1;
		tiles [13, 17] = 1;
		tiles [14, 18] = 1;
		tiles [14, 17] = 1;

		tiles [10, 18] = 1;
		tiles [10, 17] = 1;
		tiles [11, 18] = 1;
		tiles [11, 17] = 1;

		//central borda superior
		tiles [8, 20] = 1;
		tiles [8, 19] = 1;
		tiles [8, 18] = 1;
		tiles [8, 17] = 1;

		//boxes logo abaixo dos superiores
		tiles [2, 15] = 1;
		tiles [3, 15] = 1;
		tiles [2, 14] = 1;
		tiles [3, 14] = 1;
		tiles [13, 15] = 1;
		tiles [14, 15] = 1;
		tiles [13, 14] = 1;
		tiles [14, 14] = 1;

		//L sup Esq
		tiles [5, 15] = 1;
		tiles [5, 14] = 1; 
		tiles [5, 13] = 1; tiles [6, 13] = 1;
		//tiles [5, 12] = 1;
		//tiles [5, 11] = 1;

		//T Central acima casa fantasmas
		tiles [8, 15] = 1;tiles [7, 15] = 1;tiles [9, 15] = 1;
		tiles [8, 14] = 1;
		tiles [8, 13] = 1;

		//L sup Dir
		tiles [11, 15] = 1;
		tiles [11, 14] = 1; 
		tiles [11, 13] = 1; tiles [10, 13] = 1;
		//tiles [5, 12] = 1;
		//tiles [5, 11] = 1;

		//Bordas arrea de escapa esquerda
		tiles [1, 12] = 1;
		tiles [2, 12] = 1; 
		tiles [1, 11] = 1;
		tiles [2, 11] = 1; 
		tiles [1, 9] = 1;
		tiles [2, 9] = 1; 
		tiles [1, 8] = 1;
		tiles [2, 8] = 1; 

		//Bordas arrea de escapa Direita
		tiles [15, 12] = 1;
		tiles [14, 12] = 1; 
		tiles [15, 11] = 1;
		tiles [14, 11] = 1; 
		tiles [15, 9] = 1;
		tiles [14, 9] = 1; 
		tiles [15, 8] = 1;
		tiles [14, 8] = 1; 

		//desenha casa fantasmas
		//linha inferior
		tiles [6, 8] = 1;
		tiles [7, 8] = 1;
		tiles [8, 8] = 1;
		tiles [9, 8] = 1;
		tiles [10, 8] = 1;

		//linha inferior
		tiles [6, 11] = 1;
		tiles [7, 11] = 1;
		tiles [9, 11] = 1;
		tiles [10,11] = 1;
	
		//parede esquerda
		tiles [6, 9] = 1;
		tiles [6, 10] = 1;

		//parede direita
		tiles [10, 9] = 1;
		tiles [10, 10] = 1;
		// fim casa fantasmas

		tiles [4, 11] = 1;
		tiles [12, 11] = 1;
		tiles [4, 9] = 1;
		tiles [4, 8] = 1;
		tiles [12, 9] = 1;
		tiles [12, 8] = 1;


		//desenha boxes inferiores esquerdo
		tiles [2, 2] = 1;
		tiles [2, 3] = 1;
		tiles [3, 2] = 1;
		tiles [3, 3] = 1;
		tiles [4, 2] = 1;
		tiles [4, 3] = 1;
		tiles [2, 5] = 1;
		tiles [2, 6] = 1;
		tiles [3, 5] = 1;
		tiles [3, 6] = 1;
		tiles [4, 5] = 1;
		tiles [4, 6] = 1;

		//desenha boex inferior direito
		tiles [12, 2] = 1;
		tiles [13, 2] = 1;
		tiles [14, 2] = 1;
		tiles [12, 3] = 1;
		tiles [13, 3] = 1;
		tiles [14, 3] = 1;
		tiles [12, 5] = 1;
		tiles [13, 5] = 1;
		tiles [14, 5] = 1;
		tiles [12, 6] = 1;
		tiles [13, 6] = 1;
		tiles [14, 6] = 1;

		//T invertido inferior abaixo casa fantasmas
		tiles [6,6] = 1;
		tiles [7,6] = 1;
		tiles [8,6] = 1;
		tiles [9,6] = 1;
		tiles [10,6] = 1;
		tiles [8,5] = 1;

		//T  inferior abaixo casa fantasmas
		tiles [6,2] = 1;
		tiles [7,2] = 1;
		tiles [8,2] = 1;
		tiles [9,2] = 1;
		tiles [10,2] = 1;
		tiles [8,3] = 1;

		tiles [6,4] = 1;
		tiles [10,4] = 1;

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
