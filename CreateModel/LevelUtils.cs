using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateModel
{
    public class LevelUtils
    {
        public static Level FindLevelByName(Document doc, string levelName)
        {

            List<Level> listLevel = new FilteredElementCollector(doc)
               .OfClass(typeof(Level))
               .OfType<Level>()
               .ToList();

            Level level = listLevel
                .Where(x => x.Name.Equals("Уровень 1"))
                .FirstOrDefault();

            return level;
        }
        public static Level FindLevelByName(List<Level> listLevel, string levelName)
        {

            Level level = listLevel
                .Where(x => x.Name.Equals(levelName))
                .FirstOrDefault();

            return level;
        }
    }
}
