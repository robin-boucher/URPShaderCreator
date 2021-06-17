using UnityEditor;
using UnityEngine;

namespace URPShaderCreator
{
    public static class URPShaderCreatorMenu
    {
        private const string MENU_ASSET_CREATE = "Assets/Create/Shader/URPShaderCreator/";

        private static readonly string SHADER_TEMPLATE_PATH = string.Format("{0}/URPShaderCreator/Editor/ShaderTemplates/", Application.dataPath);

        private static void CreateShaderAsset(string templateFile, string assetName)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(string.Format("{0}{1}", SHADER_TEMPLATE_PATH, templateFile), assetName);
        }

        [MenuItem(MENU_ASSET_CREATE + "Unlit/Unlit Shader", false)]
        private static void CreateUnlitShader()
        {
            CreateShaderAsset("UnlitShader.shader.txt", "NewUnlitShader.shader");
        }

        [MenuItem(MENU_ASSET_CREATE + "Unlit/Unlit Transparent Shader", false)]
        private static void CreateUnlitTransparentShader()
        {
            CreateShaderAsset("UnlitTransparentShader.shader.txt", "NewUnlitTransparentShader.shader");
        }

        [MenuItem(MENU_ASSET_CREATE + "Unlit/Unlit Cutout Shader", false)]
        private static void CreateUnlitCutoutShader()
        {
            CreateShaderAsset("UnlitCutoutShader.shader.txt", "NewUnlitCutoutShader.shader");
        }

        [MenuItem(MENU_ASSET_CREATE + "Lit/Lit Shader", false)]
        private static void CreateLitShader()
        {
            CreateShaderAsset("LitShader.shader.txt", "NewLitShader.shader");
        }
    }
}