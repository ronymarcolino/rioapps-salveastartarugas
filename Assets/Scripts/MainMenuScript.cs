using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
	
	public GUIStyle windowMenuStyle;
	//public Rect jogar;
	public GUIStyle btn_jogar;
	//public Rect ajuda;
	public GUIStyle btn_ajuda;

	private int Width,Height;
	private bool isMenuPrincipal;
	private Rect windowMenu;
	//private Rect windowAjuda;
	
	// Use this for initialization
	void Awake () {
		Width = Screen.width;
		Height = Screen.height;
		//
		windowMenu = new Rect(0,0,Width,Height);
		//
		isMenuPrincipal = true;
	}
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//
	}
	
	void OnGUI(){
		if(isMenuPrincipal) 		windowMenu = GUILayout.Window(0,windowMenu,doWindowMenu,"",windowMenuStyle);
	}
	
	void doWindowMenu(int windowID){
		GUILayout.BeginVertical();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();		
			GUILayout.FlexibleSpace();
			if(GUILayout.Button (btn_jogar.name,btn_jogar, GUILayout.Width(btn_jogar.normal.background.width),GUILayout.Height(btn_jogar.normal.background.height))){SceneManager.LoadScene("Game-01");}//
			GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
	}
		
}
