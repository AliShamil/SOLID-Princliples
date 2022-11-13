#region Before

using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

//public class Project
//{
//    public Collection<ProjectFile> ProjectFiles { get; set; }

//    public void LoadAllFiles()
//    {
//        foreach (ProjectFile file in ProjectFiles)
//        {
//            file.LoadFileData();
//        }
//    }

//    public void SaveAllFiles()
//    {
//        foreach (ProjectFile file in ProjectFiles)
//        {
//            if (file as ReadOnlyFile == null)
//                file.SaveFileData();
//        }
//    }
//}


//public class ProjectFile
//{
//    public string FilePath { get; set; }

//    public byte[] FileData { get; set; }

//    public void LoadFileData()
//    {
//        // Retrieve FileData from disk
//    }

//    public virtual void SaveFileData()
//    {
//        // Write FileData to disk
//    }
//}


//public class ReadOnlyFile : ProjectFile
//{
//    public override void SaveFileData()
//    {
//        throw new InvalidOperationException();
//    }
//}

#endregion

//Here the Project class has been changed to include two collections rather than one.
//One collection comprises all of the files in the project and one holds references to writeable files only.
//The LoadAllFiles method loads data into all of the files in the AllFiles collection.
//As the files in the WriteableFiles collection will be a subset of the same references,
//the data will be visible via these also. The SaveAllFiles method has been replaced with a method that saves only the writeable files.

//The ProjectFile class now comprises just one method, which loads the file data. This method is needed for both writeable and read-only files.
//The new WriteableFile class extends ProjectFile, incorporating a method that saves the file data. This reversal of the hierarchy means that the code now complies with the LSP.



#region After

//public class Project
//{
//    public Collection<ProjectFile> AllFiles { get; set; }
//    public Collection<WriteableFile> WriteableFiles { get; set; }

//    public void LoadAllFiles()
//    {
//        foreach (ProjectFile file in AllFiles)
//        {
//            file.LoadFileData();
//        }
//    }

//    public void SaveAllWriteableFiles()
//    {
//        foreach (WriteableFile file in WriteableFiles)
//        {
//            file.SaveFileData();
//        }
//    }
//}


//public class ProjectFile
//{
//    public string FilePath { get; set; }

//    public byte[] FileData { get; set; }

//    public void LoadFileData()
//    {
//        // Retrieve FileData from disk
//    }
//}


//public class WriteableFile : ProjectFile
//{
//    public void SaveFileData()
//    {
//        // Write FileData to disk
//    }
//}

#endregion