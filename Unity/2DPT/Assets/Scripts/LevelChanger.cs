using UnityEngine;
using System.Collections;

public class LevelChanger : BaseBehaviour {

	public void ChangeLevel(string levelToChangeTo)
	{
		Application.LoadLevel(levelToChangeTo);
	}

	public void ChangeLevel2(int levelToChangeTo)
	{
		Application.LoadLevel(levelToChangeTo);
	}

	public void Quit()
	{
		Application.Quit ();
	}
	
}
