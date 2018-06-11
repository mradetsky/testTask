using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestTask.Models
{
    public class BaseModel
    {
        public BaseModel(){
            
        }
        public string Id { get; set; }

        public Address Address { get; set; }



        public static void Save<T>(T obj) where T : BaseModel
        {
            var list = Load<T>();
            var existObj = list.FirstOrDefault(x => x.Id == obj.Id);
            obj.Id = Guid.NewGuid().ToString();
            list.Add(obj);
            var fileName = typeof(T).Name + ".json";
            File.WriteAllText(fileName, JsonConvert.SerializeObject(list));
        }

        public static T Find<T>(string id) where T : BaseModel
        {
            return Load<T>().FirstOrDefault(x => x.Id == id);
        }

        public static void Delete<T>(T obj) where T : BaseModel
        {
            var list = Load<T>();
            
            var existObj = list.FirstOrDefault(x => x.Id == obj.Id);
            if (existObj != null)
            {
                list.Remove(existObj);
            }
            obj.Id = null;
        }


        public static List<T> Load<T>() where T : BaseModel
        {
            var fileName = typeof(T).Name + ".json";
            if (!File.Exists(fileName))
            {
                return new List<T>();
            }
            var list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(fileName));
            return list;

        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
    }
}
