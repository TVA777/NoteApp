﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace NoteApp
{
	static class ProjectManager
	{
		private const string _PathFile = @"";
		public static void serek(Project se)
		{
			JsonSerializer serializer = new JsonSerializer();
			//Открываем поток для записи в файл с указанием пути 
			using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				//Вызываем сериализацию и передаем объект, который хотим сериализовать 
				serializer.Serialize(writer, se);
			}
		}
		public static Project deserek()
		{
			Project deNote = null;
			//Создаём экземпляр сериализатора 
			JsonSerializer serializer = new JsonSerializer();
			//Открываем поток для чтения из файла с указанием пути 
			using (StreamReader sr = new StreamReader(@"c:\json.txt"))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				//Вызываем десериализацию и явно преобразуем результат в целевой тип данных 
				deNote = (Project)serializer.Deserialize(reader);
			}
			return deNote;
		}
	}
}
