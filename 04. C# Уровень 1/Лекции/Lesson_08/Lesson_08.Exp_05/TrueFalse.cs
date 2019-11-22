using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Lesson_08.Exp_05
{
    class TrueFalse
    {
        string fileName;
        List<Question> list;

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public int Count
        {
            get { return list.Count; }
        }
        public string FileName
        {
            set { fileName = value; }
        }

        public Question this[int index]
        {
            get { return list[index]; }
        }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
    }
}