using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionaleFitstic.Features.Messaging
{
    public class Attachement
    {
        public Attachement(string fileName, object content)
        {
            Content = content;
            FileName = fileName;
            Type = AttachementType.Text;
        }

        public enum AttachementType
        {
            Json,
            Text
        }

        public object Content { get; set; }
        public string FileName { get; set; }
        public AttachementType Type { get; set; }

        public async Task <MemoryStream> ContentToStreamAsync()
        {
            string text;
            switch (Type)
            {
                case AttachementType.Json:
                    text = Newtonsoft.Json.JsonConvert.SerializeObject(Content);
                    break;
                case AttachementType.Text:
                    text = Content.ToString();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var stream = new MemoryStream();
            var writer = new StreamWriter(stream, Encoding.UTF8);
            await writer.WriteAsync(text);
            await writer.FlushAsync();
            stream.Position = 0;
            return stream;
        }
    }
}
