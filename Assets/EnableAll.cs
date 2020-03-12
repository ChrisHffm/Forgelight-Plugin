using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class MenuItems
{
	[MenuItem("tools/EnableAll")]
	public static void EnableAll() {
		GameObject[] rootObjects = EditorSceneManager.GetActiveScene().GetRootGameObjects();

		foreach (GameObject rootObject in rootObjects)
		{
			foreach (Transform t in rootObject.GetComponentsInChildren<Transform>(true))
				t.gameObject.SetActive(true);
		}
	}
}