using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenYtChannel()
	{
        #if !UNITY_EDITOR
		        openWindow("https://www.youtube.com/channel/UC9Z1XWw1kmnvOOFsj6Bzy2g/featured?view_as=subscriber");
        #endif
    }

    [DllImport("__Internal")]
	private static extern void openWindow(string url);

}