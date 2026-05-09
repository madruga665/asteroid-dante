using UnityEditor;
using UnityEngine;
using System.IO;

public class PrefabCreator
{
    [MenuItem("Tools/Criar Prefab do Objeto Selecionado")]
    public static void CreateSelectedPrefab()
    {
        // Pega o objeto que estiver selecionado na Hierarquia
        GameObject selected = Selection.activeGameObject;

        if (selected == null)
        {
            Debug.LogError("Erro: Nenhum GameObject selecionado na hierarquia! Selecione o objeto que deseja transformar em prefab.");
            return;
        }

        // Caminho onde o prefab será salvo
        string folderPath = "Assets/Prefabs";
        string localPath = folderPath + "/" + selected.name + ".prefab";

        // Garante que a pasta Prefabs existe
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            AssetDatabase.ImportAsset(folderPath);
        }

        // Cria o prefab a partir do objeto selecionado
        bool success;
        PrefabUtility.SaveAsPrefabAsset(selected, localPath, out success);

        if (success)
        {
            Debug.Log($"<color=green>Sucesso!</color> Prefab de '{selected.name}' criado em: {localPath}");
            // Destaca o novo arquivo no Project window
            EditorGUIUtility.PingObject(AssetDatabase.LoadAssetAtPath<GameObject>(localPath));
        }
        else
        {
            Debug.LogError("Falha ao salvar o prefab em: " + localPath);
        }
    }
}
