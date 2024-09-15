using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game01Script : MonoBehaviour
{
	
	public Texture2D tPlaca;
	public Texture2D tLost;
	public Texture2D tSaved;
	public Texture2D tWin;
	public Texture2D tLose;
	public float tempoEspera;
	public int altura;
	public GUIStyle label;
	public GUIStyle explanation;
	public GUIStyle areaLose;
	public GUIStyle areaWin;
	//
	private bool isExplaining = true;
	private bool isPlaying = false;
	private bool won = false;
	private bool lose = false;
	private GameObject game01;
	private PlayerScript player;
	
	// Use this for initialization
	void Start ()
	{
		Invoke ("ocultarContextualizacao", tempoEspera);
		GetComponent<AudioSource>().Play ();
	}
	
	// Use this for initialization
	void Awake ()
	{
		player = GameObject.Find ("Bucket").GetComponent<PlayerScript> ();
		game01 = GameObject.Find ("Game01");
		game01.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (player.acertos > 25) {
			Ganhou ();
		}
		
		if (player.erros > 2) {
			Perdeu ();
		}
	}
	
	// Mostra contextualização inicial
	void ocultarContextualizacao ()
	{
		isExplaining = false;
		lose = false;
		won = false;
		isPlaying = true;
		//
		game01.SetActive (true);
	}
		
	//Perdeu
	void Perdeu ()
	{
		//
		lose = true;
		won = false;
		isPlaying = false;
		isExplaining = false;
	}
	
	//Perdeu
	void Ganhou ()
	{
		//
		won = true;
		lose = false;
		isPlaying = false;
		isExplaining = false;
	}
		
	// OnGUI is called twice per frame
	void OnGUI ()
	{
		if (isExplaining) {
			isExplaining = true;
			isPlaying = false;
			won = false;
			lose = false;
			
			GUILayout.BeginVertical ();
			GUILayout.Space (altura);
			GUILayout.Label (tPlaca);
			GUILayout.EndVertical ();
		}
		if (isPlaying){
			isPlaying = true;
			isExplaining = false;
			won = false;
			lose = false;
			
			GUILayout.BeginArea(new Rect (0,0,800,600));
				GUILayout.BeginVertical ();
					GUILayout.BeginHorizontal ();
					GUILayout.Label (tLost);
					GUILayout.Label ("x " + player.erros, label);
					GUILayout.Label (tSaved);
					GUILayout.Label ("x " + player.acertos, label);
					GUILayout.FlexibleSpace();
					GUILayout.EndHorizontal ();
					GUILayout.FlexibleSpace();
					GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace();
						GUILayout.Label ("Salve 25 filhotes, e não perca mais que 3", explanation);
						GUILayout.FlexibleSpace();
					GUILayout.EndHorizontal ();
				GUILayout.EndVertical ();
			GUILayout.EndArea();
		}
		if (won) {
			isExplaining = false;
			isPlaying = false;
			won = true;
			lose = false;
			game01.SetActive (false);
			
			GUILayout.BeginArea(new Rect (0,0,800,600),areaWin);
				GUILayout.BeginVertical ();
					GUILayout.FlexibleSpace();
					GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace();
						if(GUILayout.Button("Jogar Novamente")){ SceneManager.LoadScene("Game-01");}
						GUILayout.FlexibleSpace();
					GUILayout.EndHorizontal ();
					GUILayout.FlexibleSpace();
				GUILayout.EndVertical ();
			GUILayout.EndArea();
		}
		if (lose) {
			isExplaining = false;
			isPlaying = false;
			won = false;
			lose = true;
			game01.SetActive (false);
			
			GUILayout.BeginArea(new Rect (0,0,800,600),areaLose);
				GUILayout.BeginVertical ();
					GUILayout.FlexibleSpace();
					GUILayout.BeginHorizontal ();
						GUILayout.FlexibleSpace();
						if(GUILayout.Button("Jogar Novamente")){ SceneManager.LoadScene("Game-01"); }
						GUILayout.FlexibleSpace();
					GUILayout.EndHorizontal ();
					GUILayout.FlexibleSpace();
				GUILayout.EndVertical ();
			GUILayout.EndArea();
		}
	}
		
}