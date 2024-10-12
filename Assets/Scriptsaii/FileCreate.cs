using System.IO;
using UnityEngine;

public class CreateTextFile : MonoBehaviour
{
    void Start()
    {
        // Define the file path (Desktop path)
        string desktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
        string fileName = "MyTextFile.txt";
        string filePath = Path.Combine(desktopPath, fileName);
        
        // Content of the file
        string fileContent = "Hello, this is a text file created by a Unity game!";
        
        // Create and write to the text file
        CreateAndWriteTextFile(filePath, fileContent);
    }

    void CreateAndWriteTextFile(string path, string content)
    {
        // Check if the file exists, if not create it
        if (!File.Exists(path))
        {
            // Create the file and write the content
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(content);
                Debug.Log("File created and written to: " + path);
            }
        }
        else
        {
            // If the file exists, append new content
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(content);
                Debug.Log("File already exists. New content appended to: " + path);
            }
        }
    }
}
