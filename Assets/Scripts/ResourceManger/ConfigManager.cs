using System.IO;
using cfg.ElemCardTable;
using cfg.ElemTypeTable;
using cfg.SpritePath;
using SimpleJSON;
using Tools;

namespace ResourceManger
{
    public class ConfigManager : Singleton<ConfigManager> 
    {
        public TbCardConfig CardConfigData { get; set; }
        public TbElemTypePrefab ElemTypePrefabData { get; set; }
        public TbCardSpritePath CardSpritePath { get; set; }

        public void Init()
        {
            LoadCommonConfig();
        }
        
        private void LoadCommonConfig()
        {
            var table = new cfg.Tables(file => JSON.Parse(File.ReadAllText($"Assets/GenerateDatas/Json/{file}.json")));
            CardConfigData = table.TbCardConfig;
            ElemTypePrefabData = table.TbElemTypePrefab;
            CardSpritePath = table.TbCardSpritePath;
        }
    }
}
