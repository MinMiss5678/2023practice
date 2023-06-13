using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2023practice
{
    public class null_state
    {
        //[return: NotNullIfNotNull(nameof(url))]
        //string? GetTopLevelDomainFromFullUrl(string? url);

    }
    //MaybeNullWhen：當方法傳回指定的 bool 值時，不可為 Null 的引數可能是 null。
    //NotNullWhen：當方法傳回指定的 bool 值時，可為 Null 的引數不會是 null。
    //NotNullIfNotNull：如果指定參數的引數不是 Null，則傳回值不是 Null。
    public enum Stages
    {
        提案,
        審核,
        執行,
        驗收,
        結案
    }

    public class ProjectData
    {
        public string Id { get; set; }
        /* 其他專案資訊欄位(省略) */
        /// <summary>
        /// 專案階段：提案、執行、驗收、結案... 等
        /// </summary>
        public Stages Stage { get; set; }
        /// <summary>
        /// 驗收日期
        /// </summary>
        public DateTime? AcceptDate { get; set; }

    }

    public class ProjectService
    {
    
        //結案歸檔
        public static void CloseAndArchive(ProjectData project)
        {
            if (project.Stage != Stages.驗收)
            {
                throw new ApplicationException($"專案未達[{Stages.驗收}]階段");
            }
            else if (project.AcceptDate == null)
            {
                throw new ArgumentException("Can't be null", nameof(project.AcceptDate));
            }
            project.Stage = Stages.結案;
            //將專案狀態更新至資料庫(省略)
        }
    }
}
