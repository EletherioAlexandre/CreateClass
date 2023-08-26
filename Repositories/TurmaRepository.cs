using Coti02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Coti02.Repositories
{
    public class TurmaRepository
    {
        public void ExportToXml(Turma turma)
        {
            var xmlSerializer = new XmlSerializer(typeof(Turma));

            using (var streamWriter = new StreamWriter("c:\\study.NET\\turma.xml", false)) 
            {
                xmlSerializer.Serialize(streamWriter, turma);
            }
        }
    }
}
