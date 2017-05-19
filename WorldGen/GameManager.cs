using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public BoardManager boardScript = new BoardManager();

    
    void Update()
    {
        
    }
    private int level = 3;
    void Awake()
    {
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }
    void InitGame()
    {
        boardScript.CountProperty.SetupScene(level);
    }

	
	
}
