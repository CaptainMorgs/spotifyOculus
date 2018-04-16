using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
[CustomEditor(typeof(Spotify))]
public class SpotifyEditor : Editor
{
    private string searchQuery;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Spotify spotifyScript = (Spotify)target;

        GUILayout.Label("Search Spotify");

        searchQuery = EditorGUILayout.TextField("Search Query: ", searchQuery);

        if (GUILayout.Button("Search"))
        {
            Debug.Log("Searching spotify with search query: " + searchQuery);
            spotifyScript.SearchSpotify(searchQuery);
        }
    }

}
#endif
