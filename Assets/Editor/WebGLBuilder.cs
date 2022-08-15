using UnityEditor;

public class WebGLBuilder
{
    static void build()
    {
        string[] scenes =
        {
            "Assets/scenes/Game.unity"
        };
        string pathToDeploy = "Build/WebGLVersion";
        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
    }
}