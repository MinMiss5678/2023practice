using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
