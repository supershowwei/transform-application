using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TransformApplication.Protocols.Physical;

namespace TransformApplication.Physicals
{
    // 採用 Singleton 模式
    public class Config : IConfig
    {
        // 延遲載入
        private static readonly Lazy<Config> LazyConfig = new Lazy<Config>(() => new Config());

        // 建立設定檔改變自動載入機制
        private static ObjectCache configCache = MemoryCache.Default;

        private Config()
        {
            this.LoadConfig();
        }

        public static Config Instance
        {
            get
            {
                return LazyConfig.Value;
            }
        }

        private XDocument ConfigDocument
        {
            get
            {
                if (configCache["Config"] == null)
                {
                    this.LoadConfig();
                }

                return (XDocument)configCache["Config"];
            }
        }

        private string CurrentExecutingDirectory
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
        }

        private string ConfigPath
        {
            get
            {
                return Path.ChangeExtension(Path.Combine(this.CurrentExecutingDirectory, Assembly.GetExecutingAssembly().GetName().Name), "xml");
            }
        }

        private void LoadConfig()
        {
            CacheItemPolicy cachePolicy = new CacheItemPolicy();
            cachePolicy.ChangeMonitors.Add(new HostFileChangeMonitor(new List<string>() { this.ConfigPath }));
            configCache.Set("Config", XDocument.Load(this.ConfigPath), cachePolicy);
        }

        private void SaveConfig()
        {
            try
            {
                this.ConfigDocument.Save(this.ConfigPath);
            }
            catch
            {
            }
        }
    }
}
