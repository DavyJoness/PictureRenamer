using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureRenamer.Models
{
    public static class Renamer
    {
		private static string _path;

		public static string Path
		{
			get { return _path; }
			set { _path = value; }
		}

		private static List<FileInfo> Files;

		public static string GetFileList(out int count)
		{
			LoadFileList();
			count = Files.Count;

			return $"Znaleziono {count} plików";
		}

		private static void LoadFileList()
		{
			DirectoryInfo di = new DirectoryInfo(Path);

			Files = di.GetFiles("*.jpg").ToList();
		}

		public static string RenameFile(int index)
		{
			//Odczyt starej nazwy pliku
			string oldName = Files[index].Name;

			//Odczyt metatagow wykonanie
			FileVersionInfo info = FileVersionInfo.GetVersionInfo(Files[index].FullName);
			Image img = Image.FromFile(Files[index].FullName);

			PropertyItem propItem = img.PropertyItems.FirstOrDefault(i => i.Id == 0x132);
			string text = "";
			if (propItem != null)
			{
				ASCIIEncoding encoding = new ASCIIEncoding();
				text = encoding.GetString(propItem.Value, 0, propItem.Len - 1);
 
				System.Globalization.CultureInfo provider = CultureInfo.InvariantCulture;
				DateTime dateCreated = DateTime.ParseExact(text, "yyyy:MM:d H:m:s", provider);
				text = dateCreated.ToString("yyyy-MM-dd HH:mm:ss");
			}

			//Format
			string newName = "IMG_" + text.Replace(":",".");

			//Sprawdzenie czy plik nie istnieje
			if (File.Exists(Path + "\\" + newName+ ".jpg"))
			{
				//znajdz ile jest ych plikow
				int numberFiles = Directory.GetFiles(Path, newName + "*").Length + 1;
				newName += $"#{numberFiles}";
			}

			//Zmiana nazwy pliku
			img.Dispose();
			try
			{
				Files[index].Rename(newName, ".jpg");
				return $"Zmieniono nazwę pliku {oldName} na {newName}";
			}
			catch (Exception ex)
			{
				return $"Problem z plikiem {oldName}: {ex.Message}";			
			}

		}

		public static void Rename(this FileInfo fileInfo, string newName, string ext)
		{
			fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + newName+ ext);
		}
	}
}
